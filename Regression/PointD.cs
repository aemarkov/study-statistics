using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
	/// <summary>
	/// Точка Double
	/// </summary>
	struct PointD
	{
		public double X { get; set; }
		public double Y { get; set; }
		public PointD(double x, double y)
		{
			X = x;
			Y = y;
		}

		public new string ToString()
		{
			return "(" + X.ToString() + "; " + Y.ToString() + ")";
		}
	}
}
