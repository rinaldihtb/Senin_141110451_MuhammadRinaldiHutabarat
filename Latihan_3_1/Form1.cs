using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 8;
            while (i < 72)
            {
                if (i <= 11)
                    i++;
                else
                {
                    i += 3;
                }
                comboBox1.Items.Add(i + " pt");

            }

            foreach (FontFamily ffs in FontFamily.Families)
            {
                comboBox2.Items.Add(ffs.Name);
            }

            foreach (System.Reflection.PropertyInfo Props in typeof(Color).GetProperties())
            {
                if (Props.PropertyType.FullName == "System.Drawing.Color")
                {
                  comboBox3.Items.Add(Props.Name);
                }
                //comboBox3.Items.Add(Props.Name);
                //comboBox3.Items.Add(Props.PropertyType.FullName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(comboBox1.Text.Split(' ')[0]);
            richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont.FontFamily, size);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(comboBox1.Text.Split(' ')[0]);
            richTextBox1.SelectionFont = new System.Drawing.Font(comboBox2.Text, size, richTextBox1.SelectionFont.Style);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromName(comboBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

    }
}
