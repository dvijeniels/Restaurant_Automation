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
    class cUrunCesitleri
    {
        baglanti bagl = new baglanti();
        #region Fields
        private int _urunturno;
        private string _kategoriadi;
        private string _aciklama;
        #endregion
        #region Properties
        public int Urunturno
        {
            get { return _urunturno; }
            set { _urunturno = value; }
        }
        public string Kategoriadi
        {
            get { return _kategoriadi; }
            set { _kategoriadi = value; }
        }


        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion
        public void getByProductTypes(ListView Cesitler, string btn)
        {
            Cesitler.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select urunadi,fiyat,urunler.id from kategoriler Inner Join urunler on kategoriler.id=urunler.kategoriid  where urunler.kategoriid=@kategoriid and urunler.durum=0", con);
            int uzunluk = btn.Length;
            if (uzunluk == 1)
            {
                cmd.Parameters.Add("@kategoriid", OleDbType.Integer).Value = btn.Substring(uzunluk - 1, 1);
            }
            else
            {
                cmd.Parameters.Add("@kategoriid", OleDbType.Integer).Value = btn.Substring(uzunluk - 2, 2);
            }
            //else
            //{
            //    int position = aa.IndexOf("u");
            //    cmd.Parameters.Add("@kategoriid", OleDbType.Integer).Value = aa.Substring(position + 1);
            //}
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                OleDbDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    Cesitler.Items.Add(dr["urunadi"].ToString());
                    Cesitler.Items[i].SubItems.Add(dr["fiyat"].ToString());
                    Cesitler.Items[i].SubItems.Add(dr["id"].ToString());
                    i++;
                }
                dr.Close();
                con.Dispose();
                con.Close();
            }
        public void getByProductSearch(ListView Cesitler, string txt)
        {
            Cesitler.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from urunler where urunadi like '%" + txt + "%'", con);
            cmd.Parameters.Add("@urunadi", OleDbType.VarChar).Value = txt;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["urunadi"].ToString());
                i++;
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void urunlerCesitleriniGetir(ComboBox cb)
        {
            cb.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from kategoriler where durum=0", con);
            OleDbDataReader dr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cUrunCesitleri cu = new cUrunCesitleri();
                    cu._urunturno = Convert.ToInt32(dr["id"]);
                    cu._kategoriadi = dr["kategoriadi"].ToString();
                    cu._aciklama = dr["aciklama"].ToString();
                    cb.Items.Add(cu);
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
        public int KatIdGetir(string kelime)
        {
            int id=0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select id from kategoriler where kategoriadi=@kategoriadi", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("kategoriadi", OleDbType.VarChar).Value = kelime;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"]);
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
            return id;
        }
        public void urunlerCesitleriniGetir(ListView lv)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from kategoriler where durum=0 ", con);
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
                    lv.Items.Add(dr["id"].ToString());
                    lv.Items[i].SubItems.Add(dr["kategoriadi"].ToString());
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
        public void urunlerCesitleriniArama(ListView lv, int source)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from kategoriler where durum=0 and kategoriadi like '%" + source + "%'", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("source", OleDbType.VarChar).Value = source;
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
                    lv.Items[i].SubItems.Add(dr["kategoriadi"].ToString());
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
        public bool urunCesitEkle(cUrunCesitleri u)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into kategoriler (kategoriadi,aciklama) values (@kategoriadi,@aciklama)", con);
            cmd.Parameters.Add("kategoriadi", OleDbType.VarChar).Value = u._kategoriadi;
            cmd.Parameters.Add("aciklama", OleDbType.VarChar).Value = u._aciklama;
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
        public int urunlerCesitGuncelle(cUrunCesitleri cp)
        {
            int sonuc = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update kategoriler set kategoriadi=@kategoriadi,aciklama=@aciklama where id=@id", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("kategoriadi", OleDbType.VarChar).Value = cp._kategoriadi;
                cmd.Parameters.Add("aciklama", OleDbType.VarChar).Value = cp._aciklama;
                cmd.Parameters.Add("id", OleDbType.Integer).Value = cp._urunturno;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            con.Close();
            return sonuc;
        }
        public bool urunlerCesitSil(int katID)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update kategoriler set durum=1 where id=@id", con);
            cmd.Parameters.Add("id", OleDbType.Integer).Value = katID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (OleDbException ex)
            {
                string hata = ex.Message;
                throw;
            }
            con.Close();
            return sonuc;
        }
        public override string ToString()
        {
            return Kategoriadi;
        }
    }
    
}
