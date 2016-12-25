namespace Database_POS
{
    partial class Barang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barang_kode = new System.Windows.Forms.TextBox();
            this.barang_nama = new System.Windows.Forms.TextBox();
            this.barang_stock = new System.Windows.Forms.TextBox();
            this.save_barang_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barang_hargabeli = new System.Windows.Forms.TextBox();
            this.barang_hargajual = new System.Windows.Forms.TextBox();
            this.barang_views = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barang_views)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 228);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.save_barang_button);
            this.tabPage1.Controls.Add(this.barang_hargajual);
            this.tabPage1.Controls.Add(this.barang_hargabeli);
            this.tabPage1.Controls.Add(this.barang_stock);
            this.tabPage1.Controls.Add(this.barang_nama);
            this.tabPage1.Controls.Add(this.barang_kode);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tambah Barang";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Barang";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jumlah Stock";
            // 
            // barang_kode
            // 
            this.barang_kode.Location = new System.Drawing.Point(152, 59);
            this.barang_kode.Name = "barang_kode";
            this.barang_kode.Size = new System.Drawing.Size(115, 20);
            this.barang_kode.TabIndex = 2;
            // 
            // barang_nama
            // 
            this.barang_nama.Location = new System.Drawing.Point(152, 87);
            this.barang_nama.Name = "barang_nama";
            this.barang_nama.Size = new System.Drawing.Size(115, 20);
            this.barang_nama.TabIndex = 2;
            // 
            // barang_stock
            // 
            this.barang_stock.Location = new System.Drawing.Point(152, 115);
            this.barang_stock.Name = "barang_stock";
            this.barang_stock.Size = new System.Drawing.Size(115, 20);
            this.barang_stock.TabIndex = 2;
            // 
            // save_barang_button
            // 
            this.save_barang_button.Location = new System.Drawing.Point(355, 94);
            this.save_barang_button.Name = "save_barang_button";
            this.save_barang_button.Size = new System.Drawing.Size(93, 41);
            this.save_barang_button.TabIndex = 3;
            this.save_barang_button.Text = "Simpan";
            this.save_barang_button.UseVisualStyleBackColor = true;
            this.save_barang_button.Click += new System.EventHandler(this.save_barang_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Harga Beli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Harga Jual";
            // 
            // barang_hargabeli
            // 
            this.barang_hargabeli.Location = new System.Drawing.Point(152, 142);
            this.barang_hargabeli.Name = "barang_hargabeli";
            this.barang_hargabeli.Size = new System.Drawing.Size(115, 20);
            this.barang_hargabeli.TabIndex = 2;
            // 
            // barang_hargajual
            // 
            this.barang_hargajual.Location = new System.Drawing.Point(152, 167);
            this.barang_hargajual.Name = "barang_hargajual";
            this.barang_hargajual.Size = new System.Drawing.Size(115, 20);
            this.barang_hargajual.TabIndex = 2;
            // 
            // barang_views
            // 
            this.barang_views.AllowUserToAddRows = false;
            this.barang_views.AllowUserToDeleteRows = false;
            this.barang_views.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barang_views.Location = new System.Drawing.Point(12, 242);
            this.barang_views.Name = "barang_views";
            this.barang_views.Size = new System.Drawing.Size(476, 240);
            this.barang_views.TabIndex = 2;
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 486);
            this.Controls.Add(this.barang_views);
            this.Controls.Add(this.tabControl1);
            this.Name = "Barang";
            this.Text = "barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barang_views)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox barang_stock;
        private System.Windows.Forms.TextBox barang_nama;
        private System.Windows.Forms.TextBox barang_kode;
        private System.Windows.Forms.Button save_barang_button;
        private System.Windows.Forms.TextBox barang_hargajual;
        private System.Windows.Forms.TextBox barang_hargabeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView barang_views;
    }
}