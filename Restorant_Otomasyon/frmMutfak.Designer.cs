namespace Restorant_Otomasyon
{
    partial class frmMutfak
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMutfak));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnKatDegistir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnKatSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtAciklam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtKatAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnYeni = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnKatEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tKatID = new System.Windows.Forms.TextBox();
            this.txtAciklama = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtKatID = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnDegistir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtGidafiyat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtGidaAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtKategoriid = new System.Windows.Forms.TextBox();
            this.tGidaID = new System.Windows.Forms.TextBox();
            this.btnEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lvGidaListesi = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAramaGida = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbArama = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btncikis);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(925, 1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(35, 37);
            this.btnback.TabIndex = 5;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.x_mark_4_64;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.Location = new System.Drawing.Point(958, 1);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(35, 37);
            this.btncikis.TabIndex = 4;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(51, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Кухня";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lvKategoriler);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(437, 345);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(514, 209);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Список Категорий";
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader1});
            this.lvKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvKategoriler.FullRowSelect = true;
            this.lvKategoriler.GridLines = true;
            this.lvKategoriler.Location = new System.Drawing.Point(9, 30);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(499, 163);
            this.lvKategoriler.TabIndex = 4;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.View = System.Windows.Forms.View.Details;
            this.lvKategoriler.SelectedIndexChanged += new System.EventHandler(this.lvKategoriler_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Turid";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Название категории";
            this.columnHeader8.Width = 259;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Рассуждение категория";
            this.columnHeader1.Width = 232;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnKatDegistir);
            this.groupBox8.Controls.Add(this.btnKatSil);
            this.groupBox8.Controls.Add(this.txtAciklam);
            this.groupBox8.Controls.Add(this.txtKatAd);
            this.groupBox8.Controls.Add(this.btnYeni);
            this.groupBox8.Controls.Add(this.btnKatEkle);
            this.groupBox8.Controls.Add(this.tKatID);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.Location = new System.Drawing.Point(31, 345);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(392, 209);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Добавление категорий";
            // 
            // btnKatDegistir
            // 
            this.btnKatDegistir.ActiveBorderThickness = 1;
            this.btnKatDegistir.ActiveCornerRadius = 20;
            this.btnKatDegistir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnKatDegistir.ActiveForecolor = System.Drawing.Color.White;
            this.btnKatDegistir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnKatDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnKatDegistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKatDegistir.BackgroundImage")));
            this.btnKatDegistir.ButtonText = "Изменить";
            this.btnKatDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKatDegistir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKatDegistir.ForeColor = System.Drawing.Color.Black;
            this.btnKatDegistir.IdleBorderThickness = 1;
            this.btnKatDegistir.IdleCornerRadius = 20;
            this.btnKatDegistir.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnKatDegistir.IdleForecolor = System.Drawing.Color.Black;
            this.btnKatDegistir.IdleLineColor = System.Drawing.Color.Black;
            this.btnKatDegistir.Location = new System.Drawing.Point(94, 160);
            this.btnKatDegistir.Margin = new System.Windows.Forms.Padding(5);
            this.btnKatDegistir.Name = "btnKatDegistir";
            this.btnKatDegistir.Size = new System.Drawing.Size(181, 39);
            this.btnKatDegistir.TabIndex = 4;
            this.btnKatDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKatDegistir.Click += new System.EventHandler(this.btnKatDegistir_Click);
            // 
            // btnKatSil
            // 
            this.btnKatSil.ActiveBorderThickness = 1;
            this.btnKatSil.ActiveCornerRadius = 20;
            this.btnKatSil.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnKatSil.ActiveForecolor = System.Drawing.Color.White;
            this.btnKatSil.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnKatSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnKatSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKatSil.BackgroundImage")));
            this.btnKatSil.ButtonText = "Удалить";
            this.btnKatSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKatSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKatSil.ForeColor = System.Drawing.Color.Black;
            this.btnKatSil.IdleBorderThickness = 1;
            this.btnKatSil.IdleCornerRadius = 20;
            this.btnKatSil.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnKatSil.IdleForecolor = System.Drawing.Color.Black;
            this.btnKatSil.IdleLineColor = System.Drawing.Color.Black;
            this.btnKatSil.Location = new System.Drawing.Point(10, 125);
            this.btnKatSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKatSil.Name = "btnKatSil";
            this.btnKatSil.Size = new System.Drawing.Size(181, 39);
            this.btnKatSil.TabIndex = 4;
            this.btnKatSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKatSil.Click += new System.EventHandler(this.btnKatSil_Click);
            // 
            // txtAciklam
            // 
            this.txtAciklam.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.txtAciklam.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtAciklam.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAciklam.BorderThickness = 3;
            this.txtAciklam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAciklam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAciklam.ForeColor = System.Drawing.Color.Black;
            this.txtAciklam.isPassword = false;
            this.txtAciklam.Location = new System.Drawing.Point(86, 82);
            this.txtAciklam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAciklam.Name = "txtAciklam";
            this.txtAciklam.Size = new System.Drawing.Size(216, 40);
            this.txtAciklam.TabIndex = 5;
            this.txtAciklam.Text = "Рассуждение категории";
            this.txtAciklam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAciklam.Enter += new System.EventHandler(this.txtAciklam_Enter);
            this.txtAciklam.Leave += new System.EventHandler(this.txtAciklam_Leave);
            // 
            // txtKatAd
            // 
            this.txtKatAd.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.txtKatAd.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtKatAd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtKatAd.BorderThickness = 3;
            this.txtKatAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKatAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKatAd.ForeColor = System.Drawing.Color.Black;
            this.txtKatAd.isPassword = false;
            this.txtKatAd.Location = new System.Drawing.Point(86, 32);
            this.txtKatAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKatAd.Name = "txtKatAd";
            this.txtKatAd.Size = new System.Drawing.Size(216, 40);
            this.txtKatAd.TabIndex = 5;
            this.txtKatAd.Text = "Название категории";
            this.txtKatAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKatAd.Enter += new System.EventHandler(this.txtKatAd_Enter);
            this.txtKatAd.Leave += new System.EventHandler(this.txtKatAd_Leave);
            // 
            // btnYeni
            // 
            this.btnYeni.ActiveBorderThickness = 1;
            this.btnYeni.ActiveCornerRadius = 20;
            this.btnYeni.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnYeni.ActiveForecolor = System.Drawing.Color.White;
            this.btnYeni.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnYeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnYeni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYeni.BackgroundImage")));
            this.btnYeni.ButtonText = "Добавить";
            this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYeni.ForeColor = System.Drawing.Color.Black;
            this.btnYeni.IdleBorderThickness = 1;
            this.btnYeni.IdleCornerRadius = 20;
            this.btnYeni.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnYeni.IdleForecolor = System.Drawing.Color.Black;
            this.btnYeni.IdleLineColor = System.Drawing.Color.Black;
            this.btnYeni.Location = new System.Drawing.Point(199, 125);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(181, 39);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.ActiveBorderThickness = 1;
            this.btnKatEkle.ActiveCornerRadius = 20;
            this.btnKatEkle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnKatEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnKatEkle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnKatEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnKatEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKatEkle.BackgroundImage")));
            this.btnKatEkle.ButtonText = "Сохранить";
            this.btnKatEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKatEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKatEkle.ForeColor = System.Drawing.Color.Black;
            this.btnKatEkle.IdleBorderThickness = 1;
            this.btnKatEkle.IdleCornerRadius = 20;
            this.btnKatEkle.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnKatEkle.IdleForecolor = System.Drawing.Color.Black;
            this.btnKatEkle.IdleLineColor = System.Drawing.Color.Black;
            this.btnKatEkle.Location = new System.Drawing.Point(199, 125);
            this.btnKatEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(181, 39);
            this.btnKatEkle.TabIndex = 4;
            this.btnKatEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKatEkle.Click += new System.EventHandler(this.btnKatEkle_Click);
            // 
            // tKatID
            // 
            this.tKatID.Location = new System.Drawing.Point(44, 30);
            this.tKatID.Name = "tKatID";
            this.tKatID.Size = new System.Drawing.Size(21, 31);
            this.tKatID.TabIndex = 3;
            this.tKatID.Visible = false;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.txtAciklama.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtAciklama.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAciklama.BorderThickness = 3;
            this.txtAciklama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAciklama.ForeColor = System.Drawing.Color.Black;
            this.txtAciklama.isPassword = false;
            this.txtAciklama.Location = new System.Drawing.Point(89, 29);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(216, 40);
            this.txtAciklama.TabIndex = 5;
            this.txtAciklama.Text = "dfdfvdfvdfvdfvdf";
            this.txtAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtKatID
            // 
            this.txtKatID.Location = new System.Drawing.Point(6, 47);
            this.txtKatID.Name = "txtKatID";
            this.txtKatID.Size = new System.Drawing.Size(21, 20);
            this.txtKatID.TabIndex = 3;
            this.txtKatID.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnDegistir);
            this.groupBox9.Controls.Add(this.txtGidafiyat);
            this.groupBox9.Controls.Add(this.bunifuMetroTextbox3);
            this.groupBox9.Controls.Add(this.txtGidaAd);
            this.groupBox9.Controls.Add(this.btnSil);
            this.groupBox9.Controls.Add(this.txtKategoriid);
            this.groupBox9.Controls.Add(this.tGidaID);
            this.groupBox9.Controls.Add(this.btnEkle);
            this.groupBox9.Controls.Add(this.cbKategori);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox9.Location = new System.Drawing.Point(31, 90);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(392, 238);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Добавление блюда";
            // 
            // btnDegistir
            // 
            this.btnDegistir.ActiveBorderThickness = 1;
            this.btnDegistir.ActiveCornerRadius = 20;
            this.btnDegistir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnDegistir.ActiveForecolor = System.Drawing.Color.White;
            this.btnDegistir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnDegistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDegistir.BackgroundImage")));
            this.btnDegistir.ButtonText = "Изменить";
            this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDegistir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDegistir.ForeColor = System.Drawing.Color.Black;
            this.btnDegistir.IdleBorderThickness = 1;
            this.btnDegistir.IdleCornerRadius = 20;
            this.btnDegistir.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnDegistir.IdleForecolor = System.Drawing.Color.Black;
            this.btnDegistir.IdleLineColor = System.Drawing.Color.Black;
            this.btnDegistir.Location = new System.Drawing.Point(99, 197);
            this.btnDegistir.Margin = new System.Windows.Forms.Padding(5);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(181, 39);
            this.btnDegistir.TabIndex = 4;
            this.btnDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtGidafiyat
            // 
            this.txtGidafiyat.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.txtGidafiyat.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtGidafiyat.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtGidafiyat.BorderThickness = 3;
            this.txtGidafiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGidafiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGidafiyat.ForeColor = System.Drawing.Color.Black;
            this.txtGidafiyat.isPassword = false;
            this.txtGidafiyat.Location = new System.Drawing.Point(89, 122);
            this.txtGidafiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGidafiyat.Name = "txtGidafiyat";
            this.txtGidafiyat.Size = new System.Drawing.Size(216, 40);
            this.txtGidafiyat.TabIndex = 5;
            this.txtGidafiyat.Text = "Введите цену";
            this.txtGidafiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGidafiyat.Enter += new System.EventHandler(this.txtGidafiyat_Enter);
            this.txtGidafiyat.Leave += new System.EventHandler(this.txtGidafiyat_Leave);
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.DimGray;
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderThickness = 3;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.Black;
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(89, 326);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(216, 40);
            this.bunifuMetroTextbox3.TabIndex = 5;
            this.bunifuMetroTextbox3.Text = "Название блюдо";
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox3.OnValueChanged += new System.EventHandler(this.txtGidaAd_OnValueChanged);
            this.bunifuMetroTextbox3.Enter += new System.EventHandler(this.txtGidaAd_Enter);
            this.bunifuMetroTextbox3.Leave += new System.EventHandler(this.txtGidaAd_Leave);
            // 
            // txtGidaAd
            // 
            this.txtGidaAd.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.txtGidaAd.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtGidaAd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtGidaAd.BorderThickness = 3;
            this.txtGidaAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGidaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGidaAd.ForeColor = System.Drawing.Color.Black;
            this.txtGidaAd.isPassword = false;
            this.txtGidaAd.Location = new System.Drawing.Point(89, 74);
            this.txtGidaAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGidaAd.Name = "txtGidaAd";
            this.txtGidaAd.Size = new System.Drawing.Size(216, 40);
            this.txtGidaAd.TabIndex = 5;
            this.txtGidaAd.Text = "Название блюдо";
            this.txtGidaAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGidaAd.Enter += new System.EventHandler(this.txtGidaAd_Enter);
            this.txtGidaAd.Leave += new System.EventHandler(this.txtGidaAd_Leave);
            // 
            // btnSil
            // 
            this.btnSil.ActiveBorderThickness = 1;
            this.btnSil.ActiveCornerRadius = 20;
            this.btnSil.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnSil.ActiveForecolor = System.Drawing.Color.White;
            this.btnSil.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.ButtonText = "Удалить";
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.IdleBorderThickness = 1;
            this.btnSil.IdleCornerRadius = 20;
            this.btnSil.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnSil.IdleForecolor = System.Drawing.Color.Black;
            this.btnSil.IdleLineColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(8, 163);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(183, 39);
            this.btnSil.TabIndex = 4;
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtKategoriid
            // 
            this.txtKategoriid.Location = new System.Drawing.Point(8, 33);
            this.txtKategoriid.Name = "txtKategoriid";
            this.txtKategoriid.Size = new System.Drawing.Size(30, 31);
            this.txtKategoriid.TabIndex = 3;
            this.txtKategoriid.Visible = false;
            // 
            // tGidaID
            // 
            this.tGidaID.Location = new System.Drawing.Point(44, 33);
            this.tGidaID.Name = "tGidaID";
            this.tGidaID.Size = new System.Drawing.Size(30, 31);
            this.tGidaID.TabIndex = 3;
            this.tGidaID.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.ActiveBorderThickness = 1;
            this.btnEkle.ActiveCornerRadius = 20;
            this.btnEkle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnEkle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.ButtonText = "Сохранить";
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.IdleBorderThickness = 1;
            this.btnEkle.IdleCornerRadius = 20;
            this.btnEkle.IdleFillColor = System.Drawing.Color.Indigo;
            this.btnEkle.IdleForecolor = System.Drawing.Color.Black;
            this.btnEkle.IdleLineColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(198, 163);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(181, 39);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(89, 33);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(216, 33);
            this.cbKategori.TabIndex = 2;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lvGidaListesi);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.Location = new System.Drawing.Point(432, 90);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(552, 236);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Список Меню";
            // 
            // lvGidaListesi
            // 
            this.lvGidaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader2,
            this.columnHeader14,
            this.columnHeader13,
            this.columnHeader15});
            this.lvGidaListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvGidaListesi.FullRowSelect = true;
            this.lvGidaListesi.GridLines = true;
            this.lvGidaListesi.Location = new System.Drawing.Point(6, 27);
            this.lvGidaListesi.Name = "lvGidaListesi";
            this.lvGidaListesi.Size = new System.Drawing.Size(540, 203);
            this.lvGidaListesi.TabIndex = 4;
            this.lvGidaListesi.UseCompatibleStateImageBehavior = false;
            this.lvGidaListesi.View = System.Windows.Forms.View.Details;
            this.lvGidaListesi.SelectedIndexChanged += new System.EventHandler(this.lvGidaListesi_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Urunid";
            this.columnHeader12.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "UrunTurNo";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Под категории";
            this.columnHeader14.Width = 207;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Название еды";
            this.columnHeader13.Width = 239;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Цена";
            this.columnHeader15.Width = 88;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txtAramaGida
            // 
            this.txtAramaGida.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.txtAramaGida.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtAramaGida.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAramaGida.BorderThickness = 3;
            this.txtAramaGida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAramaGida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAramaGida.ForeColor = System.Drawing.Color.Black;
            this.txtAramaGida.isPassword = false;
            this.txtAramaGida.Location = new System.Drawing.Point(714, 46);
            this.txtAramaGida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAramaGida.Name = "txtAramaGida";
            this.txtAramaGida.Size = new System.Drawing.Size(263, 40);
            this.txtAramaGida.TabIndex = 5;
            this.txtAramaGida.Text = "Поиск...";
            this.txtAramaGida.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAramaGida.OnValueChanged += new System.EventHandler(this.txtAramaGida_OnValueChanged);
            this.txtAramaGida.Enter += new System.EventHandler(this.txtAramaGida_Enter);
            this.txtAramaGida.Leave += new System.EventHandler(this.txtAramaGida_Leave);
            // 
            // cbArama
            // 
            this.cbArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArama.FormattingEnabled = true;
            this.cbArama.Location = new System.Drawing.Point(20, 3);
            this.cbArama.Name = "cbArama";
            this.cbArama.Size = new System.Drawing.Size(252, 32);
            this.cbArama.TabIndex = 2;
            this.cbArama.SelectedIndexChanged += new System.EventHandler(this.cbArama_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbArama);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(432, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 40);
            this.panel1.TabIndex = 10;
            // 
            // frmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(993, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.txtAramaGida);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMutfak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMutfak_FormClosed);
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btncikis;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtKataAd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKatSil;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKatEkle;
        private System.Windows.Forms.TextBox tKatID;
        private System.Windows.Forms.GroupBox groupBox9;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDegistir;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGidafiyat;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGidaAd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSil;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEkle;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView lvGidaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKatDegistir;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAramaGida;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAciklama;
        private System.Windows.Forms.TextBox txtKatID;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtKatAd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAciklam;
        private System.Windows.Forms.TextBox tGidaID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnYeni;
        private System.Windows.Forms.ComboBox cbArama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKategoriid;
    }
}