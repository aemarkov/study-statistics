namespace StatisticDistribution
{
	partial class PirsonTableForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gridPirson = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridPirson)).BeginInit();
			this.SuspendLayout();
			// 
			// gridPirson
			// 
			this.gridPirson.AllowUserToAddRows = false;
			this.gridPirson.AllowUserToDeleteRows = false;
			this.gridPirson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridPirson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPirson.Location = new System.Drawing.Point(12, 12);
			this.gridPirson.Name = "gridPirson";
			this.gridPirson.ReadOnly = true;
			this.gridPirson.RowHeadersVisible = false;
			this.gridPirson.Size = new System.Drawing.Size(556, 445);
			this.gridPirson.TabIndex = 0;
			// 
			// PirsonTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(580, 469);
			this.Controls.Add(this.gridPirson);
			this.Name = "PirsonTableForm";
			this.Text = "Критические точки критерия Пирсона";
			this.Load += new System.EventHandler(this.PirsonTableForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridPirson)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridPirson;
	}
}