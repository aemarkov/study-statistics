using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics.Utils
{
	//Это просто Key-Value pair, но с 
	//возможностью менять значения Key и Value.
	//Иначе список не редактируем
	class FreqPair
	{
		public int val { get; set; }      //Интервал
		public int freq { get; set; }      //Значение
		public FreqPair()
		{
			val = 0;
			freq = 0;
		}

		public FreqPair(string val, int freq)
		{
			val = val;
			freq = freq;
		}
	}
}
