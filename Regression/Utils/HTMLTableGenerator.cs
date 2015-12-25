using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regression.Utils
{
	/// <summary>
	/// Генерирует HTML-таблицу
	/// </summary>
	public class HTMLTableGenerator
	{
		/// <summary>
		/// Список строк
		/// </summary>
		public List<HTMLTableRow> Rows { get; set; }


		private static string table_css= @"style='width: 100%; border: 2px solid #000; border-collapse: collapse;'";

		/// <summary>
		/// Создает новый объект генератора таблиц
		/// </summary>
		public HTMLTableGenerator()
		{
			Rows = new List<HTMLTableRow>();
        }
		
		/// <summary>
		/// Добавляет строку в таблицу
		/// </summary>
		/// <returns>Добавленная строка</returns>
		public HTMLTableRow AddRow()
		{
			var row = new HTMLTableRow();
			Rows.Add(row);
			return row;
		}

		/// <summary>
		/// Возвращает код таблицы
		/// </summary>
		/// <returns>Код таблицы строкой </returns>
		public string GetHTML()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("<table "+table_css+">");

			foreach (var r in Rows)
				sb.Append(r.GetHTML());

			sb.Append("</table>");
			return sb.ToString();
		}
		
	}

	/// <summary>
	/// Строка HTML-таблицы
	/// </summary>
	public class HTMLTableRow
	{
		StringBuilder sb;
		private static string td_css = @"border: 2px solid #000; text-align: center;";

		public HTMLTableRow()
		{
			sb = new StringBuilder();
			sb.Append("<tr>");
		}

		/// <summary>
		/// Добавляет ячейку
		/// </summary>
		public void AddCell(string text, string color = "#FFF")
		{
			sb.Append("<td " + make_style(td_css, color) + ">");
			sb.Append(text);
			sb.Append("</td>");
		}

		/// <summary>
		/// Добавляет ячеку, которая занимает несколько ячеек
		/// </summary>
		/// <param name="text">Содержимое</param>
		/// <param name="colspan">Объединение по горизонтали</param>
		/// <param name="rowspan">Объединение по вертикали</param>
		public void AddCell(string text, int colspan, int rowspan, string color="#FFF")
		{
			sb.Append(String.Format("<td "+ make_style(td_css,color) + " colspan=\"{0}\" rowspan=\"{1}\">", colspan, rowspan));
			sb.Append(text);
			sb.Append("</td>");
		}

		private string make_style(string style, string color)
		{
			return @"style='" + style + "background-color:"+ color+";'";
		}

		/// <summary>
		/// Возвращает код
		/// </summary>
		/// <returns></returns>
		public string GetHTML()
		{
			sb.Append("</tr>");
			return sb.ToString();
		}
	}
}
