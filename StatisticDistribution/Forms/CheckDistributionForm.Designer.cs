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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWrong = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPirsonVis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFormula)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphEmp
            // 
            this.graphEmp.Location = new System.Drawing.Point(12, 12);
            this.graphEmp.Name = "graphEmp";
            this.graphEmp.ScrollGrace = 0D;
            this.graphEmp.ScrollMaxX = 0D;
            this.graphEmp.ScrollMaxY = 0D;
            this.graphEmp.ScrollMaxY2 = 0D;
            this.graphEmp.ScrollMinX = 0D;
            this.graphEmp.ScrollMinY = 0D;
            this.graphEmp.ScrollMinY2 = 0D;
            this.graphEmp.Size = new System.Drawing.Size(350, 350);
            this.graphEmp.TabIndex = 0;
            this.graphEmp.UseExtendedPrintDialog = true;
            // 
            // graphTheor
            // 
            this.graphTheor.Location = new System.Drawing.Point(12, 368);
            this.graphTheor.Name = "graphTheor";
            this.graphTheor.ScrollGrace = 0D;
            this.graphTheor.ScrollMaxX = 0D;
            this.graphTheor.ScrollMaxY = 0D;
            this.graphTheor.ScrollMaxY2 = 0D;
            this.graphTheor.ScrollMinX = 0D;
            this.graphTheor.ScrollMinY = 0D;
            this.graphTheor.ScrollMinY2 = 0D;
            this.graphTheor.Size = new System.Drawing.Size(350, 350);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. Проверка гипотезы по графикам";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPirsonVis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCorrect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnWrong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(383, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 279);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Проверка по критерию Пирсона";
            // 
            // btnWrong
            // 
            this.btnWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWrong.Location = new System.Drawing.Point(155, 44);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(135, 35);
            this.btnWrong.TabIndex = 6;
            this.btnWrong.Text = "Отвергнуть";
            this.btnWrong.UseVisualStyleBackColor = true;
            this.btnWrong.Click += new System.EventHandler(this.btnWrong_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCorrect.Location = new System.Drawing.Point(15, 44);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(135, 35);
            this.btnCorrect.TabIndex = 5;
            this.btnCorrect.Text = "Подтвердить";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Наблюдаемое значение";
            // 
            // txtPirsonVis
            // 
            this.txtPirsonVis.Location = new System.Drawing.Point(155, 137);
            this.txtPirsonVis.Name = "txtPirsonVis";
            this.txtPirsonVis.ReadOnly = true;
            this.txtPirsonVis.Size = new System.Drawing.Size(135, 20);
            this.txtPirsonVis.TabIndex = 9;
            // 
            // CheckDistributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 727);
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
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ZedGraph.ZedGraphControl graphEmp;
		private ZedGraph.ZedGraphControl graphTheor;
		private System.Windows.Forms.Label lblDistrType;
		private System.Windows.Forms.PictureBox pboxFormula;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnWrong;
		private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.TextBox txtPirsonVis;
        private System.Windows.Forms.Label label3;
	}
}