using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Restorant_Otomasyon
{
    class cRezervasyon
    {
        #region Fields
        private int _id;
        private int _tableid;
        private int _clientid;
        private DateTime _date;
        private int _ClientCount;
        private string _description;
        private int _Additionid; 
        #endregion
        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Tableid
        {
            get { return _tableid; }
            set { _tableid = value; }
        }
        public int Clientid
        {
            get { return _clientid; }
            set { _clientid = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public int ClientCount
        {
            get { return _ClientCount; }
            set { _ClientCount = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Additionid
        {
            get { return _Additionid; }
            set { _Additionid = value; }
        } 
        #endregion
        baglanti bagl = new baglanti();
        public int getByClientIdFromRezervasyon(int tableId)
        {
            int clientid = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select Top 1 musteriid from rezervasion where masaid=@masaid order by musteriid Desc", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@masaid", OleDbType.Integer).Value = tableId;
                clientid = Convert.ToInt32(cmd.ExecuteScalar());
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
            return clientid;
        }
        public bool rezervasyonClose(int Additionid)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("UPDATE rezervasion set durum=1 where adisiyonid=@adisiyonid", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisiyonid", OleDbType.Integer).Value = Additionid;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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
        public void musteriIDGetirFromRezervasyon(ListView lv)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select rezervasion.musteriid,(adi+' '+soyadi) as musteri from rezervasion INNER JOIN musteriler on rezervasion.musteriid=musteriler.musteriid where rezervasion.durum=0 ", con);
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
                    lv.Items.Add(dr["musteriid"].ToString());
                    lv.Items[i].SubItems.Add(dr["musteri"].ToString());
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
        public void eskiRezervasyonlariGetir(ListView lv, int musteriID)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select rezervasion.musteriid,adi, soyadi,adisyonid,tarih from rezervasion INNER JOIN musteriler on rezervasion.musteriid=musteriler.musteriid where rezervasion.musteriid=@musteriid and rezervasion.durum=0 Order BY rezervasion.id Desc", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("musteriid", OleDbType.Integer).Value = musteriID;
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
        public DateTime sonRezervasyonTarihi(int mID)
        {
            DateTime tarih = new DateTime();
            tarih = DateTime.Now;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select tarih from rezervasion where rezervasion.musteriid=@musteriid and rezervasion.durum=1 Order BY rezervasion.id Desc", con);
            cmd.Parameters.Add("musteriid", OleDbType.Integer).Value = mID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                tarih=Convert.ToDateTime(cmd.ExecuteScalar());
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
            return tarih;
        }
        public int acikRezervasyonSayisi()
        {
            int sonuc = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select count(*) from rezervasion where rezervasion.durum=0 ", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc=Convert.ToInt32(cmd.ExecuteNonQuery());
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
        public bool rezervasyonAcikmiKontrol(int mID)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select Top 1 rezervasion.id from rezervasion where musteriid=@musteriid and durum=1 ORDER BY id DESC", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("musteriid", OleDbType.Integer).Value = mID;
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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
        public bool rezervasyonAc(cRezervasyon cr)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into rezervasion (musteriid,masaid,adisyonid,tarih,kackisi,aciklama,durum)values(@musteriid,@masaid,@adisyonid,@tarih,@kackisi,@aciklama,1)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("musteriid", OleDbType.Integer).Value = cr._clientid;
                cmd.Parameters.Add("masaid", OleDbType.Integer).Value = cr._tableid;
                cmd.Parameters.Add("adisyonid", OleDbType.Integer).Value = cr._Additionid;
                cmd.Parameters.Add("tarih", OleDbType.Date).Value = cr._date;
                cmd.Parameters.Add("kackisi", OleDbType.Integer).Value = cr._ClientCount;
                cmd.Parameters.Add("aciklama", OleDbType.VarChar).Value = cr._description;
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
        public int rezerveMasaIdGetir(int mid)
        {
            int sonuc = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select rezervasion.masaid from rezervasion INEER JOIN adisyonlar on rezervasion.adisyonid=adisyonlar.adisiyonid where rezervasion.durum=1 and adisyonlar.durum=0 and rezervasion.musteriid=@musteriid", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("musteriid", OleDbType.Integer).Value = mid;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
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
    }
}
