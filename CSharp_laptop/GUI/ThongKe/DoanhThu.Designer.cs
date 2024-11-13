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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelTong = new Panel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1 = new Panel();
            lblEndDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblStartDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ccbMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            lblMonth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ccbYear = new Guna.UI2.WinForms.Guna2ComboBox();
            ccbType = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panelTitle = new Panel();
            lbThongKe = new Label();
            panelTong.SuspendLayout();
            panel1.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelTong
            // 
            panelTong.BackColor = Color.FromArgb(149, 147, 186);
            panelTong.Controls.Add(guna2HtmlLabel2);
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
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(345, 808);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(434, 30);
            guna2HtmlLabel2.TabIndex = 14;
            guna2HtmlLabel2.Text = "Biểu đồ đường thống kê doanh thu theo thời gian";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart1.AutoScroll = true;
            cartesianChart1.BackColor = Color.White;
            cartesianChart1.Cursor = Cursors.Hand;
            cartesianChart1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartesianChart1.Location = new Point(44, 178);
            cartesianChart1.Margin = new Padding(6);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1040, 599);
            cartesianChart1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblEndDate);
            panel1.Controls.Add(lblStartDate);
            panel1.Controls.Add(dtpEndDate);
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(ccbMonth);
            panel1.Controls.Add(lblMonth);
            panel1.Controls.Add(lblYear);
            panel1.Controls.Add(ccbYear);
            panel1.Controls.Add(ccbType);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 89);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 79);
            panel1.TabIndex = 11;
            // 
            // lblEndDate
            // 
            lblEndDate.BackColor = Color.Transparent;
            lblEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(881, 23);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(45, 30);
            lblEndDate.TabIndex = 28;
            lblEndDate.Text = "ĐẾN";
            // 
            // lblStartDate
            // 
            lblStartDate.BackColor = Color.Transparent;
            lblStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(528, 24);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(31, 30);
            lblStartDate.TabIndex = 24;
            lblStartDate.Text = "TỪ";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Checked = true;
            dtpEndDate.CustomizableEdges = customizableEdges1;
            dtpEndDate.FillColor = Color.FromArgb(192, 192, 255);
            dtpEndDate.Font = new Font("Segoe UI", 9F);
            dtpEndDate.Format = DateTimePickerFormat.Long;
            dtpEndDate.Location = new Point(942, 14);
            dtpEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpEndDate.Size = new Size(250, 45);
            dtpEndDate.TabIndex = 27;
            dtpEndDate.Value = new DateTime(2024, 11, 12, 19, 11, 4, 928);
            // 
            // dtpStartDate
            // 
            dtpStartDate.Checked = true;
            dtpStartDate.CustomizableEdges = customizableEdges3;
            dtpStartDate.FillColor = Color.FromArgb(192, 192, 255);
            dtpStartDate.Font = new Font("Segoe UI", 9F);
            dtpStartDate.Format = DateTimePickerFormat.Long;
            dtpStartDate.Location = new Point(569, 14);
            dtpStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpStartDate.Size = new Size(250, 45);
            dtpStartDate.TabIndex = 26;
            dtpStartDate.Value = new DateTime(2024, 11, 12, 19, 10, 15, 271);
            // 
            // ccbMonth
            // 
            ccbMonth.BackColor = Color.Transparent;
            ccbMonth.CustomizableEdges = customizableEdges5;
            ccbMonth.DrawMode = DrawMode.OwnerDrawFixed;
            ccbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            ccbMonth.FocusedColor = Color.FromArgb(94, 148, 255);
            ccbMonth.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ccbMonth.Font = new Font("Segoe UI", 10F);
            ccbMonth.ForeColor = Color.FromArgb(68, 88, 112);
            ccbMonth.ItemHeight = 30;
            ccbMonth.Location = new Point(974, 23);
            ccbMonth.Name = "ccbMonth";
            ccbMonth.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ccbMonth.Size = new Size(175, 36);
            ccbMonth.TabIndex = 25;
            ccbMonth.SelectedIndexChanged += ccbMonth_SelectedIndexChanged_1;
            // 
            // lblMonth
            // 
            lblMonth.BackColor = Color.Transparent;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMonth.Location = new Point(845, 23);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(123, 30);
            lblMonth.TabIndex = 24;
            lblMonth.Text = "Chọn tháng :";
            // 
            // lblYear
            // 
            lblYear.BackColor = Color.Transparent;
            lblYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(494, 24);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(109, 30);
            lblYear.TabIndex = 23;
            lblYear.Text = "Chọn năm :";
            // 
            // ccbYear
            // 
            ccbYear.BackColor = Color.Transparent;
            ccbYear.CustomizableEdges = customizableEdges7;
            ccbYear.DrawMode = DrawMode.OwnerDrawFixed;
            ccbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            ccbYear.FocusedColor = Color.FromArgb(94, 148, 255);
            ccbYear.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ccbYear.Font = new Font("Segoe UI", 10F);
            ccbYear.ForeColor = Color.FromArgb(68, 88, 112);
            ccbYear.ItemHeight = 30;
            ccbYear.Location = new Point(609, 23);
            ccbYear.Name = "ccbYear";
            ccbYear.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ccbYear.Size = new Size(175, 36);
            ccbYear.TabIndex = 22;
            ccbYear.SelectedIndexChanged += ccbYear_SelectedIndexChanged_1;
            // 
            // ccbType
            // 
            ccbType.BackColor = Color.Transparent;
            ccbType.CustomizableEdges = customizableEdges9;
            ccbType.DrawMode = DrawMode.OwnerDrawFixed;
            ccbType.DropDownStyle = ComboBoxStyle.DropDownList;
            ccbType.FocusedColor = Color.FromArgb(94, 148, 255);
            ccbType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ccbType.Font = new Font("Segoe UI", 10F);
            ccbType.ForeColor = Color.FromArgb(68, 88, 112);
            ccbType.ItemHeight = 30;
            ccbType.Location = new Point(212, 23);
            ccbType.Name = "ccbType";
            ccbType.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ccbType.Size = new Size(236, 36);
            ccbType.TabIndex = 20;
            ccbType.SelectedIndexChanged += ccbType_SelectedIndexChanged_4;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(13, 24);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(193, 30);
            guna2HtmlLabel1.TabIndex = 19;
            guna2HtmlLabel1.Text = "Chọn loại thống kê :";
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
            lbThongKe.ForeColor = Color.RebeccaPurple;
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
            panelTong.PerformLayout();
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
        private Label label2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox ccbType;
   
        private Guna.UI2.WinForms.Guna2ComboBox ccbYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMonth;
        private Guna.UI2.WinForms.Guna2ComboBox ccbMonth;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEndDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStartDate;
    }
}
