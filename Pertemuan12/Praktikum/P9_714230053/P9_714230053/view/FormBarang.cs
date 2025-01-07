using P9_714230053.controller;
using P9_714230053.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714230053.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        string id_barang;

        public FormBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");

            dataBarang.Columns[0].HeaderText = "ID";
            dataBarang.Columns[1].HeaderText = "Nama Barang";
            dataBarang.Columns[2].HeaderText = "Harga";

            dataBarang.Columns[2].DefaultCellStyle.Format = "Rp ###,###";
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        public void ResetForm()
        {
            textBoxNamaBarang.Text = "";
            textBoxHarga.Text = "";
            textBoxCariData.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "" || textBoxHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang brg = new Barang();
                m_barang.Nama_barang = textBoxNamaBarang.Text;
                m_barang.Harga = textBoxHarga.Text;

                brg.Insert(m_barang);

                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "" || textBoxHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang brg = new Barang();
                m_barang.Nama_barang = textBoxNamaBarang.Text;
                m_barang.Harga = textBoxHarga.Text;

                brg.Update(m_barang, id_barang);

                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Barang brg = new Barang();
                brg.Delete(id_barang);
                ResetForm();
                Tampil();
            }
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            dataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE harga LIKE '%' '" + textBoxCariData.Text + "' \r\n'%' OR nama_barang LIKE '%' '" + textBoxCariData.Text + "' '%'");
        }

        private void dataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNamaBarang.Text = dataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxHarga.Text = dataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
