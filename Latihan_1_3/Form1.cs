using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text = dateTimePicker1.Value.ToShortDateString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();
            string[] tgl_pecah = dateTimePicker1.Value.ToShortDateString().Split('/');
            label6.Text = (Convert.ToInt32(tgl_pecah[2]) + vScrollBar1.Value).ToString();
            label7.Text = tgl_pecah[1];
            label8.Text = tgl_pecah[0];

            dateTimePicker1.MaxDate = new DateTime(Convert.ToInt32(label6.Text), Convert.ToInt32(label8.Text), Convert.ToInt32(label7.Text));
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = vScrollBar2.Value.ToString();
            string[] tgl_pecah = dateTimePicker1.Value.ToShortDateString().Split('/');
            label9.Text = (Convert.ToInt32(tgl_pecah[2]) - vScrollBar2.Value).ToString();
            label10.Text = tgl_pecah[1];
            label11.Text = tgl_pecah[0];

            dateTimePicker1.MinDate = new DateTime(Convert.ToInt32(label9.Text), Convert.ToInt32(label11.Text), Convert.ToInt32(label10.Text));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
