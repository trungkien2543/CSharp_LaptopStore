using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using LaptopStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI
{
    public partial class NhanVienGUI : Form
    {
        MainForm mainForm;
        NhanVienBUS bus;
        public NhanVienGUI(MainForm mainForm)
        {
            bus = new NhanVienBUS();
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void NhanVienGUI_Load(object sender, EventArgs e)
        {

            List<NhanVienDTO> nvs = bus.getAllNhanVien();
            for (int i = 0; i < nvs.Count; i++)
            {
                NhanVienDTO nv = nvs[i];
                dataGridView1.Rows.Add(new object[] { nv.ID_NhanVien, nv.TenNV, nv.NgaySinh, nv.SDT, nv.DiaChi, nv.GioiTinh, nv.CCCD, nv.Email});
            }
        }
    }
}
