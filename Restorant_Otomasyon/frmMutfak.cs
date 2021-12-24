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
    public partial class frmMutfak : Form
    {
        public frmMutfak()
        {
            InitializeComponent();
        }

        private void frmMutfak_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anasayfa glav = new Anasayfa();
            glav.Show();
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (lvGidaListesi.SelectedItems.Count > 0)
            {
                if (txtGidaAd.Text != "" & txtGidafiyat.Text != "" & txtGidaAd.Text != "Название блюдо" & txtGidafiyat.Text != "Введите цену")
                {
                    if (cbKategori.Text.Trim() != "" & (cbKategori.SelectedIndex+1) != 0)
                    {
                        cUrunler cuc = new cUrunler();
                        cuc.Urunid = Convert.ToInt32(tGidaID.Text);
                        cuc.Kategoriid = Convert.ToInt32(txtKategoriid.Text);
                        cuc.Urunadi = txtGidaAd.Text;
                        bool durum = IsNumeric(txtGidafiyat.Text);
                        if (!durum)
                        {
                            MessageBox.Show("Цену вы должны ввести только цифрами!");
                        }
                        else
                        {
                            cuc.Fiyat = Convert.ToDouble(txtGidafiyat.Text);
                            cuc.Aciklama = "Изменен";
                            int sonuc = cuc.urunGuncelle(cuc);
                            if (sonuc!=0)
                            {
                                MessageBox.Show("Успешно изменен!");
                                cuc.urunlerListeleme(lvGidaListesi);
                                Temizle();
                            }
                            else MessageBox.Show("Не удалось изменить!");
                        }
                    }
                    else MessageBox.Show("Выберите категорию для начала!");
                }
                else MessageBox.Show("Не оставляйте пустыми, пожалуйста для начала заполните!");
            }
            else MessageBox.Show("Выберите еду для начала!");
        }
        private void txtKatID_TextChanged(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            txtGidaAd.Text = "Название блюдо";
            txtGidafiyat.Text = "Введите цену";
            txtKatAd.Text = "Название категории";
            txtAciklam.Text = "Рассуждение категории";
            txtAramaGida.Text = "Поиск...";
            tKatID.Text = string.Empty;
            tGidaID.Text = string.Empty;
        }
        private void frmMutfak_Load(object sender, EventArgs e)
        {
            btnKatEkle.Visible = true;
            btnYeni.Visible = false;
            cUrunler AnaUrun = new cUrunler();
            cUrunCesitleri Anakategori = new cUrunCesitleri();
            Anakategori.urunlerCesitleriniGetir(cbArama);
            Anakategori.urunlerCesitleriniGetir(cbKategori);
            Anakategori.urunlerCesitleriniGetir(lvKategoriler);
            AnaUrun.urunlerListeleme(lvGidaListesi);
            cbKategori.Items.Insert(0, "Все категории");
            cbArama.Items.Insert(0, "Все категории");
            cbArama.SelectedItem = 0;
        }
        private void txtAciklama_Leave(object sender, EventArgs e)
        {
            if (txtAramaGida.Text == "")
            {
                txtAramaGida.Text = "Рассуждение категории";
            }
        }
        private void txtAciklama_Enter(object sender, EventArgs e)
        {
            if (txtAramaGida.Text == "Рассуждение категории")
            {
                txtAramaGida.Text = "";
            }
        }
        private void txtGidaAd_Enter(object sender, EventArgs e)
        {
            if (txtGidaAd.Text == "Название блюдо")
            {
                txtGidaAd.Text = "";
            }
        }
        private void txtGidaAd_Leave(object sender, EventArgs e)
        {
            if(txtGidaAd.Text=="")
            {
                txtGidaAd.Text = "Название блюдо";
            }
        }
        private void txtGidafiyat_Enter(object sender, EventArgs e)
        {
            if (txtGidafiyat.Text == "Введите цену")
            {
                txtGidafiyat.Text = "";
            }
        }
        private void txtGidafiyat_Leave(object sender, EventArgs e)
        {
            if(txtGidafiyat.Text=="")
            {
                txtGidafiyat.Text = "Введите цену";
            }
        }
        private void txtGidaAd_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void txtAciklam_Enter(object sender, EventArgs e)
        {
            if (txtAciklam.Text == "Рассуждение категории")
            {
                txtAciklam.Text = "";
            }
        }
        private void txtAciklam_Leave(object sender, EventArgs e)
        {
            if (txtAciklam.Text == "")
            {
                txtAciklam.Text = "Рассуждение категории";
            }
        }
        private void txtKatAd_Enter(object sender, EventArgs e)
        {
            if(txtKatAd.Text=="Название категории")
            {
                txtKatAd.Text = "";
            }
        }
        private void txtKatAd_Leave(object sender, EventArgs e)
        {
            if (txtKatAd.Text == "")
            {
                txtKatAd.Text = "Название категории";
            }
        }
        private void txtAramaGida_Leave(object sender, EventArgs e)
        {
            if(txtAramaGida.Text=="")
            {
                txtAramaGida.Text = "Поиск...";
            }
        }
        private void txtAramaGida_Enter(object sender, EventArgs e)
        {
            if (txtAramaGida.Text == "Поиск...")
            {
                txtAramaGida.Text = "";
            }
        }
        static bool IsNumeric(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtGidaAd.Text != "" & txtGidafiyat.Text != "" & txtGidaAd.Text != "Название блюдо" & txtGidafiyat.Text != "Введите цену")
            {
                if (cbKategori.Text.Trim() != "" & cbKategori.SelectedIndex!=0)
                {
                    cUrunler cu = new cUrunler();
                    cu.Urunadi = txtGidaAd.Text.Trim();
                    cu.Aciklama = "Добавлен успешно";
                    bool durum = IsNumeric(txtGidafiyat.Text);
                   if (!durum)
                   {
                       MessageBox.Show("Цену вы должны ввести только цифрами!");
                   }
                    else
                    {
                        cu.Fiyat = Convert.ToDouble(txtGidafiyat.Text);
                        cu.Kategoriid = Convert.ToInt32(txtKategoriid.Text);
                        bool sonuc = cu.urunEkle(cu);
                        if (sonuc)
                        {
                            MessageBox.Show("Успешно добавлен!");
                            cu.urunlerListeleme(lvGidaListesi);
                            Temizle();
                        }
                        else MessageBox.Show("Не удалось добавить!");
                    }
                }
                else MessageBox.Show("Выберите категорию для начала!");
            }
            else MessageBox.Show("Не оставляйте пустыми, пожалуйста для начала заполните!");
        }
        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            if (txtKatAd.Text != "" & txtAciklam.Text != "" & txtKatAd.Text != "Название категории" & txtAciklama.Text != "Рассуждение категории")
            {
                cUrunCesitleri cu = new cUrunCesitleri();
                cu.Kategoriadi = txtKatAd.Text.Trim();
                cu.Aciklama = txtAciklam.Text.Trim();
                bool sonuc = cu.urunCesitEkle(cu);
                if (sonuc)
                {
                    MessageBox.Show("Успешно добавлен!");
                    cu.urunlerCesitleriniGetir(cbKategori);
                    cu.urunlerCesitleriniGetir(lvKategoriler);
                    cu.urunlerCesitleriniGetir(cbArama);
                    Temizle();
                }
                else MessageBox.Show("Не удалось добавить!");
            }
            else MessageBox.Show("Не оставляйте пустыми, пожалуйста для начала заполните!");
        }
        private void btnKatSil_Click(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Вы хотите удалить?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cUrunCesitleri c = new cUrunCesitleri();
                    cUrunler urun = new cUrunler();
                    bool result = c.urunlerCesitSil(Convert.ToInt32(tKatID.Text));
                    if (result)
                    {
                        MessageBox.Show("Успешно удален!");
                        Temizle();
                        c.urunlerCesitleriniGetir(cbKategori);
                        c.urunlerCesitleriniGetir(cbArama);
                        c.urunlerCesitleriniGetir(lvKategoriler);
                        urun.urunlerListeleme(lvGidaListesi);
                    }
                    else MessageBox.Show("Не удалось удалить!");
                }
            }
            else MessageBox.Show("Выберите для удаления!");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvGidaListesi.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Вы хотите удалить?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cUrunler c = new cUrunler();
                    c.Urunid = Convert.ToInt32(tGidaID.Text);
                    bool result = c.urunSil(c);
                    if (result)
                    {
                        MessageBox.Show("Успешно удален!");
                        Temizle();
                        c.urunlerListeleme(lvGidaListesi);
                    }
                    else MessageBox.Show("Не удалось удалить!");
                }
            }
            else MessageBox.Show("Выберите для удаления!");
        }
        private void lvKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cUrunCesitleri c = new cUrunCesitleri();
            if (lvKategoriler.SelectedItems.Count > 0)
            {
                btnKatEkle.Visible = false;
                btnYeni.Visible = true;
                tKatID.Text = lvKategoriler.SelectedItems[0].SubItems[0].Text;
                txtKatAd.Text = lvKategoriler.SelectedItems[0].SubItems[1].Text;
                txtAciklam.Text = lvKategoriler.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                Temizle();
            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            lvKategoriler.SelectedItems.Clear();
            Temizle();
            btnKatEkle.Visible = true;
            btnYeni.Visible = false;
        }
        int TurNo = 0;
        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s=cbKategori.SelectedItem.ToString();
            cUrunCesitleri kat = new cUrunCesitleri();
            txtKategoriid.Text = Convert.ToString(kat.KatIdGetir(s));
            
        }
        private void btnKatDegistir_Click(object sender, EventArgs e)
        {
            if (lvKategoriler.SelectedItems.Count > 0)
            {
                if (txtKatAd.Text != "" & txtAciklam.Text != "" & txtAciklam.Text != "Рассуждение категории" & txtKatAd.Text != "Название категории")
                {
                    cUrunCesitleri cuc = new cUrunCesitleri();
                    cuc.Urunturno = Convert.ToInt32(tKatID.Text);
                    cuc.Kategoriadi = txtKatAd.Text;
                    cuc.Aciklama = txtAciklam.Text;
                    int sonuc = cuc.urunlerCesitGuncelle(cuc);
                    if (sonuc!=0)
                    {
                        MessageBox.Show("Успешно изменен!");
                        cuc.urunlerCesitleriniGetir(lvKategoriler);
                        cuc.urunlerCesitleriniGetir(cbKategori);
                        cuc.urunlerCesitleriniGetir(cbArama);
                        Temizle();
                    }
                    else MessageBox.Show("Не удалось изменить!");
                }
                else MessageBox.Show("Не оставляйте пустыми, пожалуйста для начала заполните!");
            }
            else MessageBox.Show("Выберите категорие для начала!");
        }

        private void lvGidaListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvGidaListesi.SelectedItems.Count>0)
            {
                txtGidaAd.Text = lvGidaListesi.SelectedItems[0].SubItems[3].Text;
                txtGidafiyat.Text = lvGidaListesi.SelectedItems[0].SubItems[4].Text;
                tGidaID.Text=lvGidaListesi.SelectedItems[0].SubItems[0].Text;
                int index = cbKategori.FindString(lvGidaListesi.SelectedItems[0].SubItems[2].Text);
                cbKategori.SelectedIndex = index;
            }
        }

        private void cbArama_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
            cUrunler u = new cUrunler();
            if (cbArama.SelectedItem.ToString() == "Все категории" || cbArama.SelectedItem.ToString() == "")
            {
                u.urunlerListeleme(lvGidaListesi);
            }
            else
            {
                // tGidaID.Text = lvGidaListesi.SelectedItems[0].SubItems[0].Text;
                cUrunCesitleri cesit = (cUrunCesitleri)cbArama.SelectedItem;
                TurNo = cesit.Urunturno;
                u.urunlerKatgoreListele(lvGidaListesi, TurNo);
            }
        }

        private void txtAramaGida_OnValueChanged(object sender, EventArgs e)
        {
            cUrunler u = new cUrunler();
            u.urunlerArama(lvGidaListesi, txtAramaGida.Text);
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
            Anasayfa glav = new Anasayfa();
            glav.ShowDialog();
        }
    }
}
