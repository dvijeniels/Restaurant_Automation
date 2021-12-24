using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Restorant_Otomasyon
{
    public partial class Glavn : Form
    {
        public Glavn()
        {
            InitializeComponent();
        }
        baglanti bagl = new baglanti();
        void btnmasa_Click(object sender, EventArgs e)
        {
            Button bttn = (sender as Button);
            frmZakaz zak = new frmZakaz();
            baglanti._ServisTurNo = 1;
            int uzunluk = bttn.Text.Length;
            if(uzunluk==6)
            {
                baglanti._buttonValue = bttn.Text.Substring(uzunluk - 6, 6);
            }
            else baglanti._buttonValue = bttn.Text.Substring(uzunluk - 7, 7);
            if (bttn.Name.Length == 8)
            {
                baglanti._buttonName = bttn.Name.Substring(bttn.Name.Length-8,8);
            }
            else baglanti._buttonName = bttn.Name.Substring(bttn.Name.Length - 9, 9);
            //baglanti._buttonName = bttn.Name;
            this.Hide();
            zak.ShowDialog();
        }
        private void Glavn_Load(object sender, EventArgs e)
        {
            int say=0,sayi=1;
            int i = 0, j = 0, masaSayisi=0;
            cMasalar cmasa = new cMasalar();
            masaSayisi = Convert.ToInt32(cmasa.MasaCount());
            for (i = 1; i <= masaSayisi; i++)
            {
                Button myButton = new Button();
                myButton.Name = "btnmasa" + sayi++;
                myButton.Text = "Стол " + (++say).ToString();
                myButton.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                myButton.ForeColor = Color.Black;
                //myButton.Image = (System.Drawing.Image)(Properties.Resources.bos);
                myButton.Size = new System.Drawing.Size(155, 60);
                myButton.Click += btnmasa_Click;
                flowLayoutPanel1.Controls.Add(myButton);
            }
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select durum, idmasa from masalar", con);
            OleDbDataReader dr = null;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    if(item is Button)
                    {
                        item.BackgroundImageLayout = ImageLayout.Zoom;
                        if (item.Name == "btnmasa" + dr["idmasa"].ToString() && dr["durum"].ToString() == "1")
                        {
                            //item.BackgroundImage = (System.Drawing.Image)Image.FromFile(@"D:\orneker\Nesneye yon\Restorant_Otomasyon\Restorant_Otomasyon\Resources\bos1.jpg");
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.booos);
                        }
                        else if (item.Name == "btnmasa" + dr["idmasa"].ToString() && dr["durum"].ToString() == "2")
                        {
                            cMasalar masa = new cMasalar();
                            DateTime dt1 = Convert.ToDateTime(masa.SessionSum(2,Convert.ToString(dr["idmasa"])).ToString());
                            DateTime dt2 = DateTime.Now;
                            string str1 = Convert.ToDateTime(masa.SessionSum(2,Convert.ToString(dr["idmasa"]).ToString())).ToShortTimeString();
                            string str2 = DateTime.Now.ToShortTimeString();
                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(str1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(str2).TimeOfDay.TotalMinutes);
                            var fark = t2 - t1;
                            item.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                            item.Text = String.Format("{0}{1}{2}",
                                fark.Days > 0 ? string.Format("{0} День", fark.Days) : "",
                                fark.Hours > 0 ? string.Format("{0} Часов", fark.Hours) : "",
                                fark.Minutes > 0 ? string.Format("\n{0} Минут", fark.Minutes) : "").Trim() + " Стол " + dr["idmasa"].ToString();
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.table_64);
                        }
                        else if (item.Name == "btnmasa" + dr["idmasa"].ToString() && dr["durum"].ToString() == "3")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.brongel);
                        }
                        else if (item.Name == "btnmasa" + dr["idmasa"].ToString() && dr["durum"].ToString() == "4")
                        {
                            item.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bron);
                        }
                    }
                }
            }
            
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            this.Hide();
            frm.ShowDialog();
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buyutkucult_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                buyutkucult.BackgroundImage = (System.Drawing.Image)(Properties.Resources.icons8_windows_metro_52);
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                buyutkucult.BackgroundImage = (System.Drawing.Image)(Properties.Resources.expand_icon_icons_com_69659);
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
