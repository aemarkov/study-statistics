using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Представляет пару Pi (теоретическая вероятность)
	/// и Mi (частота) на каком-то интервале
	/// для расчета критерия Пирсона
	/// </summary>
	public struct PirsonProbability
	{
		public double Pi;
		public int Mi;

		public PirsonProbability(int mi, double pi)
		{
			Pi = pi;
			Mi = mi;
		}
	}
}
