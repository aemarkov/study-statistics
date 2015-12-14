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
		static public List<PointD> ReadFile(string filename)
		{
			List<PointD> points = new List<PointD>();

			using (var sr = new StreamReader(filename))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
					points.Add(parse_point(line));
			}

			return points;
		}


		//Парсит строку и получает точку
		static private PointD parse_point(string line)
		{
			var strings = line.Split(';');
			return new PointD(double.Parse(strings[0]), double.Parse(strings[1]));
		}
	}
}
