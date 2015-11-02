using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

using Statistics.Utils;
using Statistics.Distribution;

namespace StatisticDistribution
{

	public partial class MainForm : Form
	{

		const int accuracy = 2;		//Точность округления относительной частоты

		//------------------ ДАННЫЕ ---------------------------------------
		List<double> data;												//Выборка
		BindingList<IntervalPair> stringIntervals { get; set; }			//Введенный пользователем интервальный ряд частот
		double interval;												//Длина интервала
		int dataSize;                                                   //Число элементов в выборке

		Distribution distribution;										//Ряды

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
			stringIntervals = new BindingList<IntervalPair>();


			//Настраиваем таблицу ввода интервального ряда
			foreach (DataGridViewColumn col in gridIntervalData.Columns)
				col.DataPropertyName = col.Name;

			stringIntervals.AllowNew = true;
			stringIntervals.AllowEdit = true;
			stringIntervals.AllowRemove = true;
			gridIntervalData.DataSource = stringIntervals;

			gridIntervalData.CellValidating += GridIntervalData_CellValidating;
			gridIntervalData.CellEndEdit += GridIntervalData_CellEndEdit;
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
					data = new List<double>();
					stringIntervals = null;

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

					//Создаем ряд
					distribution = new Distribution(data);
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
			data = null;
			setupGUIState(GUIState.INTERVAL_ONLY);
			var intervalFreq = new Dictionary<Range, double>();

			//Переводим в ряд частот
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

			//Создаем ряд
			distribution = new Distribution(intervalFreq, interval);
		}

		//Валидация ввода интервального ряда
		private void GridIntervalData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			int res;
			if((e.ColumnIndex==1) && !int.TryParse((string)e.FormattedValue, out res))
			{
				e.Cancel = true;
			}
		}

		private void GridIntervalData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			// Clear the row error in case the user presses ESC.   
			gridIntervalData.Rows[e.RowIndex].ErrorText = String.Empty;
		}


		#endregion

		#region CALC
		/////////////////////////////////////////////////////////////////////////////////////////////////
		/////////                       ОБРАБОТКА ДАННЫХ                                        /////////
		/////////////////////////////////////////////////////////////////////////////////////////////////

		//Разбивка на интервалы
		private void btnSeparate_Click(object sender, EventArgs e)
		{
			interval = (data.Last()-data.First())/(double)numIntervals.Value;
			DisplayForm.DisplayIntervalFreq(distribution.Separate(interval));
			setupGUIState(GUIState.SEPARATE);
		}

		//                 Статистический ряд
		//=======================================================

		//Показать статистический ряд частот
		private void menuStatFreq_Click(object sender, EventArgs e)
		{
			DisplayForm.DisplayStatFreq(distribution.StatFreq);
		}

		//Показать статистический ряд относительных частот
		private void menuStatRelFreq_Click(object sender, EventArgs e)
		{
			DisplayForm.DisplayStatRelFreq(distribution.StatRelFreq);
		}

		//Показать интервальный ряд частот
		private void menuIntervalFreq_Click(object sender, EventArgs e)
		{
			DisplayForm.DisplayIntervalFreq(distribution.IntervalFreq);
		}

		//Показать интервальный ряд относительных частот
		private void menuIntervalRelFreq_Click(object sender, EventArgs e)
		{
			DisplayForm.DisplayIntervalRelFreq(distribution.IntervalRelFreq);
		}

		//Показать группированный ряд частот
		private void menuGroupFreq_Click(object sender, EventArgs e)
		{
			DisplayForm.DisplayGroupFreq(distribution.GroupFreq);
		}

		////Показать группированный ряд относительных частот
		private void menuGroupRelFreq_Click(object sender, EventArgs e)
		{
			DisplayForm.DisplayGroupRelFreq(distribution.GroupRelFreq);
		}

		//Показать числовые характеристики
		private void menuEmpiricFunction_Click(object sender, EventArgs e)
		{
			EmpiricFunction.ShowEmpiricFunction(distribution.IntervalRelFreq);
		}

		//Показать эмпирическую функцию распределения
		private void menuNumericCharacteristics_Click(object sender, EventArgs e)
		{
			if (state != GUIState.INTERVAL_ONLY)
				NumCharacteristics.CalcAndShowNumCharact(distribution.StatFreq);
			else
				NumCharacteristics.CalcAndShowNumCharact(distribution.GroupFreq);
		}


		//Проверка закона о нормальном распределении
		private void menuCheckNormal_Click(object sender, EventArgs e)
		{

		}

		//Проверка закона о биномиальном распределении
		private void menuCheckBinomial_Click(object sender, EventArgs e)
		{

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
					setElementEnabled(false, menuStatFreq,  menuStatRelFreq, menuIntervalFreq, menuIntervalRelFreq, menuGroupFreq, menuGroupRelFreq, menuNumericCharacteristics, menuEmpiricFunction);
					setElementEnabled(false, numIntervals, btnSeparate);
					break;

				//Файл открыт, но не разделен. Можно смотреть только статистические ряды
				case GUIState.OPENED:
					setElementEnabled(true,  menuStatFreq, menuStatRelFreq, menuNumericCharacteristics);
					setElementEnabled(true, numIntervals, btnSeparate);
					setElementEnabled(false, menuIntervalFreq, menuIntervalRelFreq, menuGroupFreq, menuGroupRelFreq, menuEmpiricFunction);
                    break;

				//Файл открыт и разделен. Можно выполнять все операции
				case GUIState.SEPARATE:
					setElementEnabled(true, menuStatFreq, menuStatRelFreq, menuIntervalFreq, menuIntervalRelFreq, menuGroupFreq, menuGroupRelFreq, menuNumericCharacteristics, menuEmpiricFunction);
					setElementEnabled(true, numIntervals, btnSeparate);
					break;
				case GUIState.INTERVAL_ONLY:
					setElementEnabled(false, menuStatFreq, menuStatRelFreq);
					setElementEnabled(false, numIntervals, btnSeparate);
					setElementEnabled(true, menuIntervalFreq, menuIntervalRelFreq, menuGroupFreq, menuGroupRelFreq, menuNumericCharacteristics, menuEmpiricFunction);
					break;
			};
		}

		//Задает всем перечисленным элементам свойство Enabled
		private void setElementEnabled(bool enabled, params ToolStripMenuItem[] controls)
		{
			controls.All(c => {c.Enabled=enabled; return true; });
		}

		private void setElementEnabled(bool enabled, params Control[] controls)
		{
			controls.All(c => { c.Enabled = enabled; return true; });
		}


		//Сбрасывает значения рядов
		private void resetData()
		{
			interval = 0;
			dataSize = 0;
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
