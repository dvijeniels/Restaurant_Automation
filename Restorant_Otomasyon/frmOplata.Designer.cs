namespace Restorant_Otomasyon
{
    partial class frmOplata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOplata));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chindir = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbindirim = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.chindirim = new Bunifu.Framework.UI.BunifuCheckbox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblToplam = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblindirim = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblKDV = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbfiyat = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdticket = new System.Windows.Forms.RadioButton();
            this.rdnakit = new System.Windows.Forms.RadioButton();
            this.rdkredi = new System.Windows.Forms.RadioButton();
            this.lbAdisiyonid = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnoplata = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnyazdir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbhesap = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txts4t = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(907, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(839, -1);
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
            this.btncikis.Location = new System.Drawing.Point(872, -1);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(58, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Столы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvUrunler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказы";
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.lvUrunler.Location = new System.Drawing.Point(6, 19);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(532, 219);
            this.lvUrunler.TabIndex = 0;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 369;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Штук";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "urunid";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цена";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "satisid";
            this.columnHeader5.Width = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox2.Controls.Add(this.chindir);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox2.Controls.Add(this.tbindirim);
            this.groupBox2.Controls.Add(this.chindirim);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(593, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Специальная скидка";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(39, 62);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(220, 16);
            this.bunifuCustomLabel9.TabIndex = 13;
            this.bunifuCustomLabel9.Text = "Сделать скидку в процентах";
            // 
            // chindir
            // 
            this.chindir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chindir.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chindir.Checked = false;
            this.chindir.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chindir.ForeColor = System.Drawing.Color.White;
            this.chindir.Location = new System.Drawing.Point(12, 58);
            this.chindir.Margin = new System.Windows.Forms.Padding(5);
            this.chindir.Name = "chindir";
            this.chindir.Size = new System.Drawing.Size(20, 20);
            this.chindir.TabIndex = 12;
            this.chindir.OnChange += new System.EventHandler(this.chindir_OnChange);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(39, 33);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Сделать скидку в сомах";
            // 
            // tbindirim
            // 
            this.tbindirim.BorderColor = System.Drawing.Color.Blue;
            this.tbindirim.ForeColor = System.Drawing.Color.Black;
            this.tbindirim.Location = new System.Drawing.Point(10, 98);
            this.tbindirim.Margin = new System.Windows.Forms.Padding(4);
            this.tbindirim.Name = "tbindirim";
            this.tbindirim.Size = new System.Drawing.Size(248, 22);
            this.tbindirim.TabIndex = 11;
            this.tbindirim.Text = "Введите число скидки...";
            this.tbindirim.Visible = false;
            this.tbindirim.TextChanged += new System.EventHandler(this.tbindirim_TextChanged);
            this.tbindirim.Enter += new System.EventHandler(this.tbindirim_Enter);
            this.tbindirim.Leave += new System.EventHandler(this.tbindirim_Leave);
            // 
            // chindirim
            // 
            this.chindirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chindirim.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chindirim.Checked = false;
            this.chindirim.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chindirim.ForeColor = System.Drawing.Color.White;
            this.chindirim.Location = new System.Drawing.Point(12, 30);
            this.chindirim.Margin = new System.Windows.Forms.Padding(4);
            this.chindirim.Name = "chindirim";
            this.chindirim.Size = new System.Drawing.Size(20, 20);
            this.chindirim.TabIndex = 0;
            this.chindirim.OnChange += new System.EventHandler(this.chindirim_OnChange);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuCustomLabel15);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel14);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel13);
            this.groupBox3.Controls.Add(this.lblToplam);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel12);
            this.groupBox3.Controls.Add(this.lblindirim);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel17);
            this.groupBox3.Controls.Add(this.lblKDV);
            this.groupBox3.Controls.Add(this.lbfiyat);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox3.Location = new System.Drawing.Point(36, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 141);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация об оплате";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(141, 111);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(34, 15);
            this.bunifuCustomLabel15.TabIndex = 15;
            this.bunifuCustomLabel15.Text = "Сом";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(141, 83);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(34, 15);
            this.bunifuCustomLabel14.TabIndex = 12;
            this.bunifuCustomLabel14.Text = "Сом";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(141, 54);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(34, 15);
            this.bunifuCustomLabel13.TabIndex = 11;
            this.bunifuCustomLabel13.Text = "Сом";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToplam.Location = new System.Drawing.Point(70, 109);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(17, 18);
            this.lblToplam.TabIndex = 14;
            this.lblToplam.Text = "0";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(141, 25);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(34, 15);
            this.bunifuCustomLabel12.TabIndex = 10;
            this.bunifuCustomLabel12.Text = "Сом";
            // 
            // lblindirim
            // 
            this.lblindirim.AutoSize = true;
            this.lblindirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblindirim.Location = new System.Drawing.Point(70, 80);
            this.lblindirim.Name = "lblindirim";
            this.lblindirim.Size = new System.Drawing.Size(17, 18);
            this.lblindirim.TabIndex = 9;
            this.lblindirim.Text = "0";
            this.lblindirim.TextChanged += new System.EventHandler(this.lblindirim_TextChanged);
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(6, 110);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(47, 16);
            this.bunifuCustomLabel17.TabIndex = 13;
            this.bunifuCustomLabel17.Text = "Итог:";
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKDV.Location = new System.Drawing.Point(70, 51);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(17, 18);
            this.lblKDV.TabIndex = 8;
            this.lblKDV.Text = "0";
            // 
            // lbfiyat
            // 
            this.lbfiyat.AutoSize = true;
            this.lbfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbfiyat.Location = new System.Drawing.Point(70, 25);
            this.lbfiyat.Name = "lbfiyat";
            this.lbfiyat.Size = new System.Drawing.Size(17, 18);
            this.lbfiyat.TabIndex = 7;
            this.lbfiyat.Text = "0";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(6, 25);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(49, 16);
            this.bunifuCustomLabel8.TabIndex = 6;
            this.bunifuCustomLabel8.Text = "Цена:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(6, 53);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(57, 16);
            this.bunifuCustomLabel7.TabIndex = 5;
            this.bunifuCustomLabel7.Text = "Налог:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(6, 82);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(65, 16);
            this.bunifuCustomLabel6.TabIndex = 4;
            this.bunifuCustomLabel6.Text = "Скидка:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdticket);
            this.groupBox4.Controls.Add(this.rdnakit);
            this.groupBox4.Controls.Add(this.rdkredi);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(282, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 115);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вид оплаты";
            // 
            // rdticket
            // 
            this.rdticket.AutoSize = true;
            this.rdticket.Location = new System.Drawing.Point(17, 79);
            this.rdticket.Name = "rdticket";
            this.rdticket.Size = new System.Drawing.Size(66, 20);
            this.rdticket.TabIndex = 14;
            this.rdticket.TabStop = true;
            this.rdticket.Text = "Билет";
            this.rdticket.UseVisualStyleBackColor = true;
            // 
            // rdnakit
            // 
            this.rdnakit.AutoSize = true;
            this.rdnakit.Location = new System.Drawing.Point(17, 33);
            this.rdnakit.Name = "rdnakit";
            this.rdnakit.Size = new System.Drawing.Size(102, 20);
            this.rdnakit.TabIndex = 12;
            this.rdnakit.TabStop = true;
            this.rdnakit.Text = "Наличными";
            this.rdnakit.UseVisualStyleBackColor = true;
            // 
            // rdkredi
            // 
            this.rdkredi.AutoSize = true;
            this.rdkredi.Location = new System.Drawing.Point(17, 56);
            this.rdkredi.Name = "rdkredi";
            this.rdkredi.Size = new System.Drawing.Size(157, 20);
            this.rdkredi.TabIndex = 13;
            this.rdkredi.TabStop = true;
            this.rdkredi.Text = "C кредитной картой";
            this.rdkredi.UseVisualStyleBackColor = true;
            // 
            // lbAdisiyonid
            // 
            this.lbAdisiyonid.AutoSize = true;
            this.lbAdisiyonid.Location = new System.Drawing.Point(566, 43);
            this.lbAdisiyonid.Name = "lbAdisiyonid";
            this.lbAdisiyonid.Size = new System.Drawing.Size(16, 13);
            this.lbAdisiyonid.TabIndex = 11;
            this.lbAdisiyonid.Text = "Id";
            this.lbAdisiyonid.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnoplata
            // 
            this.btnoplata.Activecolor = System.Drawing.Color.Orange;
            this.btnoplata.BackColor = System.Drawing.Color.OrangeRed;
            this.btnoplata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoplata.BorderRadius = 0;
            this.btnoplata.ButtonText = "Оплатить";
            this.btnoplata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnoplata.DisabledColor = System.Drawing.Color.Gray;
            this.btnoplata.Iconcolor = System.Drawing.Color.Transparent;
            this.btnoplata.Iconimage = global::Restorant_Otomasyon.Properties.Resources.money;
            this.btnoplata.Iconimage_right = null;
            this.btnoplata.Iconimage_right_Selected = null;
            this.btnoplata.Iconimage_Selected = null;
            this.btnoplata.IconMarginLeft = 0;
            this.btnoplata.IconMarginRight = 0;
            this.btnoplata.IconRightVisible = true;
            this.btnoplata.IconRightZoom = 0D;
            this.btnoplata.IconVisible = true;
            this.btnoplata.IconZoom = 90D;
            this.btnoplata.IsTab = false;
            this.btnoplata.Location = new System.Drawing.Point(603, 392);
            this.btnoplata.Name = "btnoplata";
            this.btnoplata.Normalcolor = System.Drawing.Color.OrangeRed;
            this.btnoplata.OnHovercolor = System.Drawing.Color.Red;
            this.btnoplata.OnHoverTextColor = System.Drawing.Color.White;
            this.btnoplata.selected = false;
            this.btnoplata.Size = new System.Drawing.Size(241, 48);
            this.btnoplata.TabIndex = 10;
            this.btnoplata.Text = "Оплатить";
            this.btnoplata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnoplata.Textcolor = System.Drawing.Color.White;
            this.btnoplata.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoplata.Click += new System.EventHandler(this.btnoplata_Click);
            // 
            // btnyazdir
            // 
            this.btnyazdir.Activecolor = System.Drawing.Color.Orange;
            this.btnyazdir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnyazdir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnyazdir.BorderRadius = 0;
            this.btnyazdir.ButtonText = "Распечатать";
            this.btnyazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyazdir.DisabledColor = System.Drawing.Color.Gray;
            this.btnyazdir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnyazdir.Iconimage = global::Restorant_Otomasyon.Properties.Resources.rasp;
            this.btnyazdir.Iconimage_right = null;
            this.btnyazdir.Iconimage_right_Selected = null;
            this.btnyazdir.Iconimage_Selected = null;
            this.btnyazdir.IconMarginLeft = 0;
            this.btnyazdir.IconMarginRight = 0;
            this.btnyazdir.IconRightVisible = true;
            this.btnyazdir.IconRightZoom = 0D;
            this.btnyazdir.IconVisible = true;
            this.btnyazdir.IconZoom = 90D;
            this.btnyazdir.IsTab = false;
            this.btnyazdir.Location = new System.Drawing.Point(603, 330);
            this.btnyazdir.Name = "btnyazdir";
            this.btnyazdir.Normalcolor = System.Drawing.Color.OrangeRed;
            this.btnyazdir.OnHovercolor = System.Drawing.Color.Red;
            this.btnyazdir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnyazdir.selected = false;
            this.btnyazdir.Size = new System.Drawing.Size(241, 48);
            this.btnyazdir.TabIndex = 9;
            this.btnyazdir.Text = "Распечатать";
            this.btnyazdir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyazdir.Textcolor = System.Drawing.Color.White;
            this.btnyazdir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyazdir.Click += new System.EventHandler(this.btnyazdir_Click);
            // 
            // tbhesap
            // 
            this.tbhesap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbhesap.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbhesap.BorderColorIdle = System.Drawing.SystemColors.MenuHighlight;
            this.tbhesap.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbhesap.BorderThickness = 3;
            this.tbhesap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbhesap.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbhesap.ForeColor = System.Drawing.Color.Black;
            this.tbhesap.isPassword = false;
            this.tbhesap.Location = new System.Drawing.Point(603, 245);
            this.tbhesap.Margin = new System.Windows.Forms.Padding(4);
            this.tbhesap.Name = "tbhesap";
            this.tbhesap.Size = new System.Drawing.Size(209, 44);
            this.tbhesap.TabIndex = 12;
            this.tbhesap.Tag = "";
            this.tbhesap.Text = "Автокалькулятор";
            this.tbhesap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbhesap.Enter += new System.EventHandler(this.tbhesap_Enter);
            this.tbhesap.Leave += new System.EventHandler(this.tbhesap_Leave);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(607, 299);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(58, 16);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Сдачи:";
            // 
            // txts4t
            // 
            this.txts4t.AutoSize = true;
            this.txts4t.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txts4t.ForeColor = System.Drawing.Color.Black;
            this.txts4t.Location = new System.Drawing.Point(671, 298);
            this.txts4t.Name = "txts4t";
            this.txts4t.Size = new System.Drawing.Size(17, 18);
            this.txts4t.TabIndex = 14;
            this.txts4t.Text = "0";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(742, 300);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(34, 15);
            this.bunifuCustomLabel5.TabIndex = 15;
            this.bunifuCustomLabel5.Text = "Сом";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(825, 244);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(49, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frmOplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(907, 462);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.tbhesap);
            this.Controls.Add(this.lbAdisiyonid);
            this.Controls.Add(this.btnoplata);
            this.Controls.Add(this.txts4t);
            this.Controls.Add(this.btnyazdir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOplata";
            this.Load += new System.EventHandler(this.frmOplata_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton btnoplata;
        private Bunifu.Framework.UI.BunifuFlatButton btnyazdir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCheckbox chindirim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvUrunler;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel lblindirim;
        private Bunifu.Framework.UI.BunifuCustomLabel lblKDV;
        private Bunifu.Framework.UI.BunifuCustomLabel lbfiyat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel lblToplam;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private System.Windows.Forms.Label lbAdisiyonid;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbindirim;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCheckbox chindir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.RadioButton rdticket;
        private System.Windows.Forms.RadioButton rdnakit;
        private System.Windows.Forms.RadioButton rdkredi;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbhesap;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel txts4t;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}