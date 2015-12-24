using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utils;

namespace Regression
{
	/// <summary>
	/// Корреляционная таблица
	/// </summary>
	public class CorrelationTable
	{

		private int[,] table;        //Значения корреляционной таблицы

		/// <summary>
		/// Список интервалов по Х (горизонтально)
		/// </summary>
		public Range[] XHeaders { get; private set; }

		/// <summary>
		/// Список интервалов по У (вертикально)
		/// </summary>
		public Range[] YHeaders { get; private set; }

		public int Width { get; private set; }
		public int Height { get; private set; }

		/// <summary>
		/// Шаг по гооризонтали
		/// </summary>
		public double Bx { get; private set; }

		/// <summary>
		/// Шаг по вертикали
		/// </summary>
		public double By { get; private set; }


		/// <summary>
		/// Создание корреляционной таблицы заданного рамзера
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public CorrelationTable(int width, int height)
		{
			Width = width;
			Height = height;

			XHeaders = new Range[width];
			YHeaders = new Range[height];

			table = new int[width, height];
		}

		/// <summary>
		/// Заполняет таблицу из списка пар значений СВ
		/// </summary>
		/// <param name="poit"></param>
		public void Fill(List<PointD> data)
		{
			double min_x = data.Min(x => x.X);
			double max_x = data.Max(x => x.X);
			double min_y = data.Min(x => x.Y);
			double max_y = data.Max(x => x.Y);

			double step_x = (max_x - min_x) / Width;
			double step_y = (max_y - min_y) / Height;
			Bx = step_x;
			By = step_y;

			//Заполняем "оси"
			double x_1 = min_x;
			double x_2 = min_x + step_x;
			for(int i = 0; i<Width; i++)
			{
				XHeaders[i] = new Range(x_1, x_2, true);
				x_1 = x_2;
				x_2 += step_x;
			}

			double y_1 = min_y;
			double y_2 = min_y + step_y;
			for(int i = 0; i<Height; i++)
			{
				YHeaders[i] = new Range(y_1, y_2, true);
				y_1 = y_2;
				y_2 += step_y;
			}

			//Заполняем корреляционную таблицу
			foreach(var x in data)
			{
				this[x.X, x.Y]++;
			}
		}

		/// <summary>
		/// Доступ к элементу по индексам
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int this[int x, int y]
		{
			get
			{
				return table[x, y];
			}
			set
			{
				table[x, y] = value;
			}
        }

		/// <summary>
		/// Доступ к элементу по диапазону
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int this[Range x, Range y]
		{
			get
			{
				return table[(int)get_index_by_range_x(x), (int)get_index_by_range_y(y)];
			}
			set
			{
				table[(int)get_index_by_range_x(x), (int)get_index_by_range_y(y)] = value;
			}
		}

		/// <summary>
		/// Доступ к элементу по принадлежности к диапазону
		/// Скорее всего вам нужно это
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int this[double x, double y]
		{
			get
			{
				int x1 = (int)get_index_by_value_x(x);
				int y1 = (int)get_index_by_value_y(y);

                return table[x1,y1];
			}
			set
			{
				int x1 = (int)get_index_by_value_x(x);
				int y1 = (int)get_index_by_value_y(y);

				table[x1, y1] = value;
			}
		}

		///// УПРАВЛЕНИЕ ДИАПАЗАОНАМИ

		public Range GetX(int i)
		{
			return XHeaders[i];
		}

		public void SetX(int i, Range range)
		{
			XHeaders[i] = range;
		}
		public Range GetY(int j)
		{
			return YHeaders[j];
		}

		public void SetY(int j, Range range)
		{
			YHeaders[j] = range;
		}


		/////////////////////////////////////////////////////////////////////////////////////////////////


		private int? get_index_by_range_x(Range range)
		{
			for (int i = 0; i < XHeaders.Length; i++)
				if (XHeaders[i] == range) return i;

			return null;
		}

		private int? get_index_by_range_y(Range range)
		{
			for (int i = 0; i < YHeaders.Length; i++)
				if (YHeaders[i] == range) return i;

			return null;
		}

		//По попаданию в интервал
		private int? get_index_by_value_x(double x)
		{
			//Последнюю границу включаем
			if (x == XHeaders.Last().Right) return XHeaders.Length - 1;

			for (int i = 0; i<XHeaders.Length;i++)
			{
				var interval = XHeaders[i];
				if ((x >= interval.Left) && (x < interval.Right))
					return i;
			}

			return null;
		}

		private int? get_index_by_value_y(double y)
		{
			//Последнюю границу включаем
			if (y == YHeaders.Last().Right) return YHeaders.Length - 1;

			for (int i = 0; i < YHeaders.Length; i++)
			{
				var interval = YHeaders[i];
				if ((y >= interval.Left) && (y < interval.Right))
					return i;
			}

			return null;
		}
	}
}
