﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Costumer form_costumer = new Costumer();
            form_costumer.MdiParent = this;
            form_costumer.Show();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Barang form_barang = new Barang();
            form_barang.MdiParent = this;
            form_barang.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
