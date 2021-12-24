namespace Restorant_Otomasyon
{
    partial class frmRapor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapor));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chRapor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvIstatistik = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZRapor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).BeginInit();
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btncikis);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 36);
            this.panel2.TabIndex = 4;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(929, 0);
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
            this.btncikis.Location = new System.Drawing.Point(962, 0);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(164, 18);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Статистика  (отчёт)";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(745, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 456);
            this.panel3.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chRapor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(34, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 366);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // chRapor
            // 
            this.chRapor.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chRapor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chRapor.Legends.Add(legend1);
            this.chRapor.Location = new System.Drawing.Point(6, 30);
            this.chRapor.Name = "chRapor";
            this.chRapor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Label = "#VAL #AXISLABEL";
            series1.Legend = "Legend1";
            series1.Name = "Проданные";
            this.chRapor.Series.Add(series1);
            this.chRapor.Size = new System.Drawing.Size(643, 329);
            this.chRapor.TabIndex = 0;
            this.chRapor.Text = " ";
            // 
            // lvIstatistik
            // 
            this.lvIstatistik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvIstatistik.Location = new System.Drawing.Point(607, 42);
            this.lvIstatistik.Name = "lvIstatistik";
            this.lvIstatistik.Size = new System.Drawing.Size(119, 71);
            this.lvIstatistik.TabIndex = 19;
            this.lvIstatistik.UseCompatibleStateImageBehavior = false;
            this.lvIstatistik.View = System.Windows.Forms.View.Details;
            this.lvIstatistik.Visible = false;
            this.lvIstatistik.SelectedIndexChanged += new System.EventHandler(this.lvIstatistik_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название еды";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Штук";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBaslangic.Location = new System.Drawing.Point(386, 53);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtBaslangic.TabIndex = 16;
            // 
            // dtBitis
            // 
            this.dtBitis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBitis.Location = new System.Drawing.Point(386, 80);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 20);
            this.dtBitis.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(351, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(348, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "До";
            // 
            // btnZRapor
            // 
            this.btnZRapor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(251)))));
            this.btnZRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnZRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZRapor.BorderRadius = 0;
            this.btnZRapor.ButtonText = "Все категории";
            this.btnZRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZRapor.DisabledColor = System.Drawing.Color.Gray;
            this.btnZRapor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZRapor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnZRapor.Iconimage")));
            this.btnZRapor.Iconimage_right = null;
            this.btnZRapor.Iconimage_right_Selected = null;
            this.btnZRapor.Iconimage_Selected = null;
            this.btnZRapor.IconMarginLeft = 0;
            this.btnZRapor.IconMarginRight = 0;
            this.btnZRapor.IconRightVisible = true;
            this.btnZRapor.IconRightZoom = 0D;
            this.btnZRapor.IconVisible = true;
            this.btnZRapor.IconZoom = 90D;
            this.btnZRapor.IsTab = false;
            this.btnZRapor.Location = new System.Drawing.Point(34, 49);
            this.btnZRapor.Name = "btnZRapor";
            this.btnZRapor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnZRapor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(150)))));
            this.btnZRapor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnZRapor.selected = false;
            this.btnZRapor.Size = new System.Drawing.Size(241, 48);
            this.btnZRapor.TabIndex = 19;
            this.btnZRapor.Text = "Все категории";
            this.btnZRapor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZRapor.Textcolor = System.Drawing.Color.White;
            this.btnZRapor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZRapor.Click += new System.EventHandler(this.btnZRapor_Click);
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(997, 492);
            this.Controls.Add(this.lvIstatistik);
            this.Controls.Add(this.btnZRapor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chRapor)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRapor;
        private Bunifu.Framework.UI.BunifuFlatButton btnZRapor;
        private System.Windows.Forms.ListView lvIstatistik;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}