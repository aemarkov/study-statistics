namespace Regression
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.gridData = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnSeparate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.numCols = new System.Windows.Forms.NumericUpDown();
			this.numRows = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnInput = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gridCorrelation = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtB1_ = new System.Windows.Forms.TextBox();
			this.txtB1 = new System.Windows.Forms.TextBox();
			this.labelOMG = new System.Windows.Forms.Label();
			this.labelWTF = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtR = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtSy = new System.Windows.Forms.TextBox();
			this.txtSx = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.txtX = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnDiagr = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCorrelation)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// menuOpen
			// 
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Size = new System.Drawing.Size(172, 22);
			this.menuOpen.Text = "Открыть выборку";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// gridData
			// 
			this.gridData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridData.Location = new System.Drawing.Point(13, 28);
			this.gridData.Name = "gridData";
			this.gridData.Size = new System.Drawing.Size(303, 702);
			this.gridData.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnDiagr);
			this.groupBox1.Controls.Add(this.btnCreate);
			this.groupBox1.Controls.Add(this.btnSeparate);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.numCols);
			this.groupBox1.Controls.Add(this.numRows);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnInput);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.gridCorrelation);
			this.groupBox1.Location = new System.Drawing.Point(323, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(678, 526);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "B1\'";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(252, 20);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(225, 23);
			this.btnCreate.TabIndex = 8;
			this.btnCreate.Text = "Создать";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnSeparate
			// 
			this.btnSeparate.Location = new System.Drawing.Point(252, 48);
			this.btnSeparate.Name = "btnSeparate";
			this.btnSeparate.Size = new System.Drawing.Size(225, 23);
			this.btnSeparate.TabIndex = 7;
			this.btnSeparate.Text = "Разбить";
			this.btnSeparate.UseVisualStyleBackColor = true;
			this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Число столбцов";
			// 
			// numCols
			// 
			this.numCols.Location = new System.Drawing.Point(126, 46);
			this.numCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCols.Name = "numCols";
			this.numCols.Size = new System.Drawing.Size(120, 20);
			this.numCols.TabIndex = 5;
			this.numCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numRows
			// 
			this.numRows.Location = new System.Drawing.Point(126, 20);
			this.numRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numRows.Name = "numRows";
			this.numRows.Size = new System.Drawing.Size(120, 20);
			this.numRows.TabIndex = 4;
			this.numRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Число строк";
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(160, 79);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(317, 25);
			this.btnInput.TabIndex = 2;
			this.btnInput.Text = "Ввод данных из корреляционной таблицы";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Корреляционная таблица";
			// 
			// gridCorrelation
			// 
			this.gridCorrelation.AllowUserToAddRows = false;
			this.gridCorrelation.AllowUserToDeleteRows = false;
			this.gridCorrelation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridCorrelation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCorrelation.Location = new System.Drawing.Point(6, 110);
			this.gridCorrelation.Name = "gridCorrelation";
			this.gridCorrelation.Size = new System.Drawing.Size(664, 402);
			this.gridCorrelation.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.txtB1_);
			this.groupBox2.Controls.Add(this.txtB1);
			this.groupBox2.Controls.Add(this.labelOMG);
			this.groupBox2.Controls.Add(this.labelWTF);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtR);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtSy);
			this.groupBox2.Controls.Add(this.txtSx);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtY);
			this.groupBox2.Controls.Add(this.txtX);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(322, 560);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(670, 171);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Характеристики";
			// 
			// txtB1_
			// 
			this.txtB1_.Location = new System.Drawing.Point(30, 140);
			this.txtB1_.Name = "txtB1_";
			this.txtB1_.ReadOnly = true;
			this.txtB1_.Size = new System.Drawing.Size(150, 20);
			this.txtB1_.TabIndex = 44;
			// 
			// txtB1
			// 
			this.txtB1.Location = new System.Drawing.Point(30, 114);
			this.txtB1.Name = "txtB1";
			this.txtB1.ReadOnly = true;
			this.txtB1.Size = new System.Drawing.Size(150, 20);
			this.txtB1.TabIndex = 43;
			// 
			// labelOMG
			// 
			this.labelOMG.AutoSize = true;
			this.labelOMG.Location = new System.Drawing.Point(10, 143);
			this.labelOMG.Name = "labelOMG";
			this.labelOMG.Size = new System.Drawing.Size(22, 13);
			this.labelOMG.TabIndex = 42;
			this.labelOMG.Text = "B1\'";
			// 
			// labelWTF
			// 
			this.labelWTF.AutoSize = true;
			this.labelWTF.Location = new System.Drawing.Point(10, 117);
			this.labelWTF.Name = "labelWTF";
			this.labelWTF.Size = new System.Drawing.Size(20, 13);
			this.labelWTF.TabIndex = 41;
			this.labelWTF.Text = "B1";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 97);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(210, 13);
			this.label14.TabIndex = 40;
			this.label14.Text = "Оценка параметро линейной регрессии";
			// 
			// txtR
			// 
			this.txtR.Location = new System.Drawing.Point(407, 46);
			this.txtR.Name = "txtR";
			this.txtR.ReadOnly = true;
			this.txtR.Size = new System.Drawing.Size(150, 20);
			this.txtR.TabIndex = 39;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(386, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(10, 13);
			this.label11.TabIndex = 38;
			this.label11.Text = "r";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(381, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(140, 13);
			this.label10.TabIndex = 37;
			this.label10.Text = "Коэффициент корреляции";
			// 
			// txtSy
			// 
			this.txtSy.Location = new System.Drawing.Point(219, 69);
			this.txtSy.Name = "txtSy";
			this.txtSy.ReadOnly = true;
			this.txtSy.Size = new System.Drawing.Size(150, 20);
			this.txtSy.TabIndex = 36;
			// 
			// txtSx
			// 
			this.txtSx.Location = new System.Drawing.Point(219, 43);
			this.txtSx.Name = "txtSx";
			this.txtSx.ReadOnly = true;
			this.txtSx.Size = new System.Drawing.Size(150, 20);
			this.txtSx.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(198, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(19, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "Sy";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(198, 46);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(19, 13);
			this.label9.TabIndex = 33;
			this.label9.Text = "Sx";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(192, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 13);
			this.label7.TabIndex = 32;
			this.label7.Text = "Дисперсии:";
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(30, 69);
			this.txtY.Name = "txtY";
			this.txtY.ReadOnly = true;
			this.txtY.Size = new System.Drawing.Size(150, 20);
			this.txtY.TabIndex = 31;
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(30, 43);
			this.txtX.Name = "txtX";
			this.txtX.ReadOnly = true;
			this.txtX.Size = new System.Drawing.Size(150, 20);
			this.txtX.TabIndex = 30;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 13);
			this.label6.TabIndex = 29;
			this.label6.Text = "Y";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "X";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 27;
			this.label4.Text = "Средние:";
			// 
			// btnDiagr
			// 
			this.btnDiagr.Location = new System.Drawing.Point(483, 77);
			this.btnDiagr.Name = "btnDiagr";
			this.btnDiagr.Size = new System.Drawing.Size(189, 25);
			this.btnDiagr.TabIndex = 9;
			this.btnDiagr.Text = "Диаграмма рассеивания";
			this.btnDiagr.UseVisualStyleBackColor = true;
			this.btnDiagr.Click += new System.EventHandler(this.btnDiagr_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1011, 742);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridData);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Регрессия";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCols)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCorrelation)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.DataGridView gridData;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSeparate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numCols;
		private System.Windows.Forms.NumericUpDown numRows;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridCorrelation;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtB1_;
		private System.Windows.Forms.TextBox txtB1;
		private System.Windows.Forms.Label labelOMG;
		private System.Windows.Forms.Label labelWTF;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtR;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtSy;
		private System.Windows.Forms.TextBox txtSx;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnDiagr;
	}
}

