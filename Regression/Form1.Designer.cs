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
			this.btnInput = new System.Windows.Forms.Button();
			this.gridCorrelationInput = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSeparate = new System.Windows.Forms.Button();
			this.numSepRows = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.numSepCols = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.gridData = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numCreateCols = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.numCreateRows = new System.Windows.Forms.NumericUpDown();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtR = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSy = new System.Windows.Forms.TextBox();
			this.txtSx = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.txtX = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.menuAdditionalValues = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCorrelationInput)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSepRows)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numSepCols)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCreateCols)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCreateRows)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.обработкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1336, 24);
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
            this.menuDrawDiagram,
            this.menuAdditionalValues});
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
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(130, 73);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(120, 23);
			this.btnInput.TabIndex = 2;
			this.btnInput.Text = "Сохранить";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// gridCorrelationInput
			// 
			this.gridCorrelationInput.AllowUserToAddRows = false;
			this.gridCorrelationInput.AllowUserToDeleteRows = false;
			this.gridCorrelationInput.AllowUserToResizeColumns = false;
			this.gridCorrelationInput.AllowUserToResizeRows = false;
			this.gridCorrelationInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridCorrelationInput.BackgroundColor = System.Drawing.Color.White;
			this.gridCorrelationInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCorrelationInput.ColumnHeadersVisible = false;
			this.gridCorrelationInput.Location = new System.Drawing.Point(6, 19);
			this.gridCorrelationInput.Name = "gridCorrelationInput";
			this.gridCorrelationInput.RowHeadersVisible = false;
			this.gridCorrelationInput.Size = new System.Drawing.Size(683, 429);
			this.gridCorrelationInput.TabIndex = 13;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.gridData);
			this.groupBox2.Location = new System.Drawing.Point(12, 37);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(286, 570);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Выборка";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSeparate);
			this.groupBox1.Controls.Add(this.numSepRows);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.numSepCols);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 456);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 108);
			this.groupBox1.TabIndex = 10;
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
			this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click_1);
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
			// gridData
			// 
			this.gridData.AllowUserToAddRows = false;
			this.gridData.AllowUserToDeleteRows = false;
			this.gridData.AllowUserToResizeColumns = false;
			this.gridData.AllowUserToResizeRows = false;
			this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridData.BackgroundColor = System.Drawing.Color.White;
			this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridData.Location = new System.Drawing.Point(12, 19);
			this.gridData.Name = "gridData";
			this.gridData.Size = new System.Drawing.Size(259, 429);
			this.gridData.TabIndex = 9;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gridCorrelationInput);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Location = new System.Drawing.Point(304, 37);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(705, 570);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Диаграмма рассеивания";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.btnInput);
			this.groupBox4.Controls.Add(this.numCreateCols);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.btnCreate);
			this.groupBox4.Controls.Add(this.numCreateRows);
			this.groupBox4.Location = new System.Drawing.Point(6, 456);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(259, 108);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = " Создание корреляционной таблицы";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Число строк (Y)";
			// 
			// numCreateCols
			// 
			this.numCreateCols.Location = new System.Drawing.Point(130, 23);
			this.numCreateCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCreateCols.Name = "numCreateCols";
			this.numCreateCols.Size = new System.Drawing.Size(120, 20);
			this.numCreateCols.TabIndex = 16;
			this.numCreateCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Число столбцов (X)";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(6, 73);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(120, 23);
			this.btnCreate.TabIndex = 13;
			this.btnCreate.Text = "Создать";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
			// 
			// numCreateRows
			// 
			this.numCreateRows.Location = new System.Drawing.Point(130, 49);
			this.numCreateRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCreateRows.Name = "numCreateRows";
			this.numCreateRows.Size = new System.Drawing.Size(120, 20);
			this.numCreateRows.TabIndex = 15;
			this.numCreateRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.pictureBox5);
			this.groupBox5.Controls.Add(this.pictureBox4);
			this.groupBox5.Controls.Add(this.pictureBox3);
			this.groupBox5.Controls.Add(this.pictureBox2);
			this.groupBox5.Controls.Add(this.pictureBox1);
			this.groupBox5.Controls.Add(this.txtR);
			this.groupBox5.Controls.Add(this.label11);
			this.groupBox5.Controls.Add(this.txtSy);
			this.groupBox5.Controls.Add(this.txtSx);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.txtY);
			this.groupBox5.Controls.Add(this.txtX);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Location = new System.Drawing.Point(1015, 37);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(314, 448);
			this.groupBox5.TabIndex = 14;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Числовые характеристики";
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackgroundImage = global::Regression.Properties.Resources.r;
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox5.Location = new System.Drawing.Point(9, 370);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(200, 60);
			this.pictureBox5.TabIndex = 19;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImage = global::Regression.Properties.Resources.Sy;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Location = new System.Drawing.Point(6, 265);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(200, 60);
			this.pictureBox4.TabIndex = 18;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::Regression.Properties.Resources.Sx;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Location = new System.Drawing.Point(6, 199);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(200, 60);
			this.pictureBox3.TabIndex = 17;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::Regression.Properties.Resources.Y;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(6, 108);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 60);
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::Regression.Properties.Resources.X;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(6, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 60);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// txtR
			// 
			this.txtR.Location = new System.Drawing.Point(212, 387);
			this.txtR.Name = "txtR";
			this.txtR.ReadOnly = true;
			this.txtR.Size = new System.Drawing.Size(91, 20);
			this.txtR.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(6, 347);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(215, 20);
			this.label11.TabIndex = 10;
			this.label11.Text = "Коэффициент корреляции";
			// 
			// txtSy
			// 
			this.txtSy.Location = new System.Drawing.Point(212, 280);
			this.txtSy.Name = "txtSy";
			this.txtSy.ReadOnly = true;
			this.txtSy.Size = new System.Drawing.Size(91, 20);
			this.txtSy.TabIndex = 9;
			// 
			// txtSx
			// 
			this.txtSx.Location = new System.Drawing.Point(212, 218);
			this.txtSx.Name = "txtSx";
			this.txtSx.ReadOnly = true;
			this.txtSx.Size = new System.Drawing.Size(91, 20);
			this.txtSx.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(3, 176);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 5;
			this.label8.Text = "Дисперсия";
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(212, 123);
			this.txtY.Name = "txtY";
			this.txtY.ReadOnly = true;
			this.txtY.Size = new System.Drawing.Size(91, 20);
			this.txtY.TabIndex = 4;
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(212, 59);
			this.txtX.Name = "txtX";
			this.txtX.ReadOnly = true;
			this.txtX.Size = new System.Drawing.Size(91, 20);
			this.txtX.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(6, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Среднее";
			// 
			// menuAdditionalValues
			// 
			this.menuAdditionalValues.Name = "menuAdditionalValues";
			this.menuAdditionalValues.Size = new System.Drawing.Size(281, 22);
			this.menuAdditionalValues.Text = "Показать промежуточные значения";
			this.menuAdditionalValues.Click += new System.EventHandler(this.menuAdditionalValues_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1336, 620);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Регрессия";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCorrelationInput)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numSepRows)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numSepCols)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCreateCols)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCreateRows)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.DataGridView gridCorrelationInput;
		private System.Windows.Forms.ToolStripMenuItem menuOpenCorrelationTable;
		private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuCalc;
		private System.Windows.Forms.ToolStripMenuItem menuDrawDiagram;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSeparate;
		private System.Windows.Forms.NumericUpDown numSepRows;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numSepCols;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView gridData;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numCreateCols;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numCreateRows;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txtSy;
		private System.Windows.Forms.TextBox txtSx;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtR;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolStripMenuItem menuAdditionalValues;
	}
}

