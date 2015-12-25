using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Regression.Utils;

namespace Regression
{
	/// <summary>
	/// Считает и сохраняет все параметры корреляционных штук
	/// </summary>
	public class CorrelationCalc
	{
		#region COLLERATION_PARAMS

		/// <summary>
		/// Число элементов
		/// </summary>
		public int N { get; private set; }

		public int[] Nj { get; private set; }
		public int[] Ni { get; private set; }

		/// <summary>
		/// Середина Х наиболее часто встречающегося интервала
		/// </summary>
		public double Dx { get; private set; }

		/// <summary>
		/// Середина Х наиболее часто встречающегося интервала
		/// </summary>
		public double Dy { get; private set; }

		//Какие-то числа вместо середин интервалов
		public double[] Ui { get; private set; }

		public double[] Vj { get; private set; }

		//СУММЫ
		public double NiUi { get; private set; }
		public double NjVj { get; private set; }
		public double NiUi2 { get; private set; }
		public double NjVj2 { get; private set; }
		public double NijUiVj { get; private set;}

		//Еще суммы
		public double Qu { get; private set; }
		public double Qv { get; private set; }
		public double Quv { get; private set; }

		//Всякие параметры

		//Среднии
		public double X { get; private set; }
		public double Y { get; private set; }

		//Дисперсии
		public double Sx { get; private set; }
		public double Sy { get; private set; }

		//Коэффициент корреляции
		public double R { get; private set; }

		//ОЦенки коээфициентов линейной регрессии
		public double B1 { get; private set; }
		public double B1_ { get; private set; }

		#endregion

		/////////////////////////////////////////////////////////////////////////////

		public CorrelationTable Table { get; private set; }

		public CorrelationCalc(CorrelationTable table)
		{
			this.Table = table;

			N = get_n(table);
			Ni = get_Ni(table);
			Nj = get_Nj(table);

			var dxdy = get_DxDy(table);
			Dx = dxdy.X;
			Dy = dxdy.Y;

			Ui = get_ui(table, Dx);
			Vj = get_vj(table, Dy);

			NiUi = get_NiUi(table.Width, Ni, Ui);
			NjVj = get_NiUi(table.Height, Nj, Vj);
			NiUi2 = get_NiUi(table.Width, Ni, Ui.Select(x => x * x).ToArray());
			NjVj2 = get_NiUi(table.Height, Nj, Vj.Select(x=>x* x).ToArray());

			Qu = NiUi2 - NiUi * NiUi / N;
			Qv = NjVj2 - NjVj * NjVj / N;
			NijUiVj = get_NijUiVj(table, Ni, Ui, Nj, Vj);
			Quv= NijUiVj - NiUi * NjVj / N; ;

			//Расчет среднего
			X = table.Bx * NiUi / N + Dx;
			Y = table.By * NjVj / N + Dy;

			//Расчет дисперсии
			Sx = table.Bx * table.Bx * Qu / (N - 1);
			Sy = table.By * table.By * Qv / (N - 1);

			//Расчет коэффициента корреляции:
			R = Quv / Math.Sqrt(Qu * Qv);

			//Расчет коээфициентов линейной регрессии
			B1 = table.Bx / table.By * Quv / Qu;
			B1_ = table.Bx / table.By * Quv / Qv;
		}

		/////////////////////////////////////////////////////////////////////////////

		//Находит число элементов
		int get_n(CorrelationTable table)
		{
			int sum = 0;
			for (int i = 0; i < table.Width; i++)
				for (int j = 0; j < table.Height; j++)
					sum += table[i, j];

			return sum;
		}

		//Находит непонятно что
		int[] get_Nj(CorrelationTable table)
		{
			var ni = new int[table.Height];
			for(int y = 0; y<table.Height; y++)
			{
				int sum = 0;
				for (int x = 0; x < table.Width; x++)
					sum += table[x, y];

				ni[y] = sum;
			}

			return ni;
		}


		int[] get_Ni(CorrelationTable table)
		{
			var ni = new int[table.Width];
			for (int x = 0; x < table.Width; x++)
			{
				int sum = 0;
				for (int y = 0; y < table.Height; y++)
					sum += table[x, y];

				ni[x] = sum;
			}

			return ni;
		}

		//Находимт среднее наиболее часто встречающегося интервала
		PointI get_DxDy(CorrelationTable table)
		{

			//Находим наибллее часто встреч.
			int max=0, max_x=0, max_y=0;
			for (int i = 0; i < table.Width; i++)
				for (int j = 0; j < table.Height; j++)
					if(table[i,j]>max)
					{
						max = table[i, j];
						max_x = i;
						max_y = j;
					}

			return new PointI(max_x, max_y);
        }

		//Находим странные Ui, Vj
		double[] get_ui(CorrelationTable table, double dx)
		{
			return table.XHeaders.Select(x => (x.Middle - dx) / table.Bx).ToArray();
		}

		double[] get_vj(CorrelationTable table,  double dy)
		{
			return table.YHeaders.Select(y => (y.Middle - dy) / table.By).ToArray();
		}

		//Расчет странных сумм (4-in-1)
		double get_NiUi(int size, int[] ni, double[] ui)
		{
			double sum = 0;
			for (int i = 0; i < size; i++)
				sum += ni[i] + ui[i];

			return sum;
		}

		//Расчет других странных сумм
		double get_NijUiVj(CorrelationTable table, int[] Ni, double[] Ui, int[] Nj, double[]Vj)
		{
			double sum1 = 0;
			for (int x = 0; x < table.Width; x++)
				for (int y = 0; y < table.Height; y++)
					sum1 += table[x, y] * Ui[x] * Vj[y];        //???

			return sum1;
		}

	}
}
