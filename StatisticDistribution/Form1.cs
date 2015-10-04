using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace StatisticDistribution
{

	public partial class MainForm : Form
	{

		const int accuracy = 2;		//Точность округления относительной частоты

		//------------------ ДАННЫЕ ---------------------------------------
		List<double> data;												//Выборка
		BindingList<IntervalPair> stringIntervals { get; set; }			//Введенный пользователем интервальный ряд частот
		double interval;												//Длина интервала

		int dataSize;											//Число элементов в выборке
		Dictionary<double, double> statFreq;					//Стат. ряд частот
		Dictionary<double, double> statRelFreq;					//Стат. ряд относительных частот
		Dictionary<Range, double> intervalFreq;					//Интервальный ряд частот
		Dictionary<Range, double> intervalRelFreq;				//Интервальный ряд относительных частот
		Dictionary<double, double> groupFreq;					//Группированны ряд частот
		Dictionary<double, double> groupRelFreq;                //Группированный ряд относительных частот


		//------------------ СОСТОЯНИЕ GUI --------------------------------

		/* Состояния, в которых может быть программа
			- файл не открыт
			- файл открыт, но на интервалы не разбит
			- данные разбиты на интервалы.
		   Это нужно, чтобы управлять активностью кнопок */
		enum GUIState { NOT_OPENED, OPENED, SEPARATE, INTERVAL_ONLY};
		GUIState state;

		public MainForm()
		{
			InitializeComponent();

			//Настройка состояний
			setupGUIState(GUIState.NOT_OPENED);

			//Создаем объект данных
			data = new List<double>();
			stringIntervals = new BindingList<IntervalPair>();


			//Настраиваем таблицу ввода интервального ряда
			foreach (DataGridViewColumn col in gridIntervalData.Columns)
				col.DataPropertyName = col.Name;

			stringIntervals.AllowNew = true;
			stringIntervals.AllowEdit = true;
			stringIntervals.AllowRemove = true;
			gridIntervalData.DataSource = stringIntervals;
		}

		#region GUI_EVENTS
		/////////////////////////////////////////////////////////////////////////////////////////////////
		/////////                            ОБРАБОТЧИКИ СОБЫТИЙ                                /////////
		/////////////////////////////////////////////////////////////////////////////////////////////////

		//Открытие выборки
		private void btnOpen_Click_1(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.Filter = "Таблица в формате CSV|*.csv";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					//Меняем состояние
					setupGUIState(GUIState.OPENED);

					//Сбрасываем значения рядов
					resetData();

					//Парсим файл
					data = parseCSV(dlg.FileName, ';');
					data.Sort();
					dataSize = data.Count;

					//Какой-то странный костыль
					var bs = new BindingSource();
					bs.DataSource = data.Select(x => new { Xi = x }).ToList();
					gridData.DataSource = bs;
				}
				catch(System.FormatException)
				{
					MessageBox.Show("Файл имеет неправильное содержимое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch(System.IO.IOException)
				{
					MessageBox.Show("Не удается открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}	
			}
		}

		//Ввод интервального ряда распределения
		private void btnInterval_Click(object sender, EventArgs e)
		{
			resetData();
			setupGUIState(GUIState.INTERVAL_ONLY);
			intervalFreq = new Dictionary<Range, double>();

			//Переводим в ряд относительных частот
			foreach(var interval in stringIntervals)
			{
				Range? range;
				if((range=interval.GetRange())==null)
				{
					MessageBox.Show("Неверное значение: " + interval.Key,"Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				dataSize += interval.Value;
				intervalFreq.Add((Range)range, interval.Value);
			}
		}

		#endregion

		/////////////////////////////////////////////////////////////////////////////////////////////////
		/////////                       ОБРАБОТКА ДАННЫХ                                        /////////
		/////////////////////////////////////////////////////////////////////////////////////////////////

		#region CALC

		//Разбивка на интервалы
		private void btnSeparate_Click(object sender, EventArgs e)
		{
			if ((numIntervals.Value < 4) || (numIntervals.Value > 10))
			{
				MessageBox.Show("Число интервалов должно быть от 4 до 10", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			//Обнуляем
			groupFreq = null; groupRelFreq = null;
			intervalFreq = null; intervalRelFreq = null;

			//Просто вызываем функцию построения интервального ряда частот
			interval = (data.Last()-data.First())/(double)numIntervals.Value;

			btnIntervalFreq_Click(sender, e);
			setupGUIState(GUIState.SEPARATE);
		}

		//                 Статистический ряд
		//=======================================================

		//Высчитывает статистический ряд частот - он базовый для остальных
		Dictionary<double, double> calcStatFreq(List<double> data)
		{
			var statFreq = new Dictionary<double, double>();
			foreach (var d in data)
				if (statFreq.ContainsKey(d))
					statFreq[d]++;
				else
					statFreq.Add(d, 1);
			return statFreq;
		}

		//Показать статистический ряд частот
		private void btnStatFreq_Click(object sender, EventArgs e)
		{
			if (statFreq == null) statFreq = calcStatFreq(data);
			DisplayForm.DisplayStatFreq(statFreq);

		}

		//Показать статистический ряд относительных частот
		private void btnStatRelFreq_Click(object sender, EventArgs e)
		{
			if (statRelFreq == null)
			{
				if (statFreq == null) statFreq =  calcStatFreq(data);
				statRelFreq = new Dictionary<double, double>();
				foreach (var x in statFreq) statRelFreq.Add(x.Key, Math.Round(x.Value / dataSize,accuracy));
			}

			DisplayForm.DisplayStatRelFreq(statRelFreq);
		}

		//               Интервальный ряд
		//=======================================================

		//Высисление интервального ряда частот - он базовый для всех интервальных и группированных 
		Dictionary<Range, double> calcIntervalFreq(List<double> data)
		{
			var intervalFreq = new Dictionary<Range, double>();

			//Если стат. ряд частот еще не вычислен
			if (statFreq == null) statFreq = calcStatFreq(data);
			if (statFreq.Count == 0)
			{
				MessageBox.Show("Нет данных в статистическом ряду частот", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}

			var xi = statFreq.GetEnumerator();	//Перечислитель для обхода словаря
			double intervalStart;               //Начало интервала
			double ni;                          //Суммарная частота на интервале
			bool isNotEnd = false;				//Пришли ли к концу списка
			bool isAdded = false;				//Добавлен ли текущий элемент

			//[x0; x1]; (x1; x2]; (x2; x3]; ... (xn-1; xn];

			//Добавляем первый интервал (обе границы включаются)
			intervalStart = statFreq.First().Key;
			ni = 0;
			do
			{
				ni += xi.Current.Value;
			} while ((isNotEnd = xi.MoveNext()) && (xi.Current.Key - intervalStart <= interval));

			intervalFreq.Add(new Range(intervalStart, intervalStart+interval, true, true), ni);

			//Добавляем остальные интервалы (левая - не включается, правая - включается)
			//Нужна проверка, что остались элементы
			if (isNotEnd)
			{
				//В качестве начала интервала берем конец первого интервала
				intervalStart += interval;
				ni = 0;
				do
				{
					//Накапливаем сумму частот
					if (xi.Current.Key - intervalStart <= interval)
					{
						ni += xi.Current.Value;
						isAdded = false;
					}
					else
					{
						isAdded = true;
						//Добавляем интервал
						intervalFreq.Add(new Range(intervalStart, intervalStart + interval, false, true), ni);
						intervalStart += interval;
						ni = xi.Current.Value;
					}
				} while (xi.MoveNext());
			}			

			if(!isAdded)
			{
				//Если список завершился раньше, чем кончился интервал
				//ni уже накоплен, надо лишь установить правую границу
				intervalFreq.Add(new Range(intervalStart, intervalStart + interval, false, true), ni);
			}

			return intervalFreq;
		}

		//Показать интервальный ряд частот
		private void btnIntervalFreq_Click(object sender, EventArgs e)
		{
			if (intervalFreq == null)
			{
				intervalFreq = calcIntervalFreq(data);
				if (intervalFreq == null) return;
			}

			//Отображаем гистограмму
			DisplayForm.DisplayIntervalFreq(intervalFreq);
		}

		
		

		//Показать интервальный ряд относительных частот
		private void btnIntervalRelFreq_Click(object sender, EventArgs e)
		{
			if (intervalRelFreq == null)
			{
				if (intervalFreq == null) intervalFreq = calcIntervalFreq(data);
				if (intervalFreq == null) return;

				intervalRelFreq = new Dictionary<Range, double>();
				foreach (var x in intervalFreq) intervalRelFreq.Add(x.Key, Math.Round(x.Value / dataSize, accuracy));
			}

			DisplayForm.DisplayIntervalRelFreq(intervalRelFreq);

		}

		//                 Группированный ряд
		//=======================================================

		//Построить группированный ряд частот
		Dictionary<double, double> calcGroupFreq(List<double> data)
		{

			if (intervalFreq == null) intervalFreq = calcIntervalFreq(data);
			if (intervalFreq == null) return null;

			var groupFreq = new Dictionary<double, double>();

			foreach (var x in intervalFreq) groupFreq.Add(x.Key.Middle, x.Value);

			return groupFreq;
		}

		//Показать группированный ряд частот
		private void btnGroupFreq_Click(object sender, EventArgs e)
		{
			if(groupFreq==null)
			{
				groupFreq = calcGroupFreq(data);
				if (groupFreq == null) return;
			}

			DisplayForm.DisplayGroupFreq(groupFreq);
		}

		////Показать группированный ряд относительных частот
		private void btnGroupRelFreq_Click(object sender, EventArgs e)
		{
			if (groupRelFreq == null)
			{
				if (groupFreq == null)
				{
					groupFreq = calcGroupFreq(data);
					if (groupFreq == null) return;
				}

				groupRelFreq = new Dictionary<double, double>();
				foreach (var x in groupFreq) groupRelFreq.Add(x.Key, Math.Round(x.Value / dataSize,accuracy));
			}

			DisplayForm.DisplayGroupRelFreq(groupRelFreq);

		}

		//Показать числовые характеристики
		private void btnCharasteristic_Click(object sender, EventArgs e)
		{
            if (statFreq == null) statFreq = calcStatFreq(data);
            NumCharacteristics.CalcAndShowNumCharact(statFreq);
		}

        #endregion

        #region GUI_STATEMACHINE
        /////////////////////////////////////////////////////////////////////////////////////////////////
		/////////                            УПРАВЛЕНИЕ СОСТОЯНИЯМИ                             /////////
		/////////////////////////////////////////////////////////////////////////////////////////////////

		//Ативирует и выключает элементы в зависимости от состояния
		private void setupGUIState(GUIState state)
		{
			this.state = state;
			switch(state)
			{
				//Файл не открыт, нельзя производить никакие операции
				case GUIState.NOT_OPENED:
					setElementEnabled(false, numIntervals, btnSeparate, btnStatFreq,  btnStatRelFreq, btnIntervalFreq, btnIntervalRelFreq, btnGroupFreq, btnGroupRelFreq, btnCharasteristic);
					break;

				//Файл открыт, но не разделен. Можно смотреть только статистические ряды
				case GUIState.OPENED:
					setElementEnabled(true, numIntervals, btnSeparate, btnStatFreq, btnStatRelFreq, btnCharasteristic);
					setElementEnabled(false, btnIntervalFreq, btnIntervalRelFreq, btnGroupFreq, btnGroupRelFreq);
                    break;

				//Файл открыт и разделен. Можно выполнять все операции
				case GUIState.SEPARATE:
					setElementEnabled(true, numIntervals, btnSeparate, btnStatFreq, btnStatRelFreq, btnIntervalFreq, btnIntervalRelFreq, btnGroupFreq, btnGroupRelFreq, btnCharasteristic);
					break;
				case GUIState.INTERVAL_ONLY:
					setElementEnabled(false, numIntervals, btnSeparate, btnStatFreq, btnStatRelFreq);
					setElementEnabled(true, btnIntervalFreq, btnIntervalRelFreq, btnGroupFreq, btnGroupRelFreq, btnCharasteristic);
					break;
			};
		}

		//Задает всем перечисленным элементам свойство Enabled
		private void setElementEnabled(bool enabled, params Control[] controls)
		{
			controls.All(c => {c.Enabled=enabled; return true; });
		}


		//Сбрасывает значения рядов
		private void resetData()
		{
			statFreq = null; statRelFreq = null;
			groupFreq = null; groupRelFreq = null;
			intervalFreq = null; intervalRelFreq = null;
			interval = 0;
		}

		#endregion


		#region FILE_PARSING
		/////////////////////////////////////////////////////////////////////////////////////////////////
		/////////                        ПАРСИНГ ФАЙЛ                                           /////////
		/////////////////////////////////////////////////////////////////////////////////////////////////
		List<double> parseCSV(string filename, char separator)
		{
			//Т.к каждая строка содержит только одно число - просто переводим строку
			//в число
			var data = new List<double>();
			using (var sr = new StreamReader(filename))
			{
				string line;
				while((line=sr.ReadLine())!=null)
					data.Add(double.Parse(line));
			}
			return data;
		}



		#endregion
	}
}
