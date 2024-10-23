using CSharp_laptop.BUS;
using CSharp_laptop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI.KhachHang
{
    public partial class CreateKhachHangGUI : Form
    {
        MainForm mainForm;
        KhachHangBUS bus;
        public CreateKhachHangGUI(MainForm mainForm)
        {
            this.mainForm = mainForm;
            bus = new KhachHangBUS();
            InitializeComponent();

            List<KhachHangDTO> khs = bus.getAllKhachHang();
            rjTextBox1.setText(GetNextString(khs[khs.Count - 1].ID_KhachHang));
        }

        public string GetNextString(string input)
        {
            // Sử dụng Regex để tách phần chữ cái và phần số trong chuỗi
            var match = Regex.Match(input, @"([A-Za-z]+)(\d+)");
            if (!match.Success)
            {
                throw new ArgumentException("Input không đúng định dạng.");
            }

            // Tách phần chữ cái và phần số
            string prefix = match.Groups[1].Value;
            string numberPart = match.Groups[2].Value;

            // Tăng giá trị số và giữ nguyên số chữ số
            int number = int.Parse(numberPart) + 1;
            string nextNumberPart = number.ToString(new string('0', numberPart.Length));

            // Ghép lại và trả về kết quả
            return prefix + nextNumberPart;
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new KhachHangGUI(mainForm));
        }
    }
}
