using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Statistics.Distribution;
using Statistics.Utils;
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
		void setupForm(string title, string xName, string yName)
		{
			Text = title;
			var pane = graph.GraphPane;
			pane.YAxis.Title.Text = yName;
			pane.X2Axis.Title.Text = xName;
			pane.Title.Text = Text;

			//Настраиваем пересечение осей
			pane.XAxis.Cross = 0.0;
			pane.YAxis.Cross = 0.0;
			pane.XAxis.Scale.IsSkipFirstLabel = true;
			pane.XAxis.Scale.IsSkipLastLabel = true;
			pane.XAxis.Scale.IsSkipCrossLabel = true;
			pane.YAxis.Scale.IsSkipFirstLabel = true;
			pane.YAxis.Scale.IsSkipLastLabel = true;
			pane.YAxis.Scale.IsSkipCrossLabel = true;

			//Убираем засечки сверху и снизу
			pane.XAxis.MinorTic.IsOpposite = false;
			pane.XAxis.MajorTic.IsOpposite = false;
			pane.YAxis.MinorTic.IsOpposite = false;
			pane.YAxis.MajorTic.IsOpposite = false;

			graph.AxisChange();
			graph.Invalidate();
		}

		#endregion

		#region POLYGON

		//Построение стат. ряда частот
		public DisplayForm(Dictionary<double, double> data, string title, string xName, string yName)
		{
			InitializeComponent();

			//Вывод таблицы
			SetupDataSource<double, double>(data,xName, yName);
			setupForm(title, xName, yName);

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

		public DisplayForm(Dictionary<Range, double> data, string title, string xName, string yName)
		{
			InitializeComponent();

			//Вывод таблицы
			SetupDataSource<Range, double>(data, xName, yName);
			setupForm(title, xName, yName);

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
				var box = new BoxObj((float)xi[i], (float)height[i], (float)intervals[i], (float)height[i], Color.Black, Color.FromArgb(255, 39, 174, 96));

				pane.GraphObjList.Add(box);
				if (height[i] > maxY) maxY = height[i];
			}



			//Настраиваем масштаб
			pane.XAxis.Scale.Min = data.First().Key.Left;
			pane.XAxis.Scale.Max = data.Last().Key.Right;
			pane.YAxis.Scale.Min = 0;
			pane.YAxis.Scale.Max = maxY * 1.1;
			
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
			dataGridView1.Columns["x"].DefaultCellStyle.Format = "N2";
			dataGridView1.Columns["y"].DefaultCellStyle.Format = "N2";
		}
	}
}
