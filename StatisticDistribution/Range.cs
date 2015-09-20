using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticDistribution
{
	/// <summary>
	/// Представляет диапазон
	/// </summary>
	public struct Range
	{
		public double Left { get; set; }
		public double Right { get; set; }
		public double Middle { get {
				return Left + (Right - Left) / 2.0; } }

		public Range(double left, double right)
		{
			Left = left;
			Right = right;
		}

		public override string ToString()
		{
			return "[" + Left.ToString() + "; " + Right.ToString() + ")";
		}
	}
}
