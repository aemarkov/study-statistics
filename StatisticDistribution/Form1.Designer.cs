namespace StatisticDistribution
{
	partial class MainForm
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
			this.groupBoxInterval = new System.Windows.Forms.GroupBox();
			this.btnSeparate = new System.Windows.Forms.Button();
			this.numIntervals = new System.Windows.Forms.NumericUpDown();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnOpen = new System.Windows.Forms.Button();
			this.gridData = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnInterval = new System.Windows.Forms.Button();
			this.gridIntervalData = new System.Windows.Forms.DataGridView();
			this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.построениеРядаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStatFreq = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStatRelFreq = new System.Windows.Forms.ToolStripMenuItem();
			this.menuIntervalFreq = new System.Windows.Forms.ToolStripMenuItem();
			this.menuIntervalRelFreq = new System.Windows.Forms.ToolStripMenuItem();
			this.menuGroupFreq = new System.Windows.Forms.ToolStripMenuItem();
			this.menuGroupRelFreq = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEmpiricFunction = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNumericCharacteristics = new System.Windows.Forms.ToolStripMenuItem();
			this.проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCheckNormal = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCheckBinomial = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnFreq = new System.Windows.Forms.Button();
			this.gridFreqData = new System.Windows.Forms.DataGridView();
			this.val = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBoxInterval.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numIntervals)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridIntervalData)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridFreqData)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxInterval
			// 
			this.groupBoxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxInterval.Controls.Add(this.btnSeparate);
			this.groupBoxInterval.Controls.Add(this.numIntervals);
			this.groupBoxInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBoxInterval.Location = new System.Drawing.Point(6, 536);
			this.groupBoxInterval.Name = "groupBoxInterval";
			this.groupBoxInterval.Size = new System.Drawing.Size(291, 64);
			this.groupBoxInterval.TabIndex = 7;
			this.groupBoxInterval.TabStop = false;
			this.groupBoxInterval.Text = "Разбиение на интервалы";
			// 
			// btnSeparate
			// 
			this.btnSeparate.Location = new System.Drawing.Point(106, 25);
			this.btnSeparate.Name = "btnSeparate";
			this.btnSeparate.Size = new System.Drawing.Size(179, 26);
			this.btnSeparate.TabIndex = 1;
			this.btnSeparate.Text = "Разбить";
			this.btnSeparate.UseVisualStyleBackColor = true;
			this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click);
			// 
			// numIntervals
			// 
			this.numIntervals.DecimalPlaces = 2;
			this.numIntervals.Location = new System.Drawing.Point(7, 26);
			this.numIntervals.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numIntervals.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.numIntervals.Name = "numIntervals";
			this.numIntervals.Size = new System.Drawing.Size(93, 26);
			this.numIntervals.TabIndex = 0;
			this.numIntervals.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(5, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(313, 632);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnOpen);
			this.tabPage1.Controls.Add(this.gridData);
			this.tabPage1.Controls.Add(this.groupBoxInterval);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(305, 606);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Выборка";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOpen.Location = new System.Drawing.Point(6, 9);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(291, 37);
			this.btnOpen.TabIndex = 4;
			this.btnOpen.Text = "Открыть выборку";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
			// 
			// gridData
			// 
			this.gridData.AllowUserToAddRows = false;
			this.gridData.AllowUserToDeleteRows = false;
			this.gridData.AllowUserToResizeColumns = false;
			this.gridData.AllowUserToResizeRows = false;
			this.gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gridData.Location = new System.Drawing.Point(6, 52);
			this.gridData.Name = "gridData";
			this.gridData.RowHeadersVisible = false;
			this.gridData.Size = new System.Drawing.Size(291, 478);
			this.gridData.TabIndex = 3;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnInterval);
			this.tabPage2.Controls.Add(this.gridIntervalData);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(305, 606);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Интервальный ряд";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnInterval
			// 
			this.btnInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnInterval.Location = new System.Drawing.Point(6, 563);
			this.btnInterval.Name = "btnInterval";
			this.btnInterval.Size = new System.Drawing.Size(293, 37);
			this.btnInterval.TabIndex = 5;
			this.btnInterval.Text = "Ввод";
			this.btnInterval.UseVisualStyleBackColor = true;
			this.btnInterval.Click += new System.EventHandler(this.btnInterval_Click);
			// 
			// gridIntervalData
			// 
			this.gridIntervalData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridIntervalData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridIntervalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridIntervalData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
			this.gridIntervalData.Location = new System.Drawing.Point(6, 6);
			this.gridIntervalData.MultiSelect = false;
			this.gridIntervalData.Name = "gridIntervalData";
			this.gridIntervalData.Size = new System.Drawing.Size(293, 551);
			this.gridIntervalData.TabIndex = 0;
			// 
			// Key
			// 
			this.Key.HeaderText = "Интервал";
			this.Key.Name = "Key";
			// 
			// Value
			// 
			this.Value.HeaderText = "Частота";
			this.Value.Name = "Value";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обработкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(324, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// обработкаToolStripMenuItem
			// 
			this.обработкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построениеРядаToolStripMenuItem1,
            this.menuEmpiricFunction,
            this.menuNumericCharacteristics,
            this.проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem});
			this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
			this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.обработкаToolStripMenuItem.Text = "Обработка";
			// 
			// построениеРядаToolStripMenuItem1
			// 
			this.построениеРядаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStatFreq,
            this.menuStatRelFreq,
            this.menuIntervalFreq,
            this.menuIntervalRelFreq,
            this.menuGroupFreq,
            this.menuGroupRelFreq});
			this.построениеРядаToolStripMenuItem1.Name = "построениеРядаToolStripMenuItem1";
			this.построениеРядаToolStripMenuItem1.Size = new System.Drawing.Size(347, 22);
			this.построениеРядаToolStripMenuItem1.Text = "Построение ряда";
			// 
			// menuStatFreq
			// 
			this.menuStatFreq.Name = "menuStatFreq";
			this.menuStatFreq.Size = new System.Drawing.Size(318, 22);
			this.menuStatFreq.Text = "Статистический ряд частот";
			this.menuStatFreq.Click += new System.EventHandler(this.menuStatFreq_Click);
			// 
			// menuStatRelFreq
			// 
			this.menuStatRelFreq.Name = "menuStatRelFreq";
			this.menuStatRelFreq.Size = new System.Drawing.Size(318, 22);
			this.menuStatRelFreq.Text = "Статистический ряд относительных частот";
			this.menuStatRelFreq.Click += new System.EventHandler(this.menuStatRelFreq_Click);
			// 
			// menuIntervalFreq
			// 
			this.menuIntervalFreq.Name = "menuIntervalFreq";
			this.menuIntervalFreq.Size = new System.Drawing.Size(318, 22);
			this.menuIntervalFreq.Text = "Интервальный ряд частот";
			this.menuIntervalFreq.Click += new System.EventHandler(this.menuIntervalFreq_Click);
			// 
			// menuIntervalRelFreq
			// 
			this.menuIntervalRelFreq.Name = "menuIntervalRelFreq";
			this.menuIntervalRelFreq.Size = new System.Drawing.Size(318, 22);
			this.menuIntervalRelFreq.Text = "Интервальный ряд относительных частот";
			this.menuIntervalRelFreq.Click += new System.EventHandler(this.menuIntervalRelFreq_Click);
			// 
			// menuGroupFreq
			// 
			this.menuGroupFreq.Name = "menuGroupFreq";
			this.menuGroupFreq.Size = new System.Drawing.Size(318, 22);
			this.menuGroupFreq.Text = "Группированный ряд частот";
			this.menuGroupFreq.Click += new System.EventHandler(this.menuGroupFreq_Click);
			// 
			// menuGroupRelFreq
			// 
			this.menuGroupRelFreq.Name = "menuGroupRelFreq";
			this.menuGroupRelFreq.Size = new System.Drawing.Size(318, 22);
			this.menuGroupRelFreq.Text = "Группированный ряд относительных частот";
			this.menuGroupRelFreq.Click += new System.EventHandler(this.menuGroupRelFreq_Click);
			// 
			// menuEmpiricFunction
			// 
			this.menuEmpiricFunction.Name = "menuEmpiricFunction";
			this.menuEmpiricFunction.Size = new System.Drawing.Size(347, 22);
			this.menuEmpiricFunction.Text = "Эмпирическая функция распределения";
			this.menuEmpiricFunction.Click += new System.EventHandler(this.menuEmpiricFunction_Click);
			// 
			// menuNumericCharacteristics
			// 
			this.menuNumericCharacteristics.Name = "menuNumericCharacteristics";
			this.menuNumericCharacteristics.Size = new System.Drawing.Size(347, 22);
			this.menuNumericCharacteristics.Text = "Расчет числовых характеристик";
			this.menuNumericCharacteristics.Click += new System.EventHandler(this.menuNumericCharacteristics_Click);
			// 
			// проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem
			// 
			this.проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCheckNormal,
            this.menuCheckBinomial});
			this.проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem.Name = "проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem";
			this.проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem.Size = new System.Drawing.Size(347, 22);
			this.проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem.Text = "Проверка гипотезы о виде закона распределения";
			// 
			// menuCheckNormal
			// 
			this.menuCheckNormal.Name = "menuCheckNormal";
			this.menuCheckNormal.Size = new System.Drawing.Size(244, 22);
			this.menuCheckNormal.Text = "Нормальное распределение";
			this.menuCheckNormal.Click += new System.EventHandler(this.menuCheckNormal_Click);
			// 
			// menuCheckBinomial
			// 
			this.menuCheckBinomial.Name = "menuCheckBinomial";
			this.menuCheckBinomial.Size = new System.Drawing.Size(244, 22);
			this.menuCheckBinomial.Text = "Биномиальное распределение";
			this.menuCheckBinomial.Click += new System.EventHandler(this.menuCheckBinomial_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnFreq);
			this.tabPage3.Controls.Add(this.gridFreqData);
			this.tabPage3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(305, 606);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Ряд частот";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btnFreq
			// 
			this.btnFreq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFreq.Location = new System.Drawing.Point(6, 563);
			this.btnFreq.Name = "btnFreq";
			this.btnFreq.Size = new System.Drawing.Size(293, 37);
			this.btnFreq.TabIndex = 7;
			this.btnFreq.Text = "Ввод";
			this.btnFreq.UseVisualStyleBackColor = true;
			this.btnFreq.Click += new System.EventHandler(this.btnFreq_Click);
			// 
			// gridFreqData
			// 
			this.gridFreqData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridFreqData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridFreqData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFreqData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.val,
            this.freq});
			this.gridFreqData.Location = new System.Drawing.Point(6, 6);
			this.gridFreqData.MultiSelect = false;
			this.gridFreqData.Name = "gridFreqData";
			this.gridFreqData.Size = new System.Drawing.Size(293, 551);
			this.gridFreqData.TabIndex = 6;
			// 
			// val
			// 
			this.val.HeaderText = "Значение";
			this.val.Name = "val";
			// 
			// freq
			// 
			this.freq.HeaderText = "Частота";
			this.freq.Name = "freq";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(324, 661);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(340, 700);
			this.Name = "MainForm";
			this.Text = "Статистическое распределение";
			this.groupBoxInterval.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numIntervals)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridIntervalData)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridFreqData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBoxInterval;
		private System.Windows.Forms.Button btnSeparate;
		private System.Windows.Forms.NumericUpDown numIntervals;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.DataGridView gridData;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnInterval;
		private System.Windows.Forms.DataGridView gridIntervalData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Key;
		private System.Windows.Forms.DataGridViewTextBoxColumn Value;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem построениеРядаToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuStatFreq;
		private System.Windows.Forms.ToolStripMenuItem menuStatRelFreq;
		private System.Windows.Forms.ToolStripMenuItem menuIntervalFreq;
		private System.Windows.Forms.ToolStripMenuItem menuIntervalRelFreq;
		private System.Windows.Forms.ToolStripMenuItem menuGroupFreq;
		private System.Windows.Forms.ToolStripMenuItem menuGroupRelFreq;
		private System.Windows.Forms.ToolStripMenuItem menuEmpiricFunction;
		private System.Windows.Forms.ToolStripMenuItem menuNumericCharacteristics;
		private System.Windows.Forms.ToolStripMenuItem проверкаГипотезыОВидеЗаконаРаспределенияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuCheckNormal;
		private System.Windows.Forms.ToolStripMenuItem menuCheckBinomial;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button btnFreq;
		private System.Windows.Forms.DataGridView gridFreqData;
		private System.Windows.Forms.DataGridViewTextBoxColumn val;
		private System.Windows.Forms.DataGridViewTextBoxColumn freq;
	}
}

