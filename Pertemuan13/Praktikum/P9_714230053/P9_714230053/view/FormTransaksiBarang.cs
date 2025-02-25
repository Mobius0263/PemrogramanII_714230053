using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P9_714230053.view
{
    public partial class FormTransaksiBarang : Form
    {

        Koneksi koneksi = new Koneksi();
        M_transaksi_barang m_transaksi_barang = new M_transaksi_barang();
        string id_transaksi;
        public FormTransaksiBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang");

            dataTransaksi.Columns[0].HeaderText = "ID";
            dataTransaksi.Columns[1].HeaderText = "ID Barang";
            dataTransaksi.Columns[2].HeaderText = "Nama Barang";
            dataTransaksi.Columns[3].HeaderText = "Harga";
            dataTransaksi.Columns[4].HeaderText = "Quantity";
            dataTransaksi.Columns[5].HeaderText = "Total Harga";

            dataTransaksi.Columns[3].DefaultCellStyle.Format = "Rp ###,###";
            dataTransaksi.Columns[5].DefaultCellStyle.Format = "Rp ###,###";
        }

        public void GetDataTrx()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                int id_barang = reader.GetInt32("id_barang");
                comboBoxIdBarang.Items.Add(id_barang);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void FormTransaksiBarang_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataTrx();
        }

        public void ResetForm()
        {
            comboBoxIdBarang.SelectedIndex = -1;
            textBoxNamaBarang.Text = "";
            textBoxHargaBarang.Text = "";
            textBoxQuantity.Text = "";
            textBoxTotal.Text = "";
            textBoxCariData.Text = "";
        }

        public void getNamaBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang WHERE id_barang = '" + comboBoxIdBarang.Text + "'");
            while (reader.Read())
            {
                string nama_barang = reader.GetString("nama_barang");
                textBoxNamaBarang.Text = nama_barang;
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void getHargaBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang WHERE id_barang = '" + comboBoxIdBarang.Text + "'");
            while (reader.Read())
            {
                int harga = reader.GetInt32("harga");
                textBoxHargaBarang.Text = harga.ToString();
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void getTotal()
        {
            if (int.TryParse(textBoxQuantity.Text, out int qty) && int.TryParse(textBoxHargaBarang.Text, out int harga))
            {
                int total = qty * harga;
                textBoxTotal.Text = total.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (comboBoxIdBarang.Text == "" || textBoxNamaBarang.Text == "" || textBoxQuantity.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                m_transaksi_barang.Id_barang = comboBoxIdBarang.Text;
                m_transaksi_barang.Qty = textBoxQuantity.Text;
                m_transaksi_barang.Total = textBoxTotal.Text;

                transaksi.Insert(m_transaksi_barang);

                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (comboBoxIdBarang.Text == "" || textBoxNamaBarang.Text == "" || textBoxQuantity.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                m_transaksi_barang.Id_barang = comboBoxIdBarang.Text;
                m_transaksi_barang.Qty = textBoxQuantity.Text;
                m_transaksi_barang.Total = textBoxTotal.Text;

                transaksi.Update(m_transaksi_barang, id_transaksi);

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
                TransaksiBarang transaksi = new TransaksiBarang();
                transaksi.Delete(id_transaksi);
                ResetForm();
                Tampil();
            }
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            dataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang WHERE id_transaksi LIKE '%" + textBoxCariData.Text + "%' OR t_barang.id_barang LIKE '%" + textBoxCariData.Text + "%' OR nama_barang LIKE '%" + textBoxCariData.Text + "%' OR harga LIKE '%" + textBoxCariData.Text + "%' OR qty LIKE '%" + textBoxCariData.Text + "%' OR total LIKE '%" + textBoxCariData.Text + "%'");
        }

        private void dataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = dataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxIdBarang.Text = dataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxNamaBarang.Text = dataTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxHargaBarang.Text = dataTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxQuantity.Text = dataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxTotal.Text = dataTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void comboBoxIdBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNamaBarang();
            getHargaBarang();
            getTotal();
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            getTotal();
        }
    }
}
