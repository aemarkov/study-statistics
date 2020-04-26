using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Drawing;

namespace Statistics.Utils
{
	/// <summary>
	/// Строит гистограмму
	/// ZedGraph плохо работает с шириной гистограмм, поэтому рисуем сами
	/// </summary>
	class HistogramPlotter
	{
		private ZedGraphControl graph;


		/// <summary>
		/// Создает объект, рисующий гистограмму на заданом контролле
		/// </summary>
		/// <param name="graph">Контролл ZedGraph</param>
		public HistogramPlotter(ZedGraphControl graph)
		{
			this.graph = graph;
		}

		/// <summary>
		/// Строит диаграмму для интервального ряда
		/// </summary>
		/// <param name="intervalFreq">Интервальный ряд</param>
		public void Plot(Dictionary<Range, double> data, Color color)
		{
			//Вывод графика
			var pane = graph.GraphPane;
			double maxY = 0;

			//Находим интервалы
			var intervals = new double[data.Count];
			var height = new double[data.Count];
			var xi = new double[data.Count];

			//МЕГАКОСТЫЛь. Зря я использовал Dictionary
			int i = 0;
			foreach (var x in data)
			{
				intervals[i] = x.Key.Length;
				height[i] = x.Value / intervals[i];
				xi[i] = x.Key.Left;
				i++;
			}

			//Рисуем гистограмму
			for (i = 0; i < height.Length; i++)
			{
				var box = new BoxObj((float)xi[i], (float)height[i], (float)intervals[i], (float)height[i], Color.Black, color);

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
	}
}
