using System.Drawing;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Точечная оценка
	/// </summary>
	public struct PointValue
	{
		public string ParamName { get; private set;  }   //Название параметра
		public Bitmap Formula { get; private set; }		 //Формула точечной оценки
		public double Value { get; private set; }		 //Значение

		public PointValue(string name, Bitmap formula, double value)
		{
			ParamName = name;
			Formula = formula;
			Value = value;
		}
	}
}
