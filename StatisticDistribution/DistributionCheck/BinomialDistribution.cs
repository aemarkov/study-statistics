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

		#region STATISTICS_INTERFACE
		///////////////////////////// ДАННЫЕ О СТАТИСТИЧЕСКОМ РЯДЕ ////////////////////////////////////////

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

		//Возвращает размер исходной выборки
		public override int Count
        {
            get { throw new NotImplementedException(); }
        }


		//Возвращает точечные оценки
		public override List<PointValue> PointValues
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		//Расчитывает теоретические вероятности
		public override List<PirsonProbability> CalcProbablities()
		{
			throw new NotImplementedException();
		}
	}
}
