using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Statistics.DistributionCheck;
using Statistics.Distribution;

using ZedGraph;

namespace StatisticDistribution
{
	public partial class CheckDistributionForm : Form
	{
		AbstractDistribution distr;

		public CheckDistributionForm(AbstractDistribution distr)
		{
			InitializeComponent();
			this.distr = distr;
			lblDistrType.Text = distr.Name;

			draw_emp_distribution();
		}

		//Откланить гипотезу
		private void btnWrong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//Подтвердить гипотезу - дальнейшая проверка по критерию пирсона
		private void btnCorrect_Click(object sender, EventArgs e)
		{

		}


		//Строит полигон распределения
		void draw_emp_distribution()
		{
			setup_graph(graphEmp);

			//Построение полигона
			var pane = graphEmp.GraphPane;
			var curve = pane.AddCurve("", dictionaryToList(distr.StatisticsData), Color.FromArgb(255, 39, 174, 96));
			graphEmp.AxisChange();
			graphEmp.Invalidate();
		}

		//Преобразует словарь в набор точек
		PointPairList dictionaryToList(Dictionary<double, double> data)
		{
			var list = new PointPairList();
			foreach (var x in data) list.Add(x.Key, x.Value);
			return list;
		}

		//Настройки графика
		void setup_graph(ZedGraph.ZedGraphControl graph)
		{
			var pane = graph.GraphPane;
			pane.YAxis.Title.Text = "y";
			pane.X2Axis.Title.Text = "x";
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
	}
}
