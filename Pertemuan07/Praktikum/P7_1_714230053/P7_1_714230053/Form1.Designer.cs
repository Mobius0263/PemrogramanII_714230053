namespace P7_1_714230053
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
            this.nama = new System.Windows.Forms.Label();
            this.angkatan = new System.Windows.Forms.Label();
            this.kelas = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonWeekday = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekend = new System.Windows.Forms.RadioButton();
            this.checkBoxKuliah = new System.Windows.Forms.CheckBox();
            this.checkBoxTidur = new System.Windows.Forms.CheckBox();
            this.checkBoxLiburan = new System.Windows.Forms.CheckBox();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(21, 8);
            this.nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(35, 13);
            this.nama.TabIndex = 0;
            this.nama.Text = "Nama";
            // 
            // angkatan
            // 
            this.angkatan.AutoSize = true;
            this.angkatan.Location = new System.Drawing.Point(21, 51);
            this.angkatan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angkatan.Name = "angkatan";
            this.angkatan.Size = new System.Drawing.Size(53, 13);
            this.angkatan.TabIndex = 1;
            this.angkatan.Text = "Angkatan";
            // 
            // kelas
            // 
            this.kelas.AutoSize = true;
            this.kelas.Location = new System.Drawing.Point(21, 93);
            this.kelas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(33, 13);
            this.kelas.TabIndex = 2;
            this.kelas.Text = "Kelas";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(126, 6);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(207, 20);
            this.textBoxNama.TabIndex = 3;
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBoxAngkatan.Location = new System.Drawing.Point(126, 49);
            this.comboBoxAngkatan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(207, 21);
            this.comboBoxAngkatan.TabIndex = 4;
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(126, 91);
            this.textBoxKelas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKelas.Multiline = true;
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(207, 68);
            this.textBoxKelas.TabIndex = 5;
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(126, 188);
            this.buttonCek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(76, 23);
            this.buttonCek.TabIndex = 6;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Location = new System.Drawing.Point(256, 188);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(76, 23);
            this.buttonTutup.TabIndex = 7;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "KEGIATAN";
            // 
            // radioButtonWeekday
            // 
            this.radioButtonWeekday.AutoSize = true;
            this.radioButtonWeekday.Location = new System.Drawing.Point(23, 282);
            this.radioButtonWeekday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonWeekday.Name = "radioButtonWeekday";
            this.radioButtonWeekday.Size = new System.Drawing.Size(89, 17);
            this.radioButtonWeekday.TabIndex = 9;
            this.radioButtonWeekday.TabStop = true;
            this.radioButtonWeekday.Text = "Senin - Jumat";
            this.radioButtonWeekday.UseVisualStyleBackColor = true;
            this.radioButtonWeekday.CheckedChanged += new System.EventHandler(this.radioButtonWeekday_CheckedChanged);
            // 
            // radioButtonWeekend
            // 
            this.radioButtonWeekend.AutoSize = true;
            this.radioButtonWeekend.Location = new System.Drawing.Point(23, 307);
            this.radioButtonWeekend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonWeekend.Name = "radioButtonWeekend";
            this.radioButtonWeekend.Size = new System.Drawing.Size(97, 17);
            this.radioButtonWeekend.TabIndex = 10;
            this.radioButtonWeekend.TabStop = true;
            this.radioButtonWeekend.Text = "Sabtu - Minggu";
            this.radioButtonWeekend.UseVisualStyleBackColor = true;
            this.radioButtonWeekend.CheckedChanged += new System.EventHandler(this.radioButtonWeekend_CheckedChanged);
            // 
            // checkBoxKuliah
            // 
            this.checkBoxKuliah.AutoSize = true;
            this.checkBoxKuliah.Location = new System.Drawing.Point(23, 361);
            this.checkBoxKuliah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxKuliah.Name = "checkBoxKuliah";
            this.checkBoxKuliah.Size = new System.Drawing.Size(55, 17);
            this.checkBoxKuliah.TabIndex = 11;
            this.checkBoxKuliah.Text = "Kuliah";
            this.checkBoxKuliah.UseVisualStyleBackColor = true;
            // 
            // checkBoxTidur
            // 
            this.checkBoxTidur.AutoSize = true;
            this.checkBoxTidur.Location = new System.Drawing.Point(23, 389);
            this.checkBoxTidur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTidur.Name = "checkBoxTidur";
            this.checkBoxTidur.Size = new System.Drawing.Size(50, 17);
            this.checkBoxTidur.TabIndex = 12;
            this.checkBoxTidur.Text = "Tidur";
            this.checkBoxTidur.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiburan
            // 
            this.checkBoxLiburan.AutoSize = true;
            this.checkBoxLiburan.Location = new System.Drawing.Point(23, 416);
            this.checkBoxLiburan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxLiburan.Name = "checkBoxLiburan";
            this.checkBoxLiburan.Size = new System.Drawing.Size(61, 17);
            this.checkBoxLiburan.TabIndex = 13;
            this.checkBoxLiburan.Text = "Liburan";
            this.checkBoxLiburan.UseVisualStyleBackColor = true;
            // 
            // buttonCetak
            // 
            this.buttonCetak.Location = new System.Drawing.Point(126, 459);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(76, 23);
            this.buttonCetak.TabIndex = 14;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(256, 459);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(76, 23);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(372, 506);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.checkBoxLiburan);
            this.Controls.Add(this.checkBoxTidur);
            this.Controls.Add(this.checkBoxKuliah);
            this.Controls.Add(this.radioButtonWeekend);
            this.Controls.Add(this.radioButtonWeekday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.comboBoxAngkatan);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.angkatan);
            this.Controls.Add(this.nama);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label angkatan;
        private System.Windows.Forms.Label kelas;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonWeekday;
        private System.Windows.Forms.RadioButton radioButtonWeekend;
        private System.Windows.Forms.CheckBox checkBoxKuliah;
        private System.Windows.Forms.CheckBox checkBoxTidur;
        private System.Windows.Forms.CheckBox checkBoxLiburan;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Button buttonReset;
    }
}

