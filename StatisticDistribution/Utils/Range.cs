namespace Statistics.Utils
{
	/// <summary>
	/// Представляет диапазон
	/// </summary>
	public struct Range
	{
		private bool leftIncluded, rightIncluded;	//Включенность границ

		public double Left { get; set; }			//Левая граница диапазона
		public double Right { get; set; }			//Правая граница диапазона
		public double Middle						//Середина диапазона
		{
			get
			{
				return Left + (Right - Left) / 2.0;
			}
		}

		public double Length					//Длина интервала
		{
			get
			{
				return Right - Left;
			}
		}

		//Конструктор
		public Range(double left, double right, bool leftIncluded=false, bool rightIncluded=false)  :this()
		{
			Left = left;
			Right = right;
			this.leftIncluded = leftIncluded;
			this.rightIncluded = rightIncluded;
		}

		//Перевод к строке
		public override string ToString()
		{
			return (leftIncluded ?  "[" : "(") + Left.ToString("N2") + "; " + Right.ToString("N2") + (rightIncluded ? "]": ")");
		}
	}
}
