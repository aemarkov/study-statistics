using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ZedGraph;


namespace StatisticDistribution
{
	public partial class DisplayForm : Form
	{

#region STATIC_CALL

		//Отображение ряда частот 
		public static void DisplayStatFreq(Dictionary<double, double> data)
		{
			var frm = new DisplayForm(data, "Полигон частот", "Xi", "Ni");
			frm.Show();
		}

		//Отображение ряда относительных частот
		public static void DisplayStatRelFreq(Dictionary<double, double> data)
		{
			var frm = new DisplayForm(data, "Полигон относительных частот",  "Xi", "Wi");
			frm.Show();
		}

		//Отображение интервального ряда относительных частот
		public static void DisplayIntervalFreq(Dictionary<Range, double> data)
		{
			var frm = new DisplayForm(data, "Гистограмма частот", "Xi", "Ni*");
			frm.Show();
		}

		//Отображение интервального ряда относительных частот
		public static void DisplayIntervalRelFreq(Dictionary<Range, double> data)
		{
			var frm = new DisplayForm(data, "Гистограмма относительных частот", "Xi", "Wi*");
			frm.Show();
		}

		//Отображение группированного ряда частот
		public static void DisplayGroupFreq(Dictionary<double, double> data)
		{
			var frm = new DisplayForm(data, "Полигон для группированного ряда частот", "Xi*", "Ni*");
			frm.Show();
		}

		//Отображение группированного ряда относительных частот
		public static void DisplayGroupRelFreq(Dictionary<double, double> data)
		{
			var frm = new DisplayForm(data, "Полигон для группированного ряда относительных частот", "Xi*", "Wi*");
			frm.Show();
		}

		// Настройка текста формы
		void setupForm(string title, string axisY)
		{
			Text = title;
			var pane = graph.GraphPane;
			pane.YAxis.Title = axisY;
			pane.Title = Text;
		}

#endregion

#region POLYGON

		//Построение стат. ряда частот
		public DisplayForm(Dictionary<double, double> data, string title, string xName, string valName)
		{
			InitializeComponent();

			//Вывод таблицы
			SetupDataSource<double, double>(data,xName,  valName);
			setupForm(title, valName);

			//Построение полигона
			var pane = graph.GraphPane;
			var curve = pane.AddCurve("", dictionaryToList(data), Color.FromArgb(255, 39, 174, 96));
			graph.AxisChange();
			graph.Invalidate();
		}

		//Преобразует словарь в набор точек
		PointPairList dictionaryToList(Dictionary<double, double> data)
		{
			var list = new PointPairList();
			foreach (var x in data) list.Add(x.Key, x.Value);
			return list;
		}

#endregion

#region HISTOGRAM

		public DisplayForm(Dictionary<Range, double> data, string title, string xName, string valName)
		{
			InitializeComponent();

			//Вывод таблицы
			SetupDataSource<Range, double>(data, xName, valName);
			setupForm(title, valName);

			//Вывод графика
			var pane = graph.GraphPane;
			double maxY = 0;

			//Находим интервалы
			var intervals = new double[data.Count];
			var height = new double[data.Count];
			var xi = new double[data.Count];

			//МЕГАКОСТЫЛь. Зря я использовал Dictionary
			int i = 0;
			foreach(var x in data)
			{
				intervals[i] = x.Key.Length;
				height[i] = x.Value / intervals[i];
				xi[i] = x.Key.Left;
				i++;
			}

			//Находим высоту
			//var height = data.Select(x => x.Value / interval).ToArray();
			//var xi = data.Select(x => x.Key.Left).ToArray();

			//Рисуем гистограмму
			for (i = 0; i < height.Length; i++)
			{
				var box = new BoxItem(new RectangleF((float)xi[i], (float)height[i], (float)intervals[i], (float)height[i]), Color.Black, Color.FromArgb(255, 39, 174, 96));
				pane.GraphItemList.Add(box);
				if (height[i] > maxY) maxY = height[i];
			}



			//Настраиваем масштаб
			pane.XAxis.Min = 0;
			pane.XAxis.Max = data.Last().Key.Right*1.1;
			pane.YAxis.Min = 0;
			pane.YAxis.Max = maxY * 1.1;
			
			graph.AxisChange();
			graph.Invalidate();
		}

#endregion

		//Настриаивает таблицу и привязывает данные
		void SetupDataSource<TKey, TValue>(Dictionary<TKey, TValue> data, string xName, string valName)
		{
			dataGridView1.Columns.Add("x", xName);
			dataGridView1.Columns.Add("y", valName);

			foreach (DataGridViewColumn col in dataGridView1.Columns)
				col.DataPropertyName = col.Name;

			var bs = new BindingSource();
			bs.DataSource = data.Select(x => new { x = x.Key, y = x.Value }).ToList();
			dataGridView1.DataSource = bs;
		}
	}
}
