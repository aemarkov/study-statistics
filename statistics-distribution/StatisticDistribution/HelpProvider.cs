using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StatisticDistribution.Properties;
using System.IO;
using System.Resources;
using System.Diagnostics;

namespace StatisticDistribution
{
	/// <summary>
	/// Управляет показом спраки
	/// Перед тем, как показать справку, ее надо скопировать из ресурсов куда-то
	/// </summary>
	static class HelpProvider
	{
		/// <summary>
		/// Показать справку
		/// </summary>
		public static void ShowHelp()
		{
			if (!is_help_exists())
				extract_help();

			Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe", get_help_filename());
		}

		private static string get_help_folder()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StatisticDistribution";
        }

		private static string get_help_filename()
		{
			return get_help_folder()+"\\Help.mht";
		}

		//Проверка: существует ли распакованный файл справки
		private static bool is_help_exists()
		{
			return File.Exists(get_help_filename());
		}

		//Извлаекает справку из ресурсов
		private static void extract_help()
		{
			//Проверяет наличие папрки
			if(!Directory.Exists(get_help_folder()))
			{
				Directory.CreateDirectory(get_help_folder());
			}

			//Копирует файл из ресурсов
			File.WriteAllBytes(get_help_filename(), Resources.Help);
		} 
	}
}
