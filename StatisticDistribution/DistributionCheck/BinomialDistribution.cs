using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Statistics.Distribution;
using Statistics.Utils;
using StatisticDistribution.Helpers;
using StatisticDistribution.Properties;


namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Для проверки гипотезы о нормальном законе распределения
	/// </summary>
	public class BinomialDistribution : AbstractDistribution
	{
		private double p; // M(x) / n 			    //Вероятность благоприятного исхода (точечная оценка)
        private int n;    // Объем выборки
        private List<PointValue> point_values;		//Список точечных оценок

        Dictionary<double, double> raw_statistics;      //Исходный ряд (либо группированный, либо простой)
                                                        //Используется для расчет точечных оценок и построения
                                                        //теоретической функции
        

        #region CONSTRUCTORS
		public BinomialDistribution(Distribution.Distribution distr):base(distr)
		{
            raw_statistics = distr.StatFreq;
            n = raw_statistics.Count; //distr.Count;
            double mean = new NumericSolver(raw_statistics).Mean();
            p =  mean / n;

			point_values = new List<PointValue>
            {
                new PointValue("Вероятность появления события", Resources.binomial_p, p)
            };
		}
        #endregion



        #region STATISTICS_INTERFACE
        ///////////////////////////// ДАННЫЕ О СТАТИСТИЧЕСКОМ РЯДЕ ////////////////////////////////////////

		//Название распределения
		public override string Name { get { return "Биномиальное распределение"; } }

		public override Bitmap Funtion{ get { return Resources.binomial_function; }}

		//Возвращает ряд относительных частот, для построения полигона
		public override Dictionary<double, double> StatisticsData {get { return distr.StatRelFreq; }}

		//Возвращает список точек для построения теоретической кривой
		public override Dictionary<double, double> GetTheoreticalFreq()
		{
			// генерация теоретического ряда распределения
            Dictionary<double, double> theoreticalFreq = new Dictionary<double, double>();
            foreach(var i in raw_statistics)
            {
                int k = (int)i.Key;
                theoreticalFreq.Add(k, BinomialP.correct(k, n, p));
            }

            return theoreticalFreq;
		}

		//Возвращает точечные оценки
		public override List<PointValue> PointValues
		{
			get
			{
                return point_values;
			}
		}

		#endregion

		//Расчитывает теоретические вероятности
		public override List<PirsonProbability> CalcProbablities()
		{
            List<PirsonProbability> listOfMiPi = new List<PirsonProbability>();
            foreach(var i in raw_statistics)
            {
                int k  = (int)i.Key;
                int mi = (int)i.Value;
                double pi = BinomialP.correct(k, n, p);
                Range fakeRange = new Range(k, k, true, true);
                listOfMiPi.Add(new PirsonProbability(mi, pi, fakeRange));
            }

            return listOfMiPi;
        }
    }
}
