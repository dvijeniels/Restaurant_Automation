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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                slidemenu.Visible = false;
                zashed.Visible = false;
                dobropojalovat.Visible = false;
                panel1.Visible = true;
                Nowtime.Visible = true;
                MediaPlayer.Visible = true;
                radio1.Visible = true;
                radio2.Visible = true;
                radio3.Visible = true;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (slidemenu.Visible == false)
            {
                slidemenu.Visible = true;
                panel1.Visible = false;
                Nowtime.Visible = false;
                MediaPlayer.Visible = false;
                radio1.Visible = false;
                radio2.Visible = false;
                radio3.Visible = false;
                zashed.Visible = true;
                dobropojalovat.Visible = true;
            }
        }

        private void Glavnaya_Load(object sender, EventArgs e)
        {
            Nowtime.Text = DateTime.Now.ToLongTimeString();
            cPersoneller cp=new cPersoneller();
            zashed.Text=cp.personelSadece(baglanti._personelid);
        }

        private void radio1_Click(object sender, EventArgs e)
        {
            MediaPlayer.URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_radio1_mf_p";

        }

        private void radio2_Click(object sender, EventArgs e)
        {
            MediaPlayer.URL = "http://bbcmedia.ic.llnwd.net/stream/bbcmedia_6music_mf_p";
        }

        private void radio3_Click(object sender, EventArgs e)
        {
            MediaPlayer.URL = "http://bbcwssc.ic.llnwd.net/stream/bbcwssc_mp1_ws-einws";
        }

        private void btnmasalar_Click(object sender, EventArgs e)
        {
            Glavn masa = new Glavn();
            this.Hide();
            masa.ShowDialog();
        }
        private void btnrezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon rezer = new frmRezervasyon();
            this.Hide();
            rezer.ShowDialog();
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            //frmPaketSiparis zakaz = new frmPaketSiparis();
            //this.Hide();
            //zakaz.ShowDialog();
            //this.Close();
            frmSiparisKontrol frm = new frmSiparisKontrol();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            frmMusteri frm = new frmMusteri();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnkassa_Click(object sender, EventArgs e)
        {
            frmKassa frm = new frmKassa();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnmutfak_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnraporlama_Click(object sender, EventArgs e)
        {
            frmRapor frm = new frmRapor();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnayarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Hide();
            frm.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Nowtime.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            frmVxod frm = new frmVxod();
            this.Hide();
            frm.ShowDialog();
        }

        private void zashed_Click(object sender, EventArgs e)
        {

        }
    }
}
