﻿namespace P5_3_714230053
{
    partial class FormHP
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
            this.MerkHP = new System.Windows.Forms.Label();
            this.OS = new System.Windows.Forms.Label();
            this.Diperbaiki = new System.Windows.Forms.Label();
            this.txtMerkHP = new System.Windows.Forms.TextBox();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.rb_ios = new System.Windows.Forms.RadioButton();
            this.cbYa = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MerkHP
            // 
            this.MerkHP.AutoSize = true;
            this.MerkHP.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MerkHP.Location = new System.Drawing.Point(18, 40);
            this.MerkHP.Name = "MerkHP";
            this.MerkHP.Size = new System.Drawing.Size(91, 26);
            this.MerkHP.TabIndex = 0;
            this.MerkHP.Text = "Merk HP";
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OS.Location = new System.Drawing.Point(18, 107);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(36, 26);
            this.OS.TabIndex = 1;
            this.OS.Text = "OS";
            // 
            // Diperbaiki
            // 
            this.Diperbaiki.AutoSize = true;
            this.Diperbaiki.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diperbaiki.Location = new System.Drawing.Point(18, 159);
            this.Diperbaiki.Name = "Diperbaiki";
            this.Diperbaiki.Size = new System.Drawing.Size(182, 26);
            this.Diperbaiki.TabIndex = 2;
            this.Diperbaiki.Text = "Sudah Diperbaiki?";
            // 
            // txtMerkHP
            // 
            this.txtMerkHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMerkHP.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerkHP.Location = new System.Drawing.Point(214, 40);
            this.txtMerkHP.Name = "txtMerkHP";
            this.txtMerkHP.Size = new System.Drawing.Size(281, 31);
            this.txtMerkHP.TabIndex = 3;
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Location = new System.Drawing.Point(214, 109);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(89, 24);
            this.rb_android.TabIndex = 4;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // rb_ios
            // 
            this.rb_ios.AutoSize = true;
            this.rb_ios.Location = new System.Drawing.Point(309, 109);
            this.rb_ios.Name = "rb_ios";
            this.rb_ios.Size = new System.Drawing.Size(60, 24);
            this.rb_ios.TabIndex = 5;
            this.rb_ios.TabStop = true;
            this.rb_ios.Text = "iOS";
            this.rb_ios.UseVisualStyleBackColor = true;
            // 
            // cbYa
            // 
            this.cbYa.AutoSize = true;
            this.cbYa.Location = new System.Drawing.Point(214, 159);
            this.cbYa.Name = "cbYa";
            this.cbYa.Size = new System.Drawing.Size(55, 24);
            this.cbYa.TabIndex = 6;
            this.cbYa.Text = "Ya";
            this.cbYa.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(108, 235);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(96, 34);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(347, 235);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(96, 34);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FormHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(550, 335);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.cbYa);
            this.Controls.Add(this.rb_ios);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.txtMerkHP);
            this.Controls.Add(this.Diperbaiki);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.MerkHP);
            this.Name = "FormHP";
            this.Text = "Service HP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MerkHP;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.Label Diperbaiki;
        private System.Windows.Forms.TextBox txtMerkHP;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.RadioButton rb_ios;
        private System.Windows.Forms.CheckBox cbYa;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

