using Statistics.Utils;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Представляет пару Pi (теоретическая вероятность)
	/// и Mi (частота) на каком-то интервале
	/// для расчета критерия Пирсона
	/// </summary>
	public struct PirsonProbability
	{
		public double Pi { get; private set; }
		public int Mi { get; private set; }
		public Range Interval { get; private set; }

		public PirsonProbability(int mi, double pi, Range interval)
		{
			Pi = pi;
			Mi = mi;
			Interval = interval;
		}
	}
}
