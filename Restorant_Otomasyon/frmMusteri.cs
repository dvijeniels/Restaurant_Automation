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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }
        private void frmMusteri_FormClosed(object sender, FormClosedEventArgs e)
        {

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

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            cMusteriler c = new cMusteriler();
            c.musteriGetir(lvmusteri);
            cPaketler cp = new cPaketler();
            cp.paketMusteriIDGetir(lvMusteriler);
        }

        private void txtadi_Leave(object sender, EventArgs e)
        {
            if(txtadi.Text=="")
            {
                txtadi.Text = "Поиск...";
            }
        }
        private void txtadi_Enter(object sender, EventArgs e)
        {
            if (txtadi.Text == "Поиск...")
            {
                txtadi.Text = "";
            }
        }
        private void txtsoyadi_Leave(object sender, EventArgs e)
        {
            if (txtsoyadi.Text == "")
            {
                txtsoyadi.Text = "Поиск...";
            }
        }
        private void txtsoyadi_Enter(object sender, EventArgs e)
        {
            if (txtsoyadi.Text == "Поиск...")
            {
                txtsoyadi.Text = "";
            }
        }
        private void telefon_Leave(object sender, EventArgs e)
        {
            if (telefon.Text == "")
            {
                telefon.Text = "Поиск...";
            }
        }
        private void telefon_Enter(object sender, EventArgs e)
        {
            if (telefon.Text == "Поиск...")
            {
                telefon.Text = "";
            }
        }
        private void txtadres_Leave(object sender, EventArgs e)
        {
            if (txtadres.Text == "")
            {
                txtadres.Text = "Поиск...";
            }
        }
        private void txtadres_Enter(object sender, EventArgs e)
        {
            if (txtadres.Text == "Поиск...")
            {
                txtadres.Text = "";
            }
        }

        private void btnyeniekle_Click(object sender, EventArgs e)
        {
            baglanti._kontrol = 1;
            frmYeniMusteri sistema = new frmYeniMusteri();
            baglanti._musteriEkleme = 1;
            this.Hide();
            sistema.ShowDialog();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (lvmusteri.SelectedItems.Count > 0)
            {
                baglanti._kontrol = 2;
                baglanti._musteriEkleme = 1;
                baglanti._musteriId = Convert.ToInt32(lvmusteri.SelectedItems[0].SubItems[0].Text);
                this.Hide();
                frmYeniMusteri sistema = new frmYeniMusteri();
                sistema.ShowDialog();
            }
            else MessageBox.Show("Выберите из списка для начало!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //if (baglanti._musteriEkleme == 0)
            //{
            //    frmRezervasyon frm = new frmRezervasyon();
            //    baglanti._musteriEkleme = 1;
            //    this.Hide();
            //    frm.ShowDialog();
            //    this.Close();
            //}
            //else if (baglanti._musteriEkleme == 1)
            //{
            //    frmPaketSiparis frm = new frmPaketSiparis();
            //    baglanti._musteriEkleme = 0;
            //    this.Hide();
            //    frm.ShowDialog();
            //    this.Close();
            //}
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if (lvmusteri.SelectedItems.Count>0)
            {
                frmRezervasyon frm = new frmRezervasyon();
                baglanti._musteriEkleme = 1;
                this.Hide();
                frm.ShowDialog();
            }
            else MessageBox.Show("Выберите для резервации!");
            //else if (baglanti._musteriEkleme == 1)
            //{
            //    frmPaketSiparis frm = new frmPaketSiparis();
            //    baglanti._musteriEkleme = 0;
            //    this.Hide();
            //    frm.ShowDialog();
            //    this.Close();
            //}
        }
        private void txtadi_OnValueChanged(object sender, EventArgs e)
        {
            cMusteriler cm = new cMusteriler();
            cm.musteriAdinagoreArama(lvmusteri, txtadi.Text);
        }
        private void txtsoyadi_OnValueChanged(object sender, EventArgs e)
        {
            cMusteriler cm = new cMusteriler();
            cm.musteriSoyadinagoreArama(lvmusteri, txtsoyadi.Text);
        }
        private void telefon_OnValueChanged(object sender, EventArgs e)
        {
            cMusteriler cm = new cMusteriler();
            cm.musteriTelefonagoreArama(lvmusteri, telefon.Text);
        }
        private void txtadres_OnValueChanged(object sender, EventArgs e)
        {
            cMusteriler cm = new cMusteriler();
            cm.musteriAdresegoreArama(lvmusteri, txtadres.Text);
        }
       

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            bool resul = false;
            if (lvmusteri.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lvmusteri.SelectedItems.Count; i++)
                {
                    if (lvMusteriler.Items.Count == 0)
                    {
                        resul = true;
                    }
                    else if (lvmusteri.SelectedItems[i].SubItems[0].Text == lvMusteriler.Items[i].SubItems[0].Text)
                    {
                        resul = false;
                    }
                    else resul = true;
                }
                if (resul)
                {
                    baglanti._musteriId = Convert.ToInt32(lvmusteri.SelectedItems[0].SubItems[0].Text);
                    baglanti._ServisTurNo = 2;
                    baglanti._kontrolZakaz = 1;
                    frmZakaz frm = new frmZakaz();
                    this.Hide();
                    frm.ShowDialog();
                }
                else MessageBox.Show("Этот клиент не закрыл свой прежний счёт! Пожалуйста закройте прежний счёт для заказа.");
                
            }
        }
    }
}
