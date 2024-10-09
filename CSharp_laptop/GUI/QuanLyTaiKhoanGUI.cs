using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
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
    public partial class QuanLyTaiKhoanGUI : Form
    {
        private TaiKhoanBUS TaiKhoanBUS = new TaiKhoanBUS();
        private MainForm mainForm;
        public QuanLyTaiKhoanGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Tên Đăng Nhập", 300);
            listView1.Columns.Add("Mật Khẩu", 300);
            listView1.Columns.Add("Quyền", 300);
            LoadTaiKhoan();

        }

        private void LoadTaiKhoan()
        {

            List<TaiKhoanDTO> accs = TaiKhoanBUS.GetAllTaiKhoan();
            for (int i = 0; i < accs.Count; i++)
            {
                ListViewItem item = new ListViewItem(accs[i].TenDN); 
                item.SubItems.Add(accs[i].MatKhau); 
                item.SubItems.Add(accs[i].Quyen); 

                // Thêm item vào ListView
                listView1.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CreateTaiKhoanGUI(mainForm));
        }
    }
}
