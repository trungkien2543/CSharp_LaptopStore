namespace CustomTabControl
{
    partial class DoanhThu
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
            panelTong = new Panel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1 = new Panel();
            ccbMonth = new ComboBox();
            lblMonth = new Label();
            ccbYear = new ComboBox();
            label2 = new Label();
            ccbType = new ComboBox();
            label6 = new Label();
            panelTitle = new Panel();
            lbThongKe = new Label();
            panelTong.SuspendLayout();
            panel1.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelTong
            // 
            panelTong.BackColor = SystemColors.ActiveCaption;
            panelTong.Controls.Add(cartesianChart1);
            panelTong.Controls.Add(panel1);
            panelTong.Controls.Add(panelTitle);
            panelTong.Dock = DockStyle.Fill;
            panelTong.Location = new Point(0, 0);
            panelTong.Margin = new Padding(3, 4, 3, 4);
            panelTong.Name = "panelTong";
            panelTong.Size = new Size(1125, 887);
            panelTong.TabIndex = 0;
            panelTong.Paint += panelTong_Paint;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart1.AutoScroll = true;
            cartesianChart1.Cursor = Cursors.Hand;
            cartesianChart1.Location = new Point(37, 196);
            cartesianChart1.Margin = new Padding(5, 5, 5, 5);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1057, 636);
            cartesianChart1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(ccbMonth);
            panel1.Controls.Add(lblMonth);
            panel1.Controls.Add(ccbYear);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ccbType);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 89);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 79);
            panel1.TabIndex = 11;
            // 
            // ccbMonth
            // 
            ccbMonth.FormattingEnabled = true;
            ccbMonth.Location = new Point(834, 19);
            ccbMonth.Name = "ccbMonth";
            ccbMonth.Size = new Size(151, 28);
            ccbMonth.TabIndex = 15;
            ccbMonth.SelectedIndexChanged += ccbMonth_SelectedIndexChanged;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.Location = new Point(726, 24);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(110, 23);
            lblMonth.TabIndex = 14;
            lblMonth.Text = "Chọn tháng :";
            // 
            // ccbYear
            // 
            ccbYear.FormattingEnabled = true;
            ccbYear.Location = new Point(491, 19);
            ccbYear.Name = "ccbYear";
            ccbYear.Size = new Size(151, 28);
            ccbYear.TabIndex = 13;
            ccbYear.SelectedIndexChanged += ccbYear_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(386, 20);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 12;
            label2.Text = "Chọn năm :";
            // 
            // ccbType
            // 
            ccbType.FormattingEnabled = true;
            ccbType.Location = new Point(174, 19);
            ccbType.Name = "ccbType";
            ccbType.Size = new Size(151, 28);
            ccbType.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 24);
            label6.Name = "label6";
            label6.Size = new Size(161, 23);
            label6.TabIndex = 10;
            label6.Text = "Chọn loại thống kê:";
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(lbThongKe);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1125, 89);
            panelTitle.TabIndex = 9;
            panelTitle.Paint += panelTitle_Paint;
            // 
            // lbThongKe
            // 
            lbThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbThongKe.AutoSize = true;
            lbThongKe.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThongKe.ForeColor = Color.FromArgb(0, 0, 192);
            lbThongKe.Location = new Point(342, 17);
            lbThongKe.Name = "lbThongKe";
            lbThongKe.Size = new Size(477, 50);
            lbThongKe.TabIndex = 1;
            lbThongKe.Text = "THỐNG KÊ DOANH THU\r\n";
            lbThongKe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTong);
            Name = "DoanhThu";
            Size = new Size(1125, 887);
            panelTong.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTong;
        private Panel panelTitle;
        private Label lbThongKe;
        private Panel panel1;
        private Label label6;
        private ComboBox ccbType;
        private Label label2;
        private ComboBox ccbYear;
        private Label lblMonth;
        private ComboBox ccbMonth;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}
