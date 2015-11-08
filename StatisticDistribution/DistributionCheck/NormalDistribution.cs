using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Statistics.Distribution;
using Statistics.Utils;

using StatisticDistribution.Properties;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Для проверки гипотезы о нормальном законе распределения
	/// </summary>
	public class NormalDistribution : AbstractDistribution
	{
		double expected_value;					         //Матожидание
		double standart_deviation;				        //Среднекв. откланение

		Dictionary<double, double> raw_statistics;      //Исходный ряд (либо группированный, либо простой)
														//Используется для расчет точечных оценок и построения
														//теоретической функции

		List<PointValue> point_values;					//Точечные оценки
		
		

		#region CONSTRUCTORS

		/// <summary>
		/// Создает новый объект NormalDistribution на основе объекта 
		/// Distribution, содержащего статистические данные, для которых
		/// проверяется гипотеза
		/// </summary>
		/// <param name="distr"></param>
		public NormalDistribution(Distribution.Distribution distr):base(distr)
		{
            //Если наш исходный ряд был обычным рядом (либо ввод ряда, либо ввод выборки),
            //то берем ряд частот. Иначе берем группированный ряд частот как его аналог для
            //интервального ряда
			if (distr.StatFreq != null)
				raw_statistics = distr.StatFreq;
			else
				raw_statistics = distr.GroupFreq;


			//Расчитываем точеченые оценки

			//Мат ожидание = выборочное средние
			//Дисперсия = выборочная дисперсия
			NumericSolver solver = new NumericSolver(raw_statistics);
			standart_deviation = solver.StandartDeviation();
			expected_value = solver.Mean();

			//Создаем список с точечными оценками
			point_values= new List < PointValue >
            {
				new PointValue("Математическое ожидание", Resources.normal_expected_value, expected_value),
				new PointValue("Среднеквадратическое откланение", Resources.normal_standart_deviation, standart_deviation),
			};
		}

		#endregion

		#region STATISTICS_INTERFACE
		///////////////////////////// ДАННЫЕ О СТАТИСТИЧЕСКОМ РЯДЕ ////////////////////////////////////////

		/// <summary>
		/// Название распределения
		/// </summary>
		public override string Name { get { return "Нормальное распределение"; } }

		/// <summary>
		/// Картинка с формулой закона распределения
		/// </summary>
		public override Bitmap Funtion { get { return Resources.normal_function; } }

		//Возвращает группированный ряд относительных частот
		public override Dictionary<double, double> StatisticsData{ get { return distr.GroupRelFreq; } }


		//Возвращает мат ожидание и  среднеквадратическое откланенеие
		public override List<PointValue> PointValues { get { return point_values; } }

		//Возвращает список точек для построения теоретической кривой
		public override Dictionary<double, double> GetTheoreticalFreq()
		{
			double start = raw_statistics.First().Key;
			double end = raw_statistics.Last().Key;

			var points = new Dictionary<double, double>();

			for (double x = start; x <= end; x += 0.1)
				points.Add(x, f(x));

			return points;
		}

		#endregion

		//Вычисляет вероятности для критерия Пирсона
		public override List<PirsonProbability> CalcProbablities()
		{
			//(-inf; a1] (a1; a2] (a2; a3] ... (an-1; +inf)
			//Ф(inf)=0.5

			//Интервальный ряд распределения
			List<PirsonProbability> result = new List<PirsonProbability>();

			var intervals = distr.IntervalFreq;  //интервальный ряд
			var freq = distr.GroupFreq;          //группированный ряд (для mi)
			double u1, u2;
			double x1, x2;
			double p;

			//Значение для интервала (-inf; a1];
			u1 = -0.5;
			x2 = intervals.First().Key.Right;
			u2 = LaplasFunction.Calc(l_arg(x2));
			p = u2 - u1;
			result.Add(new PirsonProbability((int)freq.First().Value, p, new Range(Double.NegativeInfinity, x2, false, true)));
					
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
				result.Add(new PirsonProbability((int)freq.ElementAt(i).Value, p, new Range(x1,x2, false, true)));
			}

			//Значение для интервала (an-1; +inf)
			x1 = intervals.Last().Key.Left;
            u1 = LaplasFunction.Calc(l_arg(x1));
            u2 = 0.5;
            p = u2 - u1;
            result.Add(new PirsonProbability((int)freq.Last().Value, p, new Range(x1, Double.PositiveInfinity)));

			return result;
		}

		#region HELP_FUNCTIONS
		/////////////////////  ВСПОМОГАТЕЛЬНЫЕ ФУНКЦИИ /////////////////////////////////////////////

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

		#endregion
	}
}
