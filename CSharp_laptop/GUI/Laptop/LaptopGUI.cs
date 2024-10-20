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
    public partial class LaptopGUI : Form
    {
        private MainForm mainForm;
        private string laptopID;

        public LaptopGUI(string laptopID,MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.laptopID = laptopID;

            label2.Text = laptopID;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new SanPhamGUI(mainForm));
        }
    }
}
