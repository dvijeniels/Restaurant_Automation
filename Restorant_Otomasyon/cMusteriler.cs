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
    class cMusteriler
    {
        #region Fields
        private int _musteriid;
        private string _adi;
        private string _soyadi;
        private string _adres;
        private string _telefon;
        private string _mail; 
        #endregion
        #region Properties
        public int Musteriid
        {
            get { return _musteriid; }
            set { _musteriid = value; }
        }
        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }
        public string Soyadi
        {
            get { return _soyadi; }
            set { _soyadi = value; }
        }
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        } 
        #endregion
        baglanti bagl=new baglanti();
        public bool musteriVarmi(string tlf)
        {
            bool result = false;
            OleDbConnection con=new OleDbConnection(bagl.baglan);
            OleDbCommand cmd=new OleDbCommand();
            cmd.Connection=con;
            cmd.CommandText = "SELECT telefon  FROM musteriler WHERE  telefon=@telefon";
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.Add("@telefon", OleDbType.VarChar).Value = tlf;
            cmd.Parameters.Add("@sonuc", OleDbType.Integer);
            cmd.Parameters["@sonuc"].Direction = ParameterDirection.Output;
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.ExecuteNonQuery();
                result = Convert.ToBoolean(cmd.Parameters["@sonuc"].Value);
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
        public int musteriEkle(cMusteriler m)
        {
            int result = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into musteriler(adi,soyadi,adres,telefon,mail)values(@adi,@soyadi,adres,@telefon,@mail)", con);
            OleDbCommand cmd2 = new OleDbCommand("SELECT @@Identity", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adi", OleDbType.VarChar).Value = m._adi;
                cmd.Parameters.Add("@soyadi", OleDbType.VarChar).Value = m._soyadi;
                cmd.Parameters.Add("@adres", OleDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@telefon", OleDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@mail", OleDbType.VarChar).Value = m._mail;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd2.ExecuteScalar());
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        public bool musteriGuncelle(cMusteriler m)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update musteriler set adi=@adi,soyadi=@soyadi,adres=@adres,telefon=@telefon,mail=@mail where musteriid=@musteriid", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adi", OleDbType.VarChar).Value = m._adi;
                cmd.Parameters.Add("@soyadi", OleDbType.VarChar).Value = m._soyadi;
                cmd.Parameters.Add("@adres", OleDbType.VarChar).Value = m._adres;
                cmd.Parameters.Add("@telefon", OleDbType.VarChar).Value = m._telefon;
                cmd.Parameters.Add("@mail", OleDbType.VarChar).Value = m._mail;
                cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = m._musteriid;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        public void musteriGetir(ListView lv)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from musteriler", con);
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while(dr.Read())
                {
                    lv.Items.Add(dr["musteriid"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["soyadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["mail"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adres"].ToString());
                    sayac++;
                }
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public void musteriGetirFromSecilen(int musteri,TextBox adi,TextBox soyad,TextBox telefon,TextBox mail,TextBox adres)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from musteriler where musteriid=@musteriid", con);
            cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = musteri;
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    adi.Text = dr["adi"].ToString();
                    soyad.Text = dr["soyadi"].ToString();
                    telefon.Text = dr["telefon"].ToString();
                    mail.Text = dr["mail"].ToString();
                    adres.Text = dr["adres"].ToString();
                }
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public void musteriSoyadinagoreArama(ListView lv, string musteriAd)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from musteriler where soyadi like '%" + musteriAd + "%'", con);
            cmd.Parameters.Add("@soyadi", OleDbType.VarChar).Value = musteriAd;
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["musteriid"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["adi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["soyadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["mail"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adres"].ToString());
                    sayac++;
                }
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public void musteriAdinagoreArama(ListView lv, string musteriAd)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from musteriler where adi like '%" + musteriAd + "%'", con);
            cmd.Parameters.Add("@adi", OleDbType.VarChar).Value = musteriAd;
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["musteriid"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["adi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["soyadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["mail"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adres"].ToString());
                    sayac++;
                }
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public void musteriMailegoreArama(ListView lv, string musteriMail)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from musteriler where mail like '%" + musteriMail + "%'", con);
            cmd.Parameters.Add("@adi", OleDbType.VarChar).Value = musteriMail;
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["musteriid"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["adi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["soyadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["mail"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adres"].ToString());
                    sayac++;
                }
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public void musteriTelefonagoreArama(ListView lv, string musteriAd)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from musteriler where telefon like '%" + musteriAd + "%'", con);
            cmd.Parameters.Add("@telefon", OleDbType.VarChar).Value = musteriAd;
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["musteriid"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["adi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["soyadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["mail"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adres"].ToString());
                    sayac++;
                }
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        public void musteriAdresegoreArama(ListView lv, string musteriAd)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from musteriler where adres like '%" + musteriAd + "%'", con);
            cmd.Parameters.Add("@adres", OleDbType.VarChar).Value = musteriAd;
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(Convert.ToInt32(dr["musteriid"]).ToString());
                    lv.Items[sayac].SubItems.Add(dr["adi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["soyadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["telefon"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["mail"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adres"].ToString());
                    sayac++;
                }
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
    }
}
