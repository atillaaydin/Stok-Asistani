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
    public partial class satisForm : Form
    {
        public anaForm ana;
        decimal urunFiyat = 0;

        int secilenSatisID = 0;
        string secilenUrun = "";
        int secilenMiktar = 0;

        SqlConnection baglanti =
        new SqlConnection(
        @"Data Source=localhost\SQLEXPRESS;
        Initial Catalog=stokDB;
        Integrated Security=True;
        TrustServerCertificate=True");
        public satisForm()
        {
            InitializeComponent();

            UrunGetir();

            Listele();
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter(
            "select * from satislar", baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        void UrunGetir()
        {
            baglanti.Open();

            SqlCommand komut =
            new SqlCommand("select urunAdi from urunler", baglanti);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                cmbUrunAdi.Items.Add(dr[0].ToString());
            }

            baglanti.Close();
        }

        private void lblStokİslemleri_Click(object sender, EventArgs e)
        {

        }

        private void satisForm_Load(object sender, EventArgs e)
        {
            cmbAramaTuruSatis.Items.Add("ID");
            cmbAramaTuruSatis.Items.Add("Ürün Adı");
            cmbAramaTuruSatis.Items.Add("Müşteri Adı");
            cmbAramaTuruSatis.Items.Add("TC No");

        }

        private void cmbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand(
            "select fiyat from urunler where urunAdi=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", cmbUrunAdi.Text);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                urunFiyat = decimal.Parse(dr[0].ToString());

                txtFiyat.Text = urunFiyat.ToString();
            }

            baglanti.Close();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int miktar = int.Parse(txtMiktar.Text);

                txtFiyat.Text =
                (urunFiyat * miktar).ToString();
            }
            catch
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                "insert into satislar(urunAdi,miktar,toplamFiyat,musteriAdi,musteriTC,tarih) values(@p1,@p2,@p3,@p4,@p5,@p6)",
                baglanti);

                komut.Parameters.AddWithValue("@p1", cmbUrunAdi.Text);
                komut.Parameters.AddWithValue("@p2", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                komut.Parameters.AddWithValue("@p4", txtMusteriAdi.Text);
                komut.Parameters.AddWithValue("@p5", txtMusteriTcVergi.Text);
                komut.Parameters.AddWithValue("@p6", dateSatısTarihi.Value);

                komut.ExecuteNonQuery();

                SqlCommand stokAzalt = new SqlCommand(
                "update urunler set stok = stok - @stok where urunAdi=@urun",
                baglanti);

                stokAzalt.Parameters.AddWithValue("@stok", int.Parse(txtMiktar.Text));
                stokAzalt.Parameters.AddWithValue("@urun", cmbUrunAdi.Text);

                stokAzalt.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Satış başarılı");

                Listele();

                if (ana != null)
                {
                    ana.Dashboard();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(
                "Lütfen tüm alanları doğru şekilde doldurun!",
                "Uyarı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenSatisID =
            Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            secilenUrun =
            dataGridView1.CurrentRow.Cells[1].Value.ToString();

            secilenMiktar =
            Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand satisSil = new SqlCommand(
                "delete from satislar where id=@p1",
                baglanti);

                satisSil.Parameters.AddWithValue("@p1", secilenSatisID);

                satisSil.ExecuteNonQuery();

                SqlCommand stokGeri = new SqlCommand(
                "update urunler set stok = stok + @stok where urunAdi=@urun",
                baglanti);

                stokGeri.Parameters.AddWithValue("@stok", secilenMiktar);
                stokGeri.Parameters.AddWithValue("@urun", secilenUrun);

                stokGeri.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Satış silindi");

                Listele();

                if (ana != null)
                {
                    ana.Dashboard();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnSatisTemizle_Click(object sender, EventArgs e)
        {
            cmbUrunAdi.Text = "";
            txtMiktar.Clear();
            txtFiyat.Clear();
            txtMusteriAdi.Clear();
            txtMusteriTcVergi.Clear();

            cmbUrunAdi.Focus();
        }

        private void btnAraSatis_Click(object sender, EventArgs e)
        {
            string sorgu = "";

            if (cmbAramaTuruSatis.Text == "ID")
            {
                sorgu = "select * from satislar where CAST(id as nvarchar) like @arama";
            }
            else if (cmbAramaTuruSatis.Text == "Ürün Adı")
            {
                sorgu = "select * from satislar where urunAdi like @arama";
            }
            else if (cmbAramaTuruSatis.Text == "Müşteri Adı")
            {
                sorgu = "select * from satislar where musteriAdi like @arama";
            }
            else if (cmbAramaTuruSatis.Text == "TC No")
            {
                sorgu = "select * from satislar where musteriTC like @arama";
            }

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

            da.SelectCommand.Parameters.AddWithValue(
            "@arama",
            "%" + txtAraSatis.Text + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }



    }
}
