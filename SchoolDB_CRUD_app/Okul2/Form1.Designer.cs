namespace school
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textad = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textnumara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonnumfiltre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxogrnumfiltre = new System.Windows.Forms.TextBox();
            this.textBoxogradfiltre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combosinif = new System.Windows.Forms.ComboBox();
            this.textPuan = new System.Windows.Forms.TextBox();
            this.btnDersKaydet = new System.Windows.Forms.Button();
            this.ogrID = new System.Windows.Forms.Label();
            this.ders = new System.Windows.Forms.Label();
            this.not = new System.Windows.Forms.Label();
            this.btnOdevListe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNumFiltre2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumFiltre2 = new System.Windows.Forms.TextBox();
            this.textBoxFiltre2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ders_ogr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboders = new System.Windows.Forms.ComboBox();
            this.comboOgrNum = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ogrAdı,
            this.soyadi,
            this.num,
            this.sinif,
            this.sinifid});
            this.dataGridView1.Location = new System.Drawing.Point(6, 343);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(722, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 70;
            // 
            // ogrAdı
            // 
            this.ogrAdı.DataPropertyName = "ad";
            this.ogrAdı.HeaderText = "Öğrenci Adı";
            this.ogrAdı.MinimumWidth = 6;
            this.ogrAdı.Name = "ogrAdı";
            this.ogrAdı.ReadOnly = true;
            this.ogrAdı.Width = 125;
            // 
            // soyadi
            // 
            this.soyadi.DataPropertyName = "soyad";
            this.soyadi.HeaderText = "Soyadı";
            this.soyadi.MinimumWidth = 6;
            this.soyadi.Name = "soyadi";
            this.soyadi.ReadOnly = true;
            this.soyadi.Width = 125;
            // 
            // num
            // 
            this.num.DataPropertyName = "numara";
            this.num.HeaderText = "Numarası";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Width = 90;
            // 
            // sinif
            // 
            this.sinif.DataPropertyName = "sinif";
            this.sinif.HeaderText = "Sınıfı";
            this.sinif.MinimumWidth = 6;
            this.sinif.Name = "sinif";
            this.sinif.ReadOnly = true;
            this.sinif.Width = 90;
            // 
            // sinifid
            // 
            this.sinifid.DataPropertyName = "sinifid";
            this.sinifid.HeaderText = "sınıfId";
            this.sinifid.MinimumWidth = 6;
            this.sinifid.Name = "sinifid";
            this.sinifid.ReadOnly = true;
            this.sinifid.Visible = false;
            this.sinifid.Width = 125;
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(103, 77);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(100, 22);
            this.textad.TabIndex = 1;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(103, 105);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(100, 22);
            this.textsoyad.TabIndex = 2;
            // 
            // textnumara
            // 
            this.textnumara.Location = new System.Drawing.Point(103, 133);
            this.textnumara.Name = "textnumara";
            this.textnumara.Size = new System.Drawing.Size(100, 22);
            this.textnumara.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sinif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numara";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(236, 64);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(84, 35);
            this.btnkaydet.TabIndex = 5;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(236, 115);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(84, 35);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "Kaydı Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(236, 161);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(84, 35);
            this.btnguncelle.TabIndex = 7;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonnumfiltre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxogrnumfiltre);
            this.groupBox1.Controls.Add(this.textBoxogradfiltre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(38, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // buttonnumfiltre
            // 
            this.buttonnumfiltre.Location = new System.Drawing.Point(233, 49);
            this.buttonnumfiltre.Name = "buttonnumfiltre";
            this.buttonnumfiltre.Size = new System.Drawing.Size(75, 23);
            this.buttonnumfiltre.TabIndex = 8;
            this.buttonnumfiltre.Text = "Ara";
            this.buttonnumfiltre.UseVisualStyleBackColor = true;
            this.buttonnumfiltre.Click += new System.EventHandler(this.buttonnumfiltre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numara";
            // 
            // textBoxogrnumfiltre
            // 
            this.textBoxogrnumfiltre.Location = new System.Drawing.Point(107, 51);
            this.textBoxogrnumfiltre.Name = "textBoxogrnumfiltre";
            this.textBoxogrnumfiltre.Size = new System.Drawing.Size(100, 22);
            this.textBoxogrnumfiltre.TabIndex = 6;
            // 
            // textBoxogradfiltre
            // 
            this.textBoxogradfiltre.Location = new System.Drawing.Point(107, 19);
            this.textBoxogradfiltre.Name = "textBoxogradfiltre";
            this.textBoxogradfiltre.Size = new System.Drawing.Size(100, 22);
            this.textBoxogradfiltre.TabIndex = 2;
            this.textBoxogradfiltre.TextChanged += new System.EventHandler(this.textBoxogradfiltre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Öğrenci Adı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // combosinif
            // 
            this.combosinif.FormattingEnabled = true;
            this.combosinif.Location = new System.Drawing.Point(103, 161);
            this.combosinif.Name = "combosinif";
            this.combosinif.Size = new System.Drawing.Size(121, 24);
            this.combosinif.TabIndex = 9;
            this.combosinif.SelectedIndexChanged += new System.EventHandler(this.combosinif_SelectedIndexChanged);
            // 
            // textPuan
            // 
            this.textPuan.Location = new System.Drawing.Point(868, 132);
            this.textPuan.Name = "textPuan";
            this.textPuan.Size = new System.Drawing.Size(100, 22);
            this.textPuan.TabIndex = 12;
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.Location = new System.Drawing.Point(1011, 69);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(84, 35);
            this.btnDersKaydet.TabIndex = 13;
            this.btnDersKaydet.Text = "Kaydet";
            this.btnDersKaydet.UseVisualStyleBackColor = true;
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // ogrID
            // 
            this.ogrID.AutoSize = true;
            this.ogrID.Location = new System.Drawing.Point(769, 76);
            this.ogrID.Name = "ogrID";
            this.ogrID.Size = new System.Drawing.Size(75, 17);
            this.ogrID.TabIndex = 14;
            this.ogrID.Text = "Öğrenci ID";
            this.ogrID.Click += new System.EventHandler(this.label7_Click);
            // 
            // ders
            // 
            this.ders.AutoSize = true;
            this.ders.Location = new System.Drawing.Point(769, 104);
            this.ders.Name = "ders";
            this.ders.Size = new System.Drawing.Size(38, 17);
            this.ders.TabIndex = 15;
            this.ders.Text = "Ders";
            // 
            // not
            // 
            this.not.AutoSize = true;
            this.not.Location = new System.Drawing.Point(769, 132);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(81, 17);
            this.not.TabIndex = 16;
            this.not.Text = "Not (1-100)";
            // 
            // btnOdevListe
            // 
            this.btnOdevListe.Location = new System.Drawing.Point(1011, 123);
            this.btnOdevListe.Name = "btnOdevListe";
            this.btnOdevListe.Size = new System.Drawing.Size(84, 35);
            this.btnOdevListe.TabIndex = 17;
            this.btnOdevListe.Text = "Listele";
            this.btnOdevListe.UseVisualStyleBackColor = true;
            this.btnOdevListe.Click += new System.EventHandler(this.btnOdevListe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNumFiltre2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxNumFiltre2);
            this.groupBox2.Controls.Add(this.textBoxFiltre2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(772, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 91);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrele";
            // 
            // btnNumFiltre2
            // 
            this.btnNumFiltre2.Location = new System.Drawing.Point(233, 49);
            this.btnNumFiltre2.Name = "btnNumFiltre2";
            this.btnNumFiltre2.Size = new System.Drawing.Size(75, 23);
            this.btnNumFiltre2.TabIndex = 8;
            this.btnNumFiltre2.Text = "Ara";
            this.btnNumFiltre2.UseVisualStyleBackColor = true;
            this.btnNumFiltre2.Click += new System.EventHandler(this.btnNumFiltre2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Numara";
            // 
            // textBoxNumFiltre2
            // 
            this.textBoxNumFiltre2.Location = new System.Drawing.Point(107, 51);
            this.textBoxNumFiltre2.Name = "textBoxNumFiltre2";
            this.textBoxNumFiltre2.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumFiltre2.TabIndex = 6;
            // 
            // textBoxFiltre2
            // 
            this.textBoxFiltre2.Location = new System.Drawing.Point(107, 19);
            this.textBoxFiltre2.Name = "textBoxFiltre2";
            this.textBoxFiltre2.Size = new System.Drawing.Size(100, 22);
            this.textBoxFiltre2.TabIndex = 2;
            this.textBoxFiltre2.TextChanged += new System.EventHandler(this.textBoxFiltre2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ders Adı";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ders_ogr_id,
            this.ogrNum,
            this.dersAdı,
            this.puan,
            this.ogrenciID,
            this.dersid});
            this.dataGridView2.Location = new System.Drawing.Point(772, 343);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 10;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(443, 343);
            this.dataGridView2.TabIndex = 19;
            // 
            // ders_ogr_id
            // 
            this.ders_ogr_id.DataPropertyName = "ders_ogr_id";
            this.ders_ogr_id.HeaderText = "odevID";
            this.ders_ogr_id.MinimumWidth = 6;
            this.ders_ogr_id.Name = "ders_ogr_id";
            this.ders_ogr_id.ReadOnly = true;
            this.ders_ogr_id.Visible = false;
            this.ders_ogr_id.Width = 70;
            // 
            // ogrNum
            // 
            this.ogrNum.DataPropertyName = "numara";
            this.ogrNum.HeaderText = "Öğrenci Numarası";
            this.ogrNum.MinimumWidth = 6;
            this.ogrNum.Name = "ogrNum";
            this.ogrNum.ReadOnly = true;
            this.ogrNum.Width = 90;
            // 
            // dersAdı
            // 
            this.dersAdı.DataPropertyName = "ad";
            this.dersAdı.HeaderText = "Ders Adı";
            this.dersAdı.MinimumWidth = 6;
            this.dersAdı.Name = "dersAdı";
            this.dersAdı.ReadOnly = true;
            this.dersAdı.Width = 125;
            // 
            // puan
            // 
            this.puan.DataPropertyName = "puan";
            this.puan.HeaderText = "Not";
            this.puan.MinimumWidth = 6;
            this.puan.Name = "puan";
            this.puan.ReadOnly = true;
            this.puan.Width = 90;
            // 
            // ogrenciID
            // 
            this.ogrenciID.DataPropertyName = "ogr_id";
            this.ogrenciID.HeaderText = "ogrid";
            this.ogrenciID.MinimumWidth = 6;
            this.ogrenciID.Name = "ogrenciID";
            this.ogrenciID.ReadOnly = true;
            this.ogrenciID.Visible = false;
            this.ogrenciID.Width = 125;
            // 
            // dersid
            // 
            this.dersid.DataPropertyName = "ders_id";
            this.dersid.HeaderText = "dersid";
            this.dersid.MinimumWidth = 6;
            this.dersid.Name = "dersid";
            this.dersid.ReadOnly = true;
            this.dersid.Visible = false;
            this.dersid.Width = 125;
            // 
            // comboders
            // 
            this.comboders.FormattingEnabled = true;
            this.comboders.Location = new System.Drawing.Point(868, 99);
            this.comboders.Name = "comboders";
            this.comboders.Size = new System.Drawing.Size(121, 24);
            this.comboders.TabIndex = 20;
            // 
            // comboOgrNum
            // 
            this.comboOgrNum.FormattingEnabled = true;
            this.comboOgrNum.Location = new System.Drawing.Point(868, 69);
            this.comboOgrNum.Name = "comboOgrNum";
            this.comboOgrNum.Size = new System.Drawing.Size(121, 24);
            this.comboOgrNum.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(35, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Öğrenci İşlemleri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(772, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Not İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 698);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboOgrNum);
            this.Controls.Add(this.comboders);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOdevListe);
            this.Controls.Add(this.not);
            this.Controls.Add(this.ders);
            this.Controls.Add(this.ogrID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDersKaydet);
            this.Controls.Add(this.textPuan);
            this.Controls.Add(this.combosinif);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textnumara);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.textad);
            this.Name = "Form1";
            this.Text = "Öğrenci DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textnumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxogradfiltre;
        private System.Windows.Forms.Button buttonnumfiltre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxogrnumfiltre;
        private System.Windows.Forms.ComboBox combosinif;
        private System.Windows.Forms.TextBox textPuan;
        private System.Windows.Forms.Button btnDersKaydet;
        private System.Windows.Forms.Label ogrID;
        private System.Windows.Forms.Label ders;
        private System.Windows.Forms.Label not;
        private System.Windows.Forms.Button btnOdevListe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNumFiltre2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumFiltre2;
        private System.Windows.Forms.TextBox textBoxFiltre2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboders;
        private System.Windows.Forms.ComboBox comboOgrNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ders_ogr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn puan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifid;
    }
}

