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
			this.panelData = new System.Windows.Forms.Panel();
			this.btnOpen = new System.Windows.Forms.Button();
			this.gridData = new System.Windows.Forms.DataGridView();
			this.panelControls = new System.Windows.Forms.Panel();
			this.btnCharasteristic = new System.Windows.Forms.Button();
			this.groupBoxData = new System.Windows.Forms.GroupBox();
			this.btnGroupRelFreq = new System.Windows.Forms.Button();
			this.btnGroupFreq = new System.Windows.Forms.Button();
			this.btnIntervalRelFreq = new System.Windows.Forms.Button();
			this.btnIntervalFreq = new System.Windows.Forms.Button();
			this.btnStatRelFreq = new System.Windows.Forms.Button();
			this.btnStatFreq = new System.Windows.Forms.Button();
			this.groupBoxInterval = new System.Windows.Forms.GroupBox();
			this.btnSeparate = new System.Windows.Forms.Button();
			this.numIntervals = new System.Windows.Forms.NumericUpDown();
			this.panelData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			this.panelControls.SuspendLayout();
			this.groupBoxData.SuspendLayout();
			this.groupBoxInterval.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numIntervals)).BeginInit();
			this.SuspendLayout();
			// 
			// panelData
			// 
			this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelData.Controls.Add(this.btnOpen);
			this.panelData.Controls.Add(this.gridData);
			this.panelData.Location = new System.Drawing.Point(13, 13);
			this.panelData.Name = "panelData";
			this.panelData.Size = new System.Drawing.Size(297, 566);
			this.panelData.TabIndex = 0;
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOpen.Location = new System.Drawing.Point(3, 3);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(291, 37);
			this.btnOpen.TabIndex = 2;
			this.btnOpen.Text = "Открыть выборку";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
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
			this.gridData.Location = new System.Drawing.Point(3, 46);
			this.gridData.Name = "gridData";
			this.gridData.RowHeadersVisible = false;
			this.gridData.Size = new System.Drawing.Size(291, 517);
			this.gridData.TabIndex = 0;
			// 
			// panelControls
			// 
			this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panelControls.Controls.Add(this.btnCharasteristic);
			this.panelControls.Controls.Add(this.groupBoxData);
			this.panelControls.Controls.Add(this.groupBoxInterval);
			this.panelControls.Location = new System.Drawing.Point(317, 13);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new System.Drawing.Size(221, 568);
			this.panelControls.TabIndex = 1;
			// 
			// btnCharasteristic
			// 
			this.btnCharasteristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCharasteristic.Location = new System.Drawing.Point(11, 502);
			this.btnCharasteristic.Name = "btnCharasteristic";
			this.btnCharasteristic.Size = new System.Drawing.Size(202, 58);
			this.btnCharasteristic.TabIndex = 9;
			this.btnCharasteristic.Text = "Расчет числовых характиристик";
			this.btnCharasteristic.UseVisualStyleBackColor = true;
			this.btnCharasteristic.Click += new System.EventHandler(this.btnCharasteristic_Click);
			// 
			// groupBoxData
			// 
			this.groupBoxData.Controls.Add(this.btnGroupRelFreq);
			this.groupBoxData.Controls.Add(this.btnGroupFreq);
			this.groupBoxData.Controls.Add(this.btnIntervalRelFreq);
			this.groupBoxData.Controls.Add(this.btnIntervalFreq);
			this.groupBoxData.Controls.Add(this.btnStatRelFreq);
			this.groupBoxData.Controls.Add(this.btnStatFreq);
			this.groupBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBoxData.Location = new System.Drawing.Point(5, 74);
			this.groupBoxData.Name = "groupBoxData";
			this.groupBoxData.Size = new System.Drawing.Size(215, 422);
			this.groupBoxData.TabIndex = 8;
			this.groupBoxData.TabStop = false;
			this.groupBoxData.Text = "Построение рядов";
			// 
			// btnGroupRelFreq
			// 
			this.btnGroupRelFreq.Location = new System.Drawing.Point(6, 356);
			this.btnGroupRelFreq.Name = "btnGroupRelFreq";
			this.btnGroupRelFreq.Size = new System.Drawing.Size(202, 58);
			this.btnGroupRelFreq.TabIndex = 5;
			this.btnGroupRelFreq.Text = "Группированный ряд относительных частот";
			this.btnGroupRelFreq.UseVisualStyleBackColor = true;
			this.btnGroupRelFreq.Click += new System.EventHandler(this.btnGroupRelFreq_Click);
			// 
			// btnGroupFreq
			// 
			this.btnGroupFreq.Location = new System.Drawing.Point(6, 292);
			this.btnGroupFreq.Name = "btnGroupFreq";
			this.btnGroupFreq.Size = new System.Drawing.Size(202, 58);
			this.btnGroupFreq.TabIndex = 4;
			this.btnGroupFreq.Text = "Группированный ряд частот";
			this.btnGroupFreq.UseVisualStyleBackColor = true;
			this.btnGroupFreq.Click += new System.EventHandler(this.btnGroupFreq_Click);
			// 
			// btnIntervalRelFreq
			// 
			this.btnIntervalRelFreq.Location = new System.Drawing.Point(6, 228);
			this.btnIntervalRelFreq.Name = "btnIntervalRelFreq";
			this.btnIntervalRelFreq.Size = new System.Drawing.Size(202, 58);
			this.btnIntervalRelFreq.TabIndex = 3;
			this.btnIntervalRelFreq.Text = "Интервальный ряд относительных частот";
			this.btnIntervalRelFreq.UseVisualStyleBackColor = true;
			this.btnIntervalRelFreq.Click += new System.EventHandler(this.btnIntervalRelFreq_Click);
			// 
			// btnIntervalFreq
			// 
			this.btnIntervalFreq.Location = new System.Drawing.Point(6, 164);
			this.btnIntervalFreq.Name = "btnIntervalFreq";
			this.btnIntervalFreq.Size = new System.Drawing.Size(202, 58);
			this.btnIntervalFreq.TabIndex = 2;
			this.btnIntervalFreq.Text = "Интервальный ряд частот";
			this.btnIntervalFreq.UseVisualStyleBackColor = true;
			this.btnIntervalFreq.Click += new System.EventHandler(this.btnIntervalFreq_Click);
			// 
			// btnStatRelFreq
			// 
			this.btnStatRelFreq.Location = new System.Drawing.Point(7, 100);
			this.btnStatRelFreq.Name = "btnStatRelFreq";
			this.btnStatRelFreq.Size = new System.Drawing.Size(202, 58);
			this.btnStatRelFreq.TabIndex = 1;
			this.btnStatRelFreq.Text = "Статистический ряд относительных частот";
			this.btnStatRelFreq.UseVisualStyleBackColor = true;
			this.btnStatRelFreq.Click += new System.EventHandler(this.btnStatRelFreq_Click);
			// 
			// btnStatFreq
			// 
			this.btnStatFreq.Location = new System.Drawing.Point(7, 36);
			this.btnStatFreq.Name = "btnStatFreq";
			this.btnStatFreq.Size = new System.Drawing.Size(202, 58);
			this.btnStatFreq.TabIndex = 0;
			this.btnStatFreq.Text = "Статистический ряд частот";
			this.btnStatFreq.UseVisualStyleBackColor = true;
			this.btnStatFreq.Click += new System.EventHandler(this.btnStatFreq_Click);
			// 
			// groupBoxInterval
			// 
			this.groupBoxInterval.Controls.Add(this.btnSeparate);
			this.groupBoxInterval.Controls.Add(this.numIntervals);
			this.groupBoxInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBoxInterval.Location = new System.Drawing.Point(4, 4);
			this.groupBoxInterval.Name = "groupBoxInterval";
			this.groupBoxInterval.Size = new System.Drawing.Size(216, 64);
			this.groupBoxInterval.TabIndex = 7;
			this.groupBoxInterval.TabStop = false;
			this.groupBoxInterval.Text = "Разбиение на интервалы";
			// 
			// btnSeparate
			// 
			this.btnSeparate.Location = new System.Drawing.Point(106, 26);
			this.btnSeparate.Name = "btnSeparate";
			this.btnSeparate.Size = new System.Drawing.Size(104, 26);
			this.btnSeparate.TabIndex = 1;
			this.btnSeparate.Text = "Разбить";
			this.btnSeparate.UseVisualStyleBackColor = true;
			this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click);
			// 
			// numIntervals
			// 
			this.numIntervals.DecimalPlaces = 2;
			this.numIntervals.Location = new System.Drawing.Point(7, 26);
			this.numIntervals.Name = "numIntervals";
			this.numIntervals.Size = new System.Drawing.Size(93, 26);
			this.numIntervals.TabIndex = 0;
			this.numIntervals.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(549, 591);
			this.Controls.Add(this.panelControls);
			this.Controls.Add(this.panelData);
			this.MinimumSize = new System.Drawing.Size(565, 630);
			this.Name = "MainForm";
			this.Text = "Статистическое распределение";
			this.panelData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
			this.panelControls.ResumeLayout(false);
			this.groupBoxData.ResumeLayout(false);
			this.groupBoxInterval.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numIntervals)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelData;
		private System.Windows.Forms.DataGridView gridData;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Panel panelControls;
		private System.Windows.Forms.Button btnCharasteristic;
		private System.Windows.Forms.GroupBox groupBoxData;
		private System.Windows.Forms.Button btnGroupRelFreq;
		private System.Windows.Forms.Button btnGroupFreq;
		private System.Windows.Forms.Button btnIntervalRelFreq;
		private System.Windows.Forms.Button btnIntervalFreq;
		private System.Windows.Forms.Button btnStatRelFreq;
		private System.Windows.Forms.Button btnStatFreq;
		private System.Windows.Forms.GroupBox groupBoxInterval;
		private System.Windows.Forms.Button btnSeparate;
		private System.Windows.Forms.NumericUpDown numIntervals;
	}
}

