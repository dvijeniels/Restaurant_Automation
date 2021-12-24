namespace Restorant_Otomasyon
{
    partial class frmYeniMusteri
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtmusteriid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnguncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnyeniekle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnback = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(374, 36);
            this.panel2.TabIndex = 4;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(170, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Добавление клиента";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtadi
            // 
            this.txtadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtadi.Location = new System.Drawing.Point(59, 42);
            this.txtadi.Multiline = true;
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(262, 32);
            this.txtadi.TabIndex = 32;
            this.txtadi.Text = "Имя";
            this.txtadi.Enter += new System.EventHandler(this.txtadi_Enter);
            this.txtadi.Leave += new System.EventHandler(this.txtadi_Leave);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsoyad.Location = new System.Drawing.Point(59, 85);
            this.txtsoyad.Multiline = true;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(262, 32);
            this.txtsoyad.TabIndex = 33;
            this.txtsoyad.Text = "Фамилия";
            this.txtsoyad.Enter += new System.EventHandler(this.txtsoyad_Enter);
            this.txtsoyad.Leave += new System.EventHandler(this.txtsoyad_Leave);
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtmail.Location = new System.Drawing.Point(59, 171);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(262, 32);
            this.txtmail.TabIndex = 35;
            this.txtmail.Text = "Почта";
            this.txtmail.Enter += new System.EventHandler(this.txtmail_Enter);
            this.txtmail.Leave += new System.EventHandler(this.txtmail_Leave);
            // 
            // txtadres
            // 
            this.txtadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtadres.Location = new System.Drawing.Point(59, 214);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(262, 150);
            this.txtadres.TabIndex = 36;
            this.txtadres.Text = "Адрес";
            this.txtadres.Enter += new System.EventHandler(this.txtadres_Enter);
            this.txtadres.Leave += new System.EventHandler(this.txtadres_Leave);
            // 
            // txttelefon
            // 
            this.txttelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txttelefon.Location = new System.Drawing.Point(59, 128);
            this.txttelefon.Multiline = true;
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(262, 32);
            this.txttelefon.TabIndex = 37;
            this.txttelefon.Text = "Телефон";
            this.txttelefon.TextChanged += new System.EventHandler(this.txttelefon_TextChanged);
            this.txttelefon.Enter += new System.EventHandler(this.txttelefon_Enter);
            this.txttelefon.Leave += new System.EventHandler(this.txttelefon_Leave);
            // 
            // txtmusteriid
            // 
            this.txtmusteriid.Location = new System.Drawing.Point(327, 43);
            this.txtmusteriid.Multiline = true;
            this.txtmusteriid.Name = "txtmusteriid";
            this.txtmusteriid.Size = new System.Drawing.Size(33, 30);
            this.txtmusteriid.TabIndex = 39;
            this.txtmusteriid.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.prv;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(328, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnguncelle.BackColor = System.Drawing.Color.Blue;
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguncelle.BorderRadius = 0;
            this.btnguncelle.ButtonText = "Изменить";
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btnguncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguncelle.Iconimage = global::Restorant_Otomasyon.Properties.Resources.refresh;
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
            this.btnguncelle.Location = new System.Drawing.Point(59, 403);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Normalcolor = System.Drawing.Color.Blue;
            this.btnguncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.btnguncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguncelle.selected = false;
            this.btnguncelle.Size = new System.Drawing.Size(262, 48);
            this.btnguncelle.TabIndex = 31;
            this.btnguncelle.Text = "Изменить";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.Textcolor = System.Drawing.Color.White;
            this.btnguncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.Visible = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsec
            // 
            this.btnsec.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsec.BackColor = System.Drawing.Color.Blue;
            this.btnsec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsec.BorderRadius = 0;
            this.btnsec.ButtonText = "Выбрать клиента";
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
            this.btnsec.Location = new System.Drawing.Point(59, 462);
            this.btnsec.Name = "btnsec";
            this.btnsec.Normalcolor = System.Drawing.Color.Blue;
            this.btnsec.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.btnsec.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsec.selected = false;
            this.btnsec.Size = new System.Drawing.Size(262, 48);
            this.btnsec.TabIndex = 30;
            this.btnsec.Text = "Выбрать клиента";
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
            this.btnyeniekle.ButtonText = "  Добавить";
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
            this.btnyeniekle.Location = new System.Drawing.Point(59, 403);
            this.btnyeniekle.Name = "btnyeniekle";
            this.btnyeniekle.Normalcolor = System.Drawing.Color.Blue;
            this.btnyeniekle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.btnyeniekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnyeniekle.selected = false;
            this.btnyeniekle.Size = new System.Drawing.Size(262, 48);
            this.btnyeniekle.TabIndex = 29;
            this.btnyeniekle.Text = "  Добавить";
            this.btnyeniekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyeniekle.Textcolor = System.Drawing.Color.White;
            this.btnyeniekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyeniekle.Visible = false;
            this.btnyeniekle.Click += new System.EventHandler(this.btnyeniekle_Click);
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(306, 0);
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
            this.btncikis.Location = new System.Drawing.Point(339, 0);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(35, 37);
            this.btncikis.TabIndex = 4;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // frmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(374, 600);
            this.Controls.Add(this.txtmusteriid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.btnyeniekle);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYeniMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYeniMusteri";
            this.Load += new System.EventHandler(this.frmYeniMusteri_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btncikis;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnguncelle;
        private Bunifu.Framework.UI.BunifuFlatButton btnsec;
        private Bunifu.Framework.UI.BunifuFlatButton btnyeniekle;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtmusteriid;
    }
}