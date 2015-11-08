using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Statistics.Distribution;

namespace StatisticDistribution
{
	// ??? TODO ???
	// Начальный выборочный момент
	// Центральный выборочный момент
	public partial class NumCharacteristics : Form
	{
		NumericSolver solver;


		public static void CalcAndShowNumCharact(Dictionary<double, double> distr)
		{
			NumCharacteristics frm = new NumCharacteristics(distr);
			frm.Show();
		}

		public NumCharacteristics(Dictionary<double, double> distr)
		{
			InitializeComponent();
			solver = new NumericSolver(distr);

			var mean = solver.Mean();
			var dispersion = solver.Dispersion();
			var standard_deviation = solver.StandartDeviation();
			var s_dispersion = solver.SDispersion();

			tbMean.Text = mean.ToString("N2");
			tbDispersion.Text = dispersion.ToString("N2");
			tbStandartDeviation.Text = standard_deviation.ToString("N2");
		}

		//Расчет начального выборочного момента
		private void btnStartMoment_Click(object sender, EventArgs e)
		{
			int r = (int)numStartMoment.Value;
			tbStartMoment.Text = solver.StartMoment(r).ToString("N2");
		}

		//Расчет центрального выборочного момента
		private void btnCentralMoment_Click(object sender, EventArgs e)
		{
			int r = (int)numCentralMoment.Value;
			tbCentralMoment.Text = solver.CentralMoment(r).ToString("N2");
		}

		#region NUMERIC_CHARACTERISTICS


		#endregion

	}
}
