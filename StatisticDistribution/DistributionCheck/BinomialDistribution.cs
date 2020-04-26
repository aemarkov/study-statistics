using System.Collections.Generic;
using System.Drawing;
using Statistics.Distribution;
using Statistics.Utils;
using StatisticDistribution.Properties;


namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Для проверки гипотезы о нормальном законе распределения
	/// </summary>
	public class BinomialDistribution : AbstractDistribution
	{	
		private double p; // M(x) / n 					//Вероятность благоприятного исхода (точечная оценка)
		int n;											//Число опытов в одном испытании
        private List<PointValue> point_values;			//Список точечных оценок

        Dictionary<double, double> raw_statistics;      //Исходный ряд (либо группированный, либо простой)
                                                        //Используется для расчет точечных оценок и построения
                                                        //теоретической функции
        

        #region CONSTRUCTORS
		public BinomialDistribution(Distribution.Distribution distr, int number_of_experiments):base(distr)
		{
            raw_statistics = distr.StatFreq;
			n = number_of_experiments;

			//Вычисляем вероятность благоприятного исхода
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

		public override DistributionType DistributionType { get { return DistributionType.DISCRETE; } }

		//Название распределения
		public override string Name { get { return "Предполагаемое биномиальное распределение"; } }

		public override Bitmap Funtion{ get { return Resources.binomial_function; }}

		//Возвращает список точек для построения теоретической кривой
		public override Dictionary<double, double> GetTheoreticalFreq()
		{
			// генерация теоретического ряда распределения
            Dictionary<double, double> theoreticalFreq = new Dictionary<double, double>();
            foreach(var i in raw_statistics)
            {
                int k = (int)i.Key;
				if (!theoreticalFreq.ContainsKey(k))
					theoreticalFreq.Add(k, BinomialP.BinomialProbability((int)k, n, p));
				else
					throw new ElementAlreadyExistsException();
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
                double pi = BinomialP.BinomialProbability(k, n, p);
                listOfMiPi.Add(new PirsonProbability(mi, pi, k));
            }

            return listOfMiPi;
        }
    }
}
