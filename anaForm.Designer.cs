using System.Diagnostics;

namespace stokAsistani
{
    partial class anaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaForm));
            btnStok = new Button();
            btnCikis = new Button();
            btnSatis = new Button();
            lblStokAsistani = new Label();
            lblYönetim = new Label();
            panelCizgi1 = new Panel();
            panelCizgi2 = new Panel();
            lblWhatsapp = new Label();
            lblWhatsappAltYazi = new Label();
            pictureboxWhatsapp = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTarih = new Label();
            pictureTarih = new PictureBox();
            lblSaat = new Label();
            pictureSaat = new PictureBox();
            panel1 = new Panel();
            lblYönetimSistemi = new Label();
            pictureAnaBüyükLogo = new PictureBox();
            labelStokAna = new Label();
            lblAltYazi = new Label();
            panel2 = new Panel();
            label1 = new Label();
            lblToplamUrun = new Label();
            lblPanelToplamÜrün = new Label();
            picturePanelStok = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            lblToplamSatis = new Label();
            lblPanelToplamSatis = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            lblPanelAktifKullanıcı = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureboxWhatsapp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTarih).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSaat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAnaBüyükLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePanelStok).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnStok
            // 
            btnStok.BackColor = Color.Firebrick;
            btnStok.Cursor = Cursors.Hand;
            btnStok.FlatAppearance.BorderColor = Color.White;
            btnStok.FlatAppearance.BorderSize = 0;
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Font = new Font("Segoe UI", 16F);
            btnStok.Image = (Image)resources.GetObject("btnStok.Image");
            btnStok.ImageAlign = ContentAlignment.MiddleLeft;
            btnStok.Location = new Point(55, 219);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(206, 69);
            btnStok.TabIndex = 0;
            btnStok.Text = "Stok İşlemleri";
            btnStok.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStok.UseVisualStyleBackColor = false;
            btnStok.Click += btnStok_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Firebrick;
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.FlatAppearance.BorderColor = Color.White;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI", 16F);
            btnCikis.Image = (Image)resources.GetObject("btnCikis.Image");
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.Location = new Point(55, 389);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(206, 69);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click_1;
            // 
            // btnSatis
            // 
            btnSatis.BackColor = Color.Firebrick;
            btnSatis.Cursor = Cursors.Hand;
            btnSatis.FlatAppearance.BorderColor = Color.White;
            btnSatis.FlatAppearance.BorderSize = 0;
            btnSatis.FlatStyle = FlatStyle.Flat;
            btnSatis.Font = new Font("Segoe UI", 16F);
            btnSatis.Image = (Image)resources.GetObject("btnSatis.Image");
            btnSatis.ImageAlign = ContentAlignment.MiddleLeft;
            btnSatis.Location = new Point(55, 304);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(206, 69);
            btnSatis.TabIndex = 2;
            btnSatis.Text = "Satış İşlemleri";
            btnSatis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSatis.UseVisualStyleBackColor = false;
            btnSatis.Click += btnSatis_Click_1;
            // 
            // lblStokAsistani
            // 
            lblStokAsistani.AutoSize = true;
            lblStokAsistani.BackColor = Color.Transparent;
            lblStokAsistani.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStokAsistani.ForeColor = Color.White;
            lblStokAsistani.Location = new Point(69, 32);
            lblStokAsistani.Name = "lblStokAsistani";
            lblStokAsistani.Size = new Size(182, 37);
            lblStokAsistani.TabIndex = 3;
            lblStokAsistani.Text = "Stok Asistanı";
            lblStokAsistani.Click += lblStokAsistani_Click;
            // 
            // lblYönetim
            // 
            lblYönetim.AutoSize = true;
            lblYönetim.BackColor = Color.Transparent;
            lblYönetim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblYönetim.ForeColor = Color.White;
            lblYönetim.Location = new Point(114, 87);
            lblYönetim.Name = "lblYönetim";
            lblYönetim.Size = new Size(86, 15);
            lblYönetim.TabIndex = 5;
            lblYönetim.Text = "Yönetim Paneli";
            // 
            // panelCizgi1
            // 
            panelCizgi1.Location = new Point(86, 72);
            panelCizgi1.Name = "panelCizgi1";
            panelCizgi1.Size = new Size(150, 1);
            panelCizgi1.TabIndex = 6;
            // 
            // panelCizgi2
            // 
            panelCizgi2.BackColor = Color.White;
            panelCizgi2.ForeColor = Color.Gray;
            panelCizgi2.Location = new Point(33, 506);
            panelCizgi2.Name = "panelCizgi2";
            panelCizgi2.Size = new Size(250, 1);
            panelCizgi2.TabIndex = 8;
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.AutoSize = true;
            lblWhatsapp.BackColor = Color.Transparent;
            lblWhatsapp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWhatsapp.Location = new Point(46, 560);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(218, 25);
            lblWhatsapp.TabIndex = 9;
            lblWhatsapp.Text = "WhatsApp Destek Hattı";
            // 
            // lblWhatsappAltYazi
            // 
            lblWhatsappAltYazi.AutoSize = true;
            lblWhatsappAltYazi.BackColor = Color.Transparent;
            lblWhatsappAltYazi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWhatsappAltYazi.Location = new Point(86, 603);
            lblWhatsappAltYazi.Name = "lblWhatsappAltYazi";
            lblWhatsappAltYazi.Size = new Size(131, 15);
            lblWhatsappAltYazi.TabIndex = 10;
            lblWhatsappAltYazi.Text = "Bizimle iletişime geçin";
            // 
            // pictureboxWhatsapp
            // 
            pictureboxWhatsapp.BackColor = Color.Transparent;
            pictureboxWhatsapp.Cursor = Cursors.Hand;
            pictureboxWhatsapp.Image = (Image)resources.GetObject("pictureboxWhatsapp.Image");
            pictureboxWhatsapp.Location = new Point(69, 645);
            pictureboxWhatsapp.Name = "pictureboxWhatsapp";
            pictureboxWhatsapp.Size = new Size(173, 149);
            pictureboxWhatsapp.SizeMode = PictureBoxSizeMode.Zoom;
            pictureboxWhatsapp.TabIndex = 11;
            pictureboxWhatsapp.TabStop = false;
            pictureboxWhatsapp.Click += pictureboxWhatsapp_Click_1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.BackColor = Color.Transparent;
            lblTarih.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTarih.ForeColor = Color.Black;
            lblTarih.ImageAlign = ContentAlignment.TopLeft;
            lblTarih.Location = new Point(1770, 48);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(90, 21);
            lblTarih.TabIndex = 12;
            lblTarih.Text = "13.05.2025";
            // 
            // pictureTarih
            // 
            pictureTarih.BackColor = Color.Transparent;
            pictureTarih.Image = (Image)resources.GetObject("pictureTarih.Image");
            pictureTarih.Location = new Point(1740, 48);
            pictureTarih.Name = "pictureTarih";
            pictureTarih.Size = new Size(24, 24);
            pictureTarih.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTarih.TabIndex = 13;
            pictureTarih.TabStop = false;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.BackColor = Color.Transparent;
            lblSaat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSaat.ForeColor = Color.Black;
            lblSaat.Location = new Point(1638, 47);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(72, 21);
            lblSaat.TabIndex = 14;
            lblSaat.Text = "10:47:22";
            // 
            // pictureSaat
            // 
            pictureSaat.BackColor = Color.Transparent;
            pictureSaat.Image = (Image)resources.GetObject("pictureSaat.Image");
            pictureSaat.Location = new Point(1608, 48);
            pictureSaat.Name = "pictureSaat";
            pictureSaat.Size = new Size(24, 24);
            pictureSaat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSaat.TabIndex = 15;
            pictureSaat.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.ForeColor = Color.Gray;
            panel1.Location = new Point(1720, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 20);
            panel1.TabIndex = 9;
            // 
            // lblYönetimSistemi
            // 
            lblYönetimSistemi.AutoSize = true;
            lblYönetimSistemi.BackColor = Color.Transparent;
            lblYönetimSistemi.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblYönetimSistemi.ForeColor = Color.Black;
            lblYönetimSistemi.Location = new Point(1012, 389);
            lblYönetimSistemi.Name = "lblYönetimSistemi";
            lblYönetimSistemi.Size = new Size(311, 51);
            lblYönetimSistemi.TabIndex = 16;
            lblYönetimSistemi.Text = "Yönetim Sistemi";
            // 
            // pictureAnaBüyükLogo
            // 
            pictureAnaBüyükLogo.BackColor = Color.Transparent;
            pictureAnaBüyükLogo.Image = (Image)resources.GetObject("pictureAnaBüyükLogo.Image");
            pictureAnaBüyükLogo.Location = new Point(864, 33);
            pictureAnaBüyükLogo.Name = "pictureAnaBüyükLogo";
            pictureAnaBüyükLogo.Size = new Size(473, 340);
            pictureAnaBüyükLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAnaBüyükLogo.TabIndex = 17;
            pictureAnaBüyükLogo.TabStop = false;
            // 
            // labelStokAna
            // 
            labelStokAna.AutoSize = true;
            labelStokAna.BackColor = Color.Transparent;
            labelStokAna.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            labelStokAna.ForeColor = Color.DarkRed;
            labelStokAna.Location = new Point(915, 389);
            labelStokAna.Name = "labelStokAna";
            labelStokAna.Size = new Size(101, 51);
            labelStokAna.TabIndex = 18;
            labelStokAna.Text = "Stok";
            // 
            // lblAltYazi
            // 
            lblAltYazi.AutoSize = true;
            lblAltYazi.BackColor = Color.Transparent;
            lblAltYazi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAltYazi.ForeColor = Color.Gray;
            lblAltYazi.Location = new Point(933, 454);
            lblAltYazi.Name = "lblAltYazi";
            lblAltYazi.Size = new Size(376, 21);
            lblAltYazi.TabIndex = 19;
            lblAltYazi.Text = "Ürün, satış ve stok işlemlerinizi kolayca yönetin.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblToplamUrun);
            panel2.Controls.Add(lblPanelToplamÜrün);
            panel2.Controls.Add(picturePanelStok);
            panel2.Location = new Point(723, 527);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 120);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(95, 90);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 25;
            label1.Text = "Adet";
            // 
            // lblToplamUrun
            // 
            lblToplamUrun.AutoSize = true;
            lblToplamUrun.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblToplamUrun.ForeColor = Color.DarkRed;
            lblToplamUrun.Location = new Point(90, 45);
            lblToplamUrun.Name = "lblToplamUrun";
            lblToplamUrun.Size = new Size(69, 41);
            lblToplamUrun.TabIndex = 24;
            lblToplamUrun.Text = "125";
            lblToplamUrun.Click += lblPanelStokSayi_Click;
            // 
            // lblPanelToplamÜrün
            // 
            lblPanelToplamÜrün.AutoSize = true;
            lblPanelToplamÜrün.BackColor = Color.Transparent;
            lblPanelToplamÜrün.Font = new Font("Segoe UI", 11F);
            lblPanelToplamÜrün.ForeColor = Color.Gray;
            lblPanelToplamÜrün.Location = new Point(90, 20);
            lblPanelToplamÜrün.Name = "lblPanelToplamÜrün";
            lblPanelToplamÜrün.Size = new Size(94, 20);
            lblPanelToplamÜrün.TabIndex = 23;
            lblPanelToplamÜrün.Text = "Toplam Ürün";
            // 
            // picturePanelStok
            // 
            picturePanelStok.Image = (Image)resources.GetObject("picturePanelStok.Image");
            picturePanelStok.Location = new Point(15, 25);
            picturePanelStok.Name = "picturePanelStok";
            picturePanelStok.Size = new Size(60, 60);
            picturePanelStok.SizeMode = PictureBoxSizeMode.Zoom;
            picturePanelStok.TabIndex = 22;
            picturePanelStok.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblToplamSatis);
            panel3.Controls.Add(lblPanelToplamSatis);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(997, 527);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 120);
            panel3.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(95, 90);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 26;
            label3.Text = "Miktarı";
            label3.Click += label3_Click;
            // 
            // lblToplamSatis
            // 
            lblToplamSatis.AutoSize = true;
            lblToplamSatis.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblToplamSatis.ForeColor = Color.DarkRed;
            lblToplamSatis.Location = new Point(90, 45);
            lblToplamSatis.Name = "lblToplamSatis";
            lblToplamSatis.Size = new Size(34, 25);
            lblToplamSatis.TabIndex = 26;
            lblToplamSatis.Text = "48";
            lblToplamSatis.Click += label2_Click;
            // 
            // lblPanelToplamSatis
            // 
            lblPanelToplamSatis.AutoSize = true;
            lblPanelToplamSatis.BackColor = Color.Transparent;
            lblPanelToplamSatis.Font = new Font("Segoe UI", 11F);
            lblPanelToplamSatis.ForeColor = Color.Gray;
            lblPanelToplamSatis.Location = new Point(90, 20);
            lblPanelToplamSatis.Name = "lblPanelToplamSatis";
            lblPanelToplamSatis.Size = new Size(94, 20);
            lblPanelToplamSatis.TabIndex = 26;
            lblPanelToplamSatis.Text = "Toplam Satış";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblPanelAktifKullanıcı);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(1269, 527);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 120);
            panel4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(95, 90);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 27;
            label5.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(90, 45);
            label4.Name = "label4";
            label4.Size = new Size(35, 41);
            label4.TabIndex = 27;
            label4.Text = "1";
            // 
            // lblPanelAktifKullanıcı
            // 
            lblPanelAktifKullanıcı.AutoSize = true;
            lblPanelAktifKullanıcı.BackColor = Color.Transparent;
            lblPanelAktifKullanıcı.Font = new Font("Segoe UI", 11F);
            lblPanelAktifKullanıcı.ForeColor = Color.Gray;
            lblPanelAktifKullanıcı.Location = new Point(96, 20);
            lblPanelAktifKullanıcı.Name = "lblPanelAktifKullanıcı";
            lblPanelAktifKullanıcı.Size = new Size(100, 20);
            lblPanelAktifKullanıcı.TabIndex = 27;
            lblPanelAktifKullanıcı.Text = "Aktif Kullanıcı";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // anaForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblAltYazi);
            Controls.Add(labelStokAna);
            Controls.Add(pictureAnaBüyükLogo);
            Controls.Add(lblYönetimSistemi);
            Controls.Add(panel1);
            Controls.Add(pictureSaat);
            Controls.Add(lblSaat);
            Controls.Add(pictureTarih);
            Controls.Add(lblTarih);
            Controls.Add(pictureboxWhatsapp);
            Controls.Add(lblWhatsappAltYazi);
            Controls.Add(lblWhatsapp);
            Controls.Add(panelCizgi2);
            Controls.Add(panelCizgi1);
            Controls.Add(lblYönetim);
            Controls.Add(lblStokAsistani);
            Controls.Add(btnSatis);
            Controls.Add(btnCikis);
            Controls.Add(btnStok);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "anaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Asitanı - AnaSayfa";
            WindowState = FormWindowState.Maximized;
            Load += anaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureboxWhatsapp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTarih).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSaat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAnaBüyükLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePanelStok).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://wa.me/905365289769",
                UseShellExecute = true
            });
        }

        #endregion
        private PictureBox pictureBox2;
        private Button btnStok;
        private Button btnCikis;
        private Button btnSatis;
        private Label lblStokAsistani;
        private Panel panelCizgi2;
        private Label lblYönetim;
        private Panel panelCizgi1;
        private Label lblWhatsapp;
        private Label lblWhatsappAltYazi;
        private PictureBox pictureboxWhatsapp;
        private System.Windows.Forms.Timer timer1;
        private Label lblTarih;
        private PictureBox pictureTarih;
        private Label lblSaat;
        private PictureBox pictureSaat;
        private Panel panel1;
        private Label lblYönetimSistemi;
        private PictureBox pictureAnaBüyükLogo;
        private Label labelStokAna;
        private Label lblAltYazi;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox picturePanelStok;
        private Label lblPanelToplamÜrün;
        private Label lblToplamUrun;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblPanelToplamSatis;
        private Label lblPanelAktifKullanıcı;
        private Label lblToplamSatis;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}