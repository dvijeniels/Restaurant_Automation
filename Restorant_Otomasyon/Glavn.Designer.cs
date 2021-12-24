namespace Restorant_Otomasyon
{
    partial class Glavn
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
            this.lbldolu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblbos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblacik = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblrezerve = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buyutkucult = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.buyutkucult);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btncikis);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1324, 36);
            this.panel2.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.arrow_64_64__1_;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(1223, -1);
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
            this.btncikis.Location = new System.Drawing.Point(1289, -1);
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
            // lbldolu
            // 
            this.lbldolu.AutoSize = true;
            this.lbldolu.BackColor = System.Drawing.Color.Red;
            this.lbldolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldolu.Location = new System.Drawing.Point(233, 55);
            this.lbldolu.Name = "lbldolu";
            this.lbldolu.Size = new System.Drawing.Size(58, 18);
            this.lbldolu.TabIndex = 4;
            this.lbldolu.Text = "Занято";
            // 
            // lblbos
            // 
            this.lblbos.AutoSize = true;
            this.lblbos.BackColor = System.Drawing.Color.Yellow;
            this.lblbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblbos.Location = new System.Drawing.Point(332, 54);
            this.lblbos.Name = "lblbos";
            this.lblbos.Size = new System.Drawing.Size(80, 18);
            this.lblbos.TabIndex = 5;
            this.lblbos.Text = "Свободно";
            // 
            // lblacik
            // 
            this.lblacik.AutoSize = true;
            this.lblacik.BackColor = System.Drawing.Color.Magenta;
            this.lblacik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblacik.Location = new System.Drawing.Point(455, 53);
            this.lblacik.Name = "lblacik";
            this.lblacik.Size = new System.Drawing.Size(92, 18);
            this.lblacik.TabIndex = 6;
            this.lblacik.Text = "Бронирован";
            // 
            // lblrezerve
            // 
            this.lblrezerve.AutoSize = true;
            this.lblrezerve.BackColor = System.Drawing.Color.Blue;
            this.lblrezerve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblrezerve.Location = new System.Drawing.Point(602, 53);
            this.lblrezerve.Name = "lblrezerve";
            this.lblrezerve.Size = new System.Drawing.Size(118, 18);
            this.lblrezerve.TabIndex = 7;
            this.lblrezerve.Text = "Забронировано";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(308, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 20);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(209, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 20);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Magenta;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(431, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 20);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(578, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(18, 20);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 109);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1292, 542);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // buyutkucult
            // 
            this.buyutkucult.BackgroundImage = global::Restorant_Otomasyon.Properties.Resources.expand_icon_icons_com_69659;
            this.buyutkucult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buyutkucult.Location = new System.Drawing.Point(1256, -1);
            this.buyutkucult.Name = "buyutkucult";
            this.buyutkucult.Size = new System.Drawing.Size(35, 37);
            this.buyutkucult.TabIndex = 6;
            this.buyutkucult.UseVisualStyleBackColor = true;
            this.buyutkucult.Click += new System.EventHandler(this.buyutkucult_Click);
            // 
            // Glavn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1324, 678);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblrezerve);
            this.Controls.Add(this.lblacik);
            this.Controls.Add(this.lblbos);
            this.Controls.Add(this.lbldolu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Glavn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavn";
            this.Load += new System.EventHandler(this.Glavn_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblrezerve;
        private Bunifu.Framework.UI.BunifuCustomLabel lblacik;
        private Bunifu.Framework.UI.BunifuCustomLabel lblbos;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldolu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buyutkucult;
    }
}