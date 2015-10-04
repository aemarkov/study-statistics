namespace StatisticDistribution
{
    partial class NumCharacteristics
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbMean = new System.Windows.Forms.TextBox();
			this.tbDispersion = new System.Windows.Forms.TextBox();
			this.tbStandartDeviation = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCentralMoment = new System.Windows.Forms.Button();
			this.tbCentralMoment = new System.Windows.Forms.TextBox();
			this.btnStartMoment = new System.Windows.Forms.Button();
			this.tbStartMoment = new System.Windows.Forms.TextBox();
			this.tbSDispersion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numStartMoment = new System.Windows.Forms.NumericUpDown();
			this.numCentralMoment = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStartMoment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCentralMoment)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выборочное среднее";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 42);
			this.label2.TabIndex = 0;
			this.label2.Text = "Смещенная оценка генеральной дисперсии";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 48);
			this.label3.TabIndex = 0;
			this.label3.Text = "Выборочное среднее квадратическое отклонение";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 41);
			this.label4.TabIndex = 0;
			this.label4.Text = "Несмещенная оценка генеральной дисперсии";
			// 
			// tbMean
			// 
			this.tbMean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbMean.Location = new System.Drawing.Point(6, 19);
			this.tbMean.Name = "tbMean";
			this.tbMean.ReadOnly = true;
			this.tbMean.Size = new System.Drawing.Size(221, 20);
			this.tbMean.TabIndex = 1;
			// 
			// tbDispersion
			// 
			this.tbDispersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDispersion.Location = new System.Drawing.Point(6, 45);
			this.tbDispersion.Name = "tbDispersion";
			this.tbDispersion.ReadOnly = true;
			this.tbDispersion.Size = new System.Drawing.Size(221, 20);
			this.tbDispersion.TabIndex = 1;
			// 
			// tbStandartDeviation
			// 
			this.tbStandartDeviation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbStandartDeviation.Location = new System.Drawing.Point(6, 97);
			this.tbStandartDeviation.Name = "tbStandartDeviation";
			this.tbStandartDeviation.ReadOnly = true;
			this.tbStandartDeviation.Size = new System.Drawing.Size(221, 20);
			this.tbStandartDeviation.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnCentralMoment);
			this.groupBox1.Controls.Add(this.tbCentralMoment);
			this.groupBox1.Controls.Add(this.btnStartMoment);
			this.groupBox1.Controls.Add(this.tbStartMoment);
			this.groupBox1.Controls.Add(this.tbSDispersion);
			this.groupBox1.Controls.Add(this.tbStandartDeviation);
			this.groupBox1.Controls.Add(this.tbMean);
			this.groupBox1.Controls.Add(this.tbDispersion);
			this.groupBox1.Location = new System.Drawing.Point(145, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(227, 354);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Значения характеристик";
			// 
			// btnCentralMoment
			// 
			this.btnCentralMoment.Location = new System.Drawing.Point(170, 303);
			this.btnCentralMoment.Name = "btnCentralMoment";
			this.btnCentralMoment.Size = new System.Drawing.Size(57, 20);
			this.btnCentralMoment.TabIndex = 7;
			this.btnCentralMoment.Text = "Расчет";
			this.btnCentralMoment.UseVisualStyleBackColor = true;
			this.btnCentralMoment.Click += new System.EventHandler(this.btnCentralMoment_Click);
			// 
			// tbCentralMoment
			// 
			this.tbCentralMoment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCentralMoment.Location = new System.Drawing.Point(6, 303);
			this.tbCentralMoment.Name = "tbCentralMoment";
			this.tbCentralMoment.ReadOnly = true;
			this.tbCentralMoment.Size = new System.Drawing.Size(157, 20);
			this.tbCentralMoment.TabIndex = 6;
			// 
			// btnStartMoment
			// 
			this.btnStartMoment.Location = new System.Drawing.Point(170, 227);
			this.btnStartMoment.Name = "btnStartMoment";
			this.btnStartMoment.Size = new System.Drawing.Size(57, 20);
			this.btnStartMoment.TabIndex = 5;
			this.btnStartMoment.Text = "Расчет";
			this.btnStartMoment.UseVisualStyleBackColor = true;
			this.btnStartMoment.Click += new System.EventHandler(this.btnStartMoment_Click);
			// 
			// tbStartMoment
			// 
			this.tbStartMoment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbStartMoment.Location = new System.Drawing.Point(6, 227);
			this.tbStartMoment.Name = "tbStartMoment";
			this.tbStartMoment.ReadOnly = true;
			this.tbStartMoment.Size = new System.Drawing.Size(157, 20);
			this.tbStartMoment.TabIndex = 4;
			// 
			// tbSDispersion
			// 
			this.tbSDispersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSDispersion.Location = new System.Drawing.Point(6, 151);
			this.tbSDispersion.Name = "tbSDispersion";
			this.tbSDispersion.ReadOnly = true;
			this.tbSDispersion.Size = new System.Drawing.Size(221, 20);
			this.tbSDispersion.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 217);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 42);
			this.label5.TabIndex = 3;
			this.label5.Text = "Начальный выборочный момент порядка";
			// 
			// numStartMoment
			// 
			this.numStartMoment.Location = new System.Drawing.Point(12, 261);
			this.numStartMoment.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numStartMoment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numStartMoment.Name = "numStartMoment";
			this.numStartMoment.Size = new System.Drawing.Size(114, 20);
			this.numStartMoment.TabIndex = 4;
			this.numStartMoment.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numCentralMoment
			// 
			this.numCentralMoment.Location = new System.Drawing.Point(11, 337);
			this.numCentralMoment.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numCentralMoment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numCentralMoment.Name = "numCentralMoment";
			this.numCentralMoment.Size = new System.Drawing.Size(114, 20);
			this.numCentralMoment.TabIndex = 6;
			this.numCentralMoment.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 293);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 42);
			this.label6.TabIndex = 5;
			this.label6.Text = "Центральный выборочный момент порядка";
			// 
			// NumCharacteristics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 376);
			this.Controls.Add(this.numCentralMoment);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numStartMoment);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "NumCharacteristics";
			this.Text = "Числовые характеристики ряда распределения";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStartMoment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCentralMoment)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMean;
        private System.Windows.Forms.TextBox tbDispersion;
        private System.Windows.Forms.TextBox tbStandartDeviation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSDispersion;
		private System.Windows.Forms.Button btnCentralMoment;
		private System.Windows.Forms.TextBox tbCentralMoment;
		private System.Windows.Forms.Button btnStartMoment;
		private System.Windows.Forms.TextBox tbStartMoment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numStartMoment;
		private System.Windows.Forms.NumericUpDown numCentralMoment;
		private System.Windows.Forms.Label label6;
	}
}