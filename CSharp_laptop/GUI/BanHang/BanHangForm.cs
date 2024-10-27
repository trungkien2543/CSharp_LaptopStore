using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laptop.GUI.BanHang
{
    public partial class BanHangForm : Form
    {

        MainForm mainForm;
        public BanHangForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new HoaDon(mainForm));
        }
    }
}
