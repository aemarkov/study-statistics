using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Regression.Utils;
using ZedGraph;	

namespace Regression
{
	public partial class DiagramForm : Form
	{
		public DiagramForm(List<Regression.Utils.PointD> data, CorrelationCalc calc)
		{
			InitializeComponent();	
			setup_graph();

			var pane = graph.GraphPane;		//Поверхность рисования
			var table = calc.Table;			//Корреляционная таблица
			double x_1, x_2, y_1, y_2;      //Координаты концов линий регрессии
			var points = new PointPairList();

			//Построение точек
			foreach (var x in data)
				points.Add(x.X, x.Y);

			//Добавляем точки на график и убираем линию.
			var curve = pane.AddCurve("", points, Color.Green, SymbolType.Circle);
			curve.Line.IsVisible = false;
			curve.Symbol.Fill.Type = FillType.Solid;
			curve.Symbol.Size = 5;

			//Построение графиков
			//y = B0  + B1 *x
			x_1 = calc.Table.XHeaders.First().Left;
			x_2 = calc.Table.XHeaders.Last().Right;
			y_1 = calc.B0 + calc.B1 * x_1;
			y_2 = calc.B0 + calc.B1 * x_2;
	
			curve = pane.AddCurve(String.Format("y = {0:N2} + {1:N2}x", calc.B0, calc.B1), new double[] { x_1, x_2 }, new double[] { y_1, y_2 }, Color.Red, SymbolType.None);
			curve.Line.IsAntiAlias = true;

			//x = B0' + B1'*y
			y_1 = calc.Table.YHeaders.First().Left;
			y_2 = calc.Table.YHeaders.Last().Right;
			x_1 = calc.B0_ + calc.B1_ * y_1;
			x_2 = calc.B0_ + calc.B1_ * y_2;

			curve = pane.AddCurve(String.Format("x = {0:N2} + {1:N2}y",calc.B0_, calc.B1_), new double[] { x_1, x_2 }, new double[] { y_1, y_2 }, Color.Blue, SymbolType.None);
			curve.Line.IsAntiAlias = true;


			//Построение точки пересечения
			pane.AddCurve("", new double[] { calc.X }, new double[] { calc.Y }, Color.Blue, SymbolType.Circle);

			pane.AxisChange();
			graph.Invalidate();
		}


		private void draw_lines(CorrelationCalc calc, double b0, double b1)
		{
			//double b0 = calc.Y - calc.B1 * calc.X;
			double x_left = calc.Table.XHeaders.First().Left;
			double x_right = calc.Table.XHeaders.Last().Right;
			double y_left = b0 + b1 * x_left;
			double y_right = b0 + b1 * x_right;

			var pane = graph.GraphPane;
			pane.AddCurve("", new double[] { x_left, x_right }, new double[] { y_left, y_right }, Color.Red);
			pane.AxisChange();
			graph.Invalidate();
		}

		void setup_graph()
		{
			var pane = graph.GraphPane;

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

			pane.Title.Text = "Диаграмма рассеивания и линии регрессии";
			pane.XAxis.Title.Text = "X";
			pane.YAxis.Title.Text = "Y";

			graph.AxisChange();
			graph.Invalidate();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}
	}
}
