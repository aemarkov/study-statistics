using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.Utils
{
	//Находит функцию Лапласса
	public class LaplasFunction
	{
		public static double Calc(double x)
		{
			int number_of_intervals = 40000;
			return (1.0 / Math.Sqrt(2.0 * Math.PI)) * calculate_integral(0, x, number_of_intervals);
		}

		// Подинтегральная функция
		private static double exponenta_function(double argument)
		{
			return Math.Pow(Math.E, -Math.Pow(argument, 2) / 2.0);
		}

		// Используется метод прямоугольников
		// in | number_of_intervals = число интервалов, определяет точность
		private static double calculate_integral(double lower_limit, double upper_limit, int number_of_intervals = 35000)
		{
			double summary_height = 0.0f; // Суммарная высота прямоугольников
			double step = (upper_limit - lower_limit) / number_of_intervals;
			double argument = lower_limit;

			for (int i = 0; i < number_of_intervals - 1; i++, argument += step)
				summary_height += exponenta_function(argument);

			return summary_height * step;
		}
	}
}
