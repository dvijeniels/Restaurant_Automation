using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Restorant_Otomasyon
{
    class cOdeme
    {
        #region Fields
        private int _odemeid;
        private int _adisyonid;
        private double _aratoplam;
        private double _indirim;
        private double _kdvtutari;
        private double _geneltoplam;
        private DateTime _tarih;
        private int _musteriid; 
        #endregion
        #region Properties
        public int Odemeid
        {
            get { return _odemeid; }
            set { _odemeid = value; }
        }
        public int Adisyonid
        {
            get { return _adisyonid; }
            set { _adisyonid = value; }
        }
        public double Aratoplam
        {
            get { return _aratoplam; }
            set { _aratoplam = value; }
        }
        public double Indirim
        {
            get { return _indirim; }
            set { _indirim = value; }
        }
        public double Kdvtutari
        {
            get { return _kdvtutari; }
            set { _kdvtutari = value; }
        }
        public double Geneltoplam
        {
            get { return _geneltoplam; }
            set { _geneltoplam = value; }
        }
        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }
        public int Musteriid
        {
            get { return _musteriid; }
            set { _musteriid = value; }
        } 
        #endregion
        baglanti bagl = new baglanti();
        public bool oplataZakaza(cOdeme bill)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into hesapodemeleri(adisiyonid,odemeturid,musteriid,aratoplam,kdvtutari,indirim,toplamtutar,tarih)values(@adisiyonid,@odemeturid,@musteriid,@aratoplam,@kdvtutari,@indirim,@toplamtutar,@tarih)", con);
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisiyonid", OleDbType.Integer).Value = bill._adisyonid;
                cmd.Parameters.Add("@odemeturid", OleDbType.Integer).Value = bill._odemeid;
                cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = bill._musteriid;
                cmd.Parameters.Add("@aratoplam", OleDbType.Double).Value = bill._aratoplam;
                cmd.Parameters.Add("@kdvtutari", OleDbType.Double).Value = bill._kdvtutari;
                cmd.Parameters.Add("@indirim", OleDbType.Double).Value = bill._indirim;
                cmd.Parameters.Add("@toplamtutar", OleDbType.Double).Value = bill._geneltoplam;
                cmd.Parameters.Add("@tarih", OleDbType.Date).Value = DateTime.Now;
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
        public double sumTotalforClientid(int clientID)
        {
            double total = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select sum(toplamtutar) as total from hesapodemeleri where musteriid=@musteriid)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = clientID;
                total = Convert.ToDouble(cmd.ExecuteNonQuery());
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
            return total;
        }
    }
}
