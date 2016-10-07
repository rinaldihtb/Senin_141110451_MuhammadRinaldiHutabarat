namespace Latihan_2_1
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tgl = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.bln = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(28, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tgl
            // 
            this.tgl.Items.Add("1");
            this.tgl.Items.Add("2");
            this.tgl.Items.Add("3");
            this.tgl.Items.Add("4");
            this.tgl.Items.Add("5");
            this.tgl.Items.Add("6");
            this.tgl.Items.Add("7");
            this.tgl.Items.Add("8");
            this.tgl.Items.Add("9");
            this.tgl.Items.Add("10");
            this.tgl.Items.Add("11");
            this.tgl.Items.Add("12");
            this.tgl.Items.Add("13");
            this.tgl.Items.Add("14");
            this.tgl.Items.Add("15");
            this.tgl.Items.Add("16");
            this.tgl.Items.Add("17");
            this.tgl.Items.Add("18");
            this.tgl.Items.Add("19");
            this.tgl.Items.Add("20");
            this.tgl.Items.Add("21");
            this.tgl.Items.Add("22");
            this.tgl.Items.Add("23");
            this.tgl.Items.Add("24");
            this.tgl.Items.Add("25");
            this.tgl.Items.Add("26");
            this.tgl.Items.Add("27");
            this.tgl.Items.Add("28");
            this.tgl.Items.Add("29");
            this.tgl.Items.Add("30");
            this.tgl.Items.Add("31");
            this.tgl.Location = new System.Drawing.Point(28, 19);
            this.tgl.Margin = new System.Windows.Forms.Padding(10);
            this.tgl.MaximumSize = new System.Drawing.Size(120, 0);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(42, 20);
            this.tgl.TabIndex = 1;
            this.tgl.Text = "Pilih Tanggal";
            this.tgl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tgl.SelectedItemChanged += new System.EventHandler(this.tgl_SelectedItemChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bln
            // 
            this.bln.Items.Add("Januari");
            this.bln.Items.Add("Februari");
            this.bln.Items.Add("Maret");
            this.bln.Items.Add("April");
            this.bln.Items.Add("Mei");
            this.bln.Items.Add("Juni");
            this.bln.Items.Add("Juli");
            this.bln.Items.Add("Agustus");
            this.bln.Items.Add("September");
            this.bln.Items.Add("Oktober");
            this.bln.Items.Add("November");
            this.bln.Items.Add("Desember");
            this.bln.Location = new System.Drawing.Point(77, 19);
            this.bln.Margin = new System.Windows.Forms.Padding(10);
            this.bln.Name = "bln";
            this.bln.Size = new System.Drawing.Size(119, 20);
            this.bln.TabIndex = 1;
            this.bln.Text = "Pilih Bulan";
            this.bln.SelectedItemChanged += new System.EventHandler(this.bln_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bln);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DomainUpDown tgl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown bln;
        private System.Windows.Forms.Label label1;
    }
}

