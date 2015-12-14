using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utils;

namespace Regression
{
	/// <summary>
	/// Корреляционная таблица
	/// </summary>
	class CorrelationTable
	{

		private double[,] table;        //Значения корреляционной таблицы
		private Range[] x_headers;      //Список интервалов по Х (горизонтально)
		private Range[] y_headers;      //Список интервалов по У (вертикально)

		public int Width { get; private set; }
		public int Height { get; private set; }


		/// <summary>
		/// Создание корреляционной таблицы заданного рамзера
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public CorrelationTable(int width, int height)
		{
			Width = width;
			Height = height;

			x_headers = new Range[width];
			y_headers = new Range[height];

			table = new double[width, height];
		}

		/// <summary>
		/// Заполняет таблицу из списка пар значений СВ
		/// </summary>
		/// <param name="poit"></param>
		public void Fill(PointD poits)
		{

		}

		/// <summary>
		/// Доступ к элементу по индексам
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public double this[int x, int y]
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
		public double this[Range x, Range y]
		{
			get
			{
				return table[get_index_by_range_x(x), get_index_by_range_y(y)];
			}
			set
			{
				table[get_index_by_range_x(x), get_index_by_range_y(y)] = value;
			}
		}

		///// УПРАВЛЕНИЕ ДИАПАЗАОНАМИ

		public Range GetX(int i)
		{
			return x_headers[i];
		}

		public void SetX(int i, Range range)
		{
			x_headers[i] = range;
		}
		public Range GetY(int j)
		{
			return y_headers[j];
		}

		public void SetY(int j, Range range)
		{
			y_headers[j] = range;
		}


		/////////////////////////////////////////////////////////////////////////////////////////////////


		private int get_index_by_range_x(Range range)
		{
			for (int i = 0; i < x_headers.Length; i++)
				if (x_headers[i] == range) return i;

			return -1;
		}

		private int get_index_by_range_y(Range range)
		{
			for (int i = 0; i < y_headers.Length; i++)
				if (y_headers[i] == range) return i;

			return -1;
		}
	}
}
