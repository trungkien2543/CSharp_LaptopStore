namespace CustomTabControl
{
    partial class NhapHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitle = new Panel();
            lbThongKe = new Label();
            panelTK1 = new Panel();
            comboBoxYear = new ComboBox();
            label2 = new Label();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panelLine = new Panel();
            panelTK2 = new Panel();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            panelTitle.SuspendLayout();
            panelTK1.SuspendLayout();
            panelTK2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(lbThongKe);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1125, 89);
            panelTitle.TabIndex = 0;
            // 
            // lbThongKe
            // 
            lbThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbThongKe.AutoSize = true;
            lbThongKe.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThongKe.ForeColor = Color.ForestGreen;
            lbThongKe.Location = new Point(324, 19);
            lbThongKe.Name = "lbThongKe";
            lbThongKe.Size = new Size(439, 50);
            lbThongKe.TabIndex = 2;
            lbThongKe.Text = "Số lượng nhập hàng\r\n";
            lbThongKe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTK1
            // 
            panelTK1.Controls.Add(comboBoxYear);
            panelTK1.Controls.Add(label2);
            panelTK1.Controls.Add(plotView1);
            panelTK1.Dock = DockStyle.Top;
            panelTK1.Location = new Point(0, 89);
            panelTK1.Name = "panelTK1";
            panelTK1.Size = new Size(1125, 395);
            panelTK1.TabIndex = 1;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(42, 131);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(151, 28);
            comboBoxYear.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 83);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 13;
            label2.Text = "Chọn năm :";
            // 
            // plotView1
            // 
            plotView1.Location = new Point(250, 16);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(872, 347);
            plotView1.TabIndex = 0;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            plotView1.Click += plotView1_Click;
            // 
            // panelLine
            // 
            panelLine.BackColor = Color.ForestGreen;
            panelLine.Dock = DockStyle.Top;
            panelLine.Location = new Point(0, 484);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(1125, 5);
            panelLine.TabIndex = 2;
            // 
            // panelTK2
            // 
            panelTK2.Controls.Add(plotView2);
            panelTK2.Dock = DockStyle.Fill;
            panelTK2.Location = new Point(0, 489);
            panelTK2.Name = "panelTK2";
            panelTK2.Size = new Size(1125, 398);
            panelTK2.TabIndex = 3;
            // 
            // plotView2
            // 
            plotView2.Location = new Point(178, 30);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(834, 343);
            plotView2.TabIndex = 0;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // NhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(panelTK2);
            Controls.Add(panelLine);
            Controls.Add(panelTK1);
            Controls.Add(panelTitle);
            Name = "NhapHang";
            Size = new Size(1125, 887);
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelTK1.ResumeLayout(false);
            panelTK1.PerformLayout();
            panelTK2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label lbThongKe;
        private Panel panelTK1;
        private Panel panelLine;
        private Panel panelTK2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label label2;
        private ComboBox comboBoxYear;
        private OxyPlot.WindowsForms.PlotView plotView2;
    }
}
