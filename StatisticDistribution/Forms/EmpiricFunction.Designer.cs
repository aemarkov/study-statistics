namespace StatisticDistribution
{
	partial class EmpiricFunction
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
			this.graph = new ZedGraph.ZedGraphControl();
			this.imgBracket = new System.Windows.Forms.PictureBox();
			this.lblFX = new System.Windows.Forms.Label();
			this.panelFunc = new System.Windows.Forms.Panel();
			this.lblA0 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgBracket)).BeginInit();
			this.panelFunc.SuspendLayout();
			this.SuspendLayout();
			// 
			// graph
			// 
			this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.graph.IsAutoScrollRange = false;
			this.graph.IsEnableHPan = true;
			this.graph.IsEnableHZoom = true;
			this.graph.IsEnableVPan = true;
			this.graph.IsEnableVZoom = true;
			this.graph.IsPrintFillPage = true;
			this.graph.IsPrintKeepAspectRatio = true;
			this.graph.IsScrollY2 = false;
			this.graph.IsShowContextMenu = true;
			this.graph.IsShowCopyMessage = true;
			this.graph.IsShowCursorValues = false;
			this.graph.IsShowHScrollBar = false;
			this.graph.IsShowPointValues = false;
			this.graph.IsShowVScrollBar = false;
			this.graph.IsZoomOnMouseCenter = false;
			this.graph.Location = new System.Drawing.Point(12, 12);
			this.graph.Name = "graph";
			this.graph.PanButtons = System.Windows.Forms.MouseButtons.Left;
			this.graph.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
			this.graph.PanModifierKeys2 = System.Windows.Forms.Keys.None;
			this.graph.PointDateFormat = "g";
			this.graph.PointValueFormat = "G";
			this.graph.ScrollMaxX = 0D;
			this.graph.ScrollMaxY = 0D;
			this.graph.ScrollMaxY2 = 0D;
			this.graph.ScrollMinX = 0D;
			this.graph.ScrollMinY = 0D;
			this.graph.ScrollMinY2 = 0D;
			this.graph.Size = new System.Drawing.Size(573, 488);
			this.graph.TabIndex = 0;
			this.graph.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
			this.graph.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
			this.graph.ZoomModifierKeys = System.Windows.Forms.Keys.None;
			this.graph.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
			this.graph.ZoomStepFraction = 0.1D;
			// 
			// imgBracket
			// 
			this.imgBracket.BackgroundImage = global::StatisticDistribution.Properties.Resources.system;
			this.imgBracket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.imgBracket.InitialImage = global::StatisticDistribution.Properties.Resources.system;
			this.imgBracket.Location = new System.Drawing.Point(82, 3);
			this.imgBracket.Name = "imgBracket";
			this.imgBracket.Size = new System.Drawing.Size(27, 185);
			this.imgBracket.TabIndex = 1;
			this.imgBracket.TabStop = false;
			// 
			// lblFX
			// 
			this.lblFX.AutoSize = true;
			this.lblFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblFX.Location = new System.Drawing.Point(3, 84);
			this.lblFX.Name = "lblFX";
			this.lblFX.Size = new System.Drawing.Size(73, 25);
			this.lblFX.TabIndex = 2;
			this.lblFX.Text = "F*(X)=";
			// 
			// panelFunc
			// 
			this.panelFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelFunc.Controls.Add(this.lblA0);
			this.panelFunc.Controls.Add(this.lblFX);
			this.panelFunc.Controls.Add(this.imgBracket);
			this.panelFunc.Location = new System.Drawing.Point(591, 64);
			this.panelFunc.Name = "panelFunc";
			this.panelFunc.Size = new System.Drawing.Size(279, 436);
			this.panelFunc.TabIndex = 3;
			// 
			// lblA0
			// 
			this.lblA0.AutoSize = true;
			this.lblA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblA0.Location = new System.Drawing.Point(115, 13);
			this.lblA0.Name = "lblA0";
			this.lblA0.Size = new System.Drawing.Size(54, 15);
			this.lblA0.TabIndex = 3;
			this.lblA0.Text = "0, x<=A0";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(591, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(279, 49);
			this.label1.TabIndex = 4;
			this.label1.Text = "Эмпирическая функция распределния";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EmpiricFunction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(882, 512);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelFunc);
			this.Controls.Add(this.graph);
			this.Name = "EmpiricFunction";
			this.Text = "EmpiricFunction";
			((System.ComponentModel.ISupportInitialize)(this.imgBracket)).EndInit();
			this.panelFunc.ResumeLayout(false);
			this.panelFunc.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ZedGraph.ZedGraphControl graph;
		private System.Windows.Forms.PictureBox imgBracket;
		private System.Windows.Forms.Label lblFX;
		private System.Windows.Forms.Panel panelFunc;
		private System.Windows.Forms.Label lblA0;
		private System.Windows.Forms.Label label1;
	}
}