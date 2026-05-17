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
    public partial class loginForm : Form
    {
        SqlConnection baglanti =
        new SqlConnection(
        @"Data Source=localhost\SQLEXPRESS;
        Initial Catalog=stokDB;
        Integrated Security=True;
        TrustServerCertificate=True");

        bool sifreGoster = false;
        public loginForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            // Ekran boyutunu kilitle
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MinimumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblHosgeldiniz_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // BOŞ ALAN KONTROLÜ
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
            else
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                "select * from kullanicilar where kullaniciAdi=@kadi and sifre=@sifre",
                baglanti);

                komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text);

                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    baglanti.Close();

                    anaForm ana = new anaForm();

                    ana.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                    "Kullanıcı adı veya şifre hatalı!",
                    "Hatalı Giriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

                baglanti.Close();
            }

        }

        private void btnGiris_MouseEnter(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Red;
            btnGiris.ForeColor = Color.White;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.White;
            btnGiris.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (sifreGoster == false)
            {
                txtSifre.PasswordChar = '\0';
                sifreGoster = true;
            }
            else
            {
                txtSifre.PasswordChar = '*';
                sifreGoster = false;
            }
        }
    }
}
