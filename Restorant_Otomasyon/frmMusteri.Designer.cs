namespace Restorant_Otomasyon
{
    partial class frmMusteri
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtadi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtsoyadi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.telefon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtadres = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvmusteri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnguncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsiparis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnyeniekle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel2.Size = new System.Drawing.Size(1052, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(984, -1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(35, 37);
            this.btnback.TabIndex = 3;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.x_mark_4_64;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.Location = new System.Drawing.Point(1017, -1);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(140, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Список клиентов";
            // 
            // txtadi
            // 
            this.txtadi.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtadi.BorderColorIdle = System.Drawing.SystemColors.MenuHighlight;
            this.txtadi.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtadi.BorderThickness = 3;
            this.txtadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtadi.ForeColor = System.Drawing.Color.White;
            this.txtadi.isPassword = false;
            this.txtadi.Location = new System.Drawing.Point(15, 69);
            this.txtadi.Margin = new System.Windows.Forms.Padding(5);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(228, 40);
            this.txtadi.TabIndex = 17;
            this.txtadi.Text = "Поиск...";
            this.txtadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtadi.OnValueChanged += new System.EventHandler(this.txtadi_OnValueChanged);
            this.txtadi.Enter += new System.EventHandler(this.txtadi_Enter);
            this.txtadi.Leave += new System.EventHandler(this.txtadi_Leave);
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtsoyadi.BorderColorIdle = System.Drawing.SystemColors.MenuHighlight;
            this.txtsoyadi.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtsoyadi.BorderThickness = 3;
            this.txtsoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoyadi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsoyadi.ForeColor = System.Drawing.Color.White;
            this.txtsoyadi.isPassword = false;
            this.txtsoyadi.Location = new System.Drawing.Point(263, 69);
            this.txtsoyadi.Margin = new System.Windows.Forms.Padding(5);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(275, 40);
            this.txtsoyadi.TabIndex = 18;
            this.txtsoyadi.Text = "Поиск...";
            this.txtsoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsoyadi.OnValueChanged += new System.EventHandler(this.txtsoyadi_OnValueChanged);
            this.txtsoyadi.Enter += new System.EventHandler(this.txtsoyadi_Enter);
            this.txtsoyadi.Leave += new System.EventHandler(this.txtsoyadi_Leave);
            // 
            // telefon
            // 
            this.telefon.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telefon.BorderColorIdle = System.Drawing.SystemColors.MenuHighlight;
            this.telefon.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telefon.BorderThickness = 3;
            this.telefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telefon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telefon.ForeColor = System.Drawing.Color.White;
            this.telefon.isPassword = false;
            this.telefon.Location = new System.Drawing.Point(554, 69);
            this.telefon.Margin = new System.Windows.Forms.Padding(5);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(212, 40);
            this.telefon.TabIndex = 19;
            this.telefon.Text = "Поиск...";
            this.telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.telefon.OnValueChanged += new System.EventHandler(this.telefon_OnValueChanged);
            this.telefon.Enter += new System.EventHandler(this.telefon_Enter);
            this.telefon.Leave += new System.EventHandler(this.telefon_Leave);
            // 
            // txtadres
            // 
            this.txtadres.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtadres.BorderColorIdle = System.Drawing.SystemColors.MenuHighlight;
            this.txtadres.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtadres.BorderThickness = 3;
            this.txtadres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtadres.ForeColor = System.Drawing.Color.White;
            this.txtadres.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtadres.isPassword = false;
            this.txtadres.Location = new System.Drawing.Point(776, 69);
            this.txtadres.Margin = new System.Windows.Forms.Padding(5);
            this.txtadres.Name = "txtadres";
            this.txtadres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtadres.Size = new System.Drawing.Size(262, 168);
            this.txtadres.TabIndex = 20;
            this.txtadres.Text = "Поиск...";
            this.txtadres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtadres.OnValueChanged += new System.EventHandler(this.txtadres_OnValueChanged);
            this.txtadres.Enter += new System.EventHandler(this.txtadres_Enter);
            this.txtadres.Leave += new System.EventHandler(this.txtadres_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(352, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(605, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(856, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Адрес";
            // 
            // lvmusteri
            // 
            this.lvmusteri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.lvmusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvmusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvmusteri.FullRowSelect = true;
            this.lvmusteri.GridLines = true;
            this.lvmusteri.Location = new System.Drawing.Point(17, 121);
            this.lvmusteri.Name = "lvmusteri";
            this.lvmusteri.Size = new System.Drawing.Size(753, 408);
            this.lvmusteri.TabIndex = 25;
            this.lvmusteri.UseCompatibleStateImageBehavior = false;
            this.lvmusteri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Клиент NO";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 183;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Телефон";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Почта";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес";
            this.columnHeader5.Width = 185;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguncelle.BackColor = System.Drawing.Color.Blue;
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguncelle.BorderRadius = 0;
            this.btnguncelle.ButtonText = "Изменить клиента";
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btnguncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguncelle.Iconimage = global::Restorant_Otomasyon.Properties.Resources.update;
            this.btnguncelle.Iconimage_right = null;
            this.btnguncelle.Iconimage_right_Selected = null;
            this.btnguncelle.Iconimage_Selected = null;
            this.btnguncelle.IconMarginLeft = 0;
            this.btnguncelle.IconMarginRight = 0;
            this.btnguncelle.IconRightVisible = true;
            this.btnguncelle.IconRightZoom = 0D;
            this.btnguncelle.IconVisible = true;
            this.btnguncelle.IconZoom = 90D;
            this.btnguncelle.IsTab = false;
            this.btnguncelle.Location = new System.Drawing.Point(776, 338);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Normalcolor = System.Drawing.Color.Blue;
            this.btnguncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.btnguncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguncelle.selected = false;
            this.btnguncelle.Size = new System.Drawing.Size(262, 48);
            this.btnguncelle.TabIndex = 28;
            this.btnguncelle.Text = "Изменить клиента";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.Textcolor = System.Drawing.Color.White;
            this.btnguncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsiparis
            // 
            this.btnsiparis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsiparis.BackColor = System.Drawing.Color.Blue;
            this.btnsiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsiparis.BorderRadius = 0;
            this.btnsiparis.ButtonText = "Заказ для доставки";
            this.btnsiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsiparis.DisabledColor = System.Drawing.Color.Gray;
            this.btnsiparis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsiparis.Iconimage = global::Restorant_Otomasyon.Properties.Resources.meal;
            this.btnsiparis.Iconimage_right = null;
            this.btnsiparis.Iconimage_right_Selected = null;
            this.btnsiparis.Iconimage_Selected = null;
            this.btnsiparis.IconMarginLeft = 0;
            this.btnsiparis.IconMarginRight = 0;
            this.btnsiparis.IconRightVisible = true;
            this.btnsiparis.IconRightZoom = 0D;
            this.btnsiparis.IconVisible = true;
            this.btnsiparis.IconZoom = 90D;
            this.btnsiparis.IsTab = false;
            this.btnsiparis.Location = new System.Drawing.Point(776, 392);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Normalcolor = System.Drawing.Color.Blue;
            this.btnsiparis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.btnsiparis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsiparis.selected = false;
            this.btnsiparis.Size = new System.Drawing.Size(262, 48);
            this.btnsiparis.TabIndex = 27;
            this.btnsiparis.Text = "Заказ для доставки";
            this.btnsiparis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsiparis.Textcolor = System.Drawing.Color.White;
            this.btnsiparis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // btnsec
            // 
            this.btnsec.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsec.BackColor = System.Drawing.Color.Blue;
            this.btnsec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsec.BorderRadius = 0;
            this.btnsec.ButtonText = "Выбрать клиента для резервации";
            this.btnsec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsec.DisabledColor = System.Drawing.Color.Gray;
            this.btnsec.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsec.Iconimage = global::Restorant_Otomasyon.Properties.Resources.click;
            this.btnsec.Iconimage_right = null;
            this.btnsec.Iconimage_right_Selected = null;
            this.btnsec.Iconimage_Selected = null;
            this.btnsec.IconMarginLeft = 0;
            this.btnsec.IconMarginRight = 0;
            this.btnsec.IconRightVisible = true;
            this.btnsec.IconRightZoom = 0D;
            this.btnsec.IconVisible = true;
            this.btnsec.IconZoom = 90D;
            this.btnsec.IsTab = false;
            this.btnsec.Location = new System.Drawing.Point(776, 446);
            this.btnsec.Name = "btnsec";
            this.btnsec.Normalcolor = System.Drawing.Color.Blue;
            this.btnsec.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.btnsec.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsec.selected = false;
            this.btnsec.Size = new System.Drawing.Size(262, 48);
            this.btnsec.TabIndex = 27;
            this.btnsec.Text = "Выбрать клиента для резервации";
            this.btnsec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsec.Textcolor = System.Drawing.Color.White;
            this.btnsec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // btnyeniekle
            // 
            this.btnyeniekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnyeniekle.BackColor = System.Drawing.Color.Blue;
            this.btnyeniekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnyeniekle.BorderRadius = 0;
            this.btnyeniekle.ButtonText = "Добавить клиент";
            this.btnyeniekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyeniekle.DisabledColor = System.Drawing.Color.Gray;
            this.btnyeniekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnyeniekle.Iconimage = global::Restorant_Otomasyon.Properties.Resources.add;
            this.btnyeniekle.Iconimage_right = null;
            this.btnyeniekle.Iconimage_right_Selected = null;
            this.btnyeniekle.Iconimage_Selected = null;
            this.btnyeniekle.IconMarginLeft = 0;
            this.btnyeniekle.IconMarginRight = 0;
            this.btnyeniekle.IconRightVisible = true;
            this.btnyeniekle.IconRightZoom = 0D;
            this.btnyeniekle.IconVisible = true;
            this.btnyeniekle.IconZoom = 90D;
            this.btnyeniekle.IsTab = false;
            this.btnyeniekle.Location = new System.Drawing.Point(776, 284);
            this.btnyeniekle.Name = "btnyeniekle";
            this.btnyeniekle.Normalcolor = System.Drawing.Color.Blue;
            this.btnyeniekle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.btnyeniekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnyeniekle.selected = false;
            this.btnyeniekle.Size = new System.Drawing.Size(262, 48);
            this.btnyeniekle.TabIndex = 26;
            this.btnyeniekle.Text = "Добавить клиент";
            this.btnyeniekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyeniekle.Textcolor = System.Drawing.Color.White;
            this.btnyeniekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyeniekle.Click += new System.EventHandler(this.btnyeniekle_Click);
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.Location = new System.Drawing.Point(826, 83);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(193, 119);
            this.lvMusteriler.TabIndex = 29;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.Visible = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PaketMusteriid";
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1052, 541);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.btnyeniekle);
            this.Controls.Add(this.lvmusteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.txtsoyadi);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMusteri_FormClosed);
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btncikis;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtadi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtadres;
        private Bunifu.Framework.UI.BunifuMetroTextbox telefon;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Bunifu.Framework.UI.BunifuFlatButton btnguncelle;
        private Bunifu.Framework.UI.BunifuFlatButton btnsec;
        private Bunifu.Framework.UI.BunifuFlatButton btnyeniekle;
        private Bunifu.Framework.UI.BunifuFlatButton btnsiparis;
        private System.Windows.Forms.ListView lvmusteri;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}