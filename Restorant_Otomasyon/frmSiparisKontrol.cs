using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant_Otomasyon
{
    public partial class frmSiparisKontrol : Form
    {
        public frmSiparisKontrol()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa sistema = new Anasayfa();
            sistema.ShowDialog();
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void frmSiparisKontrol_Load(object sender, EventArgs e)
        {
            lvMusteriDetaylari.Columns[0].Width = 0;
            lvMusteriDetaylari.BackColor = Color.FromArgb(128, 128, 200);
            lvSatisDetaylari.BackColor = Color.FromArgb(128, 128, 100);
            cAdisyon ca = new cAdisyon();
            int butonsayisi = ca.adisyonBul();
            ca.acikaPaketAdisyonlar(lvMusteriler);
            int sol = 0, bol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(butonsayisi)));
            for (int i = 1; i <= lvMusteriler.Items.Count; i++)
            {
                Button myButton = new Button();
                myButton.AutoSize = false;
                myButton.Size = new Size(200, 50);
                myButton.FlatStyle = FlatStyle.Flat;
                myButton.ForeColor = Color.White;
                myButton.BackColor = Color.FromArgb(59, 40, 94);
                myButton.FlatAppearance.BorderSize = 0;
                myButton.Name = lvMusteriler.Items[i - 1].SubItems[0].Text;
                myButton.Text = lvMusteriler.Items[i - 1].SubItems[1].Text;
                myButton.Font = new Font(myButton.Font.FontFamily.Name,12,FontStyle.Bold);
                myButton.Top = (25 * sol++) * 2;
                panel1.Controls.Add(myButton);
                myButton.Click += new EventHandler(dinamikMethod);
                myButton.MouseEnter += new EventHandler(dinamikMethod2);
            }
        }
        protected void dinamikMethod(object sender,EventArgs e)
        {
            cAdisyon ca = new cAdisyon();
            Button dnmbtn = (sender as Button);
            frmOplata frm = new frmOplata();
            baglanti._ServisTurNo = 2;
            baglanti._AdisyonID = Convert.ToString(ca.musteriSonAdisyonID(Convert.ToInt32(dnmbtn.Name)));
            this.Hide();
            frm.ShowDialog();
        }
        protected void dinamikMethod2(object sender, EventArgs e)
        {
            cAdisyon ca = new cAdisyon();
            Button dnmbtn = (sender as Button);
            baglanti._ServisTurNo = 2;
            ca.musteriDetaylar(lvMusteriDetaylari, Convert.ToInt32(dnmbtn.Name));
            sonSiparisTarihi();
            lvSatisDetaylari.Items.Clear();
            lblToplamSip.Text = "_____";
            cSiparis cs=new cSiparis();
            baglanti._AdisyonID = Convert.ToString(ca.musteriSonAdisyonID(Convert.ToInt32(dnmbtn.Name)));
            lblgeneltoplam.Text = cs.GenelToplamBul(Convert.ToInt32(dnmbtn.Name)).ToString() + " Сомов";
        }
        void sonSiparisTarihi()
        {
            if(lvMusteriDetaylari.Items.Count>0)
            {
                cAdisyon ca=new cAdisyon();
                int s = ca.musteriSiparisSayisi(Convert.ToInt32(lvMusteriDetaylari.Items[0].SubItems[0].Text));
                lblsonsiparis.Text = lvMusteriDetaylari.Items[0].SubItems[3].Text;
                txttoplamTutar.Text = s + " раза";
            }
        }
        void toplam()
        {
            int kayitSayisi = lvSatisDetaylari.Items.Count;
            double toplam = 0;
            for (int i = 0; i < kayitSayisi; i++)
            {
                toplam += Convert.ToDouble(lvSatisDetaylari.Items[i].SubItems[2].Text)* Convert.ToDouble(lvSatisDetaylari.Items[i].SubItems[3].Text);
            }
            lblToplamSip.Text = toplam.ToString() + " Сомов";
        }

        private void lvMusteriDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMusteriDetaylari.SelectedItems.Count>0)
            {
                cSiparis c = new cSiparis();
                c.adisyonpaketSipDetaylari(lvSatisDetaylari, Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[4].Text));
                toplam();
            }
        }

        private void lvSatisDetaylari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMusteriDetaylari.SelectedItems.Count>0)
            {
                cSiparis c = new cSiparis();
                c.adisyonpaketSipDetaylari(lvSatisDetaylari, Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[4].Text));
                toplam();
                lblgeneltoplam.Text = c.GenelToplamBul(Convert.ToInt32(lvMusteriDetaylari.SelectedItems[0].SubItems[0].Text)).ToString() + " Сомов";
            }
        }
        private void btnsiparis_Click(object sender, EventArgs e)
        {
            frmMusteri frm = new frmMusteri();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
