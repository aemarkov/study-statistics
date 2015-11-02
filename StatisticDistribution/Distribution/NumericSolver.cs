using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.Distribution
{
	/// <summary>
	/// Расчет числовых характеристик
	/// </summary>
	public class NumericSolver
	{
		Dictionary<double, double> distr;			// Распределение, для которого ищем числовые характеристики
		double summary_frequence;                   // Суммарная частота
		public double mean,                         // Выборочное среднее
					  dispersion,                   // Смещенная оценка генеральной дисперсии
					  standard_deviation,           // Выборочное среднее квадратическое отклонение
					  s_dispersion,                 // Несмещенная оценка генеральной дисперсии
					  startMoment,                  // Начальный момент
					  centralMoment;                // Центральный момент

		/// <summary>
		/// Создает новый объект NumericSolver на основе ряда распределения
		/// </summary>
		/// <param name="distribution">ряд распределения</param>
		public NumericSolver(Dictionary<double, double> distribution)
		{
			this.distr = distribution;
			summary_frequence = SummaryFrequence();
		}

		// Найти сумму частот всего ряда
	    double SummaryFrequence()
		{
			double summary_frequence = 0.0;
			foreach (var x in distr)
				summary_frequence += x.Value;

			return summary_frequence;
		}

		///////////////////////////////////////////////////////////////////////////////////////////

		// Формулы взяты из учебника "Руководство к решению задач" Гмурман (с 157)
		// МАТЕМАТИЧЕСКОЕ ОЖИДАНИЕ
		public double Mean()
		{
			double range_summ = 0;
			foreach (var x in distr)
				range_summ += x.Key * x.Value;

			return range_summ / summary_frequence;
		}

		// Смещенная оценка генеральной дисперсии
		// ВЫБОРОЧНАЯ ДИСПЕРСИЯ
		public double Dispersion()
		{
			double disp_summ = 0;
			foreach (var x in distr)
				disp_summ += Math.Pow(x.Key - mean, 2) * x.Value;

			return disp_summ / summary_frequence;
		}

		// Выборочное среднее квадратическое отклонение
		public double StandartDeviation()
		{
			return Math.Sqrt(dispersion);
		}

		// Несмещенная оценка генеральной дисперсии
		// ИСПРАВЛЕННАЯ ВЫБОРОЧНАЯ ДИСПЕРСИЯ
		public double SDispersion()
		{
			double n = summary_frequence;
			return (n * dispersion) / (n - 1);
		}

		//Начальный выборочный момент
		public double StartMoment(int r)
		{
			double sm = 0;
			foreach (var x in distr)
				sm += Math.Pow(x.Key, r) * x.Value;

			return sm / summary_frequence;
		}

		//Центральный выборочный момент
		public double CentralMoment(int r)
		{
			double cm = 0;
			foreach (var x in distr)
				cm += Math.Pow(x.Key - mean, r) * x.Value;

			return cm / summary_frequence;
		}
	}
}
