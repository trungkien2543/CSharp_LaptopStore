namespace CustomTabControl
{
    public partial class ThongKeGUI : Form
    {
        public ThongKeGUI()
        {
            InitializeComponent();
            DoanhThu dt = new DoanhThu();
            addUserControl(dt);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu();
            addUserControl(dt);
        }

        private void btnHangLaptop_Click(object sender, EventArgs e)
        {
            HangLaptop hangLaptop = new HangLaptop();
            addUserControl(hangLaptop);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            addUserControl(nhanVien);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongKeGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
