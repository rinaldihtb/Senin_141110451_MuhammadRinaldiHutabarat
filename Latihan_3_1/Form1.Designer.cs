namespace Latihan_3_1
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
            this.fontChange = new System.Windows.Forms.ComboBox();
            this.boldChange = new System.Windows.Forms.Button();
            this.underlineChange = new System.Windows.Forms.Button();
            this.italicChange = new System.Windows.Forms.Button();
            this.FfamilyChange = new System.Windows.Forms.ComboBox();
            this.ColorChange = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontChange
            // 
            this.fontChange.FormattingEnabled = true;
            this.fontChange.Location = new System.Drawing.Point(12, 27);
            this.fontChange.Name = "fontChange";
            this.fontChange.Size = new System.Drawing.Size(92, 21);
            this.fontChange.TabIndex = 0;
            this.fontChange.Text = "8 pt";
            this.fontChange.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // boldChange
            // 
            this.boldChange.AllowDrop = true;
            this.boldChange.Location = new System.Drawing.Point(110, 28);
            this.boldChange.Name = "boldChange";
            this.boldChange.Size = new System.Drawing.Size(21, 21);
            this.boldChange.TabIndex = 2;
            this.boldChange.Text = "B";
            this.boldChange.UseVisualStyleBackColor = true;
            this.boldChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // underlineChange
            // 
            this.underlineChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineChange.Location = new System.Drawing.Point(164, 28);
            this.underlineChange.Name = "underlineChange";
            this.underlineChange.Size = new System.Drawing.Size(21, 21);
            this.underlineChange.TabIndex = 2;
            this.underlineChange.Text = "U";
            this.underlineChange.UseVisualStyleBackColor = true;
            this.underlineChange.Click += new System.EventHandler(this.button2_Click);
            // 
            // italicChange
            // 
            this.italicChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicChange.Location = new System.Drawing.Point(137, 28);
            this.italicChange.Name = "italicChange";
            this.italicChange.Size = new System.Drawing.Size(21, 21);
            this.italicChange.TabIndex = 2;
            this.italicChange.Text = "I";
            this.italicChange.UseVisualStyleBackColor = true;
            this.italicChange.Click += new System.EventHandler(this.button3_Click);
            // 
            // FfamilyChange
            // 
            this.FfamilyChange.FormattingEnabled = true;
            this.FfamilyChange.Location = new System.Drawing.Point(191, 28);
            this.FfamilyChange.Name = "FfamilyChange";
            this.FfamilyChange.Size = new System.Drawing.Size(147, 21);
            this.FfamilyChange.TabIndex = 0;
            this.FfamilyChange.Text = "Arial";
            this.FfamilyChange.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ColorChange
            // 
            this.ColorChange.FormattingEnabled = true;
            this.ColorChange.Location = new System.Drawing.Point(344, 28);
            this.ColorChange.Name = "ColorChange";
            this.ColorChange.Size = new System.Drawing.Size(155, 21);
            this.ColorChange.TabIndex = 0;
            this.ColorChange.Text = "Black";
            this.ColorChange.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 240);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 306);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.italicChange);
            this.Controls.Add(this.underlineChange);
            this.Controls.Add(this.boldChange);
            this.Controls.Add(this.ColorChange);
            this.Controls.Add(this.FfamilyChange);
            this.Controls.Add(this.fontChange);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fontChange;
        private System.Windows.Forms.Button boldChange;
        private System.Windows.Forms.Button underlineChange;
        private System.Windows.Forms.Button italicChange;
        private System.Windows.Forms.ComboBox FfamilyChange;
        private System.Windows.Forms.ComboBox ColorChange;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

