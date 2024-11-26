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

            if (function == "add")
            {
                tb_id.Text = id;
            }
            else
            if (function == "update")
            {

                tb_id.ReadOnly = true;
                loaddata_textbox(id);
            }

        }

        void loaddata_textbox(string id)
        {
            HangDTO hang = hangBUS.GetHangSanXuatById(id);

            tb_id.Text = hang.ID_Hang;
            tb_ten.Text = hang.TenHang;
            tb_diachi.Text = hang.DiaChi;
            tb_sdt.Text = hang.SDT;

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

            HangDTO hang = new HangDTO
            {
                ID_Hang = tb_id.Text,
                TenHang = tb_ten.Text,
                DiaChi = tb_diachi.Text,
                SDT = tb_sdt.Text
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


        private void tb_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}
