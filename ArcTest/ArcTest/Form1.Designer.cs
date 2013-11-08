namespace ArcTest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xTrackBar = new System.Windows.Forms.TrackBar();
            this.yTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.thetaTrackBar = new System.Windows.Forms.TrackBar();
            this.eta1TrackBar = new System.Windows.Forms.TrackBar();
            this.eta2TrackBar = new System.Windows.Forms.TrackBar();
            this.drawingPanel1 = new ArcTest.DrawingPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eta1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eta2TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.drawingPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 580);
            this.splitContainer1.SplitterDistance = 780;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.xTrackBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.yTrackBar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.thetaTrackBar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.eta1TrackBar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.eta2TrackBar, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 580);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "RadiusY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "RadiusX";
            // 
            // xTrackBar
            // 
            this.xTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xTrackBar.Location = new System.Drawing.Point(12, 27);
            this.xTrackBar.Maximum = 200;
            this.xTrackBar.Minimum = 50;
            this.xTrackBar.Name = "xTrackBar";
            this.xTrackBar.Size = new System.Drawing.Size(223, 45);
            this.xTrackBar.TabIndex = 1;
            this.xTrackBar.TickFrequency = 10;
            this.xTrackBar.Value = 100;
            this.xTrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // yTrackBar
            // 
            this.yTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yTrackBar.Location = new System.Drawing.Point(12, 93);
            this.yTrackBar.Maximum = 200;
            this.yTrackBar.Minimum = 50;
            this.yTrackBar.Name = "yTrackBar";
            this.yTrackBar.Size = new System.Drawing.Size(223, 45);
            this.yTrackBar.TabIndex = 3;
            this.yTrackBar.TickFrequency = 10;
            this.yTrackBar.Value = 100;
            this.yTrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Theta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eta1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Eta2";
            // 
            // thetaTrackBar
            // 
            this.thetaTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thetaTrackBar.Location = new System.Drawing.Point(12, 159);
            this.thetaTrackBar.Maximum = 90;
            this.thetaTrackBar.Name = "thetaTrackBar";
            this.thetaTrackBar.Size = new System.Drawing.Size(223, 45);
            this.thetaTrackBar.TabIndex = 7;
            this.thetaTrackBar.TickFrequency = 10;
            this.thetaTrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // eta1TrackBar
            // 
            this.eta1TrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eta1TrackBar.Location = new System.Drawing.Point(12, 225);
            this.eta1TrackBar.Maximum = 360;
            this.eta1TrackBar.Minimum = -360;
            this.eta1TrackBar.Name = "eta1TrackBar";
            this.eta1TrackBar.Size = new System.Drawing.Size(223, 45);
            this.eta1TrackBar.TabIndex = 8;
            this.eta1TrackBar.TickFrequency = 100;
            this.eta1TrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // eta2TrackBar
            // 
            this.eta2TrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eta2TrackBar.Location = new System.Drawing.Point(12, 291);
            this.eta2TrackBar.Maximum = 360;
            this.eta2TrackBar.Minimum = -360;
            this.eta2TrackBar.Name = "eta2TrackBar";
            this.eta2TrackBar.Size = new System.Drawing.Size(223, 45);
            this.eta2TrackBar.TabIndex = 9;
            this.eta2TrackBar.TickFrequency = 100;
            this.eta2TrackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // drawingPanel1
            // 
            this.drawingPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel1.Location = new System.Drawing.Point(0, 0);
            this.drawingPanel1.Name = "drawingPanel1";
            this.drawingPanel1.Size = new System.Drawing.Size(780, 580);
            this.drawingPanel1.TabIndex = 0;
            this.drawingPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 580);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eta1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eta2TrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar xTrackBar;
        private System.Windows.Forms.TrackBar yTrackBar;
        private DrawingPanel drawingPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar thetaTrackBar;
        private System.Windows.Forms.TrackBar eta1TrackBar;
        private System.Windows.Forms.TrackBar eta2TrackBar;
    }
}

