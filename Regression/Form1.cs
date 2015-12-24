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
		CorrelationCalc cor_calc;


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
			cor_calc = new CorrelationCalc(cor_table);
			print_correlation_table(cor_calc);
		}

		//Ввод корреляционной таблицы
		private void btnInput_Click(object sender, EventArgs e)
		{

		}

		/////////////////////////////////////////////////////////////////////////////

		private void print_correlation_table(CorrelationCalc calc)
		{
			gridCorrelation.Rows.Clear();
			gridCorrelation.Columns.Clear();
			var table = calc.Table;

			//---------------- Добавляем колонки ---------------------------------------
			var templ_row = new DataGridViewRow();

			//Левый столбец - гранцы интервалов по У
			templ_row.Cells.Add(new DataGridViewTextBoxCell());
			gridCorrelation.Columns.Add("YHeaders","");

			//Vi
			templ_row.Cells.Add(new DataGridViewTextBoxCell());
			gridCorrelation.Columns.Add("Vj","Vj");

			//Интервалы по X
			for (int i = 0; i < table.Width; i++)
			{
				templ_row.Cells.Add(new DataGridViewTextBoxCell());
				gridCorrelation.Columns.Add("c" + i, table.XHeaders[i].ToString());
			}

			//Nj
			templ_row.Cells.Add(new DataGridViewTextBoxCell());
			gridCorrelation.Columns.Add("Nj", "Nj");

			//NjVj
			templ_row.Cells.Add(new DataGridViewTextBoxCell());
			gridCorrelation.Columns.Add("NjVj", "NjVj");

			//NjVj2
			templ_row.Cells.Add(new DataGridViewTextBoxCell());
			gridCorrelation.Columns.Add("NjVj2", "NjVj2");

			gridCorrelation.RowTemplate = templ_row;


			//---------------- Добавляем строки ----------------------------------------

			//Строка с одной надписью Ui
			gridCorrelation.Rows.Add();
			gridCorrelation[2, 0].Value = "Ui";

			//Список Vi
			gridCorrelation.Rows.Add();
			for (int i = 0; i < table.Width; i++)
				gridCorrelation[i + 2, 1].Value = calc.Ui[i];

			//Основные строки таблицы
			for(int y=0; y<table.Height; y++)
			{
				gridCorrelation.Rows.Add();

				//Ячейка интервала
				gridCorrelation[0, y + 2].Value = table.YHeaders[y].ToString();

				//Ячейка Vj
				gridCorrelation[1, y + 2].Value = calc.Vj[y];

				//Ячейки корреляционной таблицы
				for(int x=0; x<table.Width;x++)
					gridCorrelation[x + 2, y + 2].Value = table[x, y];

				//Ячейка Nj
				gridCorrelation[table.Width + 2, y + 2].Value = calc.Nj[y].ToString();
				//NjVj
				gridCorrelation[table.Width + 3, y + 2].Value = (calc.Nj[y] * calc.Vj[y]).ToString();
				//NjVj2
				gridCorrelation[table.Width + 4, y + 2].Value = (calc.Nj[y] * calc.Vj[y]* calc.Vj[y]).ToString();
			}

			//Ni
			gridCorrelation.Rows.Add();
			gridCorrelation[0,table.Height + 2].Value = "Ni";
			for (int i = 0; i < table.Width; i++)
				gridCorrelation[i + 2, table.Height + 2].Value = calc.Ni[i];

			gridCorrelation[table.Width + 2, table.Height + 2].Value = "Сумм: " + calc.NijUiVj.ToString();
			gridCorrelation[table.Width + 3, table.Height + 2].Value = "Сумм: " + calc.NjVj.ToString();
			gridCorrelation[table.Width + 4, table.Height + 2].Value = "Сумм: " + calc.NjVj2.ToString();

			//NiUi
			gridCorrelation.Rows.Add();
			gridCorrelation[0, table.Height + 3].Value = "NiUi";
			for (int i = 0; i < table.Width; i++)
				gridCorrelation[i + 2, table.Height + 3].Value = calc.Ni[i] * calc.Ui[i];
			gridCorrelation[table.Width + 2, table.Height + 3].Value = "Сумм: " + calc.NiUi;

			//NiUi2
			gridCorrelation.Rows.Add();
			gridCorrelation[0, table.Height + 4].Value = "NiUi2";
			for (int i = 0; i < table.Width; i++)
				gridCorrelation[i + 2, table.Height + 4].Value = calc.Ni[i] * calc.Ui[i] * calc.Ui[i];
			gridCorrelation[table.Width + 2, table.Height + 4].Value = "Сумм: " + calc.NiUi2;

			////////////
			txtX.Text = calc.X.ToString("N4");
			txtY.Text = calc.Y.ToString("N4");
			txtSx.Text = calc.Sx.ToString("N4");
			txtSy.Text = calc.Sy.ToString("N4");
			txtR.Text = calc.R.ToString("N4");
			txtB1.Text = calc.B1.ToString("N4");
			txtB1_.Text = calc.B1_.ToString("N4");
		}

		//Построение диаграммы рассеивания
		private void btnDiagr_Click(object sender, EventArgs e)
		{
			var frm = new DiagramForm(data.ToList(), cor_calc);
			frm.Show(); 
		}
	}
}


/*
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

	*/