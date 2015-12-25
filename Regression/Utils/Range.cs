using System;
using System.Text.RegularExpressions;
namespace Regression.Utils
{
	/// <summary>
	/// Представляет диапазон
	/// </summary>
	public class Range
	{
		private bool leftIncluded, rightIncluded;   //Включенность границ
		private static Regex regex = new Regex(@"\[(-?[0-9]+(?:,[0-9]+)?);(-?[0-9]+(?:,[0-9]+)?)\)");

		public double Left { get; set; }			//Левая граница диапазона
		public double Right { get; set; }           //Правая граница диапазона

		//Середина диапазона
		public double Middle { get { return Left + (Right - Left) / 2.0; } }

		//Длина интервала
		public double Length { get{ return Right - Left; } }

		public Range()
		{
			Left = 0;
			Right = 0;
		}

		//Конструктор
		public Range(double left, double right, bool leftIncluded=false, bool rightIncluded=false)  :this()
		{
			Left = left;
			Right = right;
			this.leftIncluded = leftIncluded;
			this.rightIncluded = rightIncluded;
		}

		//Парсинг
		public static bool TryParse(string str, out Range range)
		{
			double left, right;
			range = null;
			var match = regex.Match(str);

			if (match.Groups.Count != 3) return false;
			if (!double.TryParse(match.Groups[1].Value, out left)) return false;
			if (!double.TryParse(match.Groups[2].Value, out right)) return false;

			range = new Range(left, right, true);
			return true;
		}

		public static Range Parse(string str)
		{
			Range range;
			if (!Range.TryParse(str, out range)) throw new FormatException();
			return range;
		}

		//Перевод к строке
		public override string ToString()
		{
			return (leftIncluded ?  "[" : "(") + Left.ToString("N2") + "; " + Right.ToString("N2") + (rightIncluded ? "]": ")")+Environment.NewLine+Middle.ToString();
		}

		//Сравнения
		public static bool operator==(Range a, Range b)
		{
			return (a.Left == b.Left) && (a.Right == b.Right);
		}

		public static bool operator!=(Range a, Range b)
		{
			return !(a == b);
		}
	}
}
