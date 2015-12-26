using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Regression.Utils
{
	/// <summary>
	/// Загружает список Point2F из файла
	/// </summary>
	static class CsvParser
	{
		/// <summary>
		/// Считывает список из файоа
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		static public List<PointD> ReadSample(string filename)
		{
			List<PointD> points = new List<PointD>();

			try
			{
				using (var sr = new StreamReader(filename))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
						points.Add(parse_point(line));
				}
			}catch(FormatException exp)
			{
				throw new ParseException("В таблице присутствует значение в неправильом формате");
            }

			return points;
		}

		/// <summary>
		/// Чтение корреляционной таблицы
		/// </summary>
		/// <param name="table"></param>
		static public CorrelationTable ReadCorrelationTable(string filename)
		{
			var raw_data = new List<List<int>>();       //Числа из файла
			var x_headers = new List<Range>();
			var y_headers = new List<Range>();

			int width = -1;                             //Ширина таблицы
			double bx = -1, by = -1;

			try
			{

				//Чтение файла
				using (var sr = new StreamReader(filename))
				{
					string line;

					//Читаем первую линию с интервалами
					line = sr.ReadLine();
					if (line == null) throw new ParseException("Файл пуст");
					var strings = separate_line(line);
					x_headers = parse_ranges(strings[1]);

					//Читаем остальные оинии
					while ((line = sr.ReadLine()) != null)
					{
						strings = separate_line(line);
						y_headers.Add(Range.Parse(strings[0]));     //Опеределяем интервал из первого столбца
						var line_data = parse_values(strings[1]);

						//Проврека на равенство длин всех строк
						if (width == -1) width = line_data.Count;
						else if (width != line_data.Count)
							throw new ParseException("Длины строк в таблице не совпадают");

						raw_data.Add(line_data);
					}
				}

			}catch(FormatException exp)
			{
				throw new ParseException("В таблице присутствует значение в неправильом формате");
			}

			//Составление таблицы из данных
			//Определение размера интервала и проверка того, что они все одинаковы
			foreach (var v in x_headers)
				if (!set_or_not_update(ref bx, v.Length)) throw new ParseException("Длины интервалов должны быть одинаковы");
			foreach (var v in y_headers)
				if (!set_or_not_update(ref by, v.Length)) throw new ParseException("Длины интервалов должны быть одинаковы");


			var table = new CorrelationTable(x_headers.Count, y_headers.Count, bx, by);

			//Перенос интервалов
			for (int i = 0; i < x_headers.Count; i++)
				table.SetX(i, x_headers[i]);

			for (int i = 0; i < y_headers.Count; i++)
				table.SetY(i, y_headers[i]);

			//Перенос значений
			for (int x = 0; x < x_headers.Count; x++)
				for (int y = 0; y < y_headers.Count; y++)
					table[x, y] = raw_data[y][x];
			


			return table;
		}

		//Парсит строку и получает точку
		static private PointD parse_point(string line)
		{
			var strings = line.Split(';');
			return new PointD(double.Parse(strings[0]), double.Parse(strings[1]));
		}

		//Разделяет строку на две части - первый элемент и остальные
		private static string[] separate_line(string line)
		{
			var strings = new string[2];
			int sep_index = line.IndexOf(';');
			if (sep_index == -1) throw new ParseException("В таблице отсутствуют необходимые столбцы");

			strings[0] = line.Substring(0, sep_index);
			strings[1] = line.Substring(sep_index + 1);

			return strings;
		}

		//Парсит значения из строки
		private static List<int> parse_values(string line)
		{
			var list = new List<int>();
			var values = line.Split(';');
			foreach (var v in values)
				if(v!="")
					list.Add(int.Parse(v));

			return list;
		}

		//Парсит диапазоны из строки
		private static List<Range> parse_ranges(string line)
		{
			var ranges = new List<Range>();
			var values = line.Split(';');
			foreach (var v in values)
				ranges.Add(Range.Parse(v));

			return ranges;
		}

		private static bool set_or_not_update(ref double val, double new_value)
		{
			if (val == -1) val = new_value;
			else if (val != new_value) return false;
			return true;
		}
	}
}
