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
    public partial class frmKassa : Form
    {
        public frmKassa()
        {
            InitializeComponent();
        }

        private void frmKassa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anasayfa glav = new Anasayfa();
            glav.Show();
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

        private void frmKassa_Load(object sender, EventArgs e)
        {
            this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2);
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            //this.rpvAylik.RefreshReport();
            //rpvAylik.Visible = false;
            //rpvGunluk.Visible = true;
            lblGunluk.Visible = true;
            lblAylik.Visible = false;
            btnzRapor.Visible = false;
            btnRapor.Visible = true;
            //this.rpvGunluk.RefreshReport();
            //this.rpvGunluk.RefreshReport();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
           // rpvAylik.Visible = true;
            btnRapor.Visible = false;
            btnzRapor.Visible = true;
           // rpvGunluk.Visible = false;
            lblGunluk.Visible = false;
            lblAylik.Visible = true;
        }

        private void btnzRapor_Click(object sender, EventArgs e)
        {
           // rpvGunluk.Visible = true;
            btnRapor.Visible = true;
            btnzRapor.Visible = false;
           // rpvAylik.Visible = false;
            lblGunluk.Visible = true;
            lblAylik.Visible = false;
        }
    }
}
