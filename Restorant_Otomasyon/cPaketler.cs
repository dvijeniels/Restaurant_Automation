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
    class cPaketler
    {
        #region Fields
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _additionid;

        public int Additionid
        {
            get { return _additionid; }
            set { _additionid = value; }
        }
        private int _clientid;

        public int Clientid
        {
            get { return _clientid; }
            set { _clientid = value; }
        }
        private string _descriptionid;

        public string Descriptionid
        {
            get { return _descriptionid; }
            set { _descriptionid = value; }
        }
        private int _state;

        public int State
        {
            get { return _state; }
            set { _state = value; }
        }
        private int _payTypeid;

        public int PayTypeid
        {
            get { return _payTypeid; }
            set { _payTypeid = value; }
        } 
        #endregion
        baglanti bagl = new baglanti();
        public bool OrderServiceEkleme(cPaketler order)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("iNSERT into paketsiparis(musteriid,adisyonid,odemeturid,aciklama)values(@musteriid,@adisyonid,@odemeturid,@aciklama)", con);
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = order._clientid;
                cmd.Parameters.Add("@adisyonid", OleDbType.Integer).Value = order._additionid;
                cmd.Parameters.Add("@odemeturid", OleDbType.Integer).Value = order._payTypeid;
                cmd.Parameters.Add("@aciklama", OleDbType.VarChar).Value = order._descriptionid;
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
        public void OrderServiceKapatma(int AdditionID)
        {
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("UPDATE paketsiparis set paketsiparis.durum=1 where paketsiparis.adisyonid=@adisyonid", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonid", OleDbType.Integer).Value = AdditionID;
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
        public int OdemeTurIdGetir(int Addisyonid)
        {
            int odemeturid = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select paketsiparis.odemeturid from adisyonlar INNER JOIN paketsiparis on adisyonlar.adisiyonid = paketsiparis.adisyonid WHERE (((adisyonlar.adisiyonid)=@adisiyonid))", con);
            cmd.Parameters.Add("@adisiyonid", OleDbType.Integer).Value = Addisyonid;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                odemeturid=Convert.ToInt32(cmd.ExecuteScalar());
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
            return odemeturid;
        }
        public void paketMusteriIDGetir(ListView lv)
        {
            lv.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select musteriid from paketsiparis where durum=0", con);
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
                    lv.Items.Add(dr["musteriid"].ToString());
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
        public int musteriSonAddisyonidGetir(int musteriId)
        {
            int no = 0;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select Adisyonlar.adisiyonid from Adisyonlar INER JOIN paketsiparis on paketsiparis.adisyonid=Adisyonlar.adisiyonid where (Adisyonlar.durum=0) and (paketsiparis.durum=0) and paketsiparis.musteriid=@musteriid", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriid", OleDbType.Integer).Value = musteriId;
                no = Convert.ToInt32(cmd.ExecuteScalar());
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
            return no;
        }
        public bool getCheckOpenAdditionID(int Additioonid)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from adisyonlar where (durum=0) and (adisiyonid=@adisiyonid)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisiyonid", OleDbType.Integer).Value = Additioonid;
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
    }
}
