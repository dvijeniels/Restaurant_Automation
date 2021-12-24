using System;
using System.Collections;
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
    public partial class frmZakaz : Form
    {
        public frmZakaz()
        {
            InitializeComponent();
        }
        int tableId, AdditionId;
        private void frmZakaz_Load(object sender, EventArgs e)
        {
            cUrunCesitleri ces = new cUrunCesitleri();
            ces.urunlerCesitleriniGetir(lvMenuButton);
            if (baglanti._ServisTurNo == 1)
            {
                btnZakaz.Visible = true;
                btnDostavka.Visible = false;
                lblmasa.Text = baglanti._buttonValue;
                cMasalar ms = new cMasalar();
                tableId = ms.TableGetByNumber(baglanti._buttonName);
                if (ms.TableGetByState(tableId, 2) == true || ms.TableGetByState(tableId, 4) == true)
                {
                    cAdisyon cad = new cAdisyon();
                    AdditionId = cad.getByAddition(tableId);
                    cSiparis orders = new cSiparis();
                    orders.getByOrder(lvSiparisler, AdditionId);
                }
            }
            else if(baglanti._ServisTurNo==2)
            {
                btnZakaz.Visible = false;
                btnDostavka.Visible = true;
                lblmasa.Text = "Заказ для доставки";
            }
            butonolustus();
            menubutton();
            //this.ActiveControl = bunifuMetroTextbox1;

        }
        void butonolustus()
        {
            int say = 0, sayi = 1;
            int i = 0, j = 0;
            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    Button myButton = new Button();
                    myButton.Name = "hesapmak" + sayi++;
                    myButton.Text = "" + (++say).ToString();
                    myButton.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    myButton.ForeColor = Color.Black;
                    myButton.BackColor = Color.Yellow;
                    myButton.Size = new System.Drawing.Size(70, 50);
                    myButton.Left = (37 * j) * 2;
                    myButton.Top = (27 * i) * 2;
                    myButton.Click += hesapmak_Click;
                    panel1.Controls.Add(myButton);

                    if (i == 3)
                    {
                        myButton.Text = "0";
                        myButton.Name = "hesapmak0";
                    }
                    if (i == 3 && j == 1)
                    {
                        myButton.Size = new System.Drawing.Size(0, 0);
                    }
                    if (i == 3 && j == 2)
                    {
                        myButton.Size = new System.Drawing.Size(146, 50);
                        myButton.Left = (18 * j) * 2;
                        myButton.Text = "C";
                        myButton.Name = "hesapmakC";
                    }
                }
            }
        }
        void menubutton()
        {
            cMasalar mas = new cMasalar();
            int sayi = 1;
            int i = 0, a = 0;
            for (i = 0; i <= mas.kategoriSayisi()-1; i++)
            {
                Button myButton = new Button();
                myButton.Name = lvMenuButton.Items[i].SubItems[0].Text;
                //myButton.Name = "menu" + sayi++;
                myButton.Text = lvMenuButton.Items[++a - 1].SubItems[1].Text;
                myButton.Font = new Font("Microsoft Sans Serif", 11);
                myButton.ForeColor = Color.White;
                myButton.BackColor = Color.FromArgb(59, 40, 94);
                myButton.FlatAppearance.BorderSize = 0;
                myButton.TabStop = false;
                myButton.FlatStyle = FlatStyle.Flat;
                myButton.Size = new System.Drawing.Size(234, 48);
                myButton.Top = (23 * i) * 2;
                myButton.Click += menu_Click;
                panel3.Controls.Add(myButton);
                //switch (myButton.Name)
                //{
                //    case "menu1":
                //        myButton.Text = "Первое блюдо";
                //        break;
                //    case "menu2":
                //        myButton.Text = "Второе блюдо";
                //        break;
                //    case "menu3":
                //        myButton.Text = "Фирменные блюда";
                //        break;
                //    case "menu4":
                //        myButton.Text = "Суши";
                //        break;
                //    case "menu5":
                //        myButton.Text = "Фастфуд";
                //        break;
                //    case "menu6":
                //        myButton.Text = "Пицца";
                //        break;
                //    case "menu7":
                //        myButton.Text = "Молочное";
                //        break;
                //    case "menu8":
                //        myButton.Text = "Салаты";
                //        break;
                //    case "menu9":
                //        myButton.Text = "Сладкие вкусняшки";
                //        break;
                //    case "menu10":
                //        myButton.Text = "Холодные напитки";
                //        break;
                //    case "menu11":
                //        myButton.Text = "Горячие напитки";
                //        break;
                //    case "menu12":
                //        myButton.Text = "Кальяны";
                //        break;
                //    case "menu13":
                //        myButton.Text = "Другие";
                //        break;
                //    default:
                //        break;
                //}
            }
        }
        cUrunCesitleri cu = new cUrunCesitleri();
        private void menu_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            int uzunluk = btn.Name.Length;
            string say = btn.Name;
            //Button bbb = lvMenuButton.Items[1].SubItems[0].Text;
            cu.getByProductTypes(lvmenu, say);
        }
        private void hesapmak_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            if (tbhesap.Text == "Введите число...")
            {
                tbhesap.Text = btn.Text;
            }
            else
            {
                tbhesap.Text += btn.Text;
            }
            if(btn.Name=="hesapmakC")
            {
                tbhesap.Text = "";
            }
        }
        private void btncikiss_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void tbhesap_Enter(object sender, EventArgs e)
        {
            if (tbhesap.Text == "Введите число...")
            {
                tbhesap.Text = "";
            }
        }
        private void tbhesap_Leave(object sender, EventArgs e)
        {
            if (tbhesap.Text == "")
            {
                tbhesap.Text = "Введите число...";
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            baglanti._ServisTurNo = 1;
            this.Hide();
            Glavn frm = new Glavn();
            frm.ShowDialog();
        }
        int sayac =0, sayac2 = 0;
        private void lvmenu_DoubleClick(object sender, EventArgs e)
        {
            if (tbhesap.Text == "Введите число...")
	    {
		 tbhesap.Text="1";
	    }
            else if (tbhesap.Text == "") tbhesap.Text = "1";
            if(lvmenu.Items.Count>0)
            {
                sayac = lvSiparisler.Items.Count;
                lvSiparisler.Items.Add(lvmenu.SelectedItems[0].Text);
                lvSiparisler.Items[sayac].SubItems.Add(tbhesap.Text);
                lvSiparisler.Items[sayac].SubItems.Add(lvmenu.SelectedItems[0].SubItems[2].Text);
                lvSiparisler.Items[sayac].SubItems.Add((Convert.ToDecimal(lvmenu.SelectedItems[0].SubItems[1].Text)*Convert.ToDecimal(tbhesap.Text)).ToString());
                lvSiparisler.Items[sayac].SubItems.Add("0");
                sayac2 = lvYeniEklenen.Items.Count;
                lvSiparisler.Items[sayac].SubItems.Add(sayac2.ToString());

                lvYeniEklenen.Items.Add(AdditionId.ToString());
                lvYeniEklenen.Items[sayac2].SubItems.Add(lvmenu.SelectedItems[0].SubItems[2].Text);
                lvYeniEklenen.Items[sayac2].SubItems.Add(tbhesap.Text);
                lvYeniEklenen.Items[sayac2].SubItems.Add(tableId.ToString());
                lvYeniEklenen.Items[sayac2].SubItems.Add(sayac2.ToString());
                sayac2++;
                tbhesap.Text = "";
            }
        }
        ArrayList silinen = new ArrayList();
        private void btnZakaz_Click(object sender, EventArgs e)
        {
            cMasalar masa = new cMasalar();
            cAdisyon cadNew = new cAdisyon();
            cSiparis saveOrder = new cSiparis();
            Glavn frm = new Glavn();
            bool sonuc = false;
            if (masa.TableGetByState(tableId, 1))
            {
                cadNew.Servisturno = 1;
                cadNew.Personelid = 1;
                cadNew.Masaid = tableId;
                cadNew.Tarih = DateTime.Now;
                sonuc = cadNew.setByAdditionNew(cadNew);
                masa.setChangeTableState(baglanti._buttonName, 2);
                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        saveOrder.Masaid = tableId;
                        saveOrder.Adisyonid = cadNew.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        saveOrder.Urunid = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                }
                this.Hide();
                frm.ShowDialog();
            }
            else if (masa.TableGetByState(tableId, 2) || masa.TableGetByState(tableId, 4))
            {
                if (lvYeniEklenen.Items.Count > 0)
                {
                    for (int i = 0; i < lvYeniEklenen.Items.Count; i++)
                    {
                        saveOrder.Masaid = tableId;
                        saveOrder.Adisyonid = cadNew.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvYeniEklenen.Items[i].SubItems[2].Text);
                        saveOrder.Urunid = Convert.ToInt32(lvYeniEklenen.Items[i].SubItems[1].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                }
                if (silinen.Count > 0)
                {
                    foreach (string item in silinen)
                    {
                        saveOrder.setDeleteOrder(Convert.ToInt32(item));
                    }
                }
                this.Hide();
                frm.ShowDialog();
            }
            else if (masa.TableGetByState(tableId, 3))
            {
                //cadNew.Servisturno = 1;
                //cadNew.Personelid = 1;
                //cadNew.Masaid = tableId;
                //cadNew.Tarih = DateTime.Now;
                //sonuc = cadNew.setByAdditionNew(cadNew);
                masa.setChangeTableState(baglanti._buttonName, 4);
                if (lvSiparisler.Items.Count > 0)
                {
                    for (int i = 0; i < lvSiparisler.Items.Count; i++)
                    {
                        saveOrder.Masaid = tableId;
                        saveOrder.Adisyonid = cadNew.getByAddition(tableId);
                        saveOrder.Adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                        saveOrder.Urunid = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                        saveOrder.setSaveOrder(saveOrder);
                    }
                }
                this.Hide();
                frm.ShowDialog();
            }
        }
        private void lvSiparisler_DoubleClick(object sender, EventArgs e)
        { 
            if (lvSiparisler.Items.Count > 0) 
            {
                if(lvSiparisler.SelectedItems[0].SubItems[4].Text!="0")
                {
                    cSiparis saveOrder = new cSiparis();
                    saveOrder.setDeleteOrder(Convert.ToInt32(lvSiparisler.SelectedItems[0].SubItems[4].Text));
                }
                else
                {
                    for (int i = 0; i < lvYeniEklenen.Items.Count; i++)
                    {
                        if (lvYeniEklenen.Items[i].SubItems[4].Text == lvSiparisler.SelectedItems[0].SubItems[5].Text)
                        {
                            lvYeniEklenen.Items.RemoveAt(i);
                        }
                    }
                }
                lvSiparisler.Items.RemoveAt(lvSiparisler.SelectedItems[0].Index);
            }
        }
        private void btnoplata_Click(object sender, EventArgs e)
        {
            baglanti._ServisTurNo = 1;
            baglanti._AdisyonID = AdditionId.ToString();
            frmOplata opl = new frmOplata();
            this.Hide();
            opl.ShowDialog();
        }
        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            cUrunCesitleri cu = new cUrunCesitleri();
            cu.getByProductSearch(lvmenu, Convert.ToString(bunifuMetroTextbox1.Text));
        }
        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "")
            {
                bunifuMetroTextbox1.Text = "Поиск...";
            }
        }
        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "Поиск...")
            {
                bunifuMetroTextbox1.Text = "";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Отменить последние действия", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Glavn frm = new Glavn();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btnDostavka_Click(object sender, EventArgs e)
        {
            cPaketler paket = new cPaketler();
            cSiparis saveOrder = new cSiparis();
            cAdisyon cadNew = new cAdisyon(); bool sonuc = false;
            if (MessageBox.Show("Вы согласны с дейтвиями?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lvSiparisler.Items.Count > 0)
                {
                    cadNew.Servisturno = 2;
                    cadNew.Personelid = 1;
                    cadNew.Masaid = 73;
                    cadNew.Tarih = DateTime.Now;
                    sonuc = cadNew.setByAdditionNew(cadNew);
                    if (sonuc) 
                    {
                            paket.Additionid = cadNew.getByAddition(73);
                            paket.Clientid = baglanti._musteriId;
                            paket.PayTypeid = 1;
                            paket.Descriptionid = "Пакет заказов";
                            bool result=paket.OrderServiceEkleme(paket);
                            if (result)
                            {
                                for (int i = 0; i < lvSiparisler.Items.Count; i++)
                                {
                                    saveOrder.Masaid = 73;
                                    saveOrder.Adisyonid = cadNew.getByAddition(73);
                                    saveOrder.Adet = Convert.ToInt32(lvSiparisler.Items[i].SubItems[1].Text);
                                    saveOrder.Urunid = Convert.ToInt32(lvSiparisler.Items[i].SubItems[2].Text);
                                    saveOrder.setSaveOrder(saveOrder);
                                }
                            }
                            else MessageBox.Show("Не удалось");
                        frmSiparisKontrol frm = new frmSiparisKontrol();
                        this.Hide();
                        frm.ShowDialog();
                    }
                }
                
            }
        }
    }
}
