using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace stokAsistani
{
    public partial class stokForm : Form
    {
        public anaForm ana;

        SqlConnection baglanti =
        new SqlConnection(
        @"Data Source=localhost\SQLEXPRESS;
        Initial Catalog=stokDB;
        Integrated Security=True;
        TrustServerCertificate=True");

        int secilenID = 0;

        void Listele()
        {
            SqlDataAdapter da =
            new SqlDataAdapter("select * from urunler", baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        public stokForm()
        {
            InitializeComponent();

            Listele();
        }

        private void stokForm_Load(object sender, EventArgs e)
        {
            cmbAramaTuruStok.Items.Add("ID");

            cmbAramaTuruStok.Items.Add("Ürün Adı");

            cmbAramaTuruStok.Items.Add("Kategori");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut =
                new SqlCommand(
                "delete from urunler where id=@p1",
                baglanti);

                komut.Parameters.AddWithValue("@p1", secilenID);

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Ürün silindi");

                Listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                "insert into urunler(urunAdi,kategori,stok,fiyat) values (@p1,@p2,@p3,@p4)",
                baglanti);

                komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtKategori.Text);
                komut.Parameters.AddWithValue("@p3", int.Parse(txtStok.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtFiyat.Text));

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Ürün başarıyla eklendi");
                Listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value == DBNull.Value)
            {
                return;
            }
            secilenID =
            Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            txtUrunAdi.Text =
            dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtKategori.Text =
            dataGridView1.CurrentRow.Cells[2].Value.ToString();

            txtStok.Text =
            dataGridView1.CurrentRow.Cells[3].Value.ToString();

            txtFiyat.Text =
            dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "" || txtKategori.Text == "" || txtStok.Text == "" || txtFiyat.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }
            try
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }

                baglanti.Open();

                SqlCommand komut =
                new SqlCommand(
                "update urunler set urunAdi=@p1,kategori=@p2,stok=@p3,fiyat=@p4 where id=@p5",
                baglanti);

                komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtKategori.Text);
                komut.Parameters.AddWithValue("@p3", int.Parse(txtStok.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p5", secilenID);

                komut.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Ürün güncellendi");

                Listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunAdi.Text = "";
            txtKategori.Text = "";
            txtStok.Text = "";
            txtFiyat.Text = "";

            txtUrunAdi.Focus();
        }

        private void btnAraStok_Click(object sender, EventArgs e)
        {
            string alan = "";

            if (cmbAramaTuruStok.Text == "ID")
            {
                alan = "id";
            }
            else if (cmbAramaTuruStok.Text == "Ürün Adı")
            {
                alan = "urunAdi";
            }
            else if (cmbAramaTuruStok.Text == "Kategori")
            {
                alan = "kategori";
            }

            SqlDataAdapter da = new SqlDataAdapter(
            "select * from urunler where " + alan +
            " like '%" + txtAraStok.Text + "%'",
            baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
