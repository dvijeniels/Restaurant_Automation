using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Restorant_Otomasyon
{
    class cPersoneller
    {
        baglanti bagl = new baglanti();
        #region Fields
        private int _personelid;
        private int _personelgorevid;
        private string _personeladi;
        private string _personelsoyadi;
        private string _personelsifre;
        private string _personelkullaniciadi;
        private bool _personeldurum; 
        #endregion
        #region Properties
        public int Personelid
        {
            get { return _personelid; }
            set { _personelid = value; }
        }
        public int Gorevid
        {
            get { return _personelgorevid; }
            set { _personelgorevid = value; }
        }
        public string Personeladi
        {
            get { return _personeladi; }
            set { _personeladi = value; }
        }
        public string Personelsoyadi
        {
            get { return _personelsoyadi; }
            set { _personelsoyadi = value; }
        }
        public string Personelsifre
        {
            get { return _personelsifre; }
            set { _personelsifre = value; }
        }
        public string Personelkullaniciadi
        {
            get { return _personelkullaniciadi; }
            set { _personelkullaniciadi = value; }
        }
        public bool Personeldurum
        {
            get { return _personeldurum; }
            set { _personeldurum = value; }
        } 
        #endregion
        public bool personelEntryControl(string password,int userid)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from personeller where personelid=@personelid and sifre=@sifre", con);
            cmd.Parameters.Add("@personelid", OleDbType.VarChar).Value = userid;
            cmd.Parameters.Add("@sifre", OleDbType.VarChar).Value = password;
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
        public void personelGetbyInformation(ComboBox cb)
        {
            //bool result=false;
            cb.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from personeller where durum=0",con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cPersoneller pers = new cPersoneller();
                pers._personelid = Convert.ToInt32(dr["personelid"]);
                pers._personelgorevid = Convert.ToInt32(dr["gorevid"]);
                pers._personeladi = Convert.ToString(dr["adi"]);
                pers._personelsoyadi = Convert.ToString(dr["soyadi"]);
                pers._personelsifre = Convert.ToString(dr["sifre"]);
                pers._personelkullaniciadi = Convert.ToString(dr["kullaniciadi"]);
                pers._personeldurum = Convert.ToBoolean(dr["durum"]);
                cb.Items.Add(pers);
            }
            dr.Close();
            con.Close();
        }
        public override string ToString()
        {

            return Personeladi+" "+Personelsoyadi;
        }
        public void personelBilgileriniGetir(ListView lv)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select personeller.*,gorev from personeller INNER JOIN gorevler on gorevler.gorevid=personeller.gorevid where personeller.durum=0", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["personelid"].ToString());
                lv.Items[i].SubItems.Add(dr["gorevid"].ToString());
                lv.Items[i].SubItems.Add(dr["gorev"].ToString());
                lv.Items[i].SubItems.Add(dr["adi"].ToString());
                lv.Items[i].SubItems.Add(dr["soyadi"].ToString());
                lv.Items[i].SubItems.Add(dr["sifre"].ToString());
                lv.Items[i].SubItems.Add(dr["kullaniciadi"].ToString());
                i++;
            }
            dr.Close();
            con.Close();
        }
        public void personelBilgileriniGetirFromIDLV(ListView lv, int persID)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select personeller.*,gorev from personeller INNER JOIN gorevler on gorevler.gorevid=personeller.gorevid where personeller.durum=0 and personeller.personelid=@personelid", con);
            cmd.Parameters.Add("personelid", OleDbType.Integer).Value = persID;

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                lv.Items.Add(dr["personelid"].ToString());
                lv.Items[i].SubItems.Add(dr["gorevid"].ToString());
                lv.Items[i].SubItems.Add(dr["gorev"].ToString());
                lv.Items[i].SubItems.Add(dr["adi"].ToString());
                lv.Items[i].SubItems.Add(dr["soyadi"].ToString());
                lv.Items[i].SubItems.Add(dr["sifre"].ToString());
                lv.Items[i].SubItems.Add(dr["kullaniciadi"].ToString());
                i++;
            }
            dr.Close();
            con.Close();
        }
        public string personelSadece(int persID)
        {
            string sonuc = "";
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select adi +' '+ soyadi from personeller where personeller.durum=0 and personeller.personelid=@personelid", con);
            cmd.Parameters.Add("personelid", OleDbType.Integer).Value = persID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc=Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                
                throw;
            }
            con.Close();
            return sonuc;
        }
        public string personelDolzhnost(int persID)
        {
            string sonuc = "";
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("SELECT gorevler.gorev FROM gorevler INNER JOIN personeller ON gorevler.gorevid = personeller.gorevid where personeller.personelid=@personelid", con);
            cmd.Parameters.Add("personelid", OleDbType.Integer).Value = persID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return sonuc;
        }
        public string personelPasswoerGetir(int persID)
        {
            string sonuc = "";
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("SELECT sifre FROM personeller where personeller.personelid=@personelid", con);
            cmd.Parameters.Add("personelid", OleDbType.Integer).Value = persID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return sonuc;
        }
        public bool personelSifreDegidtir(int personelID,string pass)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("UPDATE personeller set sifre=@sifre where personelid=@personelid", con);
            cmd.Parameters.Add("sifre", OleDbType.VarChar).Value = pass;
            cmd.Parameters.Add("personelid", OleDbType.Integer).Value = personelID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return sonuc;
        }
        public bool personelEkle(cPersoneller cp)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into personeller (adi,soyadi,sifre,gorevid) values (@adi,@soyadi,@sifre,@gorevid)", con);
            cmd.Parameters.Add("adi", OleDbType.VarChar).Value = cp._personeladi;
            cmd.Parameters.Add("soyadi", OleDbType.VarChar).Value = cp._personelsoyadi;
            cmd.Parameters.Add("sifre", OleDbType.VarChar).Value = cp._personelsifre;
            cmd.Parameters.Add("gorevid", OleDbType.Integer).Value = cp._personelgorevid;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return sonuc;
        }
        public bool personelGuncelle(cPersoneller cp,int perIDD)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update personeller set adi=@adi,soyadi=@soyadi,sifre=@sifre,gorevid=@gorevid where personelid=@personelid", con);
            cmd.Parameters.Add("personelid", OleDbType.Integer).Value = perIDD;
            cmd.Parameters.Add("adi", OleDbType.VarChar).Value = cp._personeladi;
            cmd.Parameters.Add("soyadi", OleDbType.VarChar).Value = cp._personelsoyadi;
            cmd.Parameters.Add("sifre", OleDbType.VarChar).Value = cp._personelsifre;
            cmd.Parameters.Add("gorevid", OleDbType.Integer).Value = cp._personelgorevid;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return sonuc;
        }
        public bool personelSil(int perIDD)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update personeller set durum=1 where personelid=@personelid", con);
            cmd.Parameters.Add("personelid", OleDbType.Integer).Value = perIDD;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return sonuc;
        }

    }
}
