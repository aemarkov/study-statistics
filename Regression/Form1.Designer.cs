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
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnSeparate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.numSepCols = new System.Windows.Forms.NumericUpDown();
			this.numSepRows = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnInput = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnDiagr = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.gridCorrelationInput = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.numCreateCols = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.numCreateRows = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSepCols)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSepRows)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCorrelationInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCreateCols)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCreateRows)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(637, 24);
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
			this.gridData.Location = new System.Drawing.Point(15, 17);
			this.gridData.Name = "gridData";
			this.gridData.Size = new System.Drawing.Size(331, 649);
			this.gridData.TabIndex = 1;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(9, 59);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(241, 23);
			this.btnCreate.TabIndex = 8;
			this.btnCreate.Text = "Создать";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnSeparate
			// 
			this.btnSeparate.Location = new System.Drawing.Point(356, 89);
			this.btnSeparate.Name = "btnSeparate";
			this.btnSeparate.Size = new System.Drawing.Size(241, 23);
			this.btnSeparate.TabIndex = 7;
			this.btnSeparate.Text = "Разбить";
			this.btnSeparate.UseVisualStyleBackColor = true;
			this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(353, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Число столбцов";
			// 
			// numSepCols
			// 
			this.numSepCols.Location = new System.Drawing.Point(477, 63);
			this.numSepCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numSepCols.Name = "numSepCols";
			this.numSepCols.Size = new System.Drawing.Size(120, 20);
			this.numSepCols.TabIndex = 5;
			this.numSepCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numSepRows
			// 
			this.numSepRows.Location = new System.Drawing.Point(477, 36);
			this.numSepRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numSepRows.Name = "numSepRows";
			this.numSepRows.Size = new System.Drawing.Size(120, 20);
			this.numSepRows.TabIndex = 4;
			this.numSepRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(353, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Число строк";
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(256, 3);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(341, 79);
			this.btnInput.TabIndex = 2;
			this.btnInput.Text = "Ввод данных из корреляционной таблицы";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(611, 699);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnDiagr);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.gridData);
			this.tabPage1.Controls.Add(this.btnSeparate);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.numSepCols);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.numSepRows);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(603, 673);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ввод выборки";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnDiagr
			// 
			this.btnDiagr.Location = new System.Drawing.Point(356, 118);
			this.btnDiagr.Name = "btnDiagr";
			this.btnDiagr.Size = new System.Drawing.Size(241, 25);
			this.btnDiagr.TabIndex = 10;
			this.btnDiagr.Text = "Диаграмма рассеивания";
			this.btnDiagr.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(353, 17);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(195, 13);
			this.label12.TabIndex = 2;
			this.label12.Text = "Построение корреляционной таблцы";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.gridCorrelationInput);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.numCreateCols);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.numCreateRows);
			this.tabPage2.Controls.Add(this.btnCreate);
			this.tabPage2.Controls.Add(this.btnInput);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(603, 673);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Ввод корреляционной таблицы";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// gridCorrelationInput
			// 
			this.gridCorrelationInput.AllowUserToAddRows = false;
			this.gridCorrelationInput.AllowUserToDeleteRows = false;
			this.gridCorrelationInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCorrelationInput.ColumnHeadersVisible = false;
			this.gridCorrelationInput.Location = new System.Drawing.Point(9, 89);
			this.gridCorrelationInput.Name = "gridCorrelationInput";
			this.gridCorrelationInput.RowHeadersVisible = false;
			this.gridCorrelationInput.Size = new System.Drawing.Size(588, 578);
			this.gridCorrelationInput.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Число строк (Y)";
			// 
			// numCreateCols
			// 
			this.numCreateCols.Location = new System.Drawing.Point(130, 12);
			this.numCreateCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCreateCols.Name = "numCreateCols";
			this.numCreateCols.Size = new System.Drawing.Size(120, 20);
			this.numCreateCols.TabIndex = 11;
			this.numCreateCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Число столбцов (X)";
			// 
			// numCreateRows
			// 
			this.numCreateRows.Location = new System.Drawing.Point(130, 35);
			this.numCreateRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCreateRows.Name = "numCreateRows";
			this.numCreateRows.Size = new System.Drawing.Size(120, 20);
			this.numCreateRows.TabIndex = 10;
			this.numCreateRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(637, 742);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Регрессия";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSepCols)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSepRows)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCorrelationInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCreateCols)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCreateRows)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.DataGridView gridData;
		private System.Windows.Forms.Button btnSeparate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numSepCols;
		private System.Windows.Forms.NumericUpDown numSepRows;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnDiagr;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numCreateCols;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numCreateRows;
		private System.Windows.Forms.DataGridView gridCorrelationInput;
	}
}

