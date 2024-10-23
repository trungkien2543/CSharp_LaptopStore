using CSharp_laptop.BUS;
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

namespace CSharp_laptop.GUI.NhanVien
{
    public partial class CreateNhanVienGUI : Form
    {
        NhanVienBUS bus;
        MainForm mainf;
        public CreateNhanVienGUI(MainForm mainf)
        {
            this.mainf = mainf;
            this.bus = new NhanVienBUS();
            InitializeComponent();
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
            mainf.OpenChildForm(new NhanVienGUI(mainf));
        }

        private void rjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
