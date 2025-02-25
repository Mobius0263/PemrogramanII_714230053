using MySql.Data.MySqlClient;
using P9_714230053.controller;
using P9_714230053.lib;
using P9_714230053.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P9_714230053.view
{
    public partial class FormNilai : Form
    {
        Koneksi koneksi = new Koneksi();
        M_nilai m_nilai = new M_nilai();
        string id_nilai;

        public FormNilai()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");

            dataNilai.Columns[0].HeaderText = "ID";
            dataNilai.Columns[1].HeaderText = "Matkul";
            dataNilai.Columns[2].HeaderText = "Kategori";
            dataNilai.Columns[3].HeaderText = "NPM";
            dataNilai.Columns[4].HeaderText = "Nama";
            dataNilai.Columns[5].HeaderText = "Nilai";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        public void GetDataMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                int npm = reader.GetInt32("npm");
                comboBoxNPM.Items.Add(npm);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void dataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = dataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxMatkul.Text = dataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxKategori.Text = dataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxNPM.Text = dataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxNilai.Text = dataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            dataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " + 
            "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm " +
            "WHERE t_nilai.npm LIKE '%' '" + textBoxCariData.Text + "' '%' " +
            "OR nama LIKE '%' '" + textBoxCariData.Text + "' '%'" +
            "OR matkul LIKE '%' '" + textBoxCariData.Text + "' '%'");
        }

        public void GetNamaMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa " +
                "WHERE npm = '" + comboBoxNPM.Text + "'"); 
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBoxNama.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void comboBoxNPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }

        public void ResetForm()
        {
            comboBoxMatkul.SelectedIndex = -1;
            comboBoxKategori.SelectedIndex = -1;
            comboBoxNPM.SelectedIndex = -1;
            textBoxNilai.Text = "";
            textBoxNama.Text = "";
            textBoxCariData.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (comboBoxMatkul.SelectedIndex == -1 || comboBoxKategori.SelectedIndex == 1 || comboBoxNPM.SelectedIndex == -1 || textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = comboBoxMatkul.Text;
                m_nilai.Kategori = comboBoxKategori.Text;
                m_nilai.Npm = comboBoxNPM.Text;
                m_nilai.Nilai = textBoxNilai.Text;

                nilai.Insert(m_nilai);

                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (comboBoxMatkul.SelectedIndex == -1 || comboBoxKategori.SelectedIndex == 1 || comboBoxNPM.SelectedIndex == -1 || textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = comboBoxMatkul.Text;
                m_nilai.Kategori = comboBoxKategori.Text;
                m_nilai.Npm = comboBoxNPM.Text;
                m_nilai.Nilai = textBoxNilai.Text;

                nilai.Update(m_nilai, id_nilai);

                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?",
            "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_nilai);
                ResetForm();
                Tampil();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "Report Nilai.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt} ({count}){extension}");
                    count++;
                }
                    
                // Membuat instance dari ketas Excel
                Excel excel_Iib = new Excel();
                // Memanggil metode ExportToExce1
                excel_Iib.ExportToExcel(dataNilai, filePath);
                // Notifikasi berhasil
                MessageBox.Show("Data berhasil diekspor ke file Excel." ,
                                "Informasi",
                                MessageBoxButtons. OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
