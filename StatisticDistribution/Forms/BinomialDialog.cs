using System;
using System.Windows.Forms;

namespace StatisticDistribution
{
	/// <summary>
	/// Диагологовое окно, которое запрашивает число опытов в одном испытании
	/// </summary>
	public partial class BinomialDialog : Form
	{

		/// <summary>
		/// Чило опытов в одном испытании
		/// </summary>
		public int NumberOfExperiments { get; private set; }
		

		public BinomialDialog()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			int num;
			if (Int32.TryParse(txtNumExperiments.Text, out num))
			{
				NumberOfExperiments = num;
				DialogResult = DialogResult.OK;
				this.Dispose();
			}
			else if (MessageBox.Show("Введено не число", "Проерка гипотезы о виде закона распределения", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
				this.Dispose();
				
		}


		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Dispose();
		}
	}
}
