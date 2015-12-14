using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regression.Utils;

namespace Regression
{
	public partial class Form1 : Form
	{

		/// <summary>
		/// Введенные из файла исходные данные
		/// Набор пар значений СВ
		/// </summary>
		BindingList<PointD> data;


		///////////////////////////////////////////////////////////////////////////////////////

		public Form1()
		{
			InitializeComponent();

			//Настройка списка и биндингов
			data = new BindingList<PointD>();
			data.AllowEdit = true;
			data.AllowNew = true;
			data.AllowRemove = true;

			gridData.DataSource = data;

		}


		//Открытие выборки
		private void menuOpen_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			//dlg.Filter = "*.csv|Таблица CSV";
			if (dlg.ShowDialog() != DialogResult.OK) return;

			var list = CsvParser.ReadFile(dlg.FileName);
			foreach (var x in list)
				data.Add(x);
		}

		//Создание корреляционной таблицы заданного размера
		private void btnCreate_Click(object sender, EventArgs e)
		{

		}

		//Разбитие исходной выборки в корреляционную таблицу
		private void btnSeparate_Click(object sender, EventArgs e)
		{

		}

		//Ввод корреляционной таблицы
		private void btnInput_Click(object sender, EventArgs e)
		{

		}

	}
}
