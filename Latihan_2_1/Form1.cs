using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            deklarasiSabtuMinggu();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deklarasi Tanggal Lahir
            DateTime tgl_lahir = new DateTime(1996, 09, 19);
            monthCalendar1.AddBoldedDate(tgl_lahir);
            bln.SelectedIndex = 0;
            tgl.SelectedIndex = 0;
        }

        public void deklarasiSabtuMinggu()
        {
            //Deklarasi awal Tahun
            DateTime awalTahun = new DateTime(2016, 1, 1);
            DateTime DateTemp = awalTahun;
            //monthCalendar1.SetDate(awalTahun);

            //label1.Text = Convert.ToInt32(awalTahun.DayOfWeek).ToString();
            //Deklarasi Hari sabtu dan Minggu
            int k = 0;
            int sisak = 0;
            for (int i = 1; i < 13; i++)
            {
                DateTemp = new DateTime(2016, i, 1);
                k = 6 - (int)DateTemp.DayOfWeek;
                sisak = (int)DateTemp.DayOfWeek + k;
                DateTemp = DateTemp.AddDays(k);
                //label1.Text = sisak.ToString();
                //break;
                if (sisak == 6)
                {

                    for (int j = 1; j < 6; j++)
                    {

                        //label1.Text = DateTemp.ToString();
                        monthCalendar1.AddBoldedDate(DateTemp);
                        DateTemp = DateTemp.AddDays(7);
                    }
                }

                DateTemp = new DateTime(2016, i, 1);
                k = 7 - (int)DateTemp.DayOfWeek;
                sisak = (int)DateTemp.DayOfWeek + k;
                DateTemp = DateTemp.AddDays(k);
                //label1.Text = sisak.ToString();
                //break;
                if (sisak == 7)
                {

                    for (int j = 1; j < 6; j++)
                    {

                        //label1.Text = DateTemp.ToString();
                        monthCalendar1.AddBoldedDate(DateTemp);
                        DateTemp = DateTemp.AddDays(7);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int blns = bln.SelectedIndex;
            blns++;
            //label1.Text = tgl.Text + " - " +blns;
            DateTime dateAnnual = new DateTime(2016, blns , Convert.ToInt32(tgl.Text));
            label1.Text = dateAnnual.ToString();
            monthCalendar1.AddAnnuallyBoldedDate(dateAnnual);
        }

        private void bln_SelectedItemChanged(object sender, EventArgs e)
        {
            int indexBln = bln.SelectedIndex;
            indexBln++;
            //label1.Text = indexBln.ToString();
        }

        private void tgl_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
