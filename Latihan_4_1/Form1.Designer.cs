﻿namespace Latihan_4_1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.italicChange = new System.Windows.Forms.Button();
            this.underlineChange = new System.Windows.Forms.Button();
            this.boldChange = new System.Windows.Forms.Button();
            this.ColorChange = new System.Windows.Forms.ComboBox();
            this.FfamilyChange = new System.Windows.Forms.ComboBox();
            this.fontChange = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 240);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // italicChange
            // 
            this.italicChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicChange.Location = new System.Drawing.Point(137, 32);
            this.italicChange.Name = "italicChange";
            this.italicChange.Size = new System.Drawing.Size(21, 21);
            this.italicChange.TabIndex = 9;
            this.italicChange.Text = "I";
            this.italicChange.UseVisualStyleBackColor = true;
            this.italicChange.Click += new System.EventHandler(this.italicChange_Click);
            // 
            // underlineChange
            // 
            this.underlineChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineChange.Location = new System.Drawing.Point(164, 32);
            this.underlineChange.Name = "underlineChange";
            this.underlineChange.Size = new System.Drawing.Size(21, 21);
            this.underlineChange.TabIndex = 10;
            this.underlineChange.Text = "U";
            this.underlineChange.UseVisualStyleBackColor = true;
            this.underlineChange.Click += new System.EventHandler(this.underlineChange_Click);
            // 
            // boldChange
            // 
            this.boldChange.AllowDrop = true;
            this.boldChange.Location = new System.Drawing.Point(110, 32);
            this.boldChange.Name = "boldChange";
            this.boldChange.Size = new System.Drawing.Size(21, 21);
            this.boldChange.TabIndex = 11;
            this.boldChange.Text = "B";
            this.boldChange.UseVisualStyleBackColor = true;
            this.boldChange.Click += new System.EventHandler(this.boldChange_Click);
            // 
            // ColorChange
            // 
            this.ColorChange.FormattingEnabled = true;
            this.ColorChange.Location = new System.Drawing.Point(344, 32);
            this.ColorChange.Name = "ColorChange";
            this.ColorChange.Size = new System.Drawing.Size(155, 21);
            this.ColorChange.TabIndex = 6;
            this.ColorChange.Text = "Black";
            this.ColorChange.SelectedIndexChanged += new System.EventHandler(this.ColorChange_SelectedIndexChanged);
            // 
            // FfamilyChange
            // 
            this.FfamilyChange.FormattingEnabled = true;
            this.FfamilyChange.Location = new System.Drawing.Point(191, 32);
            this.FfamilyChange.Name = "FfamilyChange";
            this.FfamilyChange.Size = new System.Drawing.Size(147, 21);
            this.FfamilyChange.TabIndex = 7;
            this.FfamilyChange.Text = "Arial";
            this.FfamilyChange.SelectedIndexChanged += new System.EventHandler(this.FfamilyChange_SelectedIndexChanged);
            // 
            // fontChange
            // 
            this.fontChange.FormattingEnabled = true;
            this.fontChange.Location = new System.Drawing.Point(12, 31);
            this.fontChange.Name = "fontChange";
            this.fontChange.Size = new System.Drawing.Size(92, 21);
            this.fontChange.TabIndex = 8;
            this.fontChange.Text = "8 pt";
            this.fontChange.SelectedIndexChanged += new System.EventHandler(this.fontChange_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 13;
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
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 302);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.italicChange);
            this.Controls.Add(this.underlineChange);
            this.Controls.Add(this.boldChange);
            this.Controls.Add(this.ColorChange);
            this.Controls.Add(this.FfamilyChange);
            this.Controls.Add(this.fontChange);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button italicChange;
        private System.Windows.Forms.Button underlineChange;
        private System.Windows.Forms.Button boldChange;
        private System.Windows.Forms.ComboBox ColorChange;
        private System.Windows.Forms.ComboBox FfamilyChange;
        private System.Windows.Forms.ComboBox fontChange;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

