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
			this.menuOpenCorrelationTable = new System.Windows.Forms.ToolStripMenuItem();
			this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCalc = new System.Windows.Forms.ToolStripMenuItem();
			this.menuDrawDiagram = new System.Windows.Forms.ToolStripMenuItem();
			this.gridData = new System.Windows.Forms.DataGridView();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnInput = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageSample = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSeparate = new System.Windows.Forms.Button();
			this.numSepRows = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numSepCols = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPageCorrelationTable = new System.Windows.Forms.TabPage();
			this.gridCorrelationInput = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.numCreateCols = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.numCreateRows = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPageSample.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSepRows)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSepCols)).BeginInit();
			this.tabPageCorrelationTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCorrelationInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCreateCols)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCreateRows)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.обработкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(637, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.menuOpenCorrelationTable});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// menuOpen
			// 
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Size = new System.Drawing.Size(269, 22);
			this.menuOpen.Text = "Открыть выборку";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// menuOpenCorrelationTable
			// 
			this.menuOpenCorrelationTable.Name = "menuOpenCorrelationTable";
			this.menuOpenCorrelationTable.Size = new System.Drawing.Size(269, 22);
			this.menuOpenCorrelationTable.Text = "Открыть корреляционную таблицу";
			this.menuOpenCorrelationTable.Click += new System.EventHandler(this.menuOpenCorrelationTable_Click);
			// 
			// обработкаToolStripMenuItem
			// 
			this.обработкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalc,
            this.menuDrawDiagram});
			this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
			this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.обработкаToolStripMenuItem.Text = "Обработка";
			// 
			// menuCalc
			// 
			this.menuCalc.Name = "menuCalc";
			this.menuCalc.Size = new System.Drawing.Size(281, 22);
			this.menuCalc.Text = "Расчет числовых характеристик";
			this.menuCalc.Click += new System.EventHandler(this.menuCalc_Click);
			// 
			// menuDrawDiagram
			// 
			this.menuDrawDiagram.Name = "menuDrawDiagram";
			this.menuDrawDiagram.Size = new System.Drawing.Size(281, 22);
			this.menuDrawDiagram.Text = "Построение диаграммы рассеивания";
			this.menuDrawDiagram.Click += new System.EventHandler(this.menuDrawDiagram_Click);
			// 
			// gridData
			// 
			this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridData.Location = new System.Drawing.Point(15, 17);
			this.gridData.Name = "gridData";
			this.gridData.Size = new System.Drawing.Size(259, 524);
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
			this.tabControl1.Controls.Add(this.tabPageSample);
			this.tabControl1.Controls.Add(this.tabPageCorrelationTable);
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(611, 699);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPageSample
			// 
			this.tabPageSample.Controls.Add(this.groupBox1);
			this.tabPageSample.Controls.Add(this.gridData);
			this.tabPageSample.Location = new System.Drawing.Point(4, 22);
			this.tabPageSample.Name = "tabPageSample";
			this.tabPageSample.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSample.Size = new System.Drawing.Size(603, 673);
			this.tabPageSample.TabIndex = 0;
			this.tabPageSample.Text = "Выборка";
			this.tabPageSample.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSeparate);
			this.groupBox1.Controls.Add(this.numSepRows);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.numSepCols);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(15, 559);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 108);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Построение корреляционной таблицы";
			// 
			// btnSeparate
			// 
			this.btnSeparate.Location = new System.Drawing.Point(6, 73);
			this.btnSeparate.Name = "btnSeparate";
			this.btnSeparate.Size = new System.Drawing.Size(241, 23);
			this.btnSeparate.TabIndex = 7;
			this.btnSeparate.Text = "Разбить";
			this.btnSeparate.UseVisualStyleBackColor = true;
			this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click);
			// 
			// numSepRows
			// 
			this.numSepRows.Location = new System.Drawing.Point(127, 21);
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Число столбцов";
			// 
			// numSepCols
			// 
			this.numSepCols.Location = new System.Drawing.Point(127, 47);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Число строк";
			// 
			// tabPageCorrelationTable
			// 
			this.tabPageCorrelationTable.Controls.Add(this.gridCorrelationInput);
			this.tabPageCorrelationTable.Controls.Add(this.label1);
			this.tabPageCorrelationTable.Controls.Add(this.numCreateCols);
			this.tabPageCorrelationTable.Controls.Add(this.label4);
			this.tabPageCorrelationTable.Controls.Add(this.numCreateRows);
			this.tabPageCorrelationTable.Controls.Add(this.btnCreate);
			this.tabPageCorrelationTable.Controls.Add(this.btnInput);
			this.tabPageCorrelationTable.Location = new System.Drawing.Point(4, 22);
			this.tabPageCorrelationTable.Name = "tabPageCorrelationTable";
			this.tabPageCorrelationTable.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCorrelationTable.Size = new System.Drawing.Size(603, 673);
			this.tabPageCorrelationTable.TabIndex = 1;
			this.tabPageCorrelationTable.Text = "Корреляционная таблица";
			this.tabPageCorrelationTable.UseVisualStyleBackColor = true;
			// 
			// gridCorrelationInput
			// 
			this.gridCorrelationInput.AllowUserToAddRows = false;
			this.gridCorrelationInput.AllowUserToDeleteRows = false;
			this.gridCorrelationInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCorrelationInput.ColumnHeadersVisible = false;
			this.gridCorrelationInput.Location = new System.Drawing.Point(9, 88);
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
			this.tabControl1.ResumeLayout(false);
			this.tabPageSample.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSepRows)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSepCols)).EndInit();
			this.tabPageCorrelationTable.ResumeLayout(false);
			this.tabPageCorrelationTable.PerformLayout();
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
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSample;
		private System.Windows.Forms.TabPage tabPageCorrelationTable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numCreateCols;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numCreateRows;
		private System.Windows.Forms.DataGridView gridCorrelationInput;
		private System.Windows.Forms.ToolStripMenuItem menuOpenCorrelationTable;
		private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuCalc;
		private System.Windows.Forms.ToolStripMenuItem menuDrawDiagram;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSeparate;
		private System.Windows.Forms.NumericUpDown numSepRows;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numSepCols;
		private System.Windows.Forms.Label label2;
	}
}

