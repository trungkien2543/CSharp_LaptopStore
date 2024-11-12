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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelTitle = new Panel();
            lbThongKe = new Label();
            panelTK1 = new Panel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panelLine = new Panel();
            panelTK2 = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbxHang = new Guna.UI2.WinForms.Guna2ComboBox();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            comboBoxYear = new Guna.UI2.WinForms.Guna2ComboBox();
            panelTitle.SuspendLayout();
            panelTK1.SuspendLayout();
            panelTK2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(149, 147, 186);
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
            lbThongKe.ForeColor = Color.RebeccaPurple;
            lbThongKe.Location = new Point(201, 19);
            lbThongKe.Name = "lbThongKe";
            lbThongKe.Size = new Size(723, 50);
            lbThongKe.TabIndex = 2;
            lbThongKe.Text = "SỐ LƯỢNG NHẬP HÀNG VÀ TỒN KHO";
            lbThongKe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTK1
            // 
            panelTK1.BackColor = Color.FromArgb(149, 147, 186);
            panelTK1.Controls.Add(comboBoxYear);
            panelTK1.Controls.Add(guna2HtmlLabel2);
            panelTK1.Controls.Add(plotView1);
            panelTK1.Dock = DockStyle.Top;
            panelTK1.Location = new Point(0, 89);
            panelTK1.Name = "panelTK1";
            panelTK1.Size = new Size(1125, 395);
            panelTK1.TabIndex = 1;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(61, 72);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(109, 30);
            guna2HtmlLabel2.TabIndex = 18;
            guna2HtmlLabel2.Text = "Chọn năm : ";
            // 
            // plotView1
            // 
            plotView1.BackColor = Color.White;
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
            panelLine.BackColor = Color.RebeccaPurple;
            panelLine.Dock = DockStyle.Top;
            panelLine.Location = new Point(0, 484);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(1125, 5);
            panelLine.TabIndex = 2;
            // 
            // panelTK2
            // 
            panelTK2.BackColor = Color.FromArgb(149, 147, 186);
            panelTK2.Controls.Add(guna2HtmlLabel1);
            panelTK2.Controls.Add(cbxHang);
            panelTK2.Controls.Add(plotView2);
            panelTK2.Dock = DockStyle.Fill;
            panelTK2.Location = new Point(0, 489);
            panelTK2.Name = "panelTK2";
            panelTK2.Size = new Size(1125, 398);
            panelTK2.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(55, 116);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(115, 30);
            guna2HtmlLabel1.TabIndex = 17;
            guna2HtmlLabel1.Text = "Chọn hãng :";
            // 
            // cbxHang
            // 
            cbxHang.BackColor = Color.Transparent;
            cbxHang.CustomizableEdges = customizableEdges5;
            cbxHang.DrawMode = DrawMode.OwnerDrawFixed;
            cbxHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxHang.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxHang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxHang.Font = new Font("Segoe UI", 10F);
            cbxHang.ForeColor = Color.FromArgb(68, 88, 112);
            cbxHang.ItemHeight = 30;
            cbxHang.Location = new Point(28, 174);
            cbxHang.Name = "cbxHang";
            cbxHang.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbxHang.Size = new Size(175, 36);
            cbxHang.TabIndex = 15;
            // 
            // plotView2
            // 
            plotView2.BackColor = Color.White;
            plotView2.Location = new Point(250, 29);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(872, 347);
            plotView2.TabIndex = 0;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // comboBoxYear
            // 
            comboBoxYear.BackColor = Color.Transparent;
            comboBoxYear.CustomizableEdges = customizableEdges7;
            comboBoxYear.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.FocusedColor = Color.FromArgb(94, 148, 255);
            comboBoxYear.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboBoxYear.Font = new Font("Segoe UI", 10F);
            comboBoxYear.ForeColor = Color.FromArgb(68, 88, 112);
            comboBoxYear.ItemHeight = 30;
            comboBoxYear.Location = new Point(28, 135);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.ShadowDecoration.CustomizableEdges = customizableEdges8;
            comboBoxYear.Size = new Size(175, 36);
            comboBoxYear.TabIndex = 19;
            // 
            // NhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RebeccaPurple;
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
            panelTK2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label lbThongKe;
        private Panel panelTK1;
        private Panel panelLine;
        private Panel panelTK2;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxHang;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxYear;
    }
}
