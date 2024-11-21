using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_laptop.BUS;
using CSharp_laptop.DAO;
using CSharp_laptop.DTO;
using LaptopStore.DTO;


namespace CSharp_laptop.GUI
{
    public partial class EditHangGUI : Form
    {

        private MainForm mainForm;
        string function, id;
        private HangBUS hangBUS = new HangBUS();
        public EditHangGUI(MainForm mainForm, string function, string id)
        {
            InitializeComponent();
            this.mainForm = mainForm; // Gán giá trị cho biến mainForm
            this.function = function;
            this.id = id;

            if (function == "update")
            {
                loaddata_textbox(id);
            }

        }

        void loaddata_textbox(string id)
        {
            HangDTO hang = hangBUS.GetHangSanXuatById(id);

            rjTextBox1.Texts = hang.ID_Hang;
            rjTextBox2.Texts = hang.TenHang;
            rjTextBox3.Texts = hang.DiaChi;
            rjTextBox4.Texts = hang.SDT;

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

            HangDTO hang = new HangDTO
            {
                ID_Hang = rjTextBox1.Texts,
                TenHang = rjTextBox2.Texts,
                DiaChi = rjTextBox3.Texts,
                SDT = rjTextBox4.Texts
            };

            bool result = (function == "add") ? SaveHang(hang, true) : SaveHang(hang, false);
        }

        bool SaveHang(HangDTO hang, bool isAdd)
        {

            if (isAdd && hangBUS.CheckIfIDExists(hang.ID_Hang))
            {
                MessageBox.Show("ID hãng đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập ID khác.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            hangBUS = new HangBUS();
            bool result = isAdd ? hangBUS.AddHangSanXuat(hang) : hangBUS.UpdateHangSanXuat(hang);

            string action = isAdd ? "Thêm" : "Update";
            MessageBox.Show(result ? $"{action} thành công" : $"{action} thất bại");

            return result;
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new HangGUI(mainForm));
        }

        private void rjTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}
