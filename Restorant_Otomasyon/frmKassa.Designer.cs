namespace Restorant_Otomasyon
{
    partial class frmKassa
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
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKassa));
           // Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Restorant_Otomasyon.DataSet1();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
           // this.rpvAylik = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblGunluk = new System.Windows.Forms.Label();
            this.lblAylik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnzRapor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRapor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataTable1TableAdapter = new Restorant_Otomasyon.DataSet1TableAdapters.DataTable1TableAdapter();
            this.DataTable2TableAdapter = new Restorant_Otomasyon.DataSet1TableAdapters.DataTable2TableAdapter();
            //this.rpvGunluk = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
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
            this.panel2.Size = new System.Drawing.Size(1048, 36);
            this.panel2.TabIndex = 3;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(980, 1);
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
            this.btncikis.Location = new System.Drawing.Point(1013, 1);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(120, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Доклад кассы";
            // 
            // rpvAylik
            // 
            //reportDataSource2.Name = "DataSet1";
            //reportDataSource2.Value = this.DataTable1BindingSource;
            //this.rpvAylik.LocalReport.DataSources.Add(reportDataSource2);
            //this.rpvAylik.LocalReport.ReportEmbeddedResource = "Restorant_Otomasyon.Report1.rdlc";
            //this.rpvAylik.Location = new System.Drawing.Point(234, 81);
            //this.rpvAylik.Name = "rpvAylik";
            //this.rpvAylik.Size = new System.Drawing.Size(781, 430);
            //this.rpvAylik.TabIndex = 6;
            // 
            // lblGunluk
            // 
            this.lblGunluk.AutoSize = true;
            this.lblGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGunluk.ForeColor = System.Drawing.Color.White;
            this.lblGunluk.Location = new System.Drawing.Point(457, 43);
            this.lblGunluk.Name = "lblGunluk";
            this.lblGunluk.Size = new System.Drawing.Size(293, 25);
            this.lblGunluk.TabIndex = 7;
            this.lblGunluk.Text = "СЕГОДНЯШНИЙ ДОКЛАД";
            // 
            // lblAylik
            // 
            this.lblAylik.AutoSize = true;
            this.lblAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAylik.ForeColor = System.Drawing.Color.White;
            this.lblAylik.Location = new System.Drawing.Point(457, 43);
            this.lblAylik.Name = "lblAylik";
            this.lblAylik.Size = new System.Drawing.Size(249, 25);
            this.lblAylik.TabIndex = 7;
            this.lblAylik.Text = "МЕСЯЧНЫЙ ДОКЛАД";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 202);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnzRapor
            // 
            this.btnzRapor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnzRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnzRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnzRapor.BorderRadius = 0;
            this.btnzRapor.ButtonText = "Сегодняшний Доклад";
            this.btnzRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnzRapor.DisabledColor = System.Drawing.Color.Gray;
            this.btnzRapor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnzRapor.Iconimage = global::Restorant_Otomasyon.Properties.Resources.database;
            this.btnzRapor.Iconimage_right = null;
            this.btnzRapor.Iconimage_right_Selected = null;
            this.btnzRapor.Iconimage_Selected = null;
            this.btnzRapor.IconMarginLeft = 0;
            this.btnzRapor.IconMarginRight = 0;
            this.btnzRapor.IconRightVisible = true;
            this.btnzRapor.IconRightZoom = 0D;
            this.btnzRapor.IconVisible = true;
            this.btnzRapor.IconZoom = 90D;
            this.btnzRapor.IsTab = false;
            this.btnzRapor.Location = new System.Drawing.Point(32, 212);
            this.btnzRapor.Name = "btnzRapor";
            this.btnzRapor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnzRapor.OnHovercolor = System.Drawing.Color.Red;
            this.btnzRapor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnzRapor.selected = false;
            this.btnzRapor.Size = new System.Drawing.Size(157, 48);
            this.btnzRapor.TabIndex = 5;
            this.btnzRapor.Text = "Сегодняшний Доклад";
            this.btnzRapor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnzRapor.Textcolor = System.Drawing.Color.White;
            this.btnzRapor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzRapor.Click += new System.EventHandler(this.btnzRapor_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRapor.BorderRadius = 0;
            this.btnRapor.ButtonText = "Месячный доклад";
            this.btnRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapor.DisabledColor = System.Drawing.Color.Gray;
            this.btnRapor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRapor.Iconimage = global::Restorant_Otomasyon.Properties.Resources.loupe;
            this.btnRapor.Iconimage_right = null;
            this.btnRapor.Iconimage_right_Selected = null;
            this.btnRapor.Iconimage_Selected = null;
            this.btnRapor.IconMarginLeft = 0;
            this.btnRapor.IconMarginRight = 0;
            this.btnRapor.IconRightVisible = true;
            this.btnRapor.IconRightZoom = 0D;
            this.btnRapor.IconVisible = true;
            this.btnRapor.IconZoom = 90D;
            this.btnRapor.IsTab = false;
            this.btnRapor.Location = new System.Drawing.Point(32, 212);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRapor.OnHovercolor = System.Drawing.Color.Red;
            this.btnRapor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRapor.selected = false;
            this.btnRapor.Size = new System.Drawing.Size(157, 48);
            this.btnRapor.TabIndex = 4;
            this.btnRapor.Text = "Месячный доклад";
            this.btnRapor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.Textcolor = System.Drawing.Color.White;
            this.btnRapor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // rpvGunluk
            // 
            //reportDataSource1.Name = "DataSet1";
            //reportDataSource1.Value = this.DataTable2BindingSource;
            //this.rpvGunluk.LocalReport.DataSources.Add(reportDataSource1);
            //this.rpvGunluk.LocalReport.ReportEmbeddedResource = "Restorant_Otomasyon.Report2.rdlc";
            //this.rpvGunluk.Location = new System.Drawing.Point(234, 81);
            //this.rpvGunluk.Name = "rpvGunluk";
            //this.rpvGunluk.Size = new System.Drawing.Size(781, 430);
            //this.rpvGunluk.TabIndex = 9;
            // 
            // frmKassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1048, 523);
           // this.Controls.Add(this.rpvGunluk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAylik);
            this.Controls.Add(this.lblGunluk);
           // this.Controls.Add(this.rpvAylik);
            this.Controls.Add(this.btnzRapor);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKassa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKassa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKassa_FormClosed);
            this.Load += new System.EventHandler(this.frmKassa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton btnzRapor;
        private Bunifu.Framework.UI.BunifuFlatButton btnRapor;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DataSet1TableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
       // private Microsoft.Reporting.WinForms.ReportViewer rpvAylik;
        private System.Windows.Forms.Label lblAylik;
        private System.Windows.Forms.Label lblGunluk;
        private System.Windows.Forms.PictureBox pictureBox1;
       // private Microsoft.Reporting.WinForms.ReportViewer rpvGunluk;
    }
}