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
    class cMasalar
    {
        #region Fields
        private int _idmasa;
        private int _kapasite;
        private int _servisturu;
        private int _durum;
        private bool _onay;
        private string _masaBilgi;
        #endregion
        #region Properties
        public int Idmasa
        {
            get { return _idmasa; }
            set { _idmasa = value; }
        }
        public int Kapasite
        {
            get { return _kapasite; }
            set { _kapasite = value; }
        }
        public int Servisturu
        {
            get { return _servisturu; }
            set { _servisturu = value; }
        }
        public int Durum
        {
            get { return _durum; }
            set { _durum = value; }
        }
        public bool Onay
        {
            get { return _onay; }
            set { _onay = value; }
        }
        public string MasaBilgi
        {
            get { return _masaBilgi; }
            set { _masaBilgi = value; }
        }
        #endregion
        baglanti bagl = new baglanti();
        public string SessionSum(int state,string masaid)
        {
            string dt = "";
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select tarih, masaid from adisyonlar Right Join masalar on adisyonlar.masaid=masalar.idmasa where masalar.durum=@durum and adisyonlar.durum=0 and masalar.idmasa=@idmasa ", con);
            OleDbDataReader dr = null;
            cmd.Parameters.Add("@durum", OleDbType.Integer).Value = state;
            cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = Convert.ToInt32(masaid);
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    dt = Convert.ToDateTime(dr["tarih"]).ToString();
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
            return dt;
        }
        public int TableGetByNumber(string TableValue)
        {
            if (TableValue.Length == 8)
            {
                return Convert.ToInt32(TableValue.Substring(TableValue.Length - 1, 1));
            }
            else if (TableValue.Length == 9)
            {
                return Convert.ToInt32(TableValue.Substring(TableValue.Length - 2, 2));
            }
            return 1;
        }
        public int kategoriSayisi()
        {
            int miktar = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select count(*) from kategoriler as sayi where durum=0", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                miktar = Convert.ToInt32(cmd.ExecuteScalar());
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
        public int TableGetByNumberRapor(string TableValue)
        {
            if (TableValue.Length == 5)
            {
                return Convert.ToInt32(TableValue.Substring(TableValue.Length - 1, 1));
            }
            else if (TableValue.Length == 6)
            {
                return Convert.ToInt32(TableValue.Substring(TableValue.Length - 2, 2));
            }
            return 1;
        }
        public bool TableGetByState(int ButtonName,int state)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select durum from masalar where idmasa=@idmasa and durum=@durum", con);
            cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = ButtonName;
            cmd.Parameters.Add("@durum", OleDbType.Integer).Value = state;
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
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        public void setChangeTableState(string btnName, int state)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update masalar set durum=@durum where idmasa=@idmasa", con);
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Parameters.Add("@durum", OleDbType.Integer).Value = state;
            if (btnName.Length == 8)
            {
                cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = btnName.Substring(btnName.Length - 1, 1);
            }
            else if (btnName.Length == 9)
            {
                cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = btnName.Substring(btnName.Length - 2, 2);
            }
            else if (btnName.Length == 10)
            {
                cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = btnName.Substring(btnName.Length - 2, 2);
            }
            if (btnName.Length == 1)
            {
                cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = btnName.Substring(btnName.Length - 1, 1);
            }
            else if (btnName.Length == 2)
            {
                cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = btnName.Substring(btnName.Length - 2, 2);
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public void setChangeTableKapasite(string btnName, int state)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update masalar set kapasite=@kapasite where idmasa=@idmasa", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Parameters.Add("@kapasite", OleDbType.Integer).Value = state;
            if (btnName.Length == 1)
            {
                cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = btnName.Substring(btnName.Length - 1, 1);
            }
            else if (btnName.Length == 2)
            {
                cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = btnName.Substring(btnName.Length - 2, 2);
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public void masaEkle(int state)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update masalar set durum=1 where idmasa=@idmasa", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = ++state;
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public void masaSil(int state)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Update masalar set durum=0 where idmasa=@idmasa", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.Parameters.Add("@idmasa", OleDbType.Integer).Value = state;
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }
        public int MasaCount()
        {
            int miktar = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select count(*) from masalar as sayi where durum=1 or durum=2 or durum=3 or durum=4", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                miktar = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void masaKapasitesiveDurumGetir(ComboBox cb)
        {
            cb.Items.Clear();
            string durum = "";
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from masalar", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cMasalar masa=new cMasalar();
               if(masa.Durum==2)
               {
                   durum = "Занят";
               }
               else if(masa.Durum==3)
               {
                   durum = "Бронирован";
               }
               masa._kapasite = Convert.ToInt32(dr["kapasite"]);
               masa._masaBilgi = "Стол №:" + dr["idmasa"].ToString()+" Место:"+ dr["kapasite"].ToString();
               masa._idmasa =Convert.ToInt32(dr["idmasa"]);
               cb.Items.Add(masa);
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public void masaKapasitesiveDurumGetirAyar(ComboBox cb)
        {
            cb.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from masalar where durum <> 0", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cMasalar masa = new cMasalar();
                masa._kapasite = Convert.ToInt32(dr["kapasite"]);
                masa._masaBilgi = "Стол №:" + dr["idmasa"].ToString() + " Место:" + dr["kapasite"].ToString();
                masa._idmasa = Convert.ToInt32(dr["idmasa"]);
                cb.Items.Add(masa);
            }
            dr.Close();
            con.Dispose();
            con.Close();
        }
        public override string ToString()
        {
            return MasaBilgi;
        }
    }
}
