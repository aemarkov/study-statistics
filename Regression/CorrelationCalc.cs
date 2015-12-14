using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
	/// <summary>
	/// Считает и сохраняет все параметры корреляционных штук
	/// </summary>
	class CorrelationCalc
	{
		#region COLLERATION_PARAMS

		/// <summary>
		/// Число элементов
		/// </summary>
		public int N { get; private set; }

		//public int Nj { get; private set; }
		//public int Ni { get; private set; }

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

		public double Vj { get; private set; }

		//СУММЫ
		public double NiUi { get; private set; }
		public double NjVj { get; private set; }
		public double NiUi2 { get; private set; }
		public double NjVj2 { get; private set; }

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
		public double r { get; private set; }

		//ОЦенки коээфициентов линейной регрессии
		public double B1 { get; private set; }
		public double B1_ { get; private set; }

		#endregion
	}
}
