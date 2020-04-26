using System;
using System.Text.RegularExpressions;

namespace Statistics.Utils
{
	//Это просто Key-Value pair, но с 
	//возможностью менять значения Key и Value.
	//Иначе список не редактируем
	public class IntervalPair
	{
		private static Regex regex = new Regex(@"\(-?[0-9]+(,[0-9]+)?;-?[0-9]+(,[0-9]+)?]");

		public string Key { get; set; }		//Интервал
		public int Value { get; set; }	    //Значение
		public IntervalPair()
		{
			Key = "";
			Value = 0;
		}

		public IntervalPair(string key, int value)
		{
			Key = key;
			Value = value;
		}

		//Парсит строку в объект Range
		public Range? GetRange()
		{
			var match = regex.Match(Key);
			if (match.Success)
			{
				//Разбиваем
				string[] numbers = Key.Split(';');

				//Вырезаем начальную и конечную скобку
				numbers[0] = numbers[0].Substring(1);
				numbers[1] = numbers[1].Substring(0, numbers[1].Length - 1);
				return new Range(Double.Parse(numbers[0]), Double.Parse(numbers[1]));
			}
			else
				return null;
		}
	}
}
