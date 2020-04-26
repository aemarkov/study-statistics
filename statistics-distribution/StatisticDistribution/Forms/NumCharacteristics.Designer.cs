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
			this.tbMean = new System.Windows.Forms.TextBox();
			this.tbDispersion = new System.Windows.Forms.TextBox();
			this.tbStandartDeviation = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCentralMoment = new System.Windows.Forms.Button();
			this.tbCentralMoment = new System.Windows.Forms.TextBox();
			this.btnStartMoment = new System.Windows.Forms.Button();
			this.tbStartMoment = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numStartMoment = new System.Windows.Forms.NumericUpDown();
			this.numCentralMoment = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStartMoment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCentralMoment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
			this.label2.Location = new System.Drawing.Point(12, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Дисперсия";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(11, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 48);
			this.label3.TabIndex = 0;
			this.label3.Text = "Выборочное среднее квадратическое отклонение";
			// 
			// tbMean
			// 
			this.tbMean.Location = new System.Drawing.Point(6, 19);
			this.tbMean.Name = "tbMean";
			this.tbMean.ReadOnly = true;
			this.tbMean.Size = new System.Drawing.Size(215, 20);
			this.tbMean.TabIndex = 1;
			// 
			// tbDispersion
			// 
			this.tbDispersion.Location = new System.Drawing.Point(6, 65);
			this.tbDispersion.Name = "tbDispersion";
			this.tbDispersion.ReadOnly = true;
			this.tbDispersion.Size = new System.Drawing.Size(215, 20);
			this.tbDispersion.TabIndex = 1;
			// 
			// tbStandartDeviation
			// 
			this.tbStandartDeviation.Location = new System.Drawing.Point(6, 116);
			this.tbStandartDeviation.Name = "tbStandartDeviation";
			this.tbStandartDeviation.ReadOnly = true;
			this.tbStandartDeviation.Size = new System.Drawing.Size(215, 20);
			this.tbStandartDeviation.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCentralMoment);
			this.groupBox1.Controls.Add(this.tbCentralMoment);
			this.groupBox1.Controls.Add(this.btnStartMoment);
			this.groupBox1.Controls.Add(this.tbStartMoment);
			this.groupBox1.Controls.Add(this.tbStandartDeviation);
			this.groupBox1.Controls.Add(this.tbMean);
			this.groupBox1.Controls.Add(this.tbDispersion);
			this.groupBox1.Location = new System.Drawing.Point(325, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(236, 307);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Значения характеристик";
			// 
			// btnCentralMoment
			// 
			this.btnCentralMoment.Location = new System.Drawing.Point(169, 277);
			this.btnCentralMoment.Name = "btnCentralMoment";
			this.btnCentralMoment.Size = new System.Drawing.Size(57, 20);
			this.btnCentralMoment.TabIndex = 7;
			this.btnCentralMoment.Text = "Расчет";
			this.btnCentralMoment.UseVisualStyleBackColor = true;
			this.btnCentralMoment.Click += new System.EventHandler(this.btnCentralMoment_Click);
			// 
			// tbCentralMoment
			// 
			this.tbCentralMoment.Location = new System.Drawing.Point(6, 276);
			this.tbCentralMoment.Name = "tbCentralMoment";
			this.tbCentralMoment.ReadOnly = true;
			this.tbCentralMoment.Size = new System.Drawing.Size(157, 20);
			this.tbCentralMoment.TabIndex = 6;
			// 
			// btnStartMoment
			// 
			this.btnStartMoment.Location = new System.Drawing.Point(169, 198);
			this.btnStartMoment.Name = "btnStartMoment";
			this.btnStartMoment.Size = new System.Drawing.Size(57, 20);
			this.btnStartMoment.TabIndex = 5;
			this.btnStartMoment.Text = "Расчет";
			this.btnStartMoment.UseVisualStyleBackColor = true;
			this.btnStartMoment.Click += new System.EventHandler(this.btnStartMoment_Click);
			// 
			// tbStartMoment
			// 
			this.tbStartMoment.Location = new System.Drawing.Point(6, 198);
			this.tbStartMoment.Name = "tbStartMoment";
			this.tbStartMoment.ReadOnly = true;
			this.tbStartMoment.Size = new System.Drawing.Size(157, 20);
			this.tbStartMoment.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 42);
			this.label5.TabIndex = 3;
			this.label5.Text = "Начальный выборочный момент порядка";
			// 
			// numStartMoment
			// 
			this.numStartMoment.Location = new System.Drawing.Point(15, 214);
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
			this.numCentralMoment.Location = new System.Drawing.Point(14, 292);
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
			this.label6.Location = new System.Drawing.Point(11, 247);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 42);
			this.label6.TabIndex = 5;
			this.label6.Text = "Центральный выборочный момент порядка";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::StatisticDistribution.Properties.Resources.mean;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(132, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(187, 43);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::StatisticDistribution.Properties.Resources.dispertion;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(131, 70);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(187, 43);
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::StatisticDistribution.Properties.Resources.stat_standart_deviation;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Location = new System.Drawing.Point(132, 119);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(187, 43);
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImage = global::StatisticDistribution.Properties.Resources.start_moment;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Location = new System.Drawing.Point(135, 191);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(187, 43);
			this.pictureBox4.TabIndex = 10;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackgroundImage = global::StatisticDistribution.Properties.Resources.central_moment;
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox5.Location = new System.Drawing.Point(134, 269);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(187, 43);
			this.pictureBox5.TabIndex = 11;
			this.pictureBox5.TabStop = false;
			// 
			// NumCharacteristics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(575, 326);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.numCentralMoment);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numStartMoment);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "NumCharacteristics";
			this.Text = "Числовые характеристики ряда распределения";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStartMoment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCentralMoment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMean;
        private System.Windows.Forms.TextBox tbDispersion;
        private System.Windows.Forms.TextBox tbStandartDeviation;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCentralMoment;
		private System.Windows.Forms.TextBox tbCentralMoment;
		private System.Windows.Forms.Button btnStartMoment;
		private System.Windows.Forms.TextBox tbStartMoment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numStartMoment;
		private System.Windows.Forms.NumericUpDown numCentralMoment;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
	}
}