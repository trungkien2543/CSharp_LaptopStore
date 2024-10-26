using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI.Laptop
{
    public partial class BaoHanhGUI : Form
    {
        private MainForm mainForm;
        public BaoHanhGUI(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            edit_panel();
        }

        void edit_panel()
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new LoaiLaptopGUI(mainForm));
        }

        private void vbButton3_Click_1(object sender, EventArgs e)
        {
            vbButton1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("đã nhấn");
        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
