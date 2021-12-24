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
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        private void txtMusteriAd_Enter(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text == "Имя")
            {
                txtMusteriAd.Text = "";
            }
        }
        private void txtMusteriAd_Leave(object sender, EventArgs e)
        {
            if (txtMusteriAd.Text == "")
            {
                txtMusteriAd.Text = "Имя";
            }
        }
        private void txtMusteriSoyad_Enter(object sender, EventArgs e)
        {
            if (txtMusteriSoyad.Text == "Фамилия")
            {
                txtMusteriSoyad.Text = "";
            }
        }
        private void txtMusteriSoyad_Leave(object sender, EventArgs e)
        {
            if (txtMusteriSoyad.Text == "")
            {
                txtMusteriSoyad.Text = "Фамилия";
            }
        }
        private void txtTelefon_Enter(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "Номер")
            {
                txtTelefon.Text = "";
            }
        }
        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "")
            {
                txtTelefon.Text = "Номер";
            }
        }
        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Почта")
            {
                txtMail.Text = "";
            }
        }
        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Почта";
            }
        }
        private void rtxtaciklama_Enter(object sender, EventArgs e)
        {
            if (rtxtaciklama.Text == "Дополнительно")
            {
                rtxtaciklama.Text = "";
            }
        }
        private void rtxtaciklama_Leave(object sender, EventArgs e)
        {
            if (rtxtaciklama.Text == "")
            {
                rtxtaciklama.Text = "Дополнительно";
            }
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
            Anasayfa frm = new Anasayfa();
            frm.ShowDialog();
        }
        private void frmRezervasyon_Load(object sender, EventArgs e)
        {

                cMusteriler cm = new cMusteriler();
                cm.musteriGetir(lvMusteriler);
                cMasalar cmasa = new cMasalar();
                cmasa.masaKapasitesiveDurumGetir(cbMasa);
                dtTarih.MinDate = DateTime.Today;
                dtTarih.Format = DateTimePickerFormat.Time;
            
        }
        private void txtMusteriAd_OnValueChanged(object sender, EventArgs e)
        {
            
                cMusteriler cmusteri = new cMusteriler();
                cmusteri.musteriAdinagoreArama(lvMusteriler, txtMusteriAd.Text);
            
        }
        private void txtMusteriSoyad_OnValueChanged(object sender, EventArgs e)
        {
            cMusteriler cmusteri = new cMusteriler();
            cmusteri.musteriSoyadinagoreArama(lvMusteriler, txtMusteriSoyad.Text);
        }
        private void txtTelefon_OnValueChanged(object sender, EventArgs e)
        {
            cMusteriler cmusteri = new cMusteriler();
            cmusteri.musteriTelefonagoreArama(lvMusteriler, txtTelefon.Text);
        }
        private void txtMail_OnValueChanged(object sender, EventArgs e)
        {
            cMusteriler cmusteri = new cMusteriler();
            cmusteri.musteriMailegoreArama(lvMusteriler, txtMail.Text);
        }
        void Temizle()
        {
            txtTarih.Text = "Дата";
            txtMasa.Text = "Стол";
            txtKisiSayisi.Text = "Число людей";
            rtxtaciklama.Text = "Дополнительно";
        }
        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            cRezervasyon r = new cRezervasyon();
            if(lvMusteriler.SelectedItems.Count>0)
            {
                bool sonuc = r.rezervasyonAcikmiKontrol(Convert.ToInt32(lvMusteriler.Items[0].SubItems[0].Text));
                if(!sonuc)
                {
                    if (txtTarih.Text!="")
                    {
                        if (txtMasa.Text != "")
                        {
                            if (txtKisiSayisi.Text != "")
                            {
                                cMasalar m = new cMasalar();
                                if (m.TableGetByState(Convert.ToInt32(txtMasID.Text), 1))
                                {
                                    cAdisyon ca = new cAdisyon();
                                    ca.Tarih = Convert.ToDateTime(txtTarih.Text);
                                    ca.Servisturno = 1;
                                    ca.Masaid = Convert.ToInt32(txtMasID.Text);
                                    ca.Personelid = 1;
                                    r.Clientid = Convert.ToInt32(Convert.ToInt32(lvMusteriler.Items[0].SubItems[0].Text));
                                    r.Tableid = Convert.ToInt32(txtMasID.Text);
                                    r.Date = Convert.ToDateTime(txtTarih.Text);
                                    r.ClientCount = Convert.ToInt32(txtKisiSayisi.Text);
                                    r.Description = rtxtaciklama.Text;
                                    r.Additionid = ca.rezervasyonAdisyonAc(ca);
                                    sonuc = r.rezervasyonAc(r);
                                    m.setChangeTableState(txtMasID.Text, 3);
                                    if (sonuc)
                                    {
                                        MessageBox.Show("Успешно зарезервированo!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Temizle();
                                    }
                                    else MessageBox.Show("К сожалению мы не смогли зарезервировать", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else MessageBox.Show("К сожалению этот стол занят для резервации", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else MessageBox.Show("Для скольки человек?", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else MessageBox.Show("Выберите стол для резервации!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Выберите дату!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("На этого клиента уже зарезервировано!","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Выберите клиента для резервации!","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        private void dtTarih_MouseEnter(object sender, EventArgs e)
        {
            dtTarih.Width = 150;
        }
        private void dtTarih_Enter(object sender, EventArgs e)
        {
            dtTarih.Width = 150;
        }
        private void dtTarih_MouseLeave(object sender, EventArgs e)
        {
            dtTarih.Width = 19;
            
        }
        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text=dtTarih.Value.ToString();
        }
        private void cbKisiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKisiSayisi.Text = cbKisiSayisi.SelectedItem.ToString();
        }
        private void cbMasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMasa.Text = cbMasa.SelectedItem.ToString();
            cbKisiSayisi.Enabled = true;
            cMasalar kapasitesi = (cMasalar)cbMasa.SelectedItem;
            int kapas = kapasitesi.Kapasite;
            txtMasID.Text = Convert.ToString(kapasitesi.Idmasa);
            cbKisiSayisi.Items.Clear();
            for (int i = 0; i < kapas; i++)
            {
                cbKisiSayisi.Items.Add(i + 1);
            }
        }
        private void cbMasa_MouseEnter(object sender, EventArgs e)
        {
            cbMasa.Width = 305;
        }
        private void cbMasa_MouseLeave(object sender, EventArgs e)
        {
            cbMasa.Width = 19;
        }
        private void cbKisiSayisi_Leave(object sender, EventArgs e)
        {
        }
        private void cbKisiSayisi_Enter(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 37;
        }
        private void cbKisiSayisi_MouseLeave(object sender, EventArgs e)
        {
            cbKisiSayisi.Width = 19;
        }
        private void btnSiparisKontrol_Click(object sender, EventArgs e)
        {
            frmSiparisKontrol frm = new frmSiparisKontrol();
            this.Hide();
            frm.ShowDialog();
        }
        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            frmYeniMusteri frmyeni = new frmYeniMusteri();
            baglanti._musteriEkleme = 0;
            this.Hide();
            frmyeni.ShowDialog();
        }
        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if(lvMusteriler.SelectedItems.Count>0)
            {
                frmYeniMusteri frmguncelle = new frmYeniMusteri();
                baglanti._musteriEkleme = 0;
                baglanti._kontrol = 2;
                baglanti._musteriId = Convert.ToInt32(lvMusteriler.Items[0].SubItems[0].Text);
                this.Hide();
                frmguncelle.ShowDialog();
            }
            else MessageBox.Show("Выберите из списка для начало!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void lvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMusteriler.Refresh();

        }
    }
}
