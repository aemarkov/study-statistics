using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Statistics.Distribution;
using Statistics.Utils;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Для проверки гипотезы о нормальном законе распределения
	/// </summary>
	public class NormalDistribution : AbstractDistribution
	{
		private double expected_value;					//Матожидание
		private double standart_deviation;				//Среднекв. откланение

		Dictionary<double, double> raw_statisttics;		//Исходный ряд (либо группированный, либо простой)

		//Название распределения
		public override string Name { get { return "Нормальное распределение"; } }

		//Конструктор
		public NormalDistribution(Distribution.Distribution distr):base(distr)
		{
			if (distr.StatFreq != null)
				raw_statisttics = distr.StatFreq;
			else
				raw_statisttics = distr.GroupFreq;


			//Расчитываем точеченые оценки

			//Мат ожидание = выборочное средние
			//Дисперсия = выборочная дисперсия
			NumericSolver solver = new NumericSolver(raw_statisttics);
			standart_deviation = solver.StandartDeviation();
			expected_value = solver.Mean();
		}

		//Возвращает группированный ряд частот для построения полигона
		public override Dictionary<double, double> StatisticsData
		{
			get
			{
				return distr.GroupFreq;
			}
		}

        public override int Count { get { return distr.Count; } }

		//Возвращает список точек для построения теоретической кривой
		public override Dictionary<double, double> GetTheoreticalFreq()
		{
			double start = raw_statisttics.First().Key;
			double end = raw_statisttics.Last().Key;

			var points = new Dictionary<double, double>();

			for (double x = start; x <= end; x += 0.1)
				points.Add(x, f(x));

			return points;
		}

		//Вычисляет вероятности для критерия Пирсона
		public override List<KeyValuePair<double, double>> CalcProbablities()
		{
			//(-inf; a1] (a1; a2] (a2; a3] ... (an-1; +inf)
			//Ф(inf)=0.5

			//Интервальный ряд распределения
			List<KeyValuePair<double, double>> result = new List<KeyValuePair<double, double>>();

			var intervals = distr.IntervalFreq; //интервальный ряд
			var freq = StatisticsData;          //группированный ряд (для mi)
			double u1, u2;
			double x1, x2;
			double p;

			//Значение для интервала (-inf; a1];
			u1 = -0.5;
			x2 = intervals.First().Key.Right;
			u2 = LaplasFunction.Calc(l_arg(x2));
			p = u2 - u1;
			result.Add(new KeyValuePair<double, double>(freq.First().Value, p));
			
			//СТРАШНЫЙ ГОВНОКОД
			//СЛОЖНОСТЬ КАЖДОЙ ИТЕРАЦИИ O(N)
			//УБЕЙТЕ МЕНЯ ЗА ЭТО
			for(int i = 1; i<intervals.Keys.Count-1; i++)
			{
				var element = intervals.ElementAt(i);
				x1 = element.Key.Left;
				x2 = element.Key.Right;
				var a1 = l_arg(x1);
				var a2 = l_arg(x2);
				u1 = LaplasFunction.Calc(l_arg(x1));
				u2 = LaplasFunction.Calc(l_arg(x2));
				p = u2 - u1;
				result.Add(new KeyValuePair<double, double>(freq.ElementAt(i).Value, p));
			}

            //Значение для интервала (an-1; +inf)
            u1 = LaplasFunction.Calc(l_arg(intervals.Last().Key.Left));
            u2 = 0.5;
            p = u2 - u1;
            result.Add(new KeyValuePair<double,double>(freq.Last().Value, p));
			return result;
		}

		///////////////////////////////////////////////////////////////////////////////////////

		//Плотность вероятности
		double f(double x)
		{
			return 1 / (Math.Sqrt(2 * Math.PI) * standart_deviation) * Math.Exp(-Math.Pow(x - expected_value, 2) / (2 * standart_deviation));
		}

		//Вычисление аргумента для функции Лапласса
		double l_arg(double x)
		{
			return (x - expected_value) / standart_deviation;
		}
	}
}
