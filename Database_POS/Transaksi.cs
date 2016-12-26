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
    public partial class Transaksi : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=project;Uid=root;Pwd=");
        MySqlDataAdapter DA;
        DataTable DT = new DataTable();
        MySqlCommand query;

        public string kd_pembelian;
        public string id_barang_pembelian;
        public string id_supplier_pembelian;
        public int kuantiti;
        public double hasil;
        //public string id_pembelian;



        public Transaksi()
        {
            InitializeComponent();
            this.views_method();
        }

        private void barang_views_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void views_method()
        {
            query = new MySqlCommand("SELECT pd.id, p.kode, s.nama as Nama_Supplier, b.nama as Nama_Barang, pd.harga_barang, pd.kuantitas FROM pembelian as p, pembelian_detail as pd, supplier as s, barang as b WHERE p.kode=pd.kode_pembelian AND pd.id_barang=b.id AND p.id_supplier=s.id", con);
            DA = new MySqlDataAdapter(query);
            DT = new DataTable();
            DA.Fill(DT);
            views_data.DataSource = DT;
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string kode_param = this.kodebarang_pembelian.Text;
            query = new MySqlCommand("select * from barang where kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kode_param);
            MySqlDataReader Reader = query.ExecuteReader();

            if (!Reader.HasRows)
            {
                con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (Reader.Read())
            {
                this.id_barang_pembelian = Reader["id"].ToString();
                this.string_barang.Text = Reader["nama"].ToString();
                this.hargabeli_pembelian.Text = Reader["harga_beli"].ToString();
                this.kodesupplier_pembelian.ReadOnly = false;
            }
            Reader.Close();
            con.Close();
        }

        private void cek_supplier_Click(object sender, EventArgs e)
        {
            con.Open();
            string kode_param = this.kodesupplier_pembelian.Text;
            query = new MySqlCommand("select * from supplier where Kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kode_param);
            MySqlDataReader Reader = query.ExecuteReader();

            if (!Reader.HasRows)
            {
                con.Close();
                MessageBox.Show("Data Tidak Ditemukan");
                return;
            }
            if (Reader.Read())
            {
                this.id_supplier_pembelian = Reader["id"].ToString();
                this.string_supplier.Text = Reader["nama"].ToString();
                this.kuantiti_pembelian.ReadOnly = false;
            }
            Reader.Close();
            con.Close();
        }

        private void kuantiti_pembelian_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.kuantiti = Convert.ToInt32(this.kuantiti_pembelian.Text);
                this.hasil = (double)this.kuantiti * Convert.ToInt32(this.hargabeli_pembelian.Text);
                this.hargatotal_pembelian.Text = this.hasil.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                this.kuantiti_pembelian.Text = null;
            }
        }

        private void views_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpan_Click(object sender, EventArgs e)
        {
            con.Open();
            string kode_param = this.kode_pembelian.Text;
            this.kd_pembelian = kode_param;
            if (kode_param == null) return;
            query = new MySqlCommand("select * from pembelian where Kode=@kode", con);
            query.Parameters.AddWithValue("@kode", kode_param);
            MySqlDataReader Reader = query.ExecuteReader();
            DateTime datenow = getdatetime();

            if (!Reader.HasRows)
            {
                con.Close();
                query = new MySqlCommand("INSERT INTO pembelian SET kode=@kode, id_supplier=@idsupplier, created_at=@dateinsert, updated_at=@dateupdate", con);
                query.Parameters.AddWithValue("@kode", kode_param);
                query.Parameters.AddWithValue("@idsupplier", this.id_supplier_pembelian);
                query.Parameters.AddWithValue("@dateinsert", datenow);
                query.Parameters.AddWithValue("@dateupdate", datenow);

                try
                {
                    con.Open();
                    query.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Input Pembelian");
                    //this.views_method();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                //MessageBox.Show("Data Tidak Ditemukan");
                //return;
            }
            con.Close();
            query = new MySqlCommand("INSERT INTO pembelian_detail SET kode_pembelian=@kd_beli, id_barang=@idbarang, harga_barang=@hargabarang, kuantitas=@kuantiti, created_at=@dateinsert, updated_at=@dateupdate", con);
            query.Parameters.AddWithValue("@kd_beli", this.kd_pembelian);
            query.Parameters.AddWithValue("@idbarang", this.id_barang_pembelian);
            query.Parameters.AddWithValue("@kuantiti", this.kuantiti_pembelian.Text);
            query.Parameters.AddWithValue("@hargabarang", this.hargabeli_pembelian.Text);
            query.Parameters.AddWithValue("@dateinsert", datenow);
            query.Parameters.AddWithValue("@dateupdate", datenow);

            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Detail Pembelian");
                this.views_method();
                con.Close();
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
