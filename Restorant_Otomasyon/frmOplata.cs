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
    public partial class frmOplata : Form
    {
        public frmOplata()
        {
            InitializeComponent();
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
            frmZakaz frm = new frmZakaz();
            frm.Show();
            this.Hide();
        }

        cSiparis cs = new cSiparis();
        double toplam,kdv,odenecek = 0;
        private void lblindirim_TextChanged(object sender, EventArgs e)
        {
            if (chindirim.Checked)
            {
                if (Convert.ToDecimal(lblindirim.Text) > 0)
                {
                    lblToplam.Text = lbfiyat.Text;
                    odenecek = Convert.ToDouble(lblToplam.Text) - Convert.ToDouble(lblindirim.Text);
                    lblToplam.Text = string.Format("{0:0.0}", odenecek);
                }
                kdv = Convert.ToDouble(lblToplam.Text) * 5 / 100;
                lblKDV.Text = string.Format("{0:0.0}", kdv);
                lblToplam.Text = string.Format("{0:0.0}", kdv + odenecek);
                if (Convert.ToDouble(lblindirim.Text) == 0)
                {
                    kdv = Convert.ToDouble(lbfiyat.Text) * 5 / 100;
                    lblKDV.Text = string.Format("{0:0.0}", kdv);
                    lblToplam.Text = string.Format("{0:0.0}", kdv + toplam);
                }
            }
            else if (chindir.Checked)
            {
                if (Convert.ToDouble(lblindirim.Text) > 0)
                {
                    lblToplam.Text = lbfiyat.Text;
                    odenecek = Math.Abs(Convert.ToDouble(lblToplam.Text) * (100 - Convert.ToDouble(lblindirim.Text)) / 100);
                    lblToplam.Text = string.Format("{0:0.0}", odenecek);
                }
                kdv = Convert.ToDouble(lblToplam.Text) * 5 / 100;
                lblKDV.Text = string.Format("{0:0.0}", kdv);
                lblToplam.Text = string.Format("{0:0.0}", kdv + odenecek);
                if (Convert.ToDouble(lblindirim.Text) == 0) {
                    kdv = Convert.ToDouble(lbfiyat.Text) * 5 / 100;
                    lblKDV.Text = string.Format("{0:0.0}", kdv);
                    lblToplam.Text = string.Format("{0:0.0}", kdv + toplam);
                }
            }
            
        }
        int odemeTurID = 0;
        private void frmOplata_Load(object sender, EventArgs e)
        {
            if (baglanti._ServisTurNo==1)
            {
                lbAdisiyonid.Text = baglanti._AdisyonID;
                tbindirim.TextChanged += new EventHandler(tbindirim_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lbAdisiyonid.Text));
                if (lvUrunler.Items.Count>0)
                {
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDouble(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lbfiyat.Text = string.Format("{0:0.0}", toplam);
                    kdv = Convert.ToDouble(lbfiyat.Text) * 5 / 100;
                    lblKDV.Text = string.Format("{0:0.0}",kdv);
                    lblToplam.Text = string.Format("{0:0.0}",kdv+toplam);
                }
                tbindirim.Clear();
            }
            else if (baglanti._ServisTurNo == 2)
            {
                lbAdisiyonid.Text = baglanti._AdisyonID; 
                cPaketler cp=new cPaketler();
                odemeTurID=cp.OdemeTurIdGetir(Convert.ToInt32(lbAdisiyonid.Text));
                tbindirim.TextChanged += new EventHandler(tbindirim_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lbAdisiyonid.Text));
                //if (odemeTurID==1)
                //{
                //    rdnakit.Checked = true;
                //}
                //else if (odemeTurID==2)
                //{
                //    rdkredi.Checked = true;
                //}
                //else if (odemeTurID == 3)
                //{
                //    rdticket.Checked = true;
                //}
                if (lvUrunler.Items.Count > 0)
                {

                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDouble(lvUrunler.Items[i].SubItems[3].Text);

                    }
                    lbfiyat.Text = string.Format("{0:0.0}", toplam);
                    kdv = Convert.ToDouble(lbfiyat.Text) * 5 / 100;
                    lblKDV.Text = string.Format("{0:0.0}", kdv);
                    lblToplam.Text = string.Format("{0:0.0}", kdv + toplam);
                }
                tbindirim.Clear();
            }
        }
        private void tbindirim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(lblindirim.Text) < Convert.ToDouble(lbfiyat.Text))
                {
                    try
                    {
                        lblindirim.Text = string.Format("{0:0.0}", Convert.ToDouble(tbindirim.Text));
                    }
                    catch (Exception)
                    {
                        lblindirim.Text = string.Format("{0:0.0}", 0);
                    }
                }
                else
                {
                    tbindirim.Text = "";
                    lblToplam.Text = string.Format("{0:0.0}", toplam + Convert.ToDouble(kdv));
                    MessageBox.Show("Скидка не может быть больше чем Суммы всего итога!"); 
                }
            }
            catch (Exception)
            {
                lblindirim.Text = string.Format("{0:0.0}", 0);
            }
        }
        private void tbindirim_Leave(object sender, EventArgs e)
        {
            if (tbindirim.Text == "")
            {
                tbindirim.Text = "Введите число скидки...";
            }
        }
        private void tbindirim_Enter(object sender, EventArgs e)
        {
            if (tbindirim.Text == "Введите число скидки...")
            {
                tbindirim.Text = "";
            }
        }
        private void chindirim_OnChange(object sender, EventArgs e)
        {
            if(chindirim.Checked)
            {
                tbindirim.Visible = true;
                groupBox2.Size = new Size(265, 134);
                chindir.Enabled = false;
            }
            else
            {
                tbindirim.Visible = false;
                groupBox2.Size = new Size(265, 90);
                tbindirim.Text = string.Empty;
                chindir.Enabled = true;
                if (Convert.ToDouble(lblindirim.Text) == 0) lblToplam.Text = string.Format("{0:0.0}", kdv + toplam);
            }
        }
        private void chindir_OnChange(object sender, EventArgs e)
        {
            if (chindir.Checked)
            {
                tbindirim.Visible = true;
                groupBox2.Size = new Size(265, 134);
                chindirim.Enabled = false;
            }
            else
            {
                tbindirim.Visible = false;
                chindirim.Enabled = true;
                groupBox2.Size = new Size(265, 90);
                tbindirim.Text = string.Empty;
                if (Convert.ToDouble(lblindirim.Text) == 0) lblToplam.Text = string.Format("{0:0.0}", kdv + toplam);
            }
        }
        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon(); int odemeturidd = 1;
        private void btnoplata_Click(object sender, EventArgs e)
        {
            if ((rdnakit.Checked || rdkredi.Checked || rdticket.Checked)==false)
            {
                MessageBox.Show("Выберите вид оплаты пожалуйста!");
            }
            else
            {
                if (rdnakit.Checked)
                {
                    odemeturidd = 1;
                }
                if (rdkredi.Checked)
                {
                    odemeturidd = 2;
                }
                if (rdticket.Checked)
                {
                    odemeturidd = 3;
                }
                if (baglanti._ServisTurNo == 1)
                {
                    int masaid = masalar.TableGetByNumber(baglanti._buttonName);
                    int musteriid = 0;
                    if (masalar.TableGetByState(masaid, 4))
                    {
                        musteriid = rezerve.getByClientIdFromRezervasyon(masaid);
                    }
                    else
                    {
                        musteriid = 1;
                    }
                    cOdeme odeme = new cOdeme();
                    //adisiyonid,odemeturno,musteriid,aratoplam,kdvtutari,indirim,toplamtutar,tarih
                    odeme.Adisyonid = Convert.ToInt32(lbAdisiyonid.Text);
                    odeme.Odemeid = odemeturidd;
                    odeme.Musteriid = musteriid;
                    odeme.Aratoplam = Convert.ToDouble(lbfiyat.Text);
                    odeme.Kdvtutari = Convert.ToDouble(lblKDV.Text);
                    odeme.Indirim = Convert.ToDouble(lblindirim.Text);
                    odeme.Geneltoplam = Convert.ToDouble(lblToplam.Text);
                    bool result = odeme.oplataZakaza(odeme);
                    if (result)
                    {
                        MessageBox.Show("Спасибо за оплату");
                        masalar.setChangeTableState(Convert.ToString(baglanti._buttonName), 1);
                        cRezervasyon c = new cRezervasyon();
                        c.rezervasyonClose(Convert.ToInt32(lbAdisiyonid.Text));
                        cAdisyon a = new cAdisyon();
                        a.additionClose(Convert.ToInt32(lbAdisiyonid.Text), 0);
                        this.Hide();
                        Glavn frm = new Glavn();
                        frm.ShowDialog();
                    }
                    else MessageBox.Show("При оплате возникла ошибка! Пожалуйста повторите попытку");
                }
                    //paketSiparis
                else if(baglanti._ServisTurNo == 2)
                {
                    cOdeme odeme = new cOdeme();
                    odeme.Adisyonid = Convert.ToInt32(lbAdisiyonid.Text);
                    odeme.Odemeid = odemeturidd;
                    odeme.Musteriid =1;
                    odeme.Aratoplam = Convert.ToDouble(lbfiyat.Text);
                    odeme.Kdvtutari = Convert.ToDouble(lblKDV.Text);
                    odeme.Indirim = Convert.ToDouble(lblindirim.Text);
                    odeme.Geneltoplam = Convert.ToDouble(lblToplam.Text);
                    bool result = odeme.oplataZakaza(odeme);
                    if (result)
                    {
                        cAdisyon a = new cAdisyon();
                        a.additionClose(Convert.ToInt32(lbAdisiyonid.Text),1);
                        cPaketler p = new cPaketler();
                        p.OrderServiceKapatma(Convert.ToInt32(lbAdisiyonid.Text));
                        MessageBox.Show("Спасибо за оплату");
                        this.Hide();
                        Glavn frm = new Glavn();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("При оплате возникла ошибка! Пожалуйста повторите попытку");
                }
            }
        }

        private void btnyazdir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 11, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Restorant Adilet", Baslik, sb, 270, 100, st);

            e.Graphics.DrawString("----------------------------", altBaslik, sb, 270, 120, st);
            e.Graphics.DrawString("Имя продукта                               Штук      Цена", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("----------------------------------------------------------", altBaslik, sb, 150, 280, st);
            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 450, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerik, sb, 520, 300 + i * 30, st);
            }
            e.Graphics.DrawString("----------------------------------------------------------", altBaslik, sb, 150, 300+30*lvUrunler.Items.Count, st);
            e.Graphics.DrawString("Скидка      :-----------------" +lblindirim.Text+" Cом",  altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count+1), st);
            e.Graphics.DrawString("Налог        :-----------------" +lblKDV.Text + " Cом", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 2), st);
            e.Graphics.DrawString("Цена         :-----------------" +lbfiyat.Text + " Cом", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 3), st);
            e.Graphics.DrawString("Итог всего :-----------------" +lblToplam.Text + " Cом", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 4), st);
        }

        private void tbhesap_Leave(object sender, EventArgs e)
        {
            if (tbhesap.Text == "")
            {
                tbhesap.Text = "Автокалькулятор";
            }
        }

        private void tbhesap_Enter(object sender, EventArgs e)
        {
            if (tbhesap.Text == "Автокалькулятор")
            {
                tbhesap.Text = "";
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            double sayi = Convert.ToDouble(tbhesap.Text);
            double lbsayi = Convert.ToDouble(lblToplam.Text);
            if (sayi < lbsayi)
            {
                MessageBox.Show("Деньги не должны быть меньше чем итог!");
            }
            else
            {
                txts4t.ForeColor = Color.White;
                txts4t.Text = Convert.ToString(sayi - lbsayi);
            }
        }
    }
}
