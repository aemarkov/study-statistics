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
            this.pboxFormula = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.txtPirsonVis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbAlpha = new System.Windows.Forms.ComboBox();
            this.txtNumOfFreedom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.txtPirsonCrit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFormula)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphEmp
            // 
            this.graphEmp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.graphEmp.Location = new System.Drawing.Point(12, 11);
            this.graphEmp.Name = "graphEmp";
            this.graphEmp.ScrollGrace = 0D;
            this.graphEmp.ScrollMaxX = 0D;
            this.graphEmp.ScrollMaxY = 0D;
            this.graphEmp.ScrollMaxY2 = 0D;
            this.graphEmp.ScrollMinX = 0D;
            this.graphEmp.ScrollMinY = 0D;
            this.graphEmp.ScrollMinY2 = 0D;
            this.graphEmp.Size = new System.Drawing.Size(350, 287);
            this.graphEmp.TabIndex = 0;
            this.graphEmp.UseExtendedPrintDialog = true;
            // 
            // graphTheor
            // 
            this.graphTheor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.graphTheor.Location = new System.Drawing.Point(12, 304);
            this.graphTheor.Name = "graphTheor";
            this.graphTheor.ScrollGrace = 0D;
            this.graphTheor.ScrollMaxX = 0D;
            this.graphTheor.ScrollMaxY = 0D;
            this.graphTheor.ScrollMaxY2 = 0D;
            this.graphTheor.ScrollMinX = 0D;
            this.graphTheor.ScrollMinY = 0D;
            this.graphTheor.ScrollMinY2 = 0D;
            this.graphTheor.Size = new System.Drawing.Size(350, 280);
            this.graphTheor.TabIndex = 1;
            this.graphTheor.UseExtendedPrintDialog = true;
            // 
            // lblDistrType
            // 
            this.lblDistrType.AutoSize = true;
            this.lblDistrType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDistrType.Location = new System.Drawing.Point(378, 12);
            this.lblDistrType.Name = "lblDistrType";
            this.lblDistrType.Size = new System.Drawing.Size(290, 24);
            this.lblDistrType.TabIndex = 2;
            this.lblDistrType.Text = "Биномиальное распределение";
            // 
            // pboxFormula
            // 
            this.pboxFormula.Location = new System.Drawing.Point(382, 40);
            this.pboxFormula.Name = "pboxFormula";
            this.pboxFormula.Size = new System.Drawing.Size(309, 151);
            this.pboxFormula.TabIndex = 3;
            this.pboxFormula.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(383, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проверка гипотезы по графикам";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Точечные оценки параметров:";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbManual.Location = new System.Drawing.Point(153, 19);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(85, 20);
            this.rbManual.TabIndex = 12;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Вручную";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAuto.Location = new System.Drawing.Point(6, 19);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(128, 20);
            this.rbAuto.TabIndex = 11;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Автоматически";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // txtPirsonVis
            // 
            this.txtPirsonVis.Location = new System.Drawing.Point(147, 176);
            this.txtPirsonVis.Name = "txtPirsonVis";
            this.txtPirsonVis.ReadOnly = true;
            this.txtPirsonVis.Size = new System.Drawing.Size(155, 20);
            this.txtPirsonVis.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 179);
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
            this.btnCorrect.Size = new System.Drawing.Size(293, 35);
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
            this.groupBox2.Size = new System.Drawing.Size(293, 46);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Проверка";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAlpha);
            this.groupBox3.Controls.Add(this.txtNumOfFreedom);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelResult);
            this.groupBox3.Controls.Add(this.txtPirsonCrit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnCorrect);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtPirsonVis);
            this.groupBox3.Location = new System.Drawing.Point(383, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 257);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверка по критерию Пирсона";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbAlpha
            // 
            this.cbAlpha.FormattingEnabled = true;
            this.cbAlpha.Items.AddRange(new object[] {
            "0,05",
            "0,01"});
            this.cbAlpha.Location = new System.Drawing.Point(147, 123);
            this.cbAlpha.Name = "cbAlpha";
            this.cbAlpha.Size = new System.Drawing.Size(155, 21);
            this.cbAlpha.TabIndex = 20;
            // 
            // txtNumOfFreedom
            // 
            this.txtNumOfFreedom.Location = new System.Drawing.Point(147, 150);
            this.txtNumOfFreedom.Name = "txtNumOfFreedom";
            this.txtNumOfFreedom.ReadOnly = true;
            this.txtNumOfFreedom.Size = new System.Drawing.Size(155, 20);
            this.txtNumOfFreedom.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Уровень значимости";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 157);
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
            this.labelResult.Location = new System.Drawing.Point(50, 225);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(222, 20);
            this.labelResult.TabIndex = 16;
            this.labelResult.Text = "НЕ ОТВЕРГАЕМ ГИПОТЕЗУ";
            // 
            // txtPirsonCrit
            // 
            this.txtPirsonCrit.Location = new System.Drawing.Point(147, 202);
            this.txtPirsonCrit.Name = "txtPirsonCrit";
            this.txtPirsonCrit.ReadOnly = true;
            this.txtPirsonCrit.Size = new System.Drawing.Size(155, 20);
            this.txtPirsonCrit.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Критическое значение";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.interval,
            this.Pi,
            this.ni,
            this.sums});
            this.dataGridView1.Location = new System.Drawing.Point(697, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(232, 256);
            this.dataGridView1.TabIndex = 15;
            // 
            // interval
            // 
            this.interval.HeaderText = "Интервал";
            this.interval.Name = "interval";
            this.interval.ReadOnly = true;
            // 
            // Pi
            // 
            this.Pi.HeaderText = "Pi";
            this.Pi.Name = "Pi";
            this.Pi.ReadOnly = true;
            // 
            // ni
            // 
            this.ni.HeaderText = "ni";
            this.ni.Name = "ni";
            this.ni.ReadOnly = true;
            // 
            // sums
            // 
            this.sums.HeaderText = "Слагаемые";
            this.sums.Name = "sums";
            this.sums.ReadOnly = true;
            // 
            // CheckDistributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 593);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pboxFormula);
            this.Controls.Add(this.lblDistrType);
            this.Controls.Add(this.graphTheor);
            this.Controls.Add(this.graphEmp);
            this.Name = "CheckDistributionForm";
            this.Text = "Проверка гипотезы о виде закона распределения";
            ((System.ComponentModel.ISupportInitialize)(this.pboxFormula)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ZedGraph.ZedGraphControl graphEmp;
		private ZedGraph.ZedGraphControl graphTheor;
		private System.Windows.Forms.Label lblDistrType;
        private System.Windows.Forms.PictureBox pboxFormula;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.TextBox txtPirsonVis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPirsonCrit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlpha;
        private System.Windows.Forms.TextBox txtNumOfFreedom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn sums;
	}
}