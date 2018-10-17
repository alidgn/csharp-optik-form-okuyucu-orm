namespace OptikForm
{
    partial class frmOptikOkuma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptikOkuma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.temizle = new System.Windows.Forms.Button();
            this.optik_oku = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rich_ing_kisi = new System.Windows.Forms.RichTextBox();
            this.rich_mat_kisi = new System.Windows.Forms.RichTextBox();
            this.rich_tr_kisi = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rich_ing_cevap = new System.Windows.Forms.RichTextBox();
            this.rich_mat_cevap = new System.Windows.Forms.RichTextBox();
            this.rich_tr_cevap = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTurkceDogru = new System.Windows.Forms.Label();
            this.lblTurkceYanlis = new System.Windows.Forms.Label();
            this.lblTurkceBos = new System.Windows.Forms.Label();
            this.lblTurkceNet = new System.Windows.Forms.Label();
            this.lblMatematikDogru = new System.Windows.Forms.Label();
            this.lblMatematikYanlis = new System.Windows.Forms.Label();
            this.lblMatematikBos = new System.Windows.Forms.Label();
            this.lblMatematikNet = new System.Windows.Forms.Label();
            this.lblIngDogru = new System.Windows.Forms.Label();
            this.lblIngYanlis = new System.Windows.Forms.Label();
            this.lblIngBos = new System.Windows.Forms.Label();
            this.lblIngNet = new System.Windows.Forms.Label();
            this.lblToplamDogru = new System.Windows.Forms.Label();
            this.lblToplamYanlis = new System.Windows.Forms.Label();
            this.lblToplamBos = new System.Windows.Forms.Label();
            this.lblToplamNet = new System.Windows.Forms.Label();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.lblFormSayisi = new System.Windows.Forms.Label();
            this.lblGosterilen = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 849);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // temizle
            // 
            this.temizle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle.Location = new System.Drawing.Point(718, 101);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(75, 44);
            this.temizle.TabIndex = 8;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Visible = false;
            this.temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // optik_oku
            // 
            this.optik_oku.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.optik_oku.Location = new System.Drawing.Point(718, 51);
            this.optik_oku.Name = "optik_oku";
            this.optik_oku.Size = new System.Drawing.Size(75, 44);
            this.optik_oku.TabIndex = 16;
            this.optik_oku.Text = "Optik oku";
            this.optik_oku.UseVisualStyleBackColor = true;
            this.optik_oku.Visible = false;
            this.optik_oku.Click += new System.EventHandler(this.OptikOku_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(816, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 138);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "TC No :";
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(109, 89);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.ReadOnly = true;
            this.txt_tc.Size = new System.Drawing.Size(175, 28);
            this.txt_tc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(37, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Soyadı :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(109, 59);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.ReadOnly = true;
            this.txt_soyad.Size = new System.Drawing.Size(175, 28);
            this.txt_soyad.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(61, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Adı :";
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(109, 29);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.ReadOnly = true;
            this.txt_ad.Size = new System.Drawing.Size(175, 28);
            this.txt_ad.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.rich_ing_kisi);
            this.groupBox2.Controls.Add(this.rich_mat_kisi);
            this.groupBox2.Controls.Add(this.rich_tr_kisi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(637, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 418);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Cevapları";
            // 
            // rich_ing_kisi
            // 
            this.rich_ing_kisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rich_ing_kisi.Location = new System.Drawing.Point(244, 60);
            this.rich_ing_kisi.Name = "rich_ing_kisi";
            this.rich_ing_kisi.Size = new System.Drawing.Size(97, 352);
            this.rich_ing_kisi.TabIndex = 9;
            this.rich_ing_kisi.Text = "";
            // 
            // rich_mat_kisi
            // 
            this.rich_mat_kisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rich_mat_kisi.Location = new System.Drawing.Point(129, 60);
            this.rich_mat_kisi.Name = "rich_mat_kisi";
            this.rich_mat_kisi.Size = new System.Drawing.Size(97, 352);
            this.rich_mat_kisi.TabIndex = 8;
            this.rich_mat_kisi.Text = "";
            // 
            // rich_tr_kisi
            // 
            this.rich_tr_kisi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rich_tr_kisi.Location = new System.Drawing.Point(12, 60);
            this.rich_tr_kisi.Name = "rich_tr_kisi";
            this.rich_tr_kisi.Size = new System.Drawing.Size(97, 352);
            this.rich_tr_kisi.TabIndex = 7;
            this.rich_tr_kisi.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(252, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "İngilizce";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(132, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Matematik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(29, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Türkçe";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.rich_ing_cevap);
            this.groupBox3.Controls.Add(this.rich_mat_cevap);
            this.groupBox3.Controls.Add(this.rich_tr_cevap);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(1003, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 418);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cevap Anahtarı";
            // 
            // rich_ing_cevap
            // 
            this.rich_ing_cevap.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rich_ing_cevap.Location = new System.Drawing.Point(244, 60);
            this.rich_ing_cevap.Name = "rich_ing_cevap";
            this.rich_ing_cevap.Size = new System.Drawing.Size(97, 352);
            this.rich_ing_cevap.TabIndex = 9;
            this.rich_ing_cevap.Text = "";
            // 
            // rich_mat_cevap
            // 
            this.rich_mat_cevap.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rich_mat_cevap.Location = new System.Drawing.Point(129, 60);
            this.rich_mat_cevap.Name = "rich_mat_cevap";
            this.rich_mat_cevap.Size = new System.Drawing.Size(97, 352);
            this.rich_mat_cevap.TabIndex = 8;
            this.rich_mat_cevap.Text = "";
            // 
            // rich_tr_cevap
            // 
            this.rich_tr_cevap.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rich_tr_cevap.Location = new System.Drawing.Point(12, 60);
            this.rich_tr_cevap.Name = "rich_tr_cevap";
            this.rich_tr_cevap.Size = new System.Drawing.Size(97, 352);
            this.rich_tr_cevap.TabIndex = 7;
            this.rich_tr_cevap.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(252, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "İngilizce";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(132, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Matematik";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(29, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Türkçe";
            // 
            // lblTurkceDogru
            // 
            this.lblTurkceDogru.AutoSize = true;
            this.lblTurkceDogru.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkceDogru.Location = new System.Drawing.Point(645, 704);
            this.lblTurkceDogru.Name = "lblTurkceDogru";
            this.lblTurkceDogru.Size = new System.Drawing.Size(49, 20);
            this.lblTurkceDogru.TabIndex = 30;
            this.lblTurkceDogru.Text = "label1";
            this.lblTurkceDogru.Visible = false;
            // 
            // lblTurkceYanlis
            // 
            this.lblTurkceYanlis.AutoSize = true;
            this.lblTurkceYanlis.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkceYanlis.Location = new System.Drawing.Point(874, 704);
            this.lblTurkceYanlis.Name = "lblTurkceYanlis";
            this.lblTurkceYanlis.Size = new System.Drawing.Size(51, 20);
            this.lblTurkceYanlis.TabIndex = 31;
            this.lblTurkceYanlis.Text = "label2";
            this.lblTurkceYanlis.Visible = false;
            // 
            // lblTurkceBos
            // 
            this.lblTurkceBos.AutoSize = true;
            this.lblTurkceBos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkceBos.Location = new System.Drawing.Point(1149, 704);
            this.lblTurkceBos.Name = "lblTurkceBos";
            this.lblTurkceBos.Size = new System.Drawing.Size(51, 20);
            this.lblTurkceBos.TabIndex = 32;
            this.lblTurkceBos.Text = "label3";
            this.lblTurkceBos.Visible = false;
            // 
            // lblTurkceNet
            // 
            this.lblTurkceNet.AutoSize = true;
            this.lblTurkceNet.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkceNet.Location = new System.Drawing.Point(1401, 704);
            this.lblTurkceNet.Name = "lblTurkceNet";
            this.lblTurkceNet.Size = new System.Drawing.Size(51, 20);
            this.lblTurkceNet.TabIndex = 33;
            this.lblTurkceNet.Text = "label4";
            this.lblTurkceNet.Visible = false;
            // 
            // lblMatematikDogru
            // 
            this.lblMatematikDogru.AutoSize = true;
            this.lblMatematikDogru.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMatematikDogru.Location = new System.Drawing.Point(645, 754);
            this.lblMatematikDogru.Name = "lblMatematikDogru";
            this.lblMatematikDogru.Size = new System.Drawing.Size(49, 20);
            this.lblMatematikDogru.TabIndex = 30;
            this.lblMatematikDogru.Text = "label1";
            this.lblMatematikDogru.Visible = false;
            // 
            // lblMatematikYanlis
            // 
            this.lblMatematikYanlis.AutoSize = true;
            this.lblMatematikYanlis.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMatematikYanlis.Location = new System.Drawing.Point(874, 754);
            this.lblMatematikYanlis.Name = "lblMatematikYanlis";
            this.lblMatematikYanlis.Size = new System.Drawing.Size(51, 20);
            this.lblMatematikYanlis.TabIndex = 31;
            this.lblMatematikYanlis.Text = "label2";
            this.lblMatematikYanlis.Visible = false;
            // 
            // lblMatematikBos
            // 
            this.lblMatematikBos.AutoSize = true;
            this.lblMatematikBos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMatematikBos.Location = new System.Drawing.Point(1149, 754);
            this.lblMatematikBos.Name = "lblMatematikBos";
            this.lblMatematikBos.Size = new System.Drawing.Size(51, 20);
            this.lblMatematikBos.TabIndex = 32;
            this.lblMatematikBos.Text = "label3";
            this.lblMatematikBos.Visible = false;
            // 
            // lblMatematikNet
            // 
            this.lblMatematikNet.AutoSize = true;
            this.lblMatematikNet.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMatematikNet.Location = new System.Drawing.Point(1401, 754);
            this.lblMatematikNet.Name = "lblMatematikNet";
            this.lblMatematikNet.Size = new System.Drawing.Size(51, 20);
            this.lblMatematikNet.TabIndex = 33;
            this.lblMatematikNet.Text = "label4";
            this.lblMatematikNet.Visible = false;
            // 
            // lblIngDogru
            // 
            this.lblIngDogru.AutoSize = true;
            this.lblIngDogru.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIngDogru.Location = new System.Drawing.Point(645, 806);
            this.lblIngDogru.Name = "lblIngDogru";
            this.lblIngDogru.Size = new System.Drawing.Size(49, 20);
            this.lblIngDogru.TabIndex = 30;
            this.lblIngDogru.Text = "label1";
            this.lblIngDogru.Visible = false;
            // 
            // lblIngYanlis
            // 
            this.lblIngYanlis.AutoSize = true;
            this.lblIngYanlis.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIngYanlis.Location = new System.Drawing.Point(874, 806);
            this.lblIngYanlis.Name = "lblIngYanlis";
            this.lblIngYanlis.Size = new System.Drawing.Size(51, 20);
            this.lblIngYanlis.TabIndex = 31;
            this.lblIngYanlis.Text = "label2";
            this.lblIngYanlis.Visible = false;
            // 
            // lblIngBos
            // 
            this.lblIngBos.AutoSize = true;
            this.lblIngBos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIngBos.Location = new System.Drawing.Point(1149, 806);
            this.lblIngBos.Name = "lblIngBos";
            this.lblIngBos.Size = new System.Drawing.Size(51, 20);
            this.lblIngBos.TabIndex = 32;
            this.lblIngBos.Text = "label3";
            this.lblIngBos.Visible = false;
            // 
            // lblIngNet
            // 
            this.lblIngNet.AutoSize = true;
            this.lblIngNet.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIngNet.Location = new System.Drawing.Point(1401, 806);
            this.lblIngNet.Name = "lblIngNet";
            this.lblIngNet.Size = new System.Drawing.Size(51, 20);
            this.lblIngNet.TabIndex = 33;
            this.lblIngNet.Text = "label4";
            this.lblIngNet.Visible = false;
            // 
            // lblToplamDogru
            // 
            this.lblToplamDogru.AutoSize = true;
            this.lblToplamDogru.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamDogru.Location = new System.Drawing.Point(645, 857);
            this.lblToplamDogru.Name = "lblToplamDogru";
            this.lblToplamDogru.Size = new System.Drawing.Size(49, 20);
            this.lblToplamDogru.TabIndex = 30;
            this.lblToplamDogru.Text = "label1";
            this.lblToplamDogru.Visible = false;
            // 
            // lblToplamYanlis
            // 
            this.lblToplamYanlis.AutoSize = true;
            this.lblToplamYanlis.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamYanlis.Location = new System.Drawing.Point(874, 857);
            this.lblToplamYanlis.Name = "lblToplamYanlis";
            this.lblToplamYanlis.Size = new System.Drawing.Size(51, 20);
            this.lblToplamYanlis.TabIndex = 31;
            this.lblToplamYanlis.Text = "label2";
            this.lblToplamYanlis.Visible = false;
            // 
            // lblToplamBos
            // 
            this.lblToplamBos.AutoSize = true;
            this.lblToplamBos.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBos.Location = new System.Drawing.Point(1149, 857);
            this.lblToplamBos.Name = "lblToplamBos";
            this.lblToplamBos.Size = new System.Drawing.Size(51, 20);
            this.lblToplamBos.TabIndex = 32;
            this.lblToplamBos.Text = "label3";
            this.lblToplamBos.Visible = false;
            // 
            // lblToplamNet
            // 
            this.lblToplamNet.AutoSize = true;
            this.lblToplamNet.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamNet.Location = new System.Drawing.Point(1401, 857);
            this.lblToplamNet.Name = "lblToplamNet";
            this.lblToplamNet.Size = new System.Drawing.Size(51, 20);
            this.lblToplamNet.TabIndex = 33;
            this.lblToplamNet.Text = "label4";
            this.lblToplamNet.Visible = false;
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaSec.Location = new System.Drawing.Point(637, 51);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(75, 44);
            this.btnDosyaSec.TabIndex = 8;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1153, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 134);
            this.listBox1.TabIndex = 36;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(637, 101);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 44);
            this.btnDegistir.TabIndex = 16;
            this.btnDegistir.Text = "Sonraki Form";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Visible = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // lblFormSayisi
            // 
            this.lblFormSayisi.AutoSize = true;
            this.lblFormSayisi.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormSayisi.Location = new System.Drawing.Point(666, 179);
            this.lblFormSayisi.Name = "lblFormSayisi";
            this.lblFormSayisi.Size = new System.Drawing.Size(101, 20);
            this.lblFormSayisi.TabIndex = 4;
            this.lblFormSayisi.Text = "Form Sayısı : ";
            this.lblFormSayisi.Visible = false;
            // 
            // lblGosterilen
            // 
            this.lblGosterilen.AutoSize = true;
            this.lblGosterilen.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGosterilen.Location = new System.Drawing.Point(666, 208);
            this.lblGosterilen.Name = "lblGosterilen";
            this.lblGosterilen.Size = new System.Drawing.Size(131, 20);
            this.lblGosterilen.TabIndex = 4;
            this.lblGosterilen.Text = "Gösterilen Form : ";
            this.lblGosterilen.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1483, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 54);
            this.button3.TabIndex = 37;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1541, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 54);
            this.button4.TabIndex = 38;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmOptikOkuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1604, 1092);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblToplamNet);
            this.Controls.Add(this.lblIngNet);
            this.Controls.Add(this.lblMatematikNet);
            this.Controls.Add(this.lblGosterilen);
            this.Controls.Add(this.lblFormSayisi);
            this.Controls.Add(this.lblTurkceNet);
            this.Controls.Add(this.lblToplamBos);
            this.Controls.Add(this.lblIngBos);
            this.Controls.Add(this.lblMatematikBos);
            this.Controls.Add(this.lblTurkceBos);
            this.Controls.Add(this.lblToplamYanlis);
            this.Controls.Add(this.lblIngYanlis);
            this.Controls.Add(this.lblToplamDogru);
            this.Controls.Add(this.lblIngDogru);
            this.Controls.Add(this.lblMatematikYanlis);
            this.Controls.Add(this.lblMatematikDogru);
            this.Controls.Add(this.lblTurkceYanlis);
            this.Controls.Add(this.lblTurkceDogru);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.optik_oku);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOptikOkuma";
            this.Text = "Optik Okuma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button optik_oku;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rich_ing_kisi;
        private System.Windows.Forms.RichTextBox rich_mat_kisi;
        private System.Windows.Forms.RichTextBox rich_tr_kisi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rich_ing_cevap;
        private System.Windows.Forms.RichTextBox rich_mat_cevap;
        private System.Windows.Forms.RichTextBox rich_tr_cevap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTurkceDogru;
        private System.Windows.Forms.Label lblTurkceYanlis;
        private System.Windows.Forms.Label lblTurkceBos;
        private System.Windows.Forms.Label lblTurkceNet;
        private System.Windows.Forms.Label lblMatematikDogru;
        private System.Windows.Forms.Label lblMatematikYanlis;
        private System.Windows.Forms.Label lblMatematikBos;
        private System.Windows.Forms.Label lblMatematikNet;
        private System.Windows.Forms.Label lblIngDogru;
        private System.Windows.Forms.Label lblIngYanlis;
        private System.Windows.Forms.Label lblIngBos;
        private System.Windows.Forms.Label lblIngNet;
        private System.Windows.Forms.Label lblToplamDogru;
        private System.Windows.Forms.Label lblToplamYanlis;
        private System.Windows.Forms.Label lblToplamBos;
        private System.Windows.Forms.Label lblToplamNet;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label lblFormSayisi;
        private System.Windows.Forms.Label lblGosterilen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

