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
    class cUrunler
    {
        baglanti bagl = new baglanti();
        #region Fields
        private int _urunid;
        private int _kategoriid;
        private string _urunadi;
        private string _aciklama;
        private double _fiyat; 
        #endregion
        #region Properties
        public int Urunid
        {
            get { return _urunid; }
            set { _urunid = value; }
        }


        public int Kategoriid
        {
            get { return _kategoriid; }
            set { _kategoriid = value; }
        }


        public string Urunadi
        {
            get { return _urunadi; }
            set { _urunadi = value; }
        }


        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }


        public double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        } 
        #endregion
        public void urunlerArama(ListView lv,string urunadi)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("SELECT kategoriler.kategoriadi, urunler.* FROM kategoriler INNER JOIN urunler ON kategoriler.id = urunler.kategoriid where urunler.durum=0 and urunadi like '%" + urunadi + "%'", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("@urunadi", OleDbType.VarChar).Value = urunadi;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["id"].ToString());
                    lv.Items[i].SubItems.Add(dr["kategoriid"].ToString());
                    lv.Items[i].SubItems.Add(dr["kategoriadi"].ToString());
                    lv.Items[i].SubItems.Add(dr["urunadi"].ToString());
                    lv.Items[i].SubItems.Add(string.Format("{0:0#00}", dr["fiyat"].ToString()));
                    lv.Items[i].SubItems.Add(dr["aciklama"].ToString());
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
        public bool urunEkle(cUrunler u)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into urunler (kategoriid,urunadi,aciklama,fiyat) values (@kategoriid,@urunadi,@aciklama,@fiyat)", con);
            cmd.Parameters.Add("kategoriid", OleDbType.Integer).Value = u._kategoriid;
            cmd.Parameters.Add("urunadi", OleDbType.VarChar).Value = u._urunadi;
            cmd.Parameters.Add("aciklama", OleDbType.VarChar).Value = u._aciklama;
            cmd.Parameters.Add("fiyat", OleDbType.Double).Value = u._fiyat;
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
        public int urunGuncelle(cUrunler cp)
        {
            int sonuc = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update urunler set kategoriid=@kategoriid,urunadi=@urunadi,aciklama=@aciklama,fiyat=@fiyat where urunler.id=@id", con);
            
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("kategoriid", OleDbType.Integer).Value = cp._kategoriid;
                cmd.Parameters.Add("urunadi", OleDbType.VarChar).Value = cp._urunadi;
                cmd.Parameters.Add("aciklama", OleDbType.VarChar).Value = cp._aciklama;
                cmd.Parameters.Add("fiyat", OleDbType.Double).Value = cp._fiyat;
                cmd.Parameters.Add("id", OleDbType.Integer).Value = cp._urunid;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return sonuc;
        }
        public bool urunSil(cUrunler u)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update urunler set durum=1 where id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("id", OleDbType.Integer).Value = u._urunid;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return sonuc;
        }
        public void urunlerListeleme(ListView lvv)
        {
            lvv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select urunler.*,kategoriler.kategoriadi from urunler INNER JOIN kategoriler on kategoriler.id=urunler.kategoriid where urunler.durum=0 and kategoriler.durum=0", con);
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lvv.Items.Add(dr["id"].ToString());
                    lvv.Items[i].SubItems.Add(dr["kategoriid"].ToString());
                    lvv.Items[i].SubItems.Add(dr["kategoriadi"].ToString());
                    lvv.Items[i].SubItems.Add(dr["urunadi"].ToString());
                    lvv.Items[i].SubItems.Add(string.Format("{0:0#00}", dr["fiyat"].ToString()));
                    lvv.Items[i].SubItems.Add(dr["aciklama"].ToString());
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
        public void urunlerIDgoreListele(ListView lv, int urunid)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from urunler where durum=0 and id=@id", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("@id", OleDbType.Integer).Value = urunid;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    lv.Items.Add(dr["id"].ToString());
                    lv.Items[i].SubItems.Add(dr["urunadi"].ToString());
                    lv.Items[i].SubItems.Add(dr["aciklama"].ToString());
                    lv.Items[i].SubItems.Add(string.Format("{0:0#00}", dr["fiyat"].ToString()));
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
        public void urunlerKatgoreListele(ListView lv, int urunid)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("SELECT kategoriler.kategoriadi, urunler.* FROM kategoriler INNER JOIN urunler ON kategoriler.id = urunler.kategoriid WHERE (((urunler.durum)=False)) and (kategoriler.id=@id)", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("@id", OleDbType.Integer).Value = urunid;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["id"].ToString());
                    lv.Items[i].SubItems.Add(dr["kategoriid"].ToString());
                    lv.Items[i].SubItems.Add(dr["kategoriadi"].ToString());
                    lv.Items[i].SubItems.Add(dr["urunadi"].ToString());
                    lv.Items[i].SubItems.Add(string.Format("{0:0#00}", dr["fiyat"].ToString()));
                    lv.Items[i].SubItems.Add(dr["aciklama"].ToString());
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
        public void urunleriListeleIstatistiklereGore(ListView lv,DateTimePicker Baslangic,DateTimePicker Bitis)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
//            SELECT urunler.urunadi, Sum(satislar.adet) AS [Sum-adet]
//FROM (kategoriler INNER JOIN urunler ON kategoriler.id = urunler.kategoriid) INNER JOIN (adisyonlar INNER JOIN satislar ON adisyonlar.adisiyonid = satislar.adisyonid) ON urunler.id = satislar.urunid
//GROUP BY urunler.urunadi, adisyonlar.tarih
//HAVING (((adisyonlar.tarih)=FormatDateTime("«Дата»","«namedformat»"))) Between "«Выражение»" And "«Выражение»" FormatDateTime("«Дата»";"«namedformat»")
//ORDER BY adeti DESC;
            OleDbCommand cmd = new OleDbCommand("SELECT Top 10 urunler.urunadi, Sum(satislar.adet) AS SumAdet FROM adisyonlar INNER JOIN (kategoriler INNER JOIN (urunler INNER JOIN satislar ON urunler.id = satislar.urunid) ON kategoriler.id = urunler.kategoriid) ON adisyonlar.adisiyonid = satislar.adisyonid WHERE tarih BETWEEN @Baslangic and @Bitis GROUP BY urunler.urunadi ORDER BY Sum(satislar.adet) DESC", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("Baslangic", OleDbType.VarChar).Value =Baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("Bitis", OleDbType.VarChar).Value = Bitis.Value.ToShortDateString();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["urunadi"].ToString());
                    lv.Items[i].SubItems.Add(dr["SumAdet"].ToString());
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
        public void urunleriListeleIstatistiklereGoreUrunID(ListView lv, DateTimePicker Baslangic, DateTimePicker Bitis,int kategoriID)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            //string donustur = Baslangic.Value.ToString("yyyy-MM-dd HH:mm:ss.FFF");
            //string donustur2 = Bitis.Value.ToString("yyyy-MM-dd HH:mm:ss.FFF");
            //            SELECT urunler.urunadi, Sum(satislar.adet) AS [Sum-adet]
            //FROM (kategoriler INNER JOIN urunler ON kategoriler.id = urunler.kategoriid) INNER JOIN (adisyonlar INNER JOIN satislar ON adisyonlar.adisiyonid = satislar.adisyonid) ON urunler.id = satislar.urunid
            //GROUP BY urunler.urunadi, adisyonlar.tarih
            //HAVING (((adisyonlar.tarih)=FormatDateTime("«Дата»","«namedformat»"))) Between "«Выражение»" And "«Выражение»" FormatDateTime("«Дата»";"«namedformat»")
            //ORDER BY adeti DESC;
            OleDbCommand cmd = new OleDbCommand("SELECT Top 10 urunler.urunadi, Sum(satislar.adet) AS SumAdet FROM adisyonlar INNER JOIN (kategoriler INNER JOIN (urunler INNER JOIN satislar ON urunler.id = satislar.urunid) ON kategoriler.id = urunler.kategoriid) ON adisyonlar.adisiyonid = satislar.adisyonid WHERE tarih BETWEEN @baslangic AND @bitis and (urunler.kategoriid=@kategoriid) GROUP BY urunler.urunadi ORDER BY Sum(satislar.adet) DESC", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("baslangic", OleDbType.VarChar).Value = Baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("bitis", OleDbType.VarChar).Value = Bitis.Value.ToShortDateString();
            cmd.Parameters.Add("kategoriid", OleDbType.Integer).Value = kategoriID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lv.Items.Add(dr["urunadi"].ToString());
                    lv.Items[i].SubItems.Add(dr["SumAdet"].ToString());
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
    }
}
