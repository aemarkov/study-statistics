using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regression.Utils
{
	/// <summary>
	/// Ощибка при парсинге CSV
	/// </summary>
	class ParseException:Exception
	{
		public ParseException() : base("Ошибка при чтении файла. Возможно, файл имеет неверный формат") { }

		public ParseException(string message) : base(message +". Проверьте правильность составления файла") { }
	}
}
