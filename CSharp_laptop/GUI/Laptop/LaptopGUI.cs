﻿using System;
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

        public LaptopGUI(string laptopID, MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.laptopID = laptopID;

            label13.Text = laptopID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new SanPhamGUI(mainForm));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new BaoHanhGUI(mainForm));
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
