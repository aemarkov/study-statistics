using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Statistics.DistributionCheck;

namespace StatisticDistribution
{
	public partial class PirsonTableForm : Form
	{
		public PirsonTableForm()
		{
			InitializeComponent();
		}

		private void PirsonTableForm_Load(object sender, EventArgs e)
		{
			var table = CriticalPirsonCriterion.GetTable();
			var sign_level = CriticalPirsonCriterion.GetSignificanceLevel();
			
			//Отображаем таблицу
			var templ_row = new DataGridViewRow();
			for (int i = 0; i < sign_level.Count + 1; i++)
			{
				templ_row.Cells.Add(new DataGridViewTextBoxCell());
				if (i == 0)
					gridPirson.Columns.Add("c0", " ");
				else
					gridPirson.Columns.Add("c" + i, sign_level[i - 1].ToString());
             }

			gridPirson.RowTemplate = templ_row;

			int i_ = 1;
			foreach(var row_ in table)
			{
				var row_index = gridPirson.Rows.Add();
				var row = gridPirson.Rows[row_index];
				row.Cells["c0"].Value=i_;

				int j = 1;
				foreach (var alpha in row_.Keys)
				{
					row.Cells["c" + j].Value = row_[alpha];
					j++;
				}

				i_++;
			}
		}
	}
}
