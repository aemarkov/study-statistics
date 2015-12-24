using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Regression
{
	public partial class DiagramForm : Form
	{
		public DiagramForm(List<PointD> data, CorrelationCalc calc)
		{
			InitializeComponent();

			var pane = graph.GraphPane;
			var table = calc.Table;

			foreach(var x in data)
			{
				pane.AddCurve("", new double[] { x.X }, new double[] { x.Y }, Color.Green);
			}

			draw_lines(calc, calc.B1);
			draw_lines(calc, calc.B1_);

			pane.AxisChange();
			graph.Invalidate();
		}


		private void draw_lines(CorrelationCalc calc, double b1)
		{
			double b0 = calc.Y - calc.B1 * calc.X;
			double x_left = calc.Table.XHeaders.First().Left;
			double x_right = calc.Table.XHeaders.Last().Right;
			double y_left = b0 + b1 * x_left;
			double y_right = b0 + b1 * x_right;

			var pane = graph.GraphPane;
			pane.AddCurve("", new double[] { x_left, x_right }, new double[] { y_left, y_right }, Color.Red);
			pane.AxisChange();
			graph.Invalidate();
		}
	}
}
