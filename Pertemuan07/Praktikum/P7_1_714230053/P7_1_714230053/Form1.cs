﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(388, 263);
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.AppendLine("Nama harus diisi"); 
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan harus diisi");
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage.AppendLine("Kelas harus diisi");
            }

            string errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
                "Lengkap!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                Size = new Size(390, 560);
            } else
            {
                MessageBox.Show(
                errorMsg.Trim(),
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }

            
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekday.Checked)
            {
                checkBoxKuliah.Enabled = true;checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true;checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false;checkBoxLiburan.Checked = false;
            }
        }

        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekend.Checked)
            {
                checkBoxKuliah.Enabled = false;checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true;checkBoxTidur.Checked=false;
                checkBoxLiburan.Enabled = true;checkBoxLiburan.Checked=false;
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            //string hari = null;
            //string kegiatan = null;

            //foreach (Control control in Controls)
            //{
            //    if (control is RadioButton radioButton && radioButton.Checked)
            //    {
            //        hari = radioButton.Text;
            //        break;
            //    }
            //}

            //foreach (Control control in Controls)
            //{
            //    if (control is CheckBox checkBox && checkBox.Checked)
            //    {
            //        if (!string.IsNullOrEmpty(kegiatan))
            //        {
            //            kegiatan += ", ";
            //        }
            //        kegiatan += checkBox.Text;
            //    }
            //}

            //Menggunakan LINQ (Language Integrated Query)

            string hari =  Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;

            string kegiatan = string.Join(", ", Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text));

            MessageBox.Show(
                "Nama: " + textBoxNama.Text + "\n" +
                "Angkatan: " + comboBoxAngkatan.Text + "\n" +
                "Kelas: " + textBoxKelas.Text + "\n" +
                "====================================\n"+
                "Hari: " + hari + "\n" +
                "Kegiatan: " + kegiatan + "\n",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //textBoxNama.Text = "";
            //comboBoxAngkatan.SelectedIndex = -1;
            //textBoxKelas.Text = "";
            //radioButtonWeekday.Checked = false;
            //radioButtonWeekend.Checked = false;
            //checkBoxKuliah.Enabled = true; checkBoxKuliah.Checked = false;
            //checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
            //checkBoxLiburan.Enabled = true; checkBoxLiburan.Checked = false;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = true;
                }
            }

            Size = new Size(388, 263);

            MessageBox.Show(
                "Form telah di reset",
                "Reset Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }
    }
}
