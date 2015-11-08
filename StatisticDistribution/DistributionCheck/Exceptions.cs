using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Исключение, возникающее при попытке добавить в биномиальное распределение два одинаковых элемента
	/// </summary>
	class ElementAlreadyExistsException:Exception
	{
		public ElementAlreadyExistsException():base("Элемент ряда повторяется. Это возможно, если исходный ряд имел дробные занчения. Биномиальное распределение определено только для целых чисел.")
		{

		}
	}
}
