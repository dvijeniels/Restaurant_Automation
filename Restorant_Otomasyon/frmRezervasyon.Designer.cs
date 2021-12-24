namespace Restorant_Otomasyon
{
    partial class frmRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTelefon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMusteriSoyad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMusteriAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMasID = new System.Windows.Forms.TextBox();
            this.rtxtaciklama = new System.Windows.Forms.RichTextBox();
            this.btnYeniMusteri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMusteriSec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSiparisKontrol = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMusteriGuncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbMasa = new System.Windows.Forms.ComboBox();
            this.cbKisiSayisi = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtKisiSayisi = new System.Windows.Forms.RichTextBox();
            this.txtMasa = new System.Windows.Forms.RichTextBox();
            this.txtTarih = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
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
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btncikis);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 36);
            this.panel2.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(898, -1);
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
            this.btncikis.Location = new System.Drawing.Point(931, -1);
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(98, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Резервация";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.HideSelection = false;
            this.lvMusteriler.Location = new System.Drawing.Point(312, 127);
            this.lvMusteriler.MultiSelect = false;
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(625, 335);
            this.lvMusteriler.TabIndex = 3;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.SelectedIndexChanged += new System.EventHandler(this.lvMusteriler_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MusteriID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Телефон";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Почта";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес";
            this.columnHeader5.Width = 117;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.White;
            this.txtTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefon.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTelefon.BorderColorIdle = System.Drawing.Color.DarkSlateGray;
            this.txtTelefon.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTelefon.BorderThickness = 2;
            this.txtTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTelefon.ForeColor = System.Drawing.Color.Black;
            this.txtTelefon.isPassword = false;
            this.txtTelefon.Location = new System.Drawing.Point(633, 66);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(147, 44);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.Text = "Номер";
            this.txtTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefon.OnValueChanged += new System.EventHandler(this.txtTelefon_OnValueChanged);
            this.txtTelefon.Enter += new System.EventHandler(this.txtTelefon_Enter);
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMail.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMail.BorderColorIdle = System.Drawing.Color.DarkSlateGray;
            this.txtMail.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMail.BorderThickness = 2;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMail.ForeColor = System.Drawing.Color.Black;
            this.txtMail.isPassword = false;
            this.txtMail.Location = new System.Drawing.Point(790, 66);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(147, 44);
            this.txtMail.TabIndex = 4;
            this.txtMail.Text = "Почта";
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMail.OnValueChanged += new System.EventHandler(this.txtMail_OnValueChanged);
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.BackColor = System.Drawing.Color.White;
            this.txtMusteriSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMusteriSoyad.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMusteriSoyad.BorderColorIdle = System.Drawing.Color.DarkSlateGray;
            this.txtMusteriSoyad.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMusteriSoyad.BorderThickness = 2;
            this.txtMusteriSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusteriSoyad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMusteriSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtMusteriSoyad.isPassword = false;
            this.txtMusteriSoyad.Location = new System.Drawing.Point(474, 66);
            this.txtMusteriSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(147, 44);
            this.txtMusteriSoyad.TabIndex = 4;
            this.txtMusteriSoyad.Text = "Фамилия";
            this.txtMusteriSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMusteriSoyad.OnValueChanged += new System.EventHandler(this.txtMusteriSoyad_OnValueChanged);
            this.txtMusteriSoyad.Enter += new System.EventHandler(this.txtMusteriSoyad_Enter);
            this.txtMusteriSoyad.Leave += new System.EventHandler(this.txtMusteriSoyad_Leave);
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.BackColor = System.Drawing.Color.White;
            this.txtMusteriAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMusteriAd.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMusteriAd.BorderColorIdle = System.Drawing.Color.DarkSlateGray;
            this.txtMusteriAd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMusteriAd.BorderThickness = 2;
            this.txtMusteriAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMusteriAd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMusteriAd.ForeColor = System.Drawing.Color.Black;
            this.txtMusteriAd.isPassword = false;
            this.txtMusteriAd.Location = new System.Drawing.Point(312, 66);
            this.txtMusteriAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(147, 44);
            this.txtMusteriAd.TabIndex = 4;
            this.txtMusteriAd.Text = "Имя";
            this.txtMusteriAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMusteriAd.OnValueChanged += new System.EventHandler(this.txtMusteriAd_OnValueChanged);
            this.txtMusteriAd.Enter += new System.EventHandler(this.txtMusteriAd_Enter);
            this.txtMusteriAd.Leave += new System.EventHandler(this.txtMusteriAd_Leave);
            // 
            // txtMasID
            // 
            this.txtMasID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMasID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMasID.Location = new System.Drawing.Point(229, 135);
            this.txtMasID.Name = "txtMasID";
            this.txtMasID.ReadOnly = true;
            this.txtMasID.Size = new System.Drawing.Size(35, 24);
            this.txtMasID.TabIndex = 5;
            this.txtMasID.Visible = false;
            // 
            // rtxtaciklama
            // 
            this.rtxtaciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtxtaciklama.Location = new System.Drawing.Point(15, 221);
            this.rtxtaciklama.Name = "rtxtaciklama";
            this.rtxtaciklama.Size = new System.Drawing.Size(208, 138);
            this.rtxtaciklama.TabIndex = 6;
            this.rtxtaciklama.Text = "Дополнительно";
            this.rtxtaciklama.Enter += new System.EventHandler(this.rtxtaciklama_Enter);
            this.rtxtaciklama.Leave += new System.EventHandler(this.rtxtaciklama_Leave);
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnYeniMusteri.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniMusteri.BorderRadius = 0;
            this.btnYeniMusteri.ButtonText = "Добавить клиент";
            this.btnYeniMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniMusteri.DisabledColor = System.Drawing.Color.Gray;
            this.btnYeniMusteri.Iconcolor = System.Drawing.Color.Transparent;
            this.btnYeniMusteri.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnYeniMusteri.Iconimage")));
            this.btnYeniMusteri.Iconimage_right = null;
            this.btnYeniMusteri.Iconimage_right_Selected = null;
            this.btnYeniMusteri.Iconimage_Selected = null;
            this.btnYeniMusteri.IconMarginLeft = 0;
            this.btnYeniMusteri.IconMarginRight = 0;
            this.btnYeniMusteri.IconRightVisible = true;
            this.btnYeniMusteri.IconRightZoom = 0D;
            this.btnYeniMusteri.IconVisible = true;
            this.btnYeniMusteri.IconZoom = 90D;
            this.btnYeniMusteri.IsTab = false;
            this.btnYeniMusteri.Location = new System.Drawing.Point(111, 496);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnYeniMusteri.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnYeniMusteri.OnHoverTextColor = System.Drawing.Color.White;
            this.btnYeniMusteri.selected = false;
            this.btnYeniMusteri.Size = new System.Drawing.Size(190, 48);
            this.btnYeniMusteri.TabIndex = 7;
            this.btnYeniMusteri.Text = "Добавить клиент";
            this.btnYeniMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniMusteri.Textcolor = System.Drawing.Color.White;
            this.btnYeniMusteri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMusteriSec.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMusteriSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriSec.BorderRadius = 0;
            this.btnMusteriSec.ButtonText = "Зарезервировать";
            this.btnMusteriSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriSec.DisabledColor = System.Drawing.Color.Gray;
            this.btnMusteriSec.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMusteriSec.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMusteriSec.Iconimage")));
            this.btnMusteriSec.Iconimage_right = null;
            this.btnMusteriSec.Iconimage_right_Selected = null;
            this.btnMusteriSec.Iconimage_Selected = null;
            this.btnMusteriSec.IconMarginLeft = 0;
            this.btnMusteriSec.IconMarginRight = 0;
            this.btnMusteriSec.IconRightVisible = true;
            this.btnMusteriSec.IconRightZoom = 0D;
            this.btnMusteriSec.IconVisible = true;
            this.btnMusteriSec.IconZoom = 90D;
            this.btnMusteriSec.IsTab = false;
            this.btnMusteriSec.Location = new System.Drawing.Point(307, 496);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnMusteriSec.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnMusteriSec.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMusteriSec.selected = false;
            this.btnMusteriSec.Size = new System.Drawing.Size(190, 48);
            this.btnMusteriSec.TabIndex = 7;
            this.btnMusteriSec.Text = "Зарезервировать";
            this.btnMusteriSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSec.Textcolor = System.Drawing.Color.White;
            this.btnMusteriSec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnSiparisKontrol
            // 
            this.btnSiparisKontrol.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSiparisKontrol.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSiparisKontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisKontrol.BorderRadius = 0;
            this.btnSiparisKontrol.ButtonText = "список резервации";
            this.btnSiparisKontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisKontrol.DisabledColor = System.Drawing.Color.Gray;
            this.btnSiparisKontrol.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSiparisKontrol.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSiparisKontrol.Iconimage")));
            this.btnSiparisKontrol.Iconimage_right = null;
            this.btnSiparisKontrol.Iconimage_right_Selected = null;
            this.btnSiparisKontrol.Iconimage_Selected = null;
            this.btnSiparisKontrol.IconMarginLeft = 0;
            this.btnSiparisKontrol.IconMarginRight = 0;
            this.btnSiparisKontrol.IconRightVisible = true;
            this.btnSiparisKontrol.IconRightZoom = 0D;
            this.btnSiparisKontrol.IconVisible = true;
            this.btnSiparisKontrol.IconZoom = 90D;
            this.btnSiparisKontrol.IsTab = false;
            this.btnSiparisKontrol.Location = new System.Drawing.Point(503, 496);
            this.btnSiparisKontrol.Name = "btnSiparisKontrol";
            this.btnSiparisKontrol.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnSiparisKontrol.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnSiparisKontrol.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSiparisKontrol.selected = false;
            this.btnSiparisKontrol.Size = new System.Drawing.Size(190, 48);
            this.btnSiparisKontrol.TabIndex = 7;
            this.btnSiparisKontrol.Text = "список резервации";
            this.btnSiparisKontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiparisKontrol.Textcolor = System.Drawing.Color.White;
            this.btnSiparisKontrol.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisKontrol.Click += new System.EventHandler(this.btnSiparisKontrol_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMusteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusteriGuncelle.BorderRadius = 0;
            this.btnMusteriGuncelle.ButtonText = "Изменить клиента";
            this.btnMusteriGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriGuncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btnMusteriGuncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMusteriGuncelle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMusteriGuncelle.Iconimage")));
            this.btnMusteriGuncelle.Iconimage_right = null;
            this.btnMusteriGuncelle.Iconimage_right_Selected = null;
            this.btnMusteriGuncelle.Iconimage_Selected = null;
            this.btnMusteriGuncelle.IconMarginLeft = 0;
            this.btnMusteriGuncelle.IconMarginRight = 0;
            this.btnMusteriGuncelle.IconRightVisible = true;
            this.btnMusteriGuncelle.IconRightZoom = 0D;
            this.btnMusteriGuncelle.IconVisible = true;
            this.btnMusteriGuncelle.IconZoom = 90D;
            this.btnMusteriGuncelle.IsTab = false;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(699, 496);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btnMusteriGuncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.btnMusteriGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMusteriGuncelle.selected = false;
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(190, 48);
            this.btnMusteriGuncelle.TabIndex = 7;
            this.btnMusteriGuncelle.Text = "Изменить клиента";
            this.btnMusteriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriGuncelle.Textcolor = System.Drawing.Color.White;
            this.btnMusteriGuncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // cbMasa
            // 
            this.cbMasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMasa.FormattingEnabled = true;
            this.cbMasa.Location = new System.Drawing.Point(204, 120);
            this.cbMasa.Name = "cbMasa";
            this.cbMasa.Size = new System.Drawing.Size(19, 39);
            this.cbMasa.TabIndex = 9;
            this.cbMasa.SelectedIndexChanged += new System.EventHandler(this.cbMasa_SelectedIndexChanged);
            this.cbMasa.MouseEnter += new System.EventHandler(this.cbMasa_MouseEnter);
            this.cbMasa.MouseLeave += new System.EventHandler(this.cbMasa_MouseLeave);
            // 
            // cbKisiSayisi
            // 
            this.cbKisiSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKisiSayisi.Enabled = false;
            this.cbKisiSayisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbKisiSayisi.FormattingEnabled = true;
            this.cbKisiSayisi.Location = new System.Drawing.Point(204, 173);
            this.cbKisiSayisi.Name = "cbKisiSayisi";
            this.cbKisiSayisi.Size = new System.Drawing.Size(19, 39);
            this.cbKisiSayisi.TabIndex = 9;
            this.cbKisiSayisi.SelectedIndexChanged += new System.EventHandler(this.cbKisiSayisi_SelectedIndexChanged);
            this.cbKisiSayisi.Enter += new System.EventHandler(this.cbKisiSayisi_Enter);
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTarih.Location = new System.Drawing.Point(204, 69);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(19, 38);
            this.dtTarih.TabIndex = 10;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            this.dtTarih.Enter += new System.EventHandler(this.dtTarih_Enter);
            this.dtTarih.MouseEnter += new System.EventHandler(this.dtTarih_MouseEnter);
            this.dtTarih.MouseLeave += new System.EventHandler(this.dtTarih_MouseLeave);
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKisiSayisi.Location = new System.Drawing.Point(15, 171);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.ReadOnly = true;
            this.txtKisiSayisi.Size = new System.Drawing.Size(183, 41);
            this.txtKisiSayisi.TabIndex = 6;
            this.txtKisiSayisi.Text = "Число людей";
            // 
            // txtMasa
            // 
            this.txtMasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMasa.Location = new System.Drawing.Point(15, 120);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.ReadOnly = true;
            this.txtMasa.Size = new System.Drawing.Size(183, 41);
            this.txtMasa.TabIndex = 6;
            this.txtMasa.Text = "Стол";
            // 
            // txtTarih
            // 
            this.txtTarih.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTarih.Location = new System.Drawing.Point(15, 69);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(183, 41);
            this.txtTarih.TabIndex = 6;
            this.txtTarih.Text = "Дата";
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(966, 569);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cbKisiSayisi);
            this.Controls.Add(this.cbMasa);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnSiparisKontrol);
            this.Controls.Add(this.btnMusteriSec);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.rtxtaciklama);
            this.Controls.Add(this.txtMasID);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervasyon";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncikis;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cbMasa;
        private Bunifu.Framework.UI.BunifuFlatButton btnMusteriGuncelle;
        private Bunifu.Framework.UI.BunifuFlatButton btnSiparisKontrol;
        private Bunifu.Framework.UI.BunifuFlatButton btnMusteriSec;
        private Bunifu.Framework.UI.BunifuFlatButton btnYeniMusteri;
        private System.Windows.Forms.RichTextBox rtxtaciklama;
        private System.Windows.Forms.TextBox txtMasID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMusteriAd;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMusteriSoyad;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTelefon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ComboBox cbKisiSayisi;
        private System.Windows.Forms.RichTextBox txtTarih;
        private System.Windows.Forms.RichTextBox txtMasa;
        private System.Windows.Forms.RichTextBox txtKisiSayisi;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.Button btnback;

    }
}