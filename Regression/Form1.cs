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


		//СОСТОЯНИЯ ИНТЕРФЕЙСА
		bool sample_exists;				//Открыта выборка
		bool cortable_empty_exists;		//Создана пустая таблица
		bool cortable_exists;			//Создана таблица (из выбокри, вручную, из файла)
		bool calc_exists;				//Значения расчитаны

		///////////////////////////////////////////////////////////////////////////////////////
		/// ИНИЦИАЛИЗАЦИЯ
		///////////////////////////////////////////////////////////////////////////////////////

		public Form1()
		{
			InitializeComponent();

			reset_all();


			gridCorrelationInput.CellValidating += GridCorrelationInput_CellValidating;
			gridCorrelationInput.CellEndEdit += GridCorrelationInput_CellEndEdit;

			//Сброс GUI
			//gui_flags_set(false);
		}



		#region CORRELATION_CREATE
		///////////////////////////////////////////////////////////////////////////////////////
		/// СОЗДАНИЕ, ОТКРЫТИЕ, ВВОД КОРРЕЛЯЦИОННОЙ ТАБЛИЦЫ
		///////////////////////////////////////////////////////////////////////////////////////


		//Очищает все таблицы и прочее
		private void reset_all()
		{
			gridCorrelationInput.Rows.Clear();
			gridCorrelationInput.Columns.Clear();

			data = new BindingList<PointD>();
			data.AllowEdit = false; ;
			data.AllowNew = false;
			data.AllowRemove = false;
			gridData.DataSource = data;

			cor_table = null;
			cor_calc = null;

			txtX.Text = "";
			txtY.Text = "";
			txtSx.Text = "";
			txtSy.Text = "";
			txtR.Text = "";

			gui_flags_set(false);
			setup_gui();
		}

		//Открытие выборки
		private void menuOpen_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			//dlg.Filter = "*.csv|Таблица CSV";
			if (dlg.ShowDialog() != DialogResult.OK) return;

			reset_all();

			var list = CsvParser.ReadSample(dlg.FileName);
			foreach (var x in list)
				data.Add(x);

			sample_exists = true;
			setup_gui();
		}

		//Открытие корреляционной таблицы из файла
		private void menuOpenCorrelationTable_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			//dlg.Filter = "*.csv|Таблица CSV";
			if (dlg.ShowDialog() != DialogResult.OK) return;

			reset_all();

			cor_table = CsvParser.ReadCorrelationTable(dlg.FileName);
			make_creation_table(cor_table);

			cortable_exists = true;
			setup_gui();
		}


		//Создание корреляционной таблицы заданного размера
		private void btnCreate_Click(object sender, EventArgs e)
		{
			if ((cortable_exists || cortable_empty_exists) && (MessageBox.Show("Создать новую таблицу? Это удалит текущие данные.", "Создание корреляционной таблицы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)) return;

			reset_all();

			int n_x = (int)numCreateCols.Value;
			int n_y = (int)numCreateRows.Value;

			cor_table = new CorrelationTable(n_x, n_y);
			make_creation_table(cor_table);

			cortable_empty_exists = true;
			setup_gui();
		}

		//Ввод корреляционной таблицы
		//Создание корреляционной таблицы из введенной пользователем
		private void btnInput_Click(object sender, EventArgs e)
		{
			try
			{
				//Заполняем интервалы
				for (int i = 1; i < gridCorrelationInput.Columns.Count; i++)
					cor_table.SetX(i-1, Range.Parse((string)gridCorrelationInput[i, 0].Value));
				

				for (int i = 1; i < gridCorrelationInput.Rows.Count; i++)
					cor_table.SetY(i-1, Range.Parse((string)gridCorrelationInput[0, i].Value));

				//Заполняем таблицу
				for (int x = 1; x < gridCorrelationInput.Columns.Count; x++)
					for (int y = 1; y < gridCorrelationInput.Rows.Count; y++)
						cor_table[x-1, y-1] = int.Parse((string)gridCorrelationInput[x, y].Value);


			} catch (FormatException exp)
			{
				MessageBox.Show("Одно или несколько значений в таблице имели неверный формат", "Создание корреляционной таблицы", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			cortable_exists = true;
			setup_gui();
		}

		//Разбитие исходной выборки в корреляционную таблицу
		private void btnSeparate_Click(object sender, EventArgs e)
		{
			int n_x = (int)numSepCols.Value;
			int n_y = (int)numSepRows.Value;

			cor_table = new CorrelationTable(n_x, n_y);
			cor_table.Fill(data.ToList());
			make_creation_table(cor_table);

			cortable_exists = true;
			setup_gui();
		}

		#endregion

		#region ACTIONS

		///////////////////////////////////////////////////////////////////////////////////////
		/// ДЕЙСТВИЯ С ТАБЛИЦОЙ
		///////////////////////////////////////////////////////////////////////////////////////

		//Расчет числовых характеристик  и вывод
		private void menuCalc_Click(object sender, EventArgs e)
		{
			cor_calc = new CorrelationCalc(cor_table);
			calc_exists = true;
			setup_gui();

			txtX.Text = cor_calc.X.ToString("N4");
			txtY.Text = cor_calc.Y.ToString("N4");
			txtSx.Text = cor_calc.Sx.ToString("N4");
			txtSy.Text = cor_calc.Sy.ToString("N4");
			txtR.Text = cor_calc.R.ToString("N4");

		}

		//Построение диаграммы рассеивания
		private void menuDrawDiagram_Click(object sender, EventArgs e)
		{
			var frm = new DiagramForm(data.ToList(), cor_calc);
			frm.Show();
		}

		#endregion

		///////////////////////////////////////////////////////////////////////////////////////
		/// УПРАВЛЕНИЕ СОСТОЯНИЕМ ИНТЕРФЕЙСА
		///////////////////////////////////////////////////////////////////////////////////////

		//Настраивает активность элементов в зависимости от флагов
		private void setup_gui()
		{
			btnSeparate.Enabled = sample_exists;
			btnInput.Enabled = cortable_empty_exists | cortable_exists;
			menuCalc.Enabled = cortable_exists;
			menuDrawDiagram.Enabled = calc_exists && sample_exists;
		}

		//Задает все флаги
		private	void gui_flags_set(bool val)
		{
			sample_exists = val;
			cortable_empty_exists = val;
			cortable_exists = val;
			calc_exists = val;
		}
		#region TABLE_GRAPHICS

		///////////////////////////////////////////////////////////////////////////////////////
		/// ТАБЛИЧНЫЙ ГРАФОН
		///////////////////////////////////////////////////////////////////////////////////////

		//Создание таблицы для ручного ввода корреляционной таблицы
		//Или отображение уже готовй таблицы
		//MVC плачет кровавыми слезами
		private void make_creation_table(CorrelationTable table)
		{
			gridCorrelationInput.Rows.Clear();
			gridCorrelationInput.Columns.Clear();

			//int cell_size = 40;
			var templ_row = new DataGridViewRow();
			var gray_style = new DataGridViewCellStyle();
			var normal_style = new DataGridViewCellStyle();

			gray_style.BackColor = Color.LightGray;
			gray_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			normal_style.Alignment = DataGridViewContentAlignment.MiddleCenter;

			//Создаем столбцы
			//Левый столбец - гранцы интервалов по У
			templ_row.Cells.Add(new DataGridViewTextBoxCell());
			gridCorrelationInput.Columns.Add("WTF".ToString(), "");

			//Остальные столбцы
			for (int i = 0; i < table.Width; i++)
			{
				templ_row.Cells.Add(new DataGridViewTextBoxCell());
				gridCorrelationInput.Columns.Add("C" + i.ToString(), "");
				//gridCorrelationInput.Columns[i + 1].Width = cell_size;
			}

			//Заполняем таблицу

			//Первая строка
			gridCorrelationInput.Rows.Add();
			foreach (DataGridViewTextBoxCell c in gridCorrelationInput.Rows[0].Cells)
				c.Style = gray_style;
			gridCorrelationInput[0, 0].Value = "Y\\X";
			gridCorrelationInput[0, 0].ReadOnly = true;

			for(int x = 1; x<table.Width; x++)
				gridCorrelationInput[x, 0].Value = table.XHeaders[x-1];

			//Остальные строки
			for (int y = 0; y < table.Height; y++)
			{
				gridCorrelationInput.Rows.Add();
				//gridCorrelationInput.Rows[y + 1].Height = cell_size;

				gridCorrelationInput[0, y + 1].Value = table.YHeaders[y];
				gridCorrelationInput[0, y + 1].Style = gray_style;

				for(int x = 0; x<table.Width; x++)
				{
					gridCorrelationInput[x+1, y+1].Style = normal_style;
					gridCorrelationInput[x+1, y+1].Value = table[x, y];
				}
			}

			//Переход на вкладку с таблией

		}

		// Валидация

		private void GridCorrelationInput_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if ((string)e.FormattedValue == "") return;
			if ((e.RowIndex == 0) && (e.ColumnIndex == 0)) return; 
			if((e.RowIndex==0)||(e.ColumnIndex==0))
			{
				//Валидация интервала
				Range range;
				if (!Range.TryParse((string)e.FormattedValue, out range)) e.Cancel = true;
			}
			else
			{
				//Валидация строки
				int v;
                if (!int.TryParse((string)e.FormattedValue, out v)) e.Cancel = true;
			}
		}

		private void GridCorrelationInput_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			gridCorrelationInput.Rows[e.RowIndex].ErrorText = String.Empty;
		}

		#endregion
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

/*private void print_correlation_table(CorrelationCalc calc)
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
	}*/
