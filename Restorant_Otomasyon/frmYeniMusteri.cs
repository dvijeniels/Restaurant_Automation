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
    public partial class frmYeniMusteri : Form
    {
        public frmYeniMusteri()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMusteri sistema = new frmMusteri();
            baglanti._kontrol = 0;
            sistema.ShowDialog();
        }
        private void btnyeniekle_Click(object sender, EventArgs e)
        {
            if (txttelefon.Text.Length>12)
            {
                if(txtadi.Text=="Имя"||txtsoyad.Text=="Фамилия")
                {
                    MessageBox.Show("Пожалуйста заполните данные!");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    c.Adi = txtadi.Text;
                    c.Soyadi = txtsoyad.Text;
                    c.Telefon = txttelefon.Text;
                    c.Mail = txtmail.Text;
                    c.Adres = txtadres.Text;
                    txtmusteriid.Text=c.musteriEkle(c).ToString();
                    if(txtmusteriid.Text!="")
                    {
                        MessageBox.Show("Клиент добавлен!");
                    }
                    else MessageBox.Show("Клиент не добавлен!");
                }
            }
            else
            {
                MessageBox.Show("Ваш номер должен состоять минимум из 12 цифр. Пожалуйста введите правильно!");
            }
        }
        private void frmYeniMusteri_Load(object sender, EventArgs e)
        {
            txttelefon.MaxLength = 13;
            if (baglanti._kontrol == 2)
            {
                btnguncelle.Visible = true;
                btnyeniekle.Visible = false;

                if (baglanti._musteriId > 0)
                {
                    cMusteriler cc = new cMusteriler();
                    cc.musteriGetirFromSecilen(Convert.ToInt32(baglanti._musteriId), txtadi, txtsoyad, txttelefon, txtmail, txtadres);
                }
            }
            else
            {
                btnyeniekle.Visible = true;
                btnsec.Visible = false;
                btnguncelle.Visible = false;
            }
        }
        private void txttelefon_Enter(object sender, EventArgs e)
        {
            if (txttelefon.Text == "Телефон")
            {
                txttelefon.Text = "+996";
            }
        }
        private void txttelefon_Leave(object sender, EventArgs e)
        {
            if (txttelefon.Text == "+996"||txttelefon.Text == "")
            {
                txttelefon.Text = "Телефон";
            }
        }
        private void txtadi_Enter(object sender, EventArgs e)
        {
            if(txtadi.Text=="Имя")
            {
                txtadi.Text = "";
            }
        }
        private void txtadi_Leave(object sender, EventArgs e)
        {
            if (txtadi.Text == "")
            {
                txtadi.Text = "Имя";
            }
        }
        private void txtsoyad_Enter(object sender, EventArgs e)
        {
            if (txtsoyad.Text == "Фамилия")
            {
                txtsoyad.Text = "";
            }
        }
        private void txtsoyad_Leave(object sender, EventArgs e)
        {
            if (txtsoyad.Text == "")
            {
                txtsoyad.Text = "Фамилия";
            }
        }
        private void txtmail_Leave(object sender, EventArgs e)
        {
            if (txtmail.Text == "")
            {
                txtmail.Text = "Почта";
            }
       }
        private void txtmail_Enter(object sender, EventArgs e)
        {
            if (txtmail.Text == "Почта")
            {
                txtmail.Text = "";
            }
        }
        private void txtadres_Enter(object sender, EventArgs e)
        {
            if (txtadres.Text == "Адрес")
            {
                txtadres.Text = "";
            }
        }
        private void txtadres_Leave(object sender, EventArgs e)
        {
            if (txtadres.Text == "")
            {
                txtadres.Text = "Адрес";
            }
        }
        private void txttelefon_TextChanged(object sender, EventArgs e)
        {
            if (txttelefon.Text.Length > 12)
            {
                pictureBox1.Visible = true;
            }
            else pictureBox1.Visible = false;
        }
        private void btnsec_Click(object sender, EventArgs e)
        {
            //if(baglanti._musteriEkleme==0)
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
            frmZakaz frm = new frmZakaz();
            this.Hide();
            frm.ShowDialog();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txttelefon.Text.Length > 12)
            {
                if (txtadi.Text == "Имя" || txtsoyad.Text == "Фамилия")
                {
                    MessageBox.Show("Пожалуйста заполните данные!");
                }
                else
                {
                    cMusteriler c = new cMusteriler();
                    c.Adi = txtadi.Text;
                    c.Soyadi = txtsoyad.Text;
                    c.Telefon = txttelefon.Text;
                    c.Mail = txtmail.Text;
                    c.Adres = txtadres.Text;
                    c.Musteriid =Convert.ToInt32(baglanti._musteriId);
                    bool sonuc=c.musteriGuncelle(c);
                    if(sonuc)
                    {
                        if (baglanti._musteriId >0)
                        {
                            MessageBox.Show("Данные клиента изменены!");
                        }
                        else MessageBox.Show("Данные клиента к сожелению не изменены!");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Ваш номер должен состоять минимум из 12 цифр. Пожалуйста введите правильно!");
            }
        }
    }
}
