namespace Regression
{
	partial class DiagramForm
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
			this.components = new System.ComponentModel.Container();
			this.graph = new ZedGraph.ZedGraphControl();
			this.SuspendLayout();
			// 
			// graph
			// 
			this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.graph.Location = new System.Drawing.Point(13, 13);
			this.graph.Name = "graph";
			this.graph.ScrollGrace = 0D;
			this.graph.ScrollMaxX = 0D;
			this.graph.ScrollMaxY = 0D;
			this.graph.ScrollMaxY2 = 0D;
			this.graph.ScrollMinX = 0D;
			this.graph.ScrollMinY = 0D;
			this.graph.ScrollMinY2 = 0D;
			this.graph.Size = new System.Drawing.Size(559, 536);
			this.graph.TabIndex = 0;
			this.graph.UseExtendedPrintDialog = true;
			// 
			// DiagramForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 561);
			this.Controls.Add(this.graph);
			this.Name = "DiagramForm";
			this.Text = "Диаграмма рассеивания";
			this.ResumeLayout(false);

		}

		#endregion

		private ZedGraph.ZedGraphControl graph;
	}
}