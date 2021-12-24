namespace Restorant_Otomasyon
{
    partial class frmSiparisKontrol
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lvMusteriDetaylari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdisyonID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSatisDetaylari = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txttoplamTutar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamSip = new System.Windows.Forms.Label();
            this.lblgeneltoplam = new System.Windows.Forms.Label();
            this.lblsonsiparis = new System.Windows.Forms.Label();
            this.btnsiparis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 4;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(897, -1);
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
            this.btncikis.Location = new System.Drawing.Point(930, -1);
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
            // lvMusteriDetaylari
            // 
            this.lvMusteriDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.AdisyonID});
            this.lvMusteriDetaylari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvMusteriDetaylari.ForeColor = System.Drawing.Color.Black;
            this.lvMusteriDetaylari.FullRowSelect = true;
            this.lvMusteriDetaylari.GridLines = true;
            this.lvMusteriDetaylari.Location = new System.Drawing.Point(209, 42);
            this.lvMusteriDetaylari.Name = "lvMusteriDetaylari";
            this.lvMusteriDetaylari.Size = new System.Drawing.Size(451, 324);
            this.lvMusteriDetaylari.TabIndex = 5;
            this.lvMusteriDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvMusteriDetaylari.View = System.Windows.Forms.View.Details;
            this.lvMusteriDetaylari.SelectedIndexChanged += new System.EventHandler(this.lvMusteriDetaylari_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "musteriid";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата";
            this.columnHeader4.Width = 130;
            // 
            // AdisyonID
            // 
            this.AdisyonID.Text = "AdisyonID";
            this.AdisyonID.Width = 0;
            // 
            // lvSatisDetaylari
            // 
            this.lvSatisDetaylari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvSatisDetaylari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvSatisDetaylari.FullRowSelect = true;
            this.lvSatisDetaylari.GridLines = true;
            this.lvSatisDetaylari.Location = new System.Drawing.Point(666, 42);
            this.lvSatisDetaylari.Name = "lvSatisDetaylari";
            this.lvSatisDetaylari.Size = new System.Drawing.Size(281, 324);
            this.lvSatisDetaylari.TabIndex = 5;
            this.lvSatisDetaylari.UseCompatibleStateImageBehavior = false;
            this.lvSatisDetaylari.View = System.Windows.Forms.View.Details;
            this.lvSatisDetaylari.SelectedIndexChanged += new System.EventHandler(this.lvSatisDetaylari_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Satisid";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Имя продукта";
            this.columnHeader7.Width = 155;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Штук";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Цена";
            this.columnHeader9.Width = 70;
            // 
            // txttoplamTutar
            // 
            this.txttoplamTutar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttoplamTutar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txttoplamTutar.ForeColor = System.Drawing.Color.Black;
            this.txttoplamTutar.HintForeColor = System.Drawing.Color.White;
            this.txttoplamTutar.HintText = "";
            this.txttoplamTutar.isPassword = false;
            this.txttoplamTutar.LineFocusedColor = System.Drawing.Color.Blue;
            this.txttoplamTutar.LineIdleColor = System.Drawing.Color.Black;
            this.txttoplamTutar.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txttoplamTutar.LineThickness = 4;
            this.txttoplamTutar.Location = new System.Drawing.Point(441, 376);
            this.txttoplamTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txttoplamTutar.Name = "txttoplamTutar";
            this.txttoplamTutar.Size = new System.Drawing.Size(96, 29);
            this.txttoplamTutar.TabIndex = 6;
            this.txttoplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Всего заказов сделано:";
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.Location = new System.Drawing.Point(727, 183);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(193, 119);
            this.lvMusteriler.TabIndex = 5;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            this.lvMusteriler.Visible = false;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Musteriid";
            this.columnHeader10.Width = 45;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Клиент";
            this.columnHeader11.Width = 49;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "AdisyonID";
            this.columnHeader12.Width = 44;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 490);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(244, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Всего:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(244, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Общий итог:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(244, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Последний заказ:";
            // 
            // lblToplamSip
            // 
            this.lblToplamSip.AutoSize = true;
            this.lblToplamSip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToplamSip.Location = new System.Drawing.Point(403, 429);
            this.lblToplamSip.Name = "lblToplamSip";
            this.lblToplamSip.Size = new System.Drawing.Size(44, 18);
            this.lblToplamSip.TabIndex = 7;
            this.lblToplamSip.Text = "____";
            // 
            // lblgeneltoplam
            // 
            this.lblgeneltoplam.AutoSize = true;
            this.lblgeneltoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblgeneltoplam.Location = new System.Drawing.Point(403, 447);
            this.lblgeneltoplam.Name = "lblgeneltoplam";
            this.lblgeneltoplam.Size = new System.Drawing.Size(44, 18);
            this.lblgeneltoplam.TabIndex = 7;
            this.lblgeneltoplam.Text = "____";
            // 
            // lblsonsiparis
            // 
            this.lblsonsiparis.AutoSize = true;
            this.lblsonsiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsonsiparis.Location = new System.Drawing.Point(403, 465);
            this.lblsonsiparis.Name = "lblsonsiparis";
            this.lblsonsiparis.Size = new System.Drawing.Size(44, 18);
            this.lblsonsiparis.TabIndex = 7;
            this.lblsonsiparis.Text = "____";
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
            this.btnsiparis.Location = new System.Drawing.Point(715, 382);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Normalcolor = System.Drawing.Color.Blue;
            this.btnsiparis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.btnsiparis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsiparis.selected = false;
            this.btnsiparis.Size = new System.Drawing.Size(205, 48);
            this.btnsiparis.TabIndex = 28;
            this.btnsiparis.Text = "Заказ для доставки";
            this.btnsiparis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsiparis.Textcolor = System.Drawing.Color.White;
            this.btnsiparis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // frmSiparisKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(966, 526);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsonsiparis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblgeneltoplam);
            this.Controls.Add(this.lblToplamSip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttoplamTutar);
            this.Controls.Add(this.lvMusteriler);
            this.Controls.Add(this.lvSatisDetaylari);
            this.Controls.Add(this.lvMusteriDetaylari);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparisKontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSiparisKontrol";
            this.Load += new System.EventHandler(this.frmSiparisKontrol_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btncikis;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ListView lvSatisDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvMusteriDetaylari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txttoplamTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsonsiparis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblgeneltoplam;
        private System.Windows.Forms.Label lblToplamSip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader AdisyonID;
        private Bunifu.Framework.UI.BunifuFlatButton btnsiparis;
    }
}