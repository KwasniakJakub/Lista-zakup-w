﻿namespace Lista_zakupów
{
    partial class projekt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnCzysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(145, 103);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 484);
            this.listBox1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(145, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(237, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 596);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 36);
            this.textBox1.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.Location = new System.Drawing.Point(145, 638);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(237, 32);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsun.Location = new System.Drawing.Point(145, 676);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(117, 39);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnCzysc
            // 
            this.btnCzysc.Font = new System.Drawing.Font("Segoe Fluent Icons", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCzysc.Location = new System.Drawing.Point(268, 676);
            this.btnCzysc.Name = "btnCzysc";
            this.btnCzysc.Size = new System.Drawing.Size(114, 39);
            this.btnCzysc.TabIndex = 5;
            this.btnCzysc.Text = "Wyczyść";
            this.btnCzysc.UseVisualStyleBackColor = true;
            this.btnCzysc.Click += new System.EventHandler(this.btnCzysc_Click);
            // 
            // projekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.btnCzysc);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "projekt";
            this.Text = "Lista zakupów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnCzysc;
    }
}
