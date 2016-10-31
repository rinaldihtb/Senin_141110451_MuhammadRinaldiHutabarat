using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_5_1
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            treeView1.Nodes.Add("Theme");
            treeView1.Nodes[0].Nodes.Add("Background");

            //COLOR
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

        private void ColorChange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            f1.richTB = Color.FromName(ColorChange.SelectedItem.ToString());
            //f1.richte
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background")
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }
    }
}
