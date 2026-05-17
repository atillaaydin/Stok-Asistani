using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace stokAsistani
{
    public partial class anaForm : Form
    {
        SqlConnection baglanti =
        new SqlConnection(
        @"Data Source=localhost\SQLEXPRESS;
        Initial Catalog=stokDB;
        Integrated Security=True;
        TrustServerCertificate=True");

        public void Dashboard()
        {
            baglanti.Open();

            // toplam ürün
            SqlCommand urunKomut =
            new SqlCommand(
            "select count(*) from urunler",
            baglanti);

            lblToplamUrun.Text =
            urunKomut.ExecuteScalar().ToString();


            // toplam satış
            SqlCommand satisKomut =
            new SqlCommand(
            "select sum(toplamFiyat) from satislar",
            baglanti);

            object sonuc = satisKomut.ExecuteScalar();

            if (sonuc != DBNull.Value)
            {
                lblToplamSatis.Text =
                sonuc.ToString() + " ₺";
            }
            else
            {
                lblToplamSatis.Text = "0 ₺";
            }

            baglanti.Close();
        }
        public anaForm()
        {
            InitializeComponent();

            Dashboard();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show(
                "Çıkış yapmak istediğinize emin misiniz?",
                "Çıkış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            satisForm satis = new satisForm();

            satis.ana = this;

            satis.ShowDialog();

            Dashboard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxWhatsapp_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://wa.me/905365289769",
                UseShellExecute = true
            });

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            stokForm stok = new stokForm();

            stok.ana = this;

            stok.ShowDialog();

            Dashboard();
        }

        private void lblStokAsistani_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");

            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPanelStokSayi_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSatis_Click_1(object sender, EventArgs e)
        {
            satisForm satis = new satisForm();

            satis.ana = this;

            satis.ShowDialog();

            Dashboard();
        }
    }
}

