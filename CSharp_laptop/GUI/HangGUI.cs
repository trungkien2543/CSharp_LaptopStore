using CSharp_laptop.BUS;
using LaptopStore.DTO;
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
    public partial class HangGUI : Form
    {
        private HangBUS hangBUS = new HangBUS();

        public HangGUI()
        {
            InitializeComponent();
            loadHangs();


            Customtable();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadHangs()
        {
            List<HangDTO> hangs = hangBUS.GetHangs();
            dataGridView1.DataSource = hangs;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        void Customtable()
        {
            dataGridView1.Columns[2].Width = 250;
        }
    }
}
