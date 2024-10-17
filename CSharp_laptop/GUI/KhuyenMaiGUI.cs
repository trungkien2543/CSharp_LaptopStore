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
    public partial class KhuyenMaiGUI : Form
    {
        public KhuyenMaiGUI()
        {
            InitializeComponent();
        }

        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhuyenMaiFormGUI form2 = new KhuyenMaiFormGUI();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }
    }
}
