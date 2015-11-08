using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticDistribution.Helpers
{
    // Gmurman (c 52 - 53)
    class BinomialP
    {
		/// <summary>
		/// Расчет вероятности k успехов в биномиальном законе
		/// </summary>
		/// <param name="k">Число успехов</param>
		/// <param name="n">Число опытов(??)</param>
		/// <param name="p">Вероятность успеха в одном испытании</param>
		/// <returns></returns>
        static public double BinomialProbability(int k, int n, double p)
        {
            double Cnk = (double)combinations(n, k);
            double pk = Math.Pow(p, k);
            double qn_k = Math.Pow(1 - p, n - k);
            double P = Cnk * pk * qn_k;
            return P;
        }

		//Вычисление факториала
        static private double correct_factorial(double n)
        {
            double factorial = 1;
            for (int i = 2; i <= n; ++i)
                factorial *= i;
            return factorial;       
        }

        // сочетания из n по k
        static private double combinations(int n, int k)
        {
            return correct_factorial(n) / (correct_factorial(k) * correct_factorial(n - k));
        }

        #region UNUSED
        static public double approximated(int k, int n, double p)
        {
            double lambda = n * p;
            return Math.Pow(lambda, (double)k) * Math.Pow(Math.E, -lambda) / approximated_factorial(k);
        }

        // http://nuclphys.sinp.msu.ru/mathan/p3/m3205.html
        // Не работает корректно
        static private double approximated_factorial(double n)
        {
            return (Math.Sqrt(2.0 * Math.PI) * Math.Pow(n, (n + 0.5))) / (Math.Pow(Math.E, 2.0));
        }
        #endregion
    }
}