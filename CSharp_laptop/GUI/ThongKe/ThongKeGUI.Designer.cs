namespace CustomTabControl
{
    partial class ThongKeGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnNhapHang = new Guna.UI2.WinForms.Guna2Button();
            btnHangLaptop = new Guna.UI2.WinForms.Guna2Button();
            btnDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelContainer = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNhapHang
            // 
            btnNhapHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnNhapHang.CheckedState.CustomBorderColor = Color.ForestGreen;
            btnNhapHang.CheckedState.FillColor = Color.White;
            btnNhapHang.CustomBorderColor = Color.White;
            btnNhapHang.CustomBorderThickness = new Padding(0, 0, 0, 4);
            btnNhapHang.CustomizableEdges = customizableEdges1;
            btnNhapHang.DisabledState.BorderColor = Color.DarkGray;
            btnNhapHang.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNhapHang.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNhapHang.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNhapHang.Dock = DockStyle.Fill;
            btnNhapHang.FillColor = Color.White;
            btnNhapHang.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhapHang.ForeColor = Color.Black;
            btnNhapHang.HoverState.CustomBorderColor = Color.ForestGreen;
            btnNhapHang.Location = new Point(659, 3);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNhapHang.Size = new Size(322, 57);
            btnNhapHang.TabIndex = 0;
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.Click += btnNhanVien_Click;
            // 
            // btnHangLaptop
            // 
            btnHangLaptop.BorderColor = Color.FromArgb(255, 128, 0);
            btnHangLaptop.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnHangLaptop.CheckedState.CustomBorderColor = Color.FromArgb(255, 128, 0);
            btnHangLaptop.CheckedState.FillColor = Color.White;
            btnHangLaptop.CustomBorderColor = Color.White;
            btnHangLaptop.CustomBorderThickness = new Padding(0, 0, 0, 4);
            btnHangLaptop.CustomizableEdges = customizableEdges3;
            btnHangLaptop.DisabledState.BorderColor = Color.DarkGray;
            btnHangLaptop.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHangLaptop.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHangLaptop.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHangLaptop.Dock = DockStyle.Fill;
            btnHangLaptop.FillColor = Color.White;
            btnHangLaptop.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHangLaptop.ForeColor = Color.Black;
            btnHangLaptop.HoverState.CustomBorderColor = Color.FromArgb(255, 128, 0);
            btnHangLaptop.Location = new Point(331, 3);
            btnHangLaptop.Name = "btnHangLaptop";
            btnHangLaptop.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHangLaptop.Size = new Size(322, 57);
            btnHangLaptop.TabIndex = 0;
            btnHangLaptop.Text = "Hãng Laptop";
            btnHangLaptop.Click += btnHangLaptop_Click;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.BorderColor = Color.FromArgb(0, 0, 192);
            btnDoanhThu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnDoanhThu.Checked = true;
            btnDoanhThu.CheckedState.CustomBorderColor = Color.FromArgb(0, 0, 192);
            btnDoanhThu.CheckedState.FillColor = Color.White;
            btnDoanhThu.CustomBorderColor = Color.White;
            btnDoanhThu.CustomBorderThickness = new Padding(0, 0, 0, 4);
            btnDoanhThu.CustomizableEdges = customizableEdges5;
            btnDoanhThu.DisabledState.BorderColor = Color.DarkGray;
            btnDoanhThu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDoanhThu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDoanhThu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDoanhThu.Dock = DockStyle.Fill;
            btnDoanhThu.FillColor = Color.White;
            btnDoanhThu.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoanhThu.ForeColor = Color.Black;
            btnDoanhThu.HoverState.CustomBorderColor = Color.FromArgb(0, 0, 192);
            btnDoanhThu.Location = new Point(3, 3);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDoanhThu.Size = new Size(322, 57);
            btnDoanhThu.TabIndex = 0;
            btnDoanhThu.Text = "Doanh thu";
            btnDoanhThu.Click += guna2Button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnNhapHang, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDoanhThu, 0, 0);
            tableLayoutPanel1.Controls.Add(btnHangLaptop, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(984, 63);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 63);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(984, 665);
            panelContainer.TabIndex = 4;
            // 
            // ThongKeGUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(984, 728);
            Controls.Add(panelContainer);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThongKeGUI";
            Text = "Form1";
            Load += ThongKeGUI_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDoanhThu;
        private Guna.UI2.WinForms.Guna2Button btnNhapHang;
        private Guna.UI2.WinForms.Guna2Button btnHangLaptop;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelContainer;
    }
}
