using System.Drawing;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Точечная оценка
	/// </summary>
	public struct PointValue
	{
		public string Name;         //Название параметра
		public Bitmap Formula;      //Формула точечной оценки
		public double Value;		//Значение

		public PointValue(string name, Bitmap formula, double value)
		{
			Name = name;
			Formula = formula;
			Value = value;
		}
	}
}
