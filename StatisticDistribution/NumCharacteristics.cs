using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticDistribution
{
	// ??? TODO ???
	// Начальный выборочный момент
	// Центральный выборочный момент
	public partial class NumCharacteristics : Form
	{

		public Dictionary<double, double> statFreq; // Статистический ряд частот
		public double summary_frequence;            // Сумма частот всего ряда
		public double mean,                         // Выборочное среднее
					  dispersion,                   // Смещенная оценка генеральной дисперсии
					  standard_deviation,           // Выборочное среднее квадратическое отклонение
					  s_dispersion,                 // Несмещенная оценка генеральной дисперсии
					  startMoment,                  //Начальный момент
					  centralMoment;                //Центральный момент

		public NumCharacteristics(Dictionary<double, double> statFreq_out)
		{
			InitializeComponent();
			statFreq = statFreq_out;
			FindNumericCharacteristics();
			SetNumericCharacteristicsToView();
		}

		public static void CalcAndShowNumCharact(Dictionary<double, double> statFreq_out)
		{
			NumCharacteristics frm = new NumCharacteristics(statFreq_out);
			frm.Show();
		}

		// Просчитать по порядку все численные характеристики ряда
		private void FindNumericCharacteristics()
		{
			summary_frequence = SummaryFrequence();
			mean = Mean();
			dispersion = Dispersion(mean);
			standard_deviation = StandartDeviation(dispersion);
			s_dispersion = SDispersion(dispersion);
		}


		// Записывает расчитанные значения во вьюху
		private void SetNumericCharacteristicsToView()
		{
			tbMean.Text = mean.ToString("N2");
			tbDispersion.Text = dispersion.ToString("N2");
			tbStandartDeviation.Text = standard_deviation.ToString("N2");
		}

		//Расчет начального выборочного момента
		private void btnStartMoment_Click(object sender, EventArgs e)
		{
			int r = (int)numStartMoment.Value;
			tbStartMoment.Text = StartMoment(r).ToString("N2");
		}

		//Расчет центрального выборочного момента
		private void btnCentralMoment_Click(object sender, EventArgs e)
		{
			int r = (int)numCentralMoment.Value;
			tbCentralMoment.Text = CentralMoment(r).ToString("N2");
		}

		#region NUMERIC_CHARACTERISTICS
		// Найти сумму частот всего ряда
		private double SummaryFrequence()
		{
			double summary_frequence = 0.0;
			foreach (var x in statFreq)
				summary_frequence += x.Value;

			return summary_frequence;
		}

		// Формулы взяты из учебника "Руководство к решению задач" Гмурман (с 157)
		// Несмещенная оценка генеральной средней (мат. ожидание)
		private double Mean()
		{
			double range_summ = 0;
			foreach (var x in statFreq)
				range_summ += x.Key * x.Value;

			return range_summ / summary_frequence;
		}

		// Смещенная оценка генеральной дисперсии
		private double Dispersion(double mean)
		{
			double disp_summ = 0;
			foreach (var x in statFreq)
				disp_summ += Math.Pow(x.Key - mean, 2) * x.Value;

			return disp_summ / summary_frequence;
		}

		// Выборочное среднее квадратическое отклонение
		private double StandartDeviation(double dispersion)
		{
			return Math.Sqrt(dispersion);
		}

		// Несмещенная оценка генеральной дисперсии
		private double SDispersion(double dispersion)
		{
			double n = summary_frequence;
			return (n * dispersion) / (n - 1);
		}

		//Начальный выборочный момент
		public double StartMoment(int r)
		{
			double sm = 0;
			foreach (var x in statFreq)
				sm += Math.Pow(x.Key, r) * x.Value;

			return sm / summary_frequence;
		}

		public double CentralMoment(int r)
		{
			double cm = 0;
			foreach (var x in statFreq)
				cm += Math.Pow(x.Key - mean, r) * x.Value;

			return cm / summary_frequence;
		}

#endregion
    }
}
