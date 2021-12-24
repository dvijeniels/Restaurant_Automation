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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa glav = new Anasayfa();
            glav.ShowDialog();
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            cPersonelGorev cpg = new cPersonelGorev();
            cMasalar cmasa = new cMasalar();
            lblMasaSayisi.Text = Convert.ToString(cmasa.MasaCount());
            cmasa.masaKapasitesiveDurumGetirAyar(cbMasa);
            string gorev = cpg.PersonelGorevTanim(baglanti._gorevid);
            if (gorev == "Администратор"||gorev == "Директор")
            {
                cpg.PersonelGorevGetir(cbPerconel);
                cpg.PersonelGorevGetir(cbGorevi);
                cp.personelBilgileriniGetir(lvPersoneller);
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                groupBox5.Visible = true;
                lblbilgi.Text = "Директора или\nАдминистраторы могут\nвыполнить другие действия\nЗашедший:" + cp.personelSadece(baglanti._personelid) + "\nВаша должность:" + cp.personelDolzhnost(baglanti._personelid);
            }
            else
            {
                this.Size = new Size(670, 400);
                groupBox4.Location =new Point (15, 50);
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox4.Visible = true;
                groupBox3.Visible = false;
                groupBox5.Visible = false;
                lblbilgi.Text = "Директора или\nАдминистраторы могут\nвыполнить другие действия\nЗашедший:" + cp.personelSadece(baglanti._personelid) + "\nВаша должность:" + cp.personelDolzhnost(baglanti._personelid);
                lblbilgi.Location = new Point(300, 50);
            }
        }
        private void btndegistir_Click(object sender, EventArgs e)
        {
            if (txtdolzh.Text != "" & txtdolzh.Text != "Введите должность")
            {
                cPersonelGorev c = new cPersonelGorev();
                //c.Personelgorevid = Convert.ToInt32(txtPersonelid.Text);
                c.Tanim = txtdolzh.Text.Trim();
                bool sonuc = c.personelGorevEkle(c);
                if (sonuc)
                {
                    MessageBox.Show("Успешно добавлен!");
                    c.PersonelGorevGetir(cbPerconel);
                    c.PersonelGorevGetir(cbGorevi);
                    txtdolzh.Text = "Введите должность"; cbGorevi.Text = "";
                }
                else MessageBox.Show("Не удалось добавить!");
            }
            else MessageBox.Show("Не оставляйте пустыми, пожалуйста для начала заполните!");
        }
        private void cbGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev c = (cPersonelGorev)cbGorevi.SelectedItem;
            txtGorevID.Text = Convert.ToString(c.Personelgorevid);
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            cPersoneller cp = new cPersoneller();
            MessageBox.Show("Как поживаете " + cp.personelSadece(baglanti._personelid)+"?");
        }
        private void cbPerconel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersonelGorev c = (cPersonelGorev)cbPerconel.SelectedItem;
            txtPersonelid.Text = Convert.ToString(c.Personelgorevid);
            string gorev = c.PersonelGorevTanim(Convert.ToInt32(txtPersonelid.Text));
            txtdolzh.Text = gorev;

        }
        private void btnDegistirAdmin_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (txtAd.Text != "" & txtSoyad.Text != "" & txtAd.Text != "Имя" & txtSoyad.Text != "Фамилия" & txtSifre.Text != "" & txtSifreTekrar.Text != "" & txtSifre.Text != "Пароль" & txtSifreTekrar.Text != "Проверка пароля")
                {
                    if (txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim())
                    {
                        cPersoneller c = new cPersoneller();
                        c.Personeladi = txtAd.Text.Trim();
                        c.Personelsoyadi = txtSoyad.Text.Trim();
                        c.Personelsifre = txtSifre.Text.Trim();
                        c.Gorevid = Convert.ToInt32(txtGorevID.Text);
                        bool sonuc = c.personelGuncelle(c,Convert.ToInt32(txtpersID.Text));
                        if (sonuc)
                        {
                            MessageBox.Show("Успешно изменен!");
                            c.personelBilgileriniGetir(lvPersoneller);
                            txtAd.Text = "Имя"; txtSoyad.Text = "Фамилия"; txtSifre.Text = "Пароль"; txtSifreTekrar.Text = "Проверка пароля";
                        }
                        else MessageBox.Show("Не удалось изменить!");
                    }
                    else MessageBox.Show("Пароли не совпадает!");
                }
                else MessageBox.Show("Не оставляйте пустыми, пожалуйста для начала заполните!");
            }
            else MessageBox.Show("Выберите персонала для начала!");
        }
        private void txtAd_Enter(object sender, EventArgs e)
        {
            if (txtAd.Text=="Имя")
            {
                txtAd.Text = string.Empty;
            }
        }
        private void txtAd_Leave(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                txtAd.Text = "Имя";
            }
        }
        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "")
            {
                txtSoyad.Text = "Фамилия";
            }
        }
        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "Фамилия")
            {
                txtSoyad.Text = string.Empty;
            }
        }
        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Пароль";
            }
        }
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Пароль")
            {
                txtSifre.Text = string.Empty;
            }
        }
        private void txtSifreTekrar_Leave(object sender, EventArgs e)
        {
            if (txtSifreTekrar.Text == "")
            {
                txtSifreTekrar.Text = "Проверка пароля";
            }
        }
        private void txtSifreTekrar_Enter(object sender, EventArgs e)
        {
            if (txtSifreTekrar.Text == "Проверка пароля")
            {
                txtSifreTekrar.Text = string.Empty;
            }
        }
        private void textbox44_Enter(object sender, EventArgs e)
        {
            if (textbox44.Text == "Пароль")
            {
                textbox44.Text = string.Empty;
            }
        }
        private void textbox44_Leave(object sender, EventArgs e)
        {
            if (textbox44.Text == "")
            {
                textbox44.Text = "Пароль";
            }
        }
        private void textboxx22_Enter(object sender, EventArgs e)
        {
            if (textboxx22.Text == "Проверка пароля")
            {
                textboxx22.Text = string.Empty;
            }
        }
        private void textboxx22_Leave(object sender, EventArgs e)
        {
            if (textboxx22.Text == "")
            {
                textboxx22.Text = "Проверка пароля";
            }
        }
        private void lvPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller c = new cPersoneller();
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                txtpersID.Text = lvPersoneller.SelectedItems[0].SubItems[0].Text;
                txtGorevID.Text = lvPersoneller.SelectedItems[0].SubItems[1].Text;
                txtAd.Text = lvPersoneller.SelectedItems[0].SubItems[3].Text;
                txtSoyad.Text = lvPersoneller.SelectedItems[0].SubItems[4].Text;
                cbGorevi.SelectedIndex = Convert.ToInt32(lvPersoneller.SelectedItems[0].Text);
                txtSifre.isPassword = true;
                txtSifreTekrar.isPassword = true;
                txtSifre.Text = c.personelPasswoerGetir(Convert.ToInt32(txtpersID.Text));
                txtSifreTekrar.Text = c.personelPasswoerGetir(Convert.ToInt32(txtpersID.Text));
            }
            else
            {
                txtSifre.Text = "Пароль";
                txtSifreTekrar.Text = "Проверка пароля";
                txtSifre.isPassword = false;
                txtSifreTekrar.isPassword = false;
                txtAd.Text = "Имя";
                txtSoyad.Text = "Фамилия";
                cbGorevi.Text = "";
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersoneller.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Вы хотите удалить?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersoneller c = new cPersoneller();
                    bool result = c.personelSil(Convert.ToInt32(txtpersID.Text));
                    if (result)
                    {
                        MessageBox.Show("Успешно удален!");
                        txtAd.Text = "Имя"; txtSoyad.Text = "Фамилия"; txtSifre.Text = "Пароль"; txtSifreTekrar.Text = "Проверка пароля";
                        c.personelBilgileriniGetir(lvPersoneller);
                    }
                    else MessageBox.Show("Не удалось удалить!");
                }
            }
            else MessageBox.Show("Выберите для удаления!");
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" & txtSoyad.Text != "" & txtAd.Text != "Имя" & txtSoyad.Text != "Фамилия" & txtSifre.Text != "" & txtSifreTekrar.Text != "" & txtSifre.Text != "Пароль" & txtSifreTekrar.Text != "Проверка пароля" & txtGorevID.Text.Trim()!="") 
            {
                if (txtSifre.Text.Length > 5)
                {
                    if (txtSifre.Text.Trim() == txtSifreTekrar.Text.Trim())
                    {
                        cPersoneller c = new cPersoneller();
                        c.Personeladi = txtAd.Text.Trim();
                        c.Personelsoyadi = txtSoyad.Text.Trim();
                        c.Personelsifre = txtSifre.Text.Trim();
                        c.Gorevid = Convert.ToInt32(txtGorevID.Text);
                        bool sonuc = c.personelEkle(c);
                        if (sonuc)
                        {
                            MessageBox.Show("Успешно добавлен!");
                            c.personelBilgileriniGetir(lvPersoneller);
                            txtAd.Text = "Имя"; txtSoyad.Text = "Фамилия"; txtSifre.Text = "Пароль"; txtSifreTekrar.Text = "Проверка пароля";
                        }
                        else MessageBox.Show("Не удалось добавить!");
                    }
                    else MessageBox.Show("Пароли не совпадает!");
                }
                else MessageBox.Show("Пароль не должен состоять меньше из 6!");
            }
            else MessageBox.Show("Не оставляйте пустыми, пожалуйста для начала заполните!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textbox44.Text.Trim() != "" & textboxx22.Text.Trim() != "" & textbox44.Text.Trim() != "Пароль" & textboxx22.Text.Trim() != "Проверка пароля")
            {
                if (textbox44.Text.Length > 5)
                {
                    if (textbox44.Text == textboxx22.Text)
                    {
                        if (baglanti._personelid.ToString() != "")
                        {
                            cPersoneller c = new cPersoneller();
                            bool sonuc = c.personelSifreDegidtir(Convert.ToInt32(baglanti._personelid),textbox44.Text);
                            if (sonuc)
                            {
                                MessageBox.Show("Пароль успешно изменен!");
                                textbox44.Text = "Пароль";
                                textboxx22.Text = "Проверка пароля";
                            }
                        }
                        else MessageBox.Show("Выберите персонала!");
                    }
                    else MessageBox.Show("Пароли не совпадает!");
                }
                else MessageBox.Show("Пароль не должен состоять меньше из 6!");
            }
            else MessageBox.Show("Не оставляйте пустыми, пожалуйста для начала заполните!");
        }
        private void txtdolzh_Enter(object sender, EventArgs e)
        {
            if (txtdolzh.Text == "Введите должность")
            {
                txtdolzh.Text = "";
            }
        }
        private void txtdolzh_Leave(object sender, EventArgs e)
        {
            if (txtdolzh.Text == "")
            {
                txtdolzh.Text = "Введите должность";
            }
        }

        private void btndolzhostsil_Click(object sender, EventArgs e)
        {
            if (txtdolzh.Text != "" & txtdolzh.Text != "Введите должность")
            {
                if (MessageBox.Show("Вы хотите удалить?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cPersonelGorev c = new cPersonelGorev();
                    c.PersonelGorevSil(cbPerconel,Convert.ToInt32(txtPersonelid.Text));
                    MessageBox.Show("Успешно удален!");
                    txtdolzh.Text = "Введите должность"; cbGorevi.Text = "";
                    c.PersonelGorevGetir(cbPerconel);
                    c.PersonelGorevGetir(cbGorevi);
                }
            }
            else MessageBox.Show("Выберите для начала!");
        }
        static bool IsNumeric(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        private void btnmasaekle_Click(object sender, EventArgs e)
        {
            cMasalar kapa = new cMasalar();
            if (txtKapasite.Text != "")
            {
                bool durum = IsNumeric(txtKapasite.Text);
                if (!durum)
                {
                    MessageBox.Show("Вместимость вы должны ввести только цифрами!");
                }
                else
                {
                    kapa.setChangeTableKapasite(txtMasID.Text, Convert.ToInt32(txtKapasite.Text));
                    MessageBox.Show("Стол №" + txtMasID.Text + "  Вместимость обновлено!");
                    cMasalar cmasa = new cMasalar();
                    cmasa.masaKapasitesiveDurumGetirAyar(cbMasa);
                }
            }
            else MessageBox.Show("Для начало введите число вместимости");
        }

        private void cbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cMasalar kapasitesi = (cMasalar)cbMasa.SelectedItem;
            int kapas = kapasitesi.Kapasite;
            txtMasID.Text = Convert.ToString(kapasitesi.Idmasa);
        }

        private void txtKapasite_Enter(object sender, EventArgs e)
        {
            if(txtKapasite.Text=="Введите число вместимости")
            {
                txtKapasite.Text = "";
            }
        }

        private void txtKapasite_Leave(object sender, EventArgs e)
        {
            if (txtKapasite.Text == "")
            {
                txtKapasite.Text = "Введите число вместимости";
            }
        }

        private void masaEkle_Click(object sender, EventArgs e)
        {
            cMasalar cmasa = new cMasalar();
            if (MessageBox.Show("Хотите добавить стол?", "добавление!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lblMasaSayisi.Text == "72")
                {
                    MessageBox.Show("Вы достигли до Максимумa. Больше никак нельзя!", "Добавление не Возможно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmasa.masaEkle(Convert.ToInt32(lblMasaSayisi.Text));
                }
            }
            lblMasaSayisi.Text = Convert.ToString(cmasa.MasaCount());
            cmasa.masaKapasitesiveDurumGetirAyar(cbMasa);
        }

        private void masaSil_Click(object sender, EventArgs e)
        {
            cMasalar cmasa = new cMasalar();
            if (MessageBox.Show("Хотите убрать стол?", "Убрать!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lblMasaSayisi.Text == "1")
                {
                    MessageBox.Show("Вы достигли до Минимумa. Больше никак нельзя!", "Убрать не Возможно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmasa.masaSil(Convert.ToInt32(lblMasaSayisi.Text));
                }
            }
            lblMasaSayisi.Text = Convert.ToString(cmasa.MasaCount());
            cmasa.masaKapasitesiveDurumGetirAyar(cbMasa);
        }

    }
}
