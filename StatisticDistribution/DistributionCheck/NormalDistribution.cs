using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Для проверки гипотезы о нормальном законе распределения
	/// </summary>
	public class NormalDistribution : AbstractDistribution
	{
		public override string Name { get { return "Нормальное распределение"; } }

		public NormalDistribution(Distribution.Distribution distr):base(distr)
		{

		}

		public override Dictionary<double, double> StatisticsData
		{
			get
			{
				return distr.GroupFreq;
			}
		}

		public override List<KeyValuePair<double, double>> CalcProbablities()
		{
			throw new NotImplementedException();
		}

		public override KeyValuePair<double, double> GetPointParams()
		{
			throw new NotImplementedException();
		}
	}
}
