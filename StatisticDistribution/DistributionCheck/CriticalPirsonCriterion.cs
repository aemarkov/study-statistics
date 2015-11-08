using System;
using System.Collections.Generic;
using System.IO;
using StatisticDistribution.Properties;

namespace Statistics.DistributionCheck
{
	/// <summary>
	/// Возвращает критическое значение
	/// критерия Пирсона
	/// </summary>
	class CriticalPirsonCriterion
	{
		#region SINGLETON
		//////////////////////// СИНГЛТОН ///////////////////////////////////////////
		private static volatile CriticalPirsonCriterion instance;
		private static object sync_root = new object();
		private static readonly string filename = "PirsonCritical.csv";

		private List<Dictionary<double, double>> table;         //Таблица критерия писрона
		private List<double> significance_level;		        //Уровнь значимости

		//Загружает таблицу критических значений
		private CriticalPirsonCriterion()
		{

			try
			{
				using (var sr = new StringReader(Resources.PirsonCritical))
				{
					int k = 1;          //Степень свободы
					string line;        //Текущая строка

					table = new List<Dictionary<double, double>>();

					//Парсим первую строку с уровнями значимости
					line = sr.ReadLine();
					significance_level = get_significance_levle(line);

					//Читаем оставшиеся строки и заполняем таблицу
					while ((line = sr.ReadLine()) != null)
						table.Add(get_line_values(line, significance_level));
				}
			}
			catch(FormatException exp)
			{
				throw new Exception("ОШИБКА ФАЙЛА КРИТИЧЕСКИХ ТОЧЕК: значение в файле не является числом");
			}
			catch(IOException exp)
			{
				throw new Exception("ОШИБКА ФАЙЛА КРИТИЧЕСКИХ ТОЧЕК: не удается открыть файл");
			}
			catch(Exception exp)
			{
				throw exp;
			}
		}

		//Парсит строку и вытаскивает уровни значимости
		private List<double> get_significance_levle(string line)
		{
			string[] strings = line.Split(';');
			var values = new List<double>();
			foreach (var sValue in strings)
				values.Add(double.Parse(sValue));

			return values;
		}

		//Парсит строку значений и создает словарь
		//Полностью пересекается с предыдущем кодом,
		//но сначала генерить лист, а потом проходить по нему и делать
		//словарь - нехорошо
		private Dictionary<double, double> get_line_values(string line, List<double> sign_level)
		{
			string[] strings = line.Split(';');
			var values = new Dictionary<double, double>();

			if (sign_level.Count != strings.Length)
				throw new Exception("ОШИБКА ФАЙЛА КРИТИЧЕСКИХ ТОЧЕК: число критических точек отличается от числа уровней значимости");

			for (int i = 0; i < strings.Length; i++)
				values.Add(sign_level[i], Double.Parse(strings[i]));

			return values;
		}

		/// <summary>
		/// Возвращает критическое значение критерия Пирсона
		/// </summary>
		/// <param name="trustProbability">Доверительная вероятность</param>
		/// <param name="degreesOfFreedom">Число степеней свободы</param>
		/// <returns></returns>
		private static CriticalPirsonCriterion Instance
		{
			get
			{
				if (instance == null)
				{
					lock (sync_root)
					{
						if (instance == null)
							instance = new CriticalPirsonCriterion();
					}
				}

				return instance;
			}
		}
		#endregion

		#region PUBLIC_INTERFACE
		///////////////////////// ИНТЕРФЕЙС ///////////////////////////////////

		//Ищет по таблице критическое значение
		public static double GetCriticalValue(double trustProbability, int degreesOfFreedom)
		{
			return Instance.get_critical_value(trustProbability, degreesOfFreedom);
		}

		//Возвращает список доверительных вероятностей
		public static List<double> GetSignificanceLevel()
		{
			return Instance.get_significanceLevel();
		}

		public static List<Dictionary<double, double>> GetTable()
		{
			return Instance.get_table();
		}

		#endregion

		/////////////////////// ПОИСК ЗНАЧЕНИЯ //////////////////////////////////////

		private double get_critical_value(double trustProbability, int degreesOfFreedom)
		{
			return table[degreesOfFreedom-1][trustProbability];
		}

		private List<double> get_significanceLevel()
		{
			return significance_level;
		}
		
		private List<Dictionary<double, double>> get_table()
		{
			return table;
		}
    }
}
