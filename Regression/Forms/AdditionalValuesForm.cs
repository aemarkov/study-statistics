using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Regression.Utils;
using TheArtOfDev.HtmlRenderer.WinForms;
using System.IO;

namespace Regression
{
	public partial class AdditionalValuesForm : Form
	{
		HtmlPanel htmlPanel;

		public AdditionalValuesForm(CorrelationCalc calc)
		{
			InitializeComponent();
			htmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();

			var table = calc.Table;
			var gen = new HTMLTableGenerator();
			HTMLTableRow row;

			//Создание шапки
			row = gen.AddRow();
			row.AddCell("Границы и середины интервалов для y", 1, 4);
			row.AddCell("Vi", 1, 4);
			row.AddCell("Границы и середины интервалов для x", table.Width, 1);
			row.AddCell("Nj", 1, 4);
			row.AddCell("NjVj", 1, 4);
			row.AddCell("NjVj^2", 1, 4);

			row = gen.AddRow();
			foreach (var x in table.XHeaders)
				row.AddCell(range_to_string(x), "#B2DFDB");

			row = gen.AddRow();
			//row.AddCell("Ui", table.Width, 1);

			row = gen.AddRow();
			foreach (var x in calc.Ui)
				row.AddCell(x.ToString("N2"));

			
			//Создание таблицы
			for (int y = 0; y<table.Height; y++)
			{
				row = gen.AddRow();
				row.AddCell(range_to_string(table.YHeaders[y]), "#B2DFDB");
				row.AddCell(calc.Vj[y].ToString("N2"));

				//Значения
				for (int x = 0; x < table.Width; x++)
					row.AddCell(table[x, y].ToString("N2"), "#B2DFDB");

				row.AddCell(calc.Nj[y].ToString("N2"));
				row.AddCell((calc.Nj[y]*calc.Vj[y]).ToString("N2"));
				row.AddCell((calc.Nj[y] * calc.Vj[y] * calc.Vj[y]).ToString("N2"));
			}

			//Нижние строки
			//Ni
			row = gen.AddRow();
			row.AddCell("Ni", 2, 1);
			foreach (var x in calc.Ni)
				row.AddCell(x.ToString("N2"));

			row.AddCell("Сумма: "+calc.N.ToString("N2"));
			row.AddCell("Сумма: " + calc.NjVj.ToString("N2"));
			row.AddCell("Сумма: " + calc.NjVj2.ToString("N2"));

			//NiUi
			row = gen.AddRow();
			row.AddCell("NiUi", 2, 1);
			for(int i = 0; i<table.Width; i++)
				row.AddCell((calc.Ni[i]*calc.Ui[i]).ToString("N2"));

			row.AddCell("Сумма: " + calc.NiUi.ToString("N2"));

			//NiUi2
			row = gen.AddRow();
			row.AddCell("NiUi^2", 2, 1);
			for (int i = 0; i < table.Width; i++)
				row.AddCell((calc.Ni[i] * calc.Ui[i]* calc.Ui[i]).ToString("N2"));

			row.AddCell("Сумма: " + calc.NiUi2.ToString("N2"));

			var str = gen.GetHTML();
			using (var sw = new StreamWriter("D:\\index.html"))
			{
				sw.WriteLine(str);
			}

				htmlPanel.Text = str;
			htmlPanel.Dock = DockStyle.Fill;
			Controls.Add(htmlPanel);
			htmlPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
			htmlPanel.Width = this.Width;
			htmlPanel.Height = this.ClientSize.Height - groupBox1.Height - 10;

			txtQu.Text = calc.Qu.ToString("N4");
			txtQv.Text = calc.Qv.ToString("N4");
			txtQuv.Text = calc.Quv.ToString("N4");
		}


		private string range_to_string(Range range)
		{
			return range.ToString() + "<br/>" + range.Middle.ToString("N2");
		}

	}
}
