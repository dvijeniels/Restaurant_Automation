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
    class cAdisyon
    {
        baglanti bagl = new baglanti();
        #region Fields
        private int _adisiyonid;
        private int _servisturno;
        private decimal _tutar;
        private int _personelid;
        private int _masaid;
        private DateTime _tarih;
        private bool _durum;
        #endregion
        #region Properties
        public int Adisiyonid
        {
            get { return _adisiyonid; }
            set { _adisiyonid = value; }
        }


        public int Servisturno
        {
            get { return _servisturno; }
            set { _servisturno = value; }
        }


        public decimal Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        }


        public int Personelid
        {
            get { return _personelid; }
            set { _personelid = value; }
        }


        public int Masaid
        {
            get { return _masaid; }
            set { _masaid = value; }
        }


        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }


        public bool Durum
        {
            get { return _durum; }
            set { _durum = value; }
        }
        #endregion
        public int getByAddition(int MasaID)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select Top 1 adisiyonid from adisyonlar where masaid=@masaid Order by adisiyonid desc", con);
            cmd.Parameters.Add("@masaid", OleDbType.Integer).Value = MasaID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
            }
            return MasaID;
        }
        public bool setByAdditionNew(cAdisyon Bilgiler)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into Adisyonlar(servisturno,tarih,personelid,masaid,durum)values(@servisturno,@tarih,@personelid,@masaid,@durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("servisturno", OleDbType.Integer).Value = Bilgiler.Servisturno;
                cmd.Parameters.Add("tarih", OleDbType.Date).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("personelid", OleDbType.Integer).Value = Bilgiler.Personelid;
                cmd.Parameters.Add("masaid", OleDbType.Integer).Value =Bilgiler.Masaid;
                cmd.Parameters.Add("durum", OleDbType.Boolean).Value= 0;
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
        public void additionClose(int Additionid,int durum)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("UPDATE adisyonlar SET adisyonlar.durum = True WHERE (((adisyonlar.adisiyonid)=@adisiyonid))", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisiyonid", OleDbType.Integer).Value = Additionid;
                //cmd.Parameters.Add("@durum", OleDbType.Integer).Value = durum;
                cmd.ExecuteNonQuery();
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
        }
        public int adisyonBul()
        {
            int miktar = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select count(*) from adisyonlar as sayi where durum=0 and servisturno=2", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                miktar =Convert.ToInt32(cmd.ExecuteScalar());
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
            return miktar;
        }
        public void acikaPaketAdisyonlar(ListView lv)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT musteriler.adi +' '+musteriler.soyadi as musteri,paketsiparis.musteriid, adisyonlar.adisiyonid FROM musteriler INNER JOIN (adisyonlar INNER JOIN paketsiparis ON adisyonlar.adisiyonid = paketsiparis.adisyonid) ON musteriler.musteriid = paketsiparis.musteriid WHERE (((adisyonlar.durum)=False))", con);
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr=cmd.ExecuteReader();
                int i=0;
                while(dr.Read())
                {
                    lv.Items.Add(dr["musteriid"].ToString());
                    lv.Items[i].SubItems.Add(dr["musteri"].ToString());
                    lv.Items[i].SubItems.Add(dr["adisiyonid"].ToString());
                    i++;
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
        public int musteriSonAdisyonID(int musteriid)
        {
            int sonuc = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select adisyonlar.adisiyonid from adisyonlar INNER JOIN paketsiparis on paketsiparis.adisyonid=adisyonlar.adisiyonid where paketsiparis.durum=0 and adisyonlar.durum=0 and paketsiparis.musteriid=@musteriid", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = musteriid;
                sonuc = Convert.ToInt32(cmd.ExecuteScalar());
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
            return sonuc;
        }
        public void musteriDetaylar(ListView lv,int musteriID)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
//            SELECT paketsiparis.musteriid, paketsiparis.adisyonid, musteriler.adi, musteriler.soyadi, adisyonlar.tarih
//FROM musteriler INNER JOIN (adisyonlar INNER JOIN paketsiparis ON adisyonlar.adisiyonid = paketsiparis.adisyonid) ON musteriler.musteriid = paketsiparis.musteriid
//WHERE (((adisyonlar.servisturno)=2) AND ((adisyonlar.durum)=True));

            OleDbCommand cmd = new OleDbCommand("Select paketsiparis.musteriid,paketsiparis.adisyonid,musteriler.adi,musteriler.soyadi, adisyonlar.tarih from musteriler INNER JOIN (adisyonlar INNER JOIN paketsiparis ON adisyonlar.adisiyonid = paketsiparis.adisyonid) ON musteriler.musteriid = paketsiparis.musteriid where adisyonlar.servisturno=2 and paketsiparis.musteriid=@musteriid and adisyonlar.durum=0", con);
            cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = musteriID;
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["musteriid"].ToString());
                    lv.Items[i].SubItems.Add(dr["adi"].ToString());
                    lv.Items[i].SubItems.Add(dr["soyadi"].ToString());
                    lv.Items[i].SubItems.Add(dr["tarih"].ToString());
                    lv.Items[i].SubItems.Add(dr["adisyonid"].ToString());
                    i++;
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
        public int musteriSiparisSayisi(int musteriID)
        {
            int sayi = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            //            SELECT paketsiparis.musteriid, paketsiparis.adisyonid, musteriler.adi, musteriler.soyadi, adisyonlar.tarih
            //FROM musteriler INNER JOIN (adisyonlar INNER JOIN paketsiparis ON adisyonlar.adisiyonid = paketsiparis.adisyonid) ON musteriler.musteriid = paketsiparis.musteriid
            //WHERE (((adisyonlar.servisturno)=2) AND ((adisyonlar.durum)=True));

            OleDbCommand cmd = new OleDbCommand("Select musteriler.musteriid from musteriler INNER JOIN (adisyonlar INNER JOIN paketsiparis ON adisyonlar.adisiyonid = paketsiparis.adisyonid) ON musteriler.musteriid = paketsiparis.musteriid where adisyonlar.servisturno=2 and paketsiparis.musteriid=@musteriid", con);
            cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = musteriID;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sayi = Convert.ToInt32(cmd.ExecuteScalar());
                con.Dispose();
                con.Close();
            return sayi;
        }
        public int rezervasyonAdisyonAc(cAdisyon a)
        {
            int result = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into adisyonlar(servisturno,tarih,personelid,masaid)values(@servisturno,@tarih,@personelid,@masaid)", con);
            OleDbCommand cmd2 = new OleDbCommand("SELECT @@Identity", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("servisturno", OleDbType.Integer).Value = a.Servisturno;
                cmd.Parameters.Add("tarih", OleDbType.Date).Value = a.Tarih;
                cmd.Parameters.Add("personelid", OleDbType.Integer).Value = a.Personelid;
                cmd.Parameters.Add("masaid", OleDbType.Integer).Value = a.Masaid;
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
    }
}
