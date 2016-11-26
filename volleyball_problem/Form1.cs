using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long a, b, hasil;
            a = Convert.ToInt64(textBox1.Text);
            b = Convert.ToInt64(textBox2.Text);

            hasil = verify(a, b);

            textBox3.Text = hasil.ToString();
            //textBox3.Text = faktorial(a).ToString();

        }

        private static long kombinasi(long a, long b)
        {
            //return (faktorial(a) / (faktorial(b)*faktorial(a - b)))%modula();

            long hasil = 1;
            for (long i = 0; i < (a - b); i++)
            {
                hasil = hasil * (a - i) / (i + 1);
            }
            return hasil % modula();
        }

        private static long faktorial(long n)
        {
            long fak = 1;
            for (long i = n; i > 0; i--)
            {
                fak *= i;
            }
            return fak;
        }
        private static long modula()
        {
            return (long)Math.Pow(10, 9)+7;
        }

        public static long verify(long a, long b)
        {
            if (a < b)
                return verify(b, a);
            if (a >= (b + 2) && a == 25)
                return kombinasi((a + b) - 1, b);
            else if (a == (b + 2) && a >= 26)
                return kombinasi(48, 24) * pangkat(2, (b - 24)) % modula();
            else
                return 0;
        }

        public static long pangkat(long b, long n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return b;
            long set = pangkat(b, n / 2);
            if (n % 2 == 0)
                return (set * set) % modula();
            else
                return ((set * set) % modula()) * b;
        }

    }
}
