using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Statistics.Utils;
using System.ComponentModel;

namespace Statistics.Distribution
{
	/// <summary>
	/// Этот класс хранит списки рядов распределения
	/// - статистический ряд частот\относительных частот
	/// - интервальный ряд
	/// - группированный ряд
	/// и обеспечивает их отложенное вычисление
	/// </summary>
	public class Distribution
	{
		
		#region ROWS
		//////////////////////////////////// РЯДЫ /////////////////////////////////////////////

		int data_size;
		double interval = 1;

		Dictionary<double, double> stat_freq;                    //Стат. ряд частот
		Dictionary<double, double> stat_rel_freq;                //Стат. ряд относительных частот
		Dictionary<Range, double> interval_freq;                 //Интервальный ряд частот
		Dictionary<Range, double> interval_rel_freq;             //Интервальный ряд относительных частот
		Dictionary<double, double> group_freq;                   //Группированны ряд частот
		Dictionary<double, double> group_rel_freq;               //Группированный ряд относительных частот

		#endregion

		/////////////////////////// ВСПОМОГАТЕЛЬНЫЕ ДАННЫЕ ////////////////////////////////////
		BindingList<IntervalPair> string_intervals;     //Сырые данные от ввода интервального ряда частот


		#region CONSTRUCTORS
		////////////////////////////////// КОНСТРУКТОРЫ ///////////////////////////////////////

		/// <summary>
		/// Конструктор по-умолчанию, обнуляет данные
		/// </summary>
		public Distribution()
		{
			stat_freq = null;
			stat_rel_freq = null;
			interval_freq = null;
			interval_rel_freq = null;
			group_freq = null;
			group_rel_freq = null;
		}

		//Заполняет статистический ряд частот
		public Distribution(List<double> data) : this()
		{
			data_size = data.Count;
			stat_freq = new Dictionary<double, double>();

			foreach (var d in data)
				if (stat_freq.ContainsKey(d))
					stat_freq[d]++;
				else
					stat_freq.Add(d, 1);
		}

		//Заполняет интервальный ряд частот
		public Distribution(Dictionary<Range, double> interval_freq, double interval) : this()
		{
			this.interval = interval;
			this.interval_freq = interval_freq;
			//this.string_intervals = stringIntervals;
		}

		#endregion

		#region CALCULATIONS
		//////////////////////////// РАСЧЕТ РЯДОВ ///////////////////////////////////////////

		//Разбивает ряд
		public Dictionary<Range, double> Separate(double interval)
		{
			this.interval = interval;
			interval_freq = null;
			interval_rel_freq = null;
			return IntervalFreq;
		}


		//Стат. ряд частот
		public Dictionary<double, double> StatFreq
		{
			get
			{
				return stat_freq;
			}
		}

		//Стат. ряд относительных частот
		public Dictionary<double, double> StatRelFreq
		{
			get
			{
				if (stat_rel_freq == null)
				{
					stat_rel_freq = new Dictionary<double, double>();
					foreach (var x in stat_freq) stat_rel_freq.Add(x.Key, x.Value / data_size);
				}
				return stat_rel_freq;
			}
		}

		//Интервальный ряд частот
		public Dictionary<Range, double> IntervalFreq
		{
			get
			{
				if(interval_freq== null)
				{
					interval_freq = new Dictionary<Range, double>();

					var xi = StatFreq.GetEnumerator();  //Перечислитель для обхода словаря
					double intervalStart;               //Начало интервала
					double ni;                          //Суммарная частота на интервале
					bool isNotEnd = false;              //Пришли ли к концу списка
					bool isAdded = false;               //Добавлен ли текущий элемент

					//[x0; x1]; (x1; x2]; (x2; x3]; ... (xn-1; xn];

					//Добавляем первый интервал (обе границы включаются)
					intervalStart = StatFreq.First().Key;
					ni = 0;
					do
					{
						ni += xi.Current.Value;
					} while ((isNotEnd = xi.MoveNext()) && (xi.Current.Key - intervalStart <= interval));

					interval_freq.Add(new Range(intervalStart, intervalStart + interval, true, true), ni);

					//Добавляем остальные интервалы (левая - не включается, правая - включается)
					//Нужна проверка, что остались элементы
					if (isNotEnd)
					{
						//В качестве начала интервала берем конец первого интервала
						intervalStart += interval;
						ni = 0;
						do
						{
							//Накапливаем сумму частот
							if (xi.Current.Key - intervalStart <= interval)
							{
								ni += xi.Current.Value;
								isAdded = false;
							}
							else
							{
								isAdded = true;
								//Добавляем интервал
								interval_freq.Add(new Range(intervalStart, intervalStart + interval, false, true), ni);
								intervalStart += interval;
								ni = xi.Current.Value;
							}
						} while (xi.MoveNext());
					}

					if (!isAdded)
					{
						//Если список завершился раньше, чем кончился интервал
						//ni уже накоплен, надо лишь установить правую границу
						interval_freq.Add(new Range(intervalStart, intervalStart + interval, false, true), ni);
					}
				}
				return interval_freq;
			}
		}

		//Интервальный ряд относительных частот
		public Dictionary<Range, double> IntervalRelFreq
		{
			get
			{
				if(interval_rel_freq==null)
				{
					interval_rel_freq = new Dictionary<Range, double>();
					foreach (var x in IntervalFreq) interval_rel_freq.Add(x.Key, x.Value / data_size);
				}
				return interval_rel_freq;
			}
		}

		//Группированны ряд частот
		public Dictionary<double, double> GroupFreq
		{
			get
			{
				if(group_freq==null)
				{
					group_freq = new Dictionary<double, double>();
					foreach (var x in IntervalFreq) group_freq.Add(x.Key.Middle, x.Value);
				}
				return group_freq;
			}
		}

		//Группированный ряд относительных частот
		public Dictionary<double, double> GroupRelFreq
		{
			get
			{
				if(group_rel_freq==null)
				{
					group_rel_freq = new Dictionary<double, double>();
					foreach (var x in GroupFreq) group_rel_freq.Add(x.Key, x.Value / data_size);
				}
				return group_rel_freq;
			}
		}

		//Строит интервальный ряд по ряду, введеному пользователем в виджет
		/*void calc_interval(BindingList<IntervalPair> stringIntervals, double interval)
		{
			var xi = stat_freq.GetEnumerator();  //Перечислитель для обхода словаря
			double intervalStart;                //Начало интервала
			double ni;                           //Суммарная частота на интервале
			bool isNotEnd = false;               //Пришли ли к концу списка
			bool isAdded = false;                //Добавлен ли текущий элемент

			

			//[x0; x1]; (x1; x2]; (x2; x3]; ... (xn-1; xn];

			//Добавляем первый интервал (обе границы включаются)
			intervalStart = stat_freq.First().Key;
			ni = 0;
			do
			{
				ni += xi.Current.Value;
			} while ((isNotEnd = xi.MoveNext()) && (xi.Current.Key - intervalStart <= interval));

			interval_freq.Add(new Range(intervalStart, intervalStart + interval, true, true), ni);

			//Добавляем остальные интервалы (левая - не включается, правая - включается)
			//Нужна проверка, что остались элементы
			if (isNotEnd)
			{
				//В качестве начала интервала берем конец первого интервала
				intervalStart += interval;
				ni = 0;
				do
				{
					//Накапливаем сумму частот
					if (xi.Current.Key - intervalStart <= interval)
					{
						ni += xi.Current.Value;
						isAdded = false;
					}
					else
					{
						isAdded = true;
						//Добавляем интервал
						interval_freq.Add(new Range(intervalStart, intervalStart + interval, false, true), ni);
						intervalStart += interval;
						ni = xi.Current.Value;
					}
				} while (xi.MoveNext());
			}

			if (!isAdded)
			{
				//Если список завершился раньше, чем кончился интервал
				//ni уже накоплен, надо лишь установить правую границу
				interval_freq.Add(new Range(intervalStart, intervalStart + interval, false, true), ni);
			}
		}
		void calc_rel_interval() { }
		void calc_group() { }*/


		#endregion
	}
}
