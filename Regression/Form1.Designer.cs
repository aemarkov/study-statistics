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
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnSeparate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.numCols = new System.Windows.Forms.NumericUpDown();
			this.numRows = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnInput = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gridCorrelation = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCols)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCorrelation)).BeginInit();
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
			this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridData.Location = new System.Drawing.Point(13, 28);
			this.gridData.Name = "gridData";
			this.gridData.Size = new System.Drawing.Size(303, 650);
			this.gridData.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
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
			this.groupBox1.Size = new System.Drawing.Size(678, 650);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Корреляционная таблица";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(249, 108);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(417, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Разбить введенные из файла данные и сформировать корреляционную таблицу";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(255, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 13);
			this.label5.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(253, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(417, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Создать пустую корреляционную таблицу заданного размера для ручного ввода";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(21, 74);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(225, 23);
			this.btnCreate.TabIndex = 8;
			this.btnCreate.Text = "Создать";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnSeparate
			// 
			this.btnSeparate.Location = new System.Drawing.Point(21, 103);
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
			this.btnInput.Location = new System.Drawing.Point(256, 20);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(410, 46);
			this.btnInput.TabIndex = 2;
			this.btnInput.Text = "Ввод данных из корреляционной таблицы";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Корреляционная таблица";
			// 
			// gridCorrelation
			// 
			this.gridCorrelation.AllowUserToAddRows = false;
			this.gridCorrelation.AllowUserToDeleteRows = false;
			this.gridCorrelation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCorrelation.Location = new System.Drawing.Point(6, 154);
			this.gridCorrelation.Name = "gridCorrelation";
			this.gridCorrelation.Size = new System.Drawing.Size(664, 490);
			this.gridCorrelation.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1011, 690);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gridData);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCreate;
	}
}

