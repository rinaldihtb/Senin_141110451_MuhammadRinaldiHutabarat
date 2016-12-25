using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database_POS
{
    public partial class Costumer : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=project;Uid=root;Pwd=");

        public Costumer()
        {
            

            InitializeComponent();
        }

        private void Costumer_Load(object sender, EventArgs e)
        {

        
        }

        public void show_list()
        {
            /*job = new MySqlCommand("select * from customer", con);
            DA = new MySqlDataAdapter(job);
            DT = new DataTable();
            DA.Fill(DT);
            list_customer_view.DataSource = DT;*/
        }
    }
}
