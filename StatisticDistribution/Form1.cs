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
		List<double> data;
		double interval;

		Dictionary<double, double> statFreq;					//Стат. ряд частот
		Dictionary<double, double> statRelFreq;					//Стат. ряд относительных частот
		Dictionary<Range, double> intervalFreq;					//Интервальный ряд частот
		Dictionary<Range, double> intervalRelFreq;				//Интервальный ряд относительных частот
		Dictionary<double, double> groupFreq;					//Группированны ряд частот
		Dictionary<double, double> groupRelFreq;				//Группированный ряд относительных частот


		//------------------ СОСТОЯНИЕ GUI --------------------------------

		/* Состояния, в которых может быть программа
			- файл не открыт
			- файл открыт, но на интервалы не разбит
			- данные разбиты на интервалы.
		   Это нужно, чтобы управлять активностью кнопок */
		enum GUIState { NOT_OPENED, OPENED, SEPARATE};
		GUIState state;

		public MainForm()
		{
			InitializeComponent();

			//Настройка состояний
			setupGUIState(GUIState.NOT_OPENED);

			//Создаем объект данных
			data = new List<double>();
		}

		#region GUI_EVENTS
		/////////////////////////////////////////////////////////////////////////////////////////////////
		/////////                            ОБРАБОТЧИКИ СОБЫТИЙ                                /////////
		/////////////////////////////////////////////////////////////////////////////////////////////////

		//Открытие выборки
		private void btnOpen_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.Filter = "Таблица в формате CSV|*.csv";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					//Парсим файл
					data = parseCSV(dlg.FileName, ';');
					data.Sort();

					//Какой-то странный костыль
					var bs = new BindingSource();
					bs.DataSource = data.Select(x => new { Xi = x }).ToList();
					gridData.DataSource = bs;

					//Меняем состояние
					setupGUIState(GUIState.OPENED);

					//Сбрасываем значения рядов
					statFreq = null; statRelFreq = null;
					groupFreq = null; groupRelFreq = null;
					intervalFreq = null; intervalRelFreq = null;
					interval = 0;
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

		//Разбивка на интервалы
		private void btnSeparate_Click(object sender, EventArgs e)
		{
			//Просто вызываем функцию построения интервального ряда частот
			interval = (double)numIntervals.Value;

			groupFreq = null; groupRelFreq = null;
			intervalFreq = null; intervalRelFreq = null;

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
				foreach (var x in statFreq) statRelFreq.Add(x.Key, Math.Round(x.Value / data.Count,accuracy));
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

			//Разбиваем на интервалы
			double left = 0;            //Значение левой границы
			double ni = 0;              //Частота интервала

			left = statFreq.First().Key;//Получаем первую границу

			//Разбиваем на интервалы
			foreach (var x in statFreq)
			{
				if ((x.Key - left) < interval)
					ni += x.Value;
				else
				{
					//Интервал получен - сохраняем
					intervalFreq.Add(new Range(left, x.Key), ni);
					ni = x.Value;
					left = x.Key;
				}
			}

			intervalFreq.Add(new Range(left, left + interval), ni);

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
				foreach (var x in intervalFreq) intervalRelFreq.Add(x.Key, Math.Round(x.Value / data.Count, accuracy));
			}

			DisplayForm.DisplayIntervalRelFreq(intervalRelFreq);

		}

		//                 Групповой ряд
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
				foreach (var x in groupFreq) groupRelFreq.Add(x.Key, Math.Round(x.Value / data.Count,accuracy));
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
			};
		}

		//Задает всем перечисленным элементам свойство Enabled
		private void setElementEnabled(bool enabled, params Control[] controls)
		{
			controls.All(c => {c.Enabled=enabled; return true; });
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

		/////////////////////////////////////////////////////////////////////////////////////////////////
		/////////                       ОБРАБОТКА ДАННЫХ                                        /////////
		/////////////////////////////////////////////////////////////////////////////////////////////////
	}
}
