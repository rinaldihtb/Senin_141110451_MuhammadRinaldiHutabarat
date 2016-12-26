namespace Database_POS
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Estockbarang = new System.Windows.Forms.TextBox();
            this.Ekodebarang = new System.Windows.Forms.TextBox();
            this.cek_supplier = new System.Windows.Forms.Button();
            this.string_supplier = new System.Windows.Forms.Label();
            this.string_barang = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.simpan = new System.Windows.Forms.Button();
            this.hargatotal_pembelian = new System.Windows.Forms.TextBox();
            this.hargabeli_pembelian = new System.Windows.Forms.TextBox();
            this.kuantiti_pembelian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kodesupplier_pembelian = new System.Windows.Forms.TextBox();
            this.kodebarang_pembelian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Enamabarang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Ehargajual = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Ehargabeli = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.views_data = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.kode_pembelian = new System.Windows.Forms.TextBox();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_data)).BeginInit();
            this.SuspendLayout();
            // 
            // Estockbarang
            // 
            this.Estockbarang.Location = new System.Drawing.Point(155, 110);
            this.Estockbarang.Name = "Estockbarang";
            this.Estockbarang.Size = new System.Drawing.Size(115, 20);
            this.Estockbarang.TabIndex = 12;
            // 
            // Ekodebarang
            // 
            this.Ekodebarang.Location = new System.Drawing.Point(155, 54);
            this.Ekodebarang.Name = "Ekodebarang";
            this.Ekodebarang.Size = new System.Drawing.Size(115, 20);
            this.Ekodebarang.TabIndex = 14;
            // 
            // cek_supplier
            // 
            this.cek_supplier.Location = new System.Drawing.Point(379, 89);
            this.cek_supplier.Name = "cek_supplier";
            this.cek_supplier.Size = new System.Drawing.Size(90, 23);
            this.cek_supplier.TabIndex = 34;
            this.cek_supplier.Text = "Cek Supplier";
            this.cek_supplier.UseVisualStyleBackColor = true;
            this.cek_supplier.Click += new System.EventHandler(this.cek_supplier_Click);
            // 
            // string_supplier
            // 
            this.string_supplier.AutoSize = true;
            this.string_supplier.Location = new System.Drawing.Point(208, 92);
            this.string_supplier.Name = "string_supplier";
            this.string_supplier.Size = new System.Drawing.Size(51, 13);
            this.string_supplier.TabIndex = 33;
            this.string_supplier.Text = "(Supplier)";
            // 
            // string_barang
            // 
            this.string_barang.AutoSize = true;
            this.string_barang.Location = new System.Drawing.Point(208, 64);
            this.string_barang.Name = "string_barang";
            this.string_barang.Size = new System.Drawing.Size(47, 13);
            this.string_barang.TabIndex = 32;
            this.string_barang.Text = "(Barang)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(379, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Cek Barang";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(379, 123);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(93, 41);
            this.simpan.TabIndex = 29;
            this.simpan.Text = "Tambah";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // hargatotal_pembelian
            // 
            this.hargatotal_pembelian.Location = new System.Drawing.Point(161, 169);
            this.hargatotal_pembelian.Name = "hargatotal_pembelian";
            this.hargatotal_pembelian.ReadOnly = true;
            this.hargatotal_pembelian.Size = new System.Drawing.Size(115, 20);
            this.hargatotal_pembelian.TabIndex = 24;
            // 
            // hargabeli_pembelian
            // 
            this.hargabeli_pembelian.Location = new System.Drawing.Point(161, 144);
            this.hargabeli_pembelian.Name = "hargabeli_pembelian";
            this.hargabeli_pembelian.ReadOnly = true;
            this.hargabeli_pembelian.Size = new System.Drawing.Size(115, 20);
            this.hargabeli_pembelian.TabIndex = 25;
            // 
            // kuantiti_pembelian
            // 
            this.kuantiti_pembelian.Location = new System.Drawing.Point(161, 117);
            this.kuantiti_pembelian.Name = "kuantiti_pembelian";
            this.kuantiti_pembelian.ReadOnly = true;
            this.kuantiti_pembelian.Size = new System.Drawing.Size(41, 20);
            this.kuantiti_pembelian.TabIndex = 26;
            this.kuantiti_pembelian.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kuantiti_pembelian_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Harga Jual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Harga Beli";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Jumlah Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nama Barang";
            // 
            // kodesupplier_pembelian
            // 
            this.kodesupplier_pembelian.Location = new System.Drawing.Point(161, 89);
            this.kodesupplier_pembelian.Name = "kodesupplier_pembelian";
            this.kodesupplier_pembelian.ReadOnly = true;
            this.kodesupplier_pembelian.Size = new System.Drawing.Size(41, 20);
            this.kodesupplier_pembelian.TabIndex = 27;
            // 
            // kodebarang_pembelian
            // 
            this.kodebarang_pembelian.Location = new System.Drawing.Point(161, 61);
            this.kodebarang_pembelian.Name = "kodebarang_pembelian";
            this.kodebarang_pembelian.Size = new System.Drawing.Size(41, 20);
            this.kodebarang_pembelian.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Harga Beli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kode Supplier";
            // 
            // Enamabarang
            // 
            this.Enamabarang.Location = new System.Drawing.Point(155, 82);
            this.Enamabarang.Name = "Enamabarang";
            this.Enamabarang.Size = new System.Drawing.Size(115, 20);
            this.Enamabarang.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kuantiti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kode Barang";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cek";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ehargajual
            // 
            this.Ehargajual.Location = new System.Drawing.Point(155, 162);
            this.Ehargajual.Name = "Ehargajual";
            this.Ehargajual.Size = new System.Drawing.Size(115, 20);
            this.Ehargajual.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Ehargajual);
            this.tabPage2.Controls.Add(this.Ehargabeli);
            this.tabPage2.Controls.Add(this.Estockbarang);
            this.tabPage2.Controls.Add(this.Enamabarang);
            this.tabPage2.Controls.Add(this.Ekodebarang);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Penjualan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Ehargabeli
            // 
            this.Ehargabeli.Location = new System.Drawing.Point(155, 137);
            this.Ehargabeli.Name = "Ehargabeli";
            this.Ehargabeli.Size = new System.Drawing.Size(115, 20);
            this.Ehargabeli.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Edit Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pembelian";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 412);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.views_data);
            this.tabPage1.Controls.Add(this.cek_supplier);
            this.tabPage1.Controls.Add(this.string_supplier);
            this.tabPage1.Controls.Add(this.string_barang);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.simpan);
            this.tabPage1.Controls.Add(this.hargatotal_pembelian);
            this.tabPage1.Controls.Add(this.hargabeli_pembelian);
            this.tabPage1.Controls.Add(this.kuantiti_pembelian);
            this.tabPage1.Controls.Add(this.kodesupplier_pembelian);
            this.tabPage1.Controls.Add(this.kode_pembelian);
            this.tabPage1.Controls.Add(this.kodebarang_pembelian);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pembelian";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // views_data
            // 
            this.views_data.AllowUserToAddRows = false;
            this.views_data.AllowUserToDeleteRows = false;
            this.views_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.views_data.Location = new System.Drawing.Point(6, 204);
            this.views_data.Name = "views_data";
            this.views_data.Size = new System.Drawing.Size(476, 173);
            this.views_data.TabIndex = 35;
            this.views_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.views_data_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Kode Pembelian";
            // 
            // kode_pembelian
            // 
            this.kode_pembelian.Location = new System.Drawing.Point(161, 33);
            this.kode_pembelian.Name = "kode_pembelian";
            this.kode_pembelian.Size = new System.Drawing.Size(41, 20);
            this.kode_pembelian.TabIndex = 28;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.views_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Estockbarang;
        private System.Windows.Forms.TextBox Ekodebarang;
        private System.Windows.Forms.Button cek_supplier;
        private System.Windows.Forms.Label string_supplier;
        private System.Windows.Forms.Label string_barang;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.TextBox hargatotal_pembelian;
        private System.Windows.Forms.TextBox hargabeli_pembelian;
        private System.Windows.Forms.TextBox kuantiti_pembelian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kodesupplier_pembelian;
        private System.Windows.Forms.TextBox kodebarang_pembelian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Enamabarang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Ehargajual;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Ehargabeli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView views_data;
        private System.Windows.Forms.TextBox kode_pembelian;
        private System.Windows.Forms.Label label13;

    }
}