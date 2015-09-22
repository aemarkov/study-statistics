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
            this.tbSDispersion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.tbMean.Size = new System.Drawing.Size(215, 20);
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
            this.tbDispersion.Size = new System.Drawing.Size(215, 20);
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
            this.tbStandartDeviation.Size = new System.Drawing.Size(215, 20);
            this.tbStandartDeviation.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbSDispersion);
            this.groupBox1.Controls.Add(this.tbStandartDeviation);
            this.groupBox1.Controls.Add(this.tbMean);
            this.groupBox1.Controls.Add(this.tbDispersion);
            this.groupBox1.Location = new System.Drawing.Point(145, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значения характеристик";
            // 
            // tbSDispersion
            // 
            this.tbSDispersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSDispersion.Location = new System.Drawing.Point(6, 151);
            this.tbSDispersion.Name = "tbSDispersion";
            this.tbSDispersion.ReadOnly = true;
            this.tbSDispersion.Size = new System.Drawing.Size(215, 20);
            this.tbSDispersion.TabIndex = 3;
            // 
            // NumCharacteristics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 217);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NumCharacteristics";
            this.Text = "Числовые характеристики ряда распределения";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}