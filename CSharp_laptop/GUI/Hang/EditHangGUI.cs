﻿using System;
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
    public partial class EditHangGUI : Form
    {

        private MainForm mainForm;
        public EditHangGUI(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm; // Gán giá trị cho biến mainForm
        }


        private void EditHangGUI_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new HangGUI(mainForm));
        }
    }
}
