namespace stokAsistani
{
    partial class satisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisForm));
            pictureSatisEkraniLogo = new PictureBox();
            lblSatisİslemleri = new Label();
            panelCizgi1 = new Panel();
            cmbUrunAdi = new ComboBox();
            txtMiktar = new TextBox();
            txtFiyat = new TextBox();
            txtMusteriAdi = new TextBox();
            dateSatısTarihi = new DateTimePicker();
            lblSatısEkraniÜrünAdi = new Label();
            lblSatısEkraniSatisMiktari = new Label();
            lblSatısEkraniToplamFiyat = new Label();
            lblSatısEkraniMüsteriAdi = new Label();
            txtMusteriTcVergi = new TextBox();
            lblSatısEkraniVergiTcNo = new Label();
            btnSatisEkle = new Button();
            btnSatisSil = new Button();
            btnSatisTemizle = new Button();
            dataGridView1 = new DataGridView();
            cmbAramaTuruSatis = new ComboBox();
            txtAraSatis = new TextBox();
            btnAraSatis = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureSatisEkraniLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureSatisEkraniLogo
            // 
            pictureSatisEkraniLogo.BackColor = Color.Transparent;
            pictureSatisEkraniLogo.Image = (Image)resources.GetObject("pictureSatisEkraniLogo.Image");
            pictureSatisEkraniLogo.Location = new Point(12, 12);
            pictureSatisEkraniLogo.Name = "pictureSatisEkraniLogo";
            pictureSatisEkraniLogo.Size = new Size(128, 109);
            pictureSatisEkraniLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSatisEkraniLogo.TabIndex = 1;
            pictureSatisEkraniLogo.TabStop = false;
            // 
            // lblSatisİslemleri
            // 
            lblSatisİslemleri.AutoSize = true;
            lblSatisİslemleri.BackColor = Color.Transparent;
            lblSatisİslemleri.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSatisİslemleri.ForeColor = Color.DarkRed;
            lblSatisİslemleri.Location = new Point(146, 41);
            lblSatisİslemleri.Name = "lblSatisİslemleri";
            lblSatisİslemleri.Size = new Size(248, 47);
            lblSatisİslemleri.TabIndex = 2;
            lblSatisİslemleri.Text = "Satış İşlemleri";
            lblSatisİslemleri.Click += lblStokİslemleri_Click;
            // 
            // panelCizgi1
            // 
            panelCizgi1.BackColor = Color.DarkRed;
            panelCizgi1.ForeColor = Color.DarkRed;
            panelCizgi1.Location = new Point(163, 91);
            panelCizgi1.Name = "panelCizgi1";
            panelCizgi1.Size = new Size(211, 1);
            panelCizgi1.TabIndex = 3;
            // 
            // cmbUrunAdi
            // 
            cmbUrunAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUrunAdi.Font = new Font("Segoe UI", 11F);
            cmbUrunAdi.FormattingEnabled = true;
            cmbUrunAdi.Location = new Point(206, 202);
            cmbUrunAdi.Name = "cmbUrunAdi";
            cmbUrunAdi.Size = new Size(230, 28);
            cmbUrunAdi.TabIndex = 4;
            cmbUrunAdi.SelectedIndexChanged += cmbUrunAdi_SelectedIndexChanged;
            // 
            // txtMiktar
            // 
            txtMiktar.Font = new Font("Segoe UI", 11F);
            txtMiktar.Location = new Point(206, 258);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(230, 27);
            txtMiktar.TabIndex = 5;
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new Font("Segoe UI", 11F);
            txtFiyat.Location = new Point(206, 321);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(230, 27);
            txtFiyat.TabIndex = 6;
            txtFiyat.TextChanged += txtFiyat_TextChanged;
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Font = new Font("Segoe UI", 11F);
            txtMusteriAdi.Location = new Point(206, 376);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(230, 27);
            txtMusteriAdi.TabIndex = 7;
            // 
            // dateSatısTarihi
            // 
            dateSatısTarihi.CalendarFont = new Font("Segoe UI", 10F);
            dateSatısTarihi.Location = new Point(221, 506);
            dateSatısTarihi.Name = "dateSatısTarihi";
            dateSatısTarihi.Size = new Size(200, 23);
            dateSatısTarihi.TabIndex = 8;
            // 
            // lblSatısEkraniÜrünAdi
            // 
            lblSatısEkraniÜrünAdi.AutoSize = true;
            lblSatısEkraniÜrünAdi.BackColor = Color.Transparent;
            lblSatısEkraniÜrünAdi.Font = new Font("Segoe UI", 12F);
            lblSatısEkraniÜrünAdi.Location = new Point(37, 202);
            lblSatısEkraniÜrünAdi.Name = "lblSatısEkraniÜrünAdi";
            lblSatısEkraniÜrünAdi.Size = new Size(79, 21);
            lblSatısEkraniÜrünAdi.TabIndex = 9;
            lblSatısEkraniÜrünAdi.Text = "Ürün Adı :";
            // 
            // lblSatısEkraniSatisMiktari
            // 
            lblSatısEkraniSatisMiktari.AutoSize = true;
            lblSatısEkraniSatisMiktari.BackColor = Color.Transparent;
            lblSatısEkraniSatisMiktari.Font = new Font("Segoe UI", 12F);
            lblSatısEkraniSatisMiktari.Location = new Point(37, 260);
            lblSatısEkraniSatisMiktari.Name = "lblSatısEkraniSatisMiktari";
            lblSatısEkraniSatisMiktari.Size = new Size(107, 21);
            lblSatısEkraniSatisMiktari.TabIndex = 10;
            lblSatısEkraniSatisMiktari.Text = "Satış Miktarı : ";
            // 
            // lblSatısEkraniToplamFiyat
            // 
            lblSatısEkraniToplamFiyat.AutoSize = true;
            lblSatısEkraniToplamFiyat.BackColor = Color.Transparent;
            lblSatısEkraniToplamFiyat.Font = new Font("Segoe UI", 12F);
            lblSatısEkraniToplamFiyat.Location = new Point(37, 323);
            lblSatısEkraniToplamFiyat.Name = "lblSatısEkraniToplamFiyat";
            lblSatısEkraniToplamFiyat.Size = new Size(104, 21);
            lblSatısEkraniToplamFiyat.TabIndex = 11;
            lblSatısEkraniToplamFiyat.Text = "Toplam Fiyat :";
            // 
            // lblSatısEkraniMüsteriAdi
            // 
            lblSatısEkraniMüsteriAdi.AutoSize = true;
            lblSatısEkraniMüsteriAdi.BackColor = Color.Transparent;
            lblSatısEkraniMüsteriAdi.Font = new Font("Segoe UI", 12F);
            lblSatısEkraniMüsteriAdi.Location = new Point(37, 382);
            lblSatısEkraniMüsteriAdi.Name = "lblSatısEkraniMüsteriAdi";
            lblSatısEkraniMüsteriAdi.Size = new Size(97, 21);
            lblSatısEkraniMüsteriAdi.TabIndex = 12;
            lblSatısEkraniMüsteriAdi.Text = "Müşteri Adı :";
            // 
            // txtMusteriTcVergi
            // 
            txtMusteriTcVergi.Font = new Font("Segoe UI", 11F);
            txtMusteriTcVergi.Location = new Point(206, 439);
            txtMusteriTcVergi.MaxLength = 11;
            txtMusteriTcVergi.Name = "txtMusteriTcVergi";
            txtMusteriTcVergi.Size = new Size(230, 27);
            txtMusteriTcVergi.TabIndex = 13;
            // 
            // lblSatısEkraniVergiTcNo
            // 
            lblSatısEkraniVergiTcNo.AutoSize = true;
            lblSatısEkraniVergiTcNo.BackColor = Color.Transparent;
            lblSatısEkraniVergiTcNo.Font = new Font("Segoe UI", 12F);
            lblSatısEkraniVergiTcNo.Location = new Point(37, 439);
            lblSatısEkraniVergiTcNo.Name = "lblSatısEkraniVergiTcNo";
            lblSatısEkraniVergiTcNo.Size = new Size(158, 21);
            lblSatısEkraniVergiTcNo.TabIndex = 14;
            lblSatısEkraniVergiTcNo.Text = "Müşteri TC-Vergi No :";
            // 
            // btnSatisEkle
            // 
            btnSatisEkle.BackColor = Color.Firebrick;
            btnSatisEkle.FlatAppearance.BorderSize = 0;
            btnSatisEkle.FlatStyle = FlatStyle.Flat;
            btnSatisEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSatisEkle.ForeColor = Color.White;
            btnSatisEkle.Location = new Point(272, 553);
            btnSatisEkle.Name = "btnSatisEkle";
            btnSatisEkle.Size = new Size(200, 50);
            btnSatisEkle.TabIndex = 17;
            btnSatisEkle.Text = "Ekle";
            btnSatisEkle.UseVisualStyleBackColor = false;
            btnSatisEkle.Click += btnEkle_Click;
            // 
            // btnSatisSil
            // 
            btnSatisSil.BackColor = Color.Firebrick;
            btnSatisSil.FlatAppearance.BorderSize = 0;
            btnSatisSil.FlatStyle = FlatStyle.Flat;
            btnSatisSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSatisSil.ForeColor = Color.White;
            btnSatisSil.Location = new Point(496, 553);
            btnSatisSil.Name = "btnSatisSil";
            btnSatisSil.Size = new Size(200, 50);
            btnSatisSil.TabIndex = 18;
            btnSatisSil.Text = "Sil";
            btnSatisSil.UseVisualStyleBackColor = false;
            btnSatisSil.Click += btnSil_Click;
            // 
            // btnSatisTemizle
            // 
            btnSatisTemizle.BackColor = Color.Firebrick;
            btnSatisTemizle.FlatAppearance.BorderSize = 0;
            btnSatisTemizle.FlatStyle = FlatStyle.Flat;
            btnSatisTemizle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSatisTemizle.ForeColor = Color.White;
            btnSatisTemizle.Location = new Point(384, 609);
            btnSatisTemizle.Name = "btnSatisTemizle";
            btnSatisTemizle.Size = new Size(200, 50);
            btnSatisTemizle.TabIndex = 19;
            btnSatisTemizle.Text = "Temizle";
            btnSatisTemizle.UseVisualStyleBackColor = false;
            btnSatisTemizle.Click += btnSatisTemizle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(522, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(650, 496);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbAramaTuruSatis
            // 
            cmbAramaTuruSatis.FormattingEnabled = true;
            cmbAramaTuruSatis.Location = new Point(838, 539);
            cmbAramaTuruSatis.Name = "cmbAramaTuruSatis";
            cmbAramaTuruSatis.Size = new Size(121, 23);
            cmbAramaTuruSatis.TabIndex = 21;
            // 
            // txtAraSatis
            // 
            txtAraSatis.Location = new Point(965, 539);
            txtAraSatis.Name = "txtAraSatis";
            txtAraSatis.Size = new Size(100, 23);
            txtAraSatis.TabIndex = 22;
            // 
            // btnAraSatis
            // 
            btnAraSatis.Location = new Point(930, 569);
            btnAraSatis.Name = "btnAraSatis";
            btnAraSatis.Size = new Size(75, 23);
            btnAraSatis.TabIndex = 23;
            btnAraSatis.Text = "Ara";
            btnAraSatis.UseVisualStyleBackColor = true;
            btnAraSatis.Click += btnAraSatis_Click;
            // 
            // satisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1184, 661);
            Controls.Add(btnAraSatis);
            Controls.Add(txtAraSatis);
            Controls.Add(cmbAramaTuruSatis);
            Controls.Add(dataGridView1);
            Controls.Add(btnSatisTemizle);
            Controls.Add(btnSatisSil);
            Controls.Add(btnSatisEkle);
            Controls.Add(lblSatısEkraniVergiTcNo);
            Controls.Add(txtMusteriTcVergi);
            Controls.Add(lblSatısEkraniMüsteriAdi);
            Controls.Add(lblSatısEkraniToplamFiyat);
            Controls.Add(lblSatısEkraniSatisMiktari);
            Controls.Add(lblSatısEkraniÜrünAdi);
            Controls.Add(dateSatısTarihi);
            Controls.Add(txtMusteriAdi);
            Controls.Add(txtFiyat);
            Controls.Add(txtMiktar);
            Controls.Add(cmbUrunAdi);
            Controls.Add(panelCizgi1);
            Controls.Add(lblSatisİslemleri);
            Controls.Add(pictureSatisEkraniLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "satisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış İşlemleri";
            Load += satisForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureSatisEkraniLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureSatisEkraniLogo;
        private Label lblSatisİslemleri;
        private Panel panelCizgi1;
        private ComboBox cmbUrunAdi;
        private TextBox txtMiktar;
        private TextBox txtFiyat;
        private TextBox txtMusteriAdi;
        private DateTimePicker dateSatısTarihi;
        private Label lblSatısEkraniÜrünAdi;
        private Label lblSatısEkraniSatisMiktari;
        private Label lblSatısEkraniToplamFiyat;
        private Label lblSatısEkraniMüsteriAdi;
        private TextBox txtMusteriTcVergi;
        private Label lblSatısEkraniVergiTcNo;
        private Button btnSatisEkle;
        private Button btnSatisSil;
        private Button btnSatisTemizle;
        private DataGridView dataGridView1;
        private ComboBox cmbAramaTuruSatis;
        private TextBox txtAraSatis;
        private Button btnAraSatis;
    }
}