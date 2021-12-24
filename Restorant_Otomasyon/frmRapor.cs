using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Restorant_Otomasyon
{
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }
        void menubutton()
        {
            int sayi = 1;
            int i = 0;
            for (i = 0; i <= 12; i++)
            {
                Button myButton = new Button();
                myButton.Name = "menu" + sayi++;
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
                switch (myButton.Name)
                {
                    case "menu1":
                        myButton.Text = "Первое блюдо";
                        break;
                    case "menu2":
                        myButton.Text = "Второе блюдо";
                        break;
                    case "menu3":
                        myButton.Text = "Фирменные блюда";
                        break;
                    case "menu4":
                        myButton.Text = "Суши";
                        break;
                    case "menu5":
                        myButton.Text = "Фастфуд";
                        break;
                    case "menu6":
                        myButton.Text = "Пицца";
                        break;
                    case "menu7":
                        myButton.Text = "Молочное";
                        break;
                    case "menu8":
                        myButton.Text = "Салаты";
                        break;
                    case "menu9":
                        myButton.Text = "Сладкие вкусняшки";
                        break;
                    case "menu10":
                        myButton.Text = "Холодные напитки";
                        break;
                    case "menu11":
                        myButton.Text = "Горячие напитки";
                        break;
                    case "menu12":
                        myButton.Text = "Кальяны";
                        break;
                    case "menu13":
                        myButton.Text = "Другие";
                        break;
                    default:
                        break;
                }
            }
        }
        private void menu_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            int uzunluk = btn.Name.Length;
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            cUrunler u = new cUrunler();
            cMasalar masa = new cMasalar();
            lvIstatistik.Items.Clear();
            u.urunleriListeleIstatistiklereGoreUrunID(lvIstatistik, dtBaslangic, dtBitis, masa.TableGetByNumberRapor(btn.Name));
            groupBox1.Text ="Статистика по категории: "+ btn.Text;
            if (lvIstatistik.Items.Count>0)
            {
                chRapor.Series["Проданные"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    chRapor.Series["Проданные"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);
                }
            }
            else
            {
                chRapor.Series["Проданные"].Points.Clear();
                MessageBox.Show("Пока что ничего нету выберите другие даты");
            }
           // cu.getByProductTypes(lvmenu, btn);
        }
        private void frmRapor_Load(object sender, EventArgs e)
        {
            menubutton();
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
        private void btnZRapor_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Общая статистика всех категорий";
            chRapor.Series[0].EmptyPointStyle.Color = Color.Transparent;
            chRapor.Series[0].Color = Color.FromArgb(59, 40, 251);
            cUrunler u = new cUrunler();
            lvIstatistik.Items.Clear();
            u.urunleriListeleIstatistiklereGore(lvIstatistik, dtBaslangic, dtBitis);
            if (lvIstatistik.Items.Count > 0)
            {
                chRapor.Series["Проданные"].Points.Clear();
                for (int i = 0; i < lvIstatistik.Items.Count; i++)
                {
                    
                    chRapor.Series["Проданные"].Points.AddXY(lvIstatistik.Items[i].SubItems[0].Text, lvIstatistik.Items[i].SubItems[1].Text);
                    //chRapor.Series["Проданные"].Label = lvIstatistik.Items[i].SubItems[0].Text;
                }
            }
            else
            {
                MessageBox.Show("Пока что ничего нету выберите другие даты");
            }
        }

        private void lvIstatistik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
