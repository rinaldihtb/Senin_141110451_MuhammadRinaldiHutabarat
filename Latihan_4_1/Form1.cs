using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        private bool boldV = false;
        private bool italicV = false;
        private bool underlineV = false;

        private string firstText;
        public Form1()
        {
            InitializeComponent();
            this.firstText = "";
        }

        private void underlineChange_Click(object sender, EventArgs e)
        {
            this.underlineV = true;
            //this.BIU();
            this.changeFontSize();
            this.underlineV = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
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
                fontChange.Items.Add(i + " pt");

            }

            foreach (FontFamily ffs in FontFamily.Families)
            {
                FfamilyChange.Items.Add(ffs.Name);
            }

            foreach (System.Reflection.PropertyInfo Props in typeof(Color).GetProperties())
            {
                if (Props.PropertyType.FullName == "System.Drawing.Color")
                {
                    ColorChange.Items.Add(Props.Name);
                }
                //comboBox3.Items.Add(Props.Name);
                //comboBox3.Items.Add(Props.PropertyType.FullName);
            }
        }

        private void fontChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changeFontSize();
            //int size = Convert.ToInt32(fontChange.Text.Split(' ')[0]);
            //richTextBox1.SelectionFont = new System.Drawing.Font(richTextBox1.SelectionFont.FontFamily, size);
        }

        private void FfamilyChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.changeFontSize();
            /*int size = Convert.ToInt32(fontChange.Text.Split(' ')[0]);
            
            richTextBox1.SelectionFont = new System.Drawing.Font(FfamilyChange.Text, size, richTextBox1.SelectionFont.Style);*/
        }

        private void ColorChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromName(ColorChange.Text);
        }

        private void boldChange_Click(object sender, EventArgs e)
        {
            this.boldV = true;
            //this.BIU();
            this.changeFontSize();
            this.boldV = false;
        }

        private void italicChange_Click(object sender, EventArgs e)
        {
            this.italicV = true;
            //this.BIU();
            this.changeFontSize();
            this.italicV = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void changeFontSize()
        {
            int size = Convert.ToInt32(fontChange.Text.Split(' ')[0]);
            int PosisiAwal = richTextBox1.SelectionStart;
            int PosisiAkhir = richTextBox1.SelectionLength;
            for (int i = PosisiAwal; i < PosisiAwal + PosisiAkhir; i++)
            {
                //SET PENENTUAN POSISI yang akan diganti perHURUF
                richTextBox1.SelectionStart = i;
                richTextBox1.SelectionLength = 1;
                this.BIU();
                richTextBox1.SelectionFont = new System.Drawing.Font(FfamilyChange.Text, size, richTextBox1.SelectionFont.Style);
            }
            richTextBox1.SelectionStart = PosisiAwal;
            richTextBox1.SelectionLength = PosisiAkhir;
            /*richTextBox1.SelectionFont = new System.Drawing.Font(FfamilyChange.Text, size, richTextBox1.SelectionFont.Style);*/
        }

        private void BIU()
        {
            Font slf, slfNew;
            slf = richTextBox1.SelectionFont;
            //UNDERLINE
            if (underlineV)
            {
                if (slf.Underline)
                    slfNew = new Font(richTextBox1.Font, slf.Style & ~FontStyle.Underline);
                else
                    slfNew = new Font(slf, slf.Style | FontStyle.Underline);
                richTextBox1.SelectionFont = slfNew;
            }
            //BOLD
            if (boldV)
            {
                if (slf.Bold)
                    slfNew = new Font(slf, slf.Style & ~FontStyle.Bold);
                else
                    slfNew = new Font(slf, slf.Style | FontStyle.Bold);
                richTextBox1.SelectionFont = slfNew;
            }
            //ITALIC
            if (italicV)
            {
                if (slf.Italic)
                    slfNew = new Font(slf, slf.Style & ~FontStyle.Italic);
                else
                    slfNew = new Font(slf, slf.Style | FontStyle.Italic);
                richTextBox1.SelectionFont = slfNew;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                this.firstText = richTextBox1.Text;
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.save();
        }

        private void save()
        {
            saveFileDialog1.Filter = "All Files (*.*)|*.*| Text Document (*.txt)|*.txt|Rich Textbox Format (*.rft)|*.rft";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Text != this.firstText)
            {
                DialogResult check = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (check == DialogResult.Yes)
                {
                    this.save();
                }
                else if (check == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
