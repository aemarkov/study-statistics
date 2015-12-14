using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regression
{
	/// <summary>
	/// Шаблонная точка
	/// </summary>
	public class PointT<T>
	{
		public T X { get; set; }
		public T Y { get; set; }
		public PointT(T x, T y)
		{
			X = x;
			Y = y;
		}

		public new string ToString()
		{
			return "(" + X.ToString() + "; " + Y.ToString() + ")";
		}
	}

	/// <summary>
	/// Точка Double
	/// </summary>
	public class PointD:PointT<double>
	{
		public PointD(double x, double y) : base(x, y) { }
	}

	/// <summary>
	/// Точка Int
	/// Да, я сделал то, что уже есть.
	/// Чтобы не подключать Drawing туда, где он 
	/// по смыслу не нужен
	/// </summary>
	public class PointI: PointT<int>
	{
		public PointI(int x, int y) : base(x, y) { }
	}
}
