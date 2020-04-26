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

		//Говнокод нужен этот, чтобы джедай рукожопый мог значения х
		//для ряда дискретного и непрерывного передавать
		//object - Range или Int быть может
		public object XValue { get; private set; }		

		public PirsonProbability(int mi, double pi, object interval) :this()
		{
			Pi = pi;
			Mi = mi;
			XValue = interval;
		}
	}
}
