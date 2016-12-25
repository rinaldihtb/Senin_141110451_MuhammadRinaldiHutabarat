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
    public partial class Barang : Form
    {
        // Database Connection
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=project;Uid=root;Pwd=");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand query;
        public Barang()
        {
            InitializeComponent();
            this.view_barang();
        }

        private void Barang_Load(object sender, EventArgs e)
        {

        }

        public void view_barang()
        {
            query = new MySqlCommand("select * from barang", con);
            DA = new MySqlDataAdapter(query);
            DT = new DataTable();
            DA.Fill(DT);
            barang_views.DataSource = DT;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_barang_button_Click(object sender, EventArgs e)
        {
            string kodebarang = this.barang_kode.Text;
            string namabarang = this.barang_nama.Text;
            string stockbarang = this.barang_stock.Text;
            string hbelibarang = this.barang_hargabeli.Text;
            string hjualbarang = this.barang_hargajual.Text;
            DateTime datenow = getdatetime();


            query = new MySqlCommand("INSERT INTO barang VALUES(@id,@kode,@nama,@jstok,@hargabeli,@hargajual,@dateinsert,@dateupdate)", con);
            query.Parameters.AddWithValue("@id", null);
            query.Parameters.AddWithValue("@kode", kodebarang);
            query.Parameters.AddWithValue("@nama", namabarang);
            query.Parameters.AddWithValue("@jstok", stockbarang);
            query.Parameters.AddWithValue("@hargabeli", hbelibarang);
            query.Parameters.AddWithValue("@hargajual", hjualbarang);
            query.Parameters.AddWithValue("@dateinsert", datenow);
            query.Parameters.AddWithValue("@dateupdate", null);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Barang");
                con.Close();
                view_barang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        public static DateTime getdatetime()
        {
            DateTime getdatetime = DateTime.UtcNow;
            int year = getdatetime.Year;
            int month = getdatetime.Month;
            int day = getdatetime.Day;
            int hour = getdatetime.Hour;
            int min = getdatetime.Minute;
            int sec = getdatetime.Second;
            DateTime datetime = new DateTime(year, month, day, hour, min, sec);
            return datetime;
        }
    }
}
