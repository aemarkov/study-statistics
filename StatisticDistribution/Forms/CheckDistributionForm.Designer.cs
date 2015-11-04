namespace StatisticDistribution
{
	partial class CheckDistributionForm
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
			this.components = new System.ComponentModel.Container();
			this.graphEmp = new ZedGraph.ZedGraphControl();
			this.graphTheor = new ZedGraph.ZedGraphControl();
			this.lblDistrType = new System.Windows.Forms.Label();
			this.rbManual = new System.Windows.Forms.RadioButton();
			this.rbAuto = new System.Windows.Forms.RadioButton();
			this.txtPirsonVis = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCorrect = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbAlpha = new System.Windows.Forms.ComboBox();
			this.txtDegreesOfFreedom = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelResult = new System.Windows.Forms.Label();
			this.txtPirsonCrit = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gridCalcTable = new System.Windows.Forms.DataGridView();
			this.pboxFunction = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gridPointValues = new System.Windows.Forms.DataGridView();
			this.ParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Formula = new System.Windows.Forms.DataGridViewImageColumn();
			this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sums = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCalcTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pboxFunction)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridPointValues)).BeginInit();
			this.SuspendLayout();
			// 
			// graphEmp
			// 
			this.graphEmp.Location = new System.Drawing.Point(12, 11);
			this.graphEmp.Name = "graphEmp";
			this.graphEmp.ScrollGrace = 0D;
			this.graphEmp.ScrollMaxX = 0D;
			this.graphEmp.ScrollMaxY = 0D;
			this.graphEmp.ScrollMaxY2 = 0D;
			this.graphEmp.ScrollMinX = 0D;
			this.graphEmp.ScrollMinY = 0D;
			this.graphEmp.ScrollMinY2 = 0D;
			this.graphEmp.Size = new System.Drawing.Size(350, 300);
			this.graphEmp.TabIndex = 0;
			this.graphEmp.UseExtendedPrintDialog = true;
			// 
			// graphTheor
			// 
			this.graphTheor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.graphTheor.Location = new System.Drawing.Point(12, 317);
			this.graphTheor.Name = "graphTheor";
			this.graphTheor.ScrollGrace = 0D;
			this.graphTheor.ScrollMaxX = 0D;
			this.graphTheor.ScrollMaxY = 0D;
			this.graphTheor.ScrollMaxY2 = 0D;
			this.graphTheor.ScrollMinX = 0D;
			this.graphTheor.ScrollMinY = 0D;
			this.graphTheor.ScrollMinY2 = 0D;
			this.graphTheor.Size = new System.Drawing.Size(350, 300);
			this.graphTheor.TabIndex = 1;
			this.graphTheor.UseExtendedPrintDialog = true;
			// 
			// lblDistrType
			// 
			this.lblDistrType.AutoSize = true;
			this.lblDistrType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDistrType.Location = new System.Drawing.Point(379, 11);
			this.lblDistrType.Name = "lblDistrType";
			this.lblDistrType.Size = new System.Drawing.Size(268, 24);
			this.lblDistrType.TabIndex = 2;
			this.lblDistrType.Text = "Нормальное распределение";
			// 
			// rbManual
			// 
			this.rbManual.AutoSize = true;
			this.rbManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbManual.Location = new System.Drawing.Point(153, 19);
			this.rbManual.Name = "rbManual";
			this.rbManual.Size = new System.Drawing.Size(85, 20);
			this.rbManual.TabIndex = 12;
			this.rbManual.Text = "Вручную";
			this.rbManual.UseVisualStyleBackColor = true;
			this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
			// 
			// rbAuto
			// 
			this.rbAuto.AutoSize = true;
			this.rbAuto.Checked = true;
			this.rbAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbAuto.Location = new System.Drawing.Point(6, 19);
			this.rbAuto.Name = "rbAuto";
			this.rbAuto.Size = new System.Drawing.Size(128, 20);
			this.rbAuto.TabIndex = 11;
			this.rbAuto.TabStop = true;
			this.rbAuto.Text = "Автоматически";
			this.rbAuto.UseVisualStyleBackColor = true;
			this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
			// 
			// txtPirsonVis
			// 
			this.txtPirsonVis.Location = new System.Drawing.Point(147, 112);
			this.txtPirsonVis.Name = "txtPirsonVis";
			this.txtPirsonVis.ReadOnly = true;
			this.txtPirsonVis.Size = new System.Drawing.Size(221, 20);
			this.txtPirsonVis.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Наблюдаемое значение";
			// 
			// btnCorrect
			// 
			this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCorrect.Location = new System.Drawing.Point(9, 71);
			this.btnCorrect.Name = "btnCorrect";
			this.btnCorrect.Size = new System.Drawing.Size(359, 35);
			this.btnCorrect.TabIndex = 5;
			this.btnCorrect.Text = "Проверить";
			this.btnCorrect.UseVisualStyleBackColor = true;
			this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbAuto);
			this.groupBox2.Controls.Add(this.rbManual);
			this.groupBox2.Location = new System.Drawing.Point(9, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(359, 46);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Проверка";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbAlpha);
			this.groupBox3.Controls.Add(this.txtDegreesOfFreedom);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.labelResult);
			this.groupBox3.Controls.Add(this.txtPirsonCrit);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.groupBox2);
			this.groupBox3.Controls.Add(this.btnCorrect);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txtPirsonVis);
			this.groupBox3.Location = new System.Drawing.Point(382, 360);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(374, 257);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Проверка по критерию Пирсона";
			// 
			// cbAlpha
			// 
			this.cbAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAlpha.FormattingEnabled = true;
			this.cbAlpha.Location = new System.Drawing.Point(147, 138);
			this.cbAlpha.Name = "cbAlpha";
			this.cbAlpha.Size = new System.Drawing.Size(221, 21);
			this.cbAlpha.TabIndex = 20;
			// 
			// txtDegreesOfFreedom
			// 
			this.txtDegreesOfFreedom.Location = new System.Drawing.Point(147, 166);
			this.txtDegreesOfFreedom.Name = "txtDegreesOfFreedom";
			this.txtDegreesOfFreedom.ReadOnly = true;
			this.txtDegreesOfFreedom.Size = new System.Drawing.Size(221, 20);
			this.txtDegreesOfFreedom.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Уровень значимости";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Число степеней свободы";
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelResult.ForeColor = System.Drawing.Color.Green;
			this.labelResult.Location = new System.Drawing.Point(78, 225);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(222, 20);
			this.labelResult.TabIndex = 16;
			this.labelResult.Text = "НЕ ОТВЕРГАЕМ ГИПОТЕЗУ";
			this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelResult.Visible = false;
			// 
			// txtPirsonCrit
			// 
			this.txtPirsonCrit.Location = new System.Drawing.Point(147, 192);
			this.txtPirsonCrit.Name = "txtPirsonCrit";
			this.txtPirsonCrit.ReadOnly = true;
			this.txtPirsonCrit.Size = new System.Drawing.Size(221, 20);
			this.txtPirsonCrit.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Критическое значение";
			// 
			// gridCalcTable
			// 
			this.gridCalcTable.AllowUserToAddRows = false;
			this.gridCalcTable.AllowUserToDeleteRows = false;
			this.gridCalcTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCalcTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.interval,
            this.Pi,
            this.ni,
            this.sums});
			this.gridCalcTable.Location = new System.Drawing.Point(762, 40);
			this.gridCalcTable.Name = "gridCalcTable";
			this.gridCalcTable.ReadOnly = true;
			this.gridCalcTable.RowHeadersVisible = false;
			this.gridCalcTable.Size = new System.Drawing.Size(304, 577);
			this.gridCalcTable.TabIndex = 15;
			// 
			// pboxFunction
			// 
			this.pboxFunction.BackgroundImage = global::StatisticDistribution.Properties.Resources.normal_function;
			this.pboxFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pboxFunction.Location = new System.Drawing.Point(382, 40);
			this.pboxFunction.Name = "pboxFunction";
			this.pboxFunction.Size = new System.Drawing.Size(300, 71);
			this.pboxFunction.TabIndex = 3;
			this.pboxFunction.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(379, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Точечные оценки параметров";
			// 
			// gridPointValues
			// 
			this.gridPointValues.AllowUserToAddRows = false;
			this.gridPointValues.AllowUserToDeleteRows = false;
			this.gridPointValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPointValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParamName,
            this.Formula,
            this.Value});
			this.gridPointValues.Location = new System.Drawing.Point(383, 144);
			this.gridPointValues.Name = "gridPointValues";
			this.gridPointValues.ReadOnly = true;
			this.gridPointValues.RowHeadersVisible = false;
			this.gridPointValues.Size = new System.Drawing.Size(373, 210);
			this.gridPointValues.TabIndex = 0;
			// 
			// ParamName
			// 
			this.ParamName.HeaderText = "Параметр";
			this.ParamName.Name = "ParamName";
			this.ParamName.ReadOnly = true;
			this.ParamName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ParamName.Width = 200;
			// 
			// Formula
			// 
			this.Formula.HeaderText = "Формула";
			this.Formula.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.Formula.Name = "Formula";
			this.Formula.ReadOnly = true;
			this.Formula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Value
			// 
			this.Value.HeaderText = "Значение";
			this.Value.Name = "Value";
			this.Value.ReadOnly = true;
			this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Value.Width = 70;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(759, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Процесс вычисления";
			// 
			// interval
			// 
			this.interval.FillWeight = 97.92616F;
			this.interval.HeaderText = "Интервал";
			this.interval.Name = "interval";
			this.interval.ReadOnly = true;
			this.interval.Width = 140;
			// 
			// Pi
			// 
			this.Pi.FillWeight = 30F;
			this.Pi.HeaderText = "Pi";
			this.Pi.MinimumWidth = 20;
			this.Pi.Name = "Pi";
			this.Pi.ReadOnly = true;
			this.Pi.Width = 40;
			// 
			// ni
			// 
			this.ni.FillWeight = 48.07822F;
			this.ni.HeaderText = "ni";
			this.ni.Name = "ni";
			this.ni.ReadOnly = true;
			this.ni.Width = 40;
			// 
			// sums
			// 
			this.sums.FillWeight = 118.9294F;
			this.sums.HeaderText = "Слагаемые";
			this.sums.Name = "sums";
			this.sums.ReadOnly = true;
			this.sums.Width = 80;
			// 
			// CheckDistributionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1084, 632);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gridPointValues);
			this.Controls.Add(this.gridCalcTable);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.pboxFunction);
			this.Controls.Add(this.lblDistrType);
			this.Controls.Add(this.graphTheor);
			this.Controls.Add(this.graphEmp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "CheckDistributionForm";
			this.Text = "Проверка гипотезы о виде закона распределения";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCalcTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pboxFunction)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridPointValues)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ZedGraph.ZedGraphControl graphEmp;
		private ZedGraph.ZedGraphControl graphTheor;
		private System.Windows.Forms.Label lblDistrType;
        private System.Windows.Forms.PictureBox pboxFunction;
		private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.TextBox txtPirsonVis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPirsonCrit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlpha;
        private System.Windows.Forms.TextBox txtDegreesOfFreedom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridCalcTable;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView gridPointValues;
		private System.Windows.Forms.DataGridViewTextBoxColumn ParamName;
		private System.Windows.Forms.DataGridViewImageColumn Formula;
		private System.Windows.Forms.DataGridViewTextBoxColumn Value;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn interval;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pi;
		private System.Windows.Forms.DataGridViewTextBoxColumn ni;
		private System.Windows.Forms.DataGridViewTextBoxColumn sums;
	}
}