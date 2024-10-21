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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new SanPhamGUI(mainForm));
        }
    }
}
