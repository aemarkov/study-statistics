using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
		CorrelationTable cor_table;


		///////////////////////////////////////////////////////////////////////////////////////

		public Form1()
		{
			InitializeComponent();

			//Настройка списка и биндингов
			data = new BindingList<PointD>();
			data.AllowEdit = false;;
			data.AllowNew = false;
			data.AllowRemove = false;

			gridData.DataSource = data;


			int? a = null;
			int b = a.GetValueOrDefault();
			int c = b;

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
			int n_x = (int)numCols.Value;
			int n_y = (int)numRows.Value;

			cor_table = new CorrelationTable(n_x, n_y);
		}

		//Разбитие исходной выборки в корреляционную таблицу
		private void btnSeparate_Click(object sender, EventArgs e)
		{
			int n_x = (int)numCols.Value;
			int n_y = (int)numRows.Value;

			cor_table = new CorrelationTable(n_x, n_y);
			cor_table.Fill(data.ToList());
			print_correlation_table(cor_table);
		}

		//Ввод корреляционной таблицы
		private void btnInput_Click(object sender, EventArgs e)
		{

		}

		/////////////////////////////////////////////////////////////////////////////

		private void print_correlation_table(CorrelationTable table)
		{
			gridCorrelation.Rows.Clear();
			gridCorrelation.Columns.Clear();

			//Добавляем колонки
			var templ_row = new DataGridViewRow();
			templ_row.Cells.Add(new DataGridViewTextBoxCell());
			gridCorrelation.Columns.Add("YHeaders","");
			for (int i = 0; i<table.Width; i++)
			{
				templ_row.Cells.Add(new DataGridViewTextBoxCell());
				gridCorrelation.Columns.Add("c" + i, table.XHeaders[i].ToString());
            }
			gridCorrelation.RowTemplate = templ_row;

			//Добавляем значения
			for(int y=0; y<table.Height; y++)
			{
				gridCorrelation.Rows.Add();
				gridCorrelation[0, y].Value = table.YHeaders[y].ToString();

				for(int x=0; x<table.Width; x++)
				{
					gridCorrelation[x + 1, y].Value = table[x, y].ToString();
				}
			}
		}
	}
}
