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
    class cSiparis
    {
        baglanti bagl = new baglanti();
        #region Fields
        private int _satisid;
        private int _adisyonid;
        private int _urunid;
        private int _masaid;
        private int _adet;
        private bool _durum; 
        #endregion
        #region Properties
        public int Satisid
        {
            get { return _satisid; }
            set { _satisid = value; }
        }
        public int Adisyonid
        {
            get { return _adisyonid; }
            set { _adisyonid = value; }
        }
        public int Urunid
        {
            get { return _urunid; }
            set { _urunid = value; }
        }
        public int Masaid
        {
            get { return _masaid; }
            set { _masaid = value; }
        }
        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }
        public bool Durum
        {
            get { return _durum; }
            set { _durum = value; }
        } 
        #endregion
        public void getByOrder(ListView lv,int AdisyonId)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select urunadi,fiyat,satislar.satisid,satislar.urunid,satislar.adet from satislar Inner Join urunler on satislar.urunid=urunler.id where adisyonid=@adisyonid", con);

            cmd.Parameters.Add("@adisyonid", OleDbType.Integer).Value = AdisyonId;
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
                    lv.Items.Add(dr["urunadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adet"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["urunid"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDouble(dr["fiyat"])*Convert.ToDouble(dr["adet"])));
                    lv.Items[sayac].SubItems.Add(dr["satisid"].ToString());
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
                con.Close();
            }
        }
        public bool setSaveOrder(cSiparis Bilgiler)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into satislar(adisyonid,urunid,masaid,adet)values(@adisyonid,@urunid,@masaid,@adet)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("adisyonid", OleDbType.Integer).Value = Bilgiler.Adisyonid;
                cmd.Parameters.Add("urunid", OleDbType.Integer).Value = Bilgiler.Urunid;
                cmd.Parameters.Add("masaid", OleDbType.Integer).Value = Bilgiler.Masaid;
                cmd.Parameters.Add("adet", OleDbType.Integer).Value = Bilgiler.Adet;
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
        public void setDeleteOrder(int satisId)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Delete from satislar where satisid=@satisid", con);
            cmd.Parameters.Add("@satisid", OleDbType.Integer).Value = satisId;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public decimal GenelToplamBul(int musteriid)
        {
            decimal geneltoplam=1;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            //"Select sum(toplamtutar) from hesapodemeleri where musteriid=@musteriid"
            OleDbCommand cmd = new OleDbCommand("SELECT Sum(satislar.adet*fiyat) AS Выражение1 FROM urunler INNER JOIN (musteriler INNER JOIN ((adisyonlar INNER JOIN paketsiparis ON adisyonlar.adisiyonid = paketsiparis.adisyonid) INNER JOIN satislar ON adisyonlar.adisiyonid = satislar.adisyonid) ON musteriler.musteriid = paketsiparis.musteriid) ON urunler.id = satislar.urunid WHERE (((paketsiparis.musteriid)=@musteriid) AND ((paketsiparis.durum)=False))", con);
            cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = musteriid;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object idResult = cmd.ExecuteScalar();
                geneltoplam = idResult == DBNull.Value ? 0 : Convert.ToInt32(idResult);
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
            return geneltoplam;
        }
        public void adisyonpaketSipDetaylari(ListView lv, int adis)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
//            SELECT satislar.satisid, urunler.urunadi, urunler.fiyat, satislar.adet
//FROM adisyonlar INNER JOIN (urunler INNER JOIN satislar ON urunler.id = satislar.urunid) ON adisyonlar.adisiyonid = satislar.adisyonid;
            OleDbCommand cmd = new OleDbCommand("Select satislar.satisid, urunler.urunadi,urunler.fiyat,satislar.adet from adisyonlar INNER JOIN (urunler INNER JOIN satislar ON urunler.id = satislar.urunid) ON adisyonlar.adisiyonid = satislar.adisyonid where satislar.adisyonid=@adisyonid", con);
            cmd.Parameters.Add("@adisyonid", OleDbType.Integer).Value = adis;
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
                    lv.Items.Add(dr["satisid"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["urunadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adet"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["fiyat"].ToString());
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
                con.Dispose();
                con.Close();
            }
        }
    }
}
