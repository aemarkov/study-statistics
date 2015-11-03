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

			draw_distribution(graphEmp, distr.StatisticsData);
			draw_distribution(graphTheor, distr.GetTheoreticalFreq());
		}

		//Отклонить гипотезу
		private void btnWrong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//Подтвердить гипотезу - дальнейшая проверка по критерию пирсона
		private void btnCorrect_Click(object sender, EventArgs e)
		{
			var probs = distr.CalcProbablities();
            double pirson = 0;
            int n = distr.Count;

            foreach(var el in probs)
            {
                pirson += (el.Key - n * el.Value) / (n * el.Value);
            }
            txtPirsonVis.Text = pirson.ToString("N4");
		}

		///////////////////////////// ПОСТРОЙКА ГРАФИКОВ //////////////////////////////////////

		//Строит полигон распределения
		void draw_distribution(ZedGraphControl graph, Dictionary<double, double> distr)
		{
			setup_graph(graph);

			//Построение полигона
			var pane = graph.GraphPane;
			var curve = pane.AddCurve("", dictionaryToList(distr), Color.FromArgb(255, 39, 174, 96),SymbolType.None);
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
