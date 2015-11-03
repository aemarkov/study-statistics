using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Для проверки гипотезы о нормальном законе распределения
	/// </summary>
	public class BinomialDistribution : AbstractDistribution
	{
		//Название распределения
		public override string Name { get { return "Биномиальное распределение"; } }

		//Конструктор
		public BinomialDistribution(Distribution.Distribution distr):base(distr)
		{

		}

		//Возвращает ряд частот, для построения полигона
		public override Dictionary<double, double> StatisticsData
		{
			get
			{
				return distr.StatFreq;
			}
		}

		//Возвращает список точек для построения теоретической кривой
		public override Dictionary<double, double> GetTheoreticalFreq()
		{
			throw new NotImplementedException();
		}

		//Вычисляет вероятности для критерия Пирсона
		public override List<KeyValuePair<double, double>> CalcProbablities()
		{
			throw new NotImplementedException();
		}

        public override int Count
        {
            get { throw new NotImplementedException(); }
        }

        public override KeyValuePair<double, double> PointValues
        {
            get { throw new NotImplementedException(); }
        }

	}
}
