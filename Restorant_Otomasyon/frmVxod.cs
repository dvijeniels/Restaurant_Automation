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
    public partial class frmVxod : Form
    {
        public frmVxod()
        {
            InitializeComponent();
        }
        baglanti bagl = new baglanti();

        private void btncikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            cPersoneller pers = new cPersoneller();
            bool result = pers.personelEntryControl(txtsifre.Text, baglanti._personelid);
            if (result)
            {
                cPersonelHareketleri cph = new cPersonelHareketleri();
                cph.Personelid = baglanti._personelid;
                cph.Islem = "Выполнил вход";
                cph.Tarih = DateTime.Now;
                cph.personelActionSave(cph);
                this.Hide();
                Anasayfa menu = new Anasayfa();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Вы не правильно ввели свой пароль", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            txtsifre.Text = ""; 
        }

        private void frmVxod_Load(object sender, EventArgs e)
        {
            cPersoneller pers = new cPersoneller();
            pers.personelGetbyInformation(combobax);
        }

        private void combobax_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller pers = (cPersoneller)combobax.SelectedItem;
            baglanti._personelid = pers.Personelid;
            baglanti._gorevid = pers.Gorevid;
        }

        private void txtsifre_Enter(object sender, EventArgs e)
        {
            if (txtsifre.Text == "Пароль")
            {
                txtsifre.Text = "";
            }
        }

        private void txtsifre_Leave(object sender, EventArgs e)
        {
            if (txtsifre.Text == "")
            {
                txtsifre.Text = "Пароль";
            }
        }
    }
}
