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
    class cPersonelHareketleri
    {
        #region Fields
        private int _id;
        private int _personelid;
        private string _islem;
        private DateTime _tarih;
        private bool _personeldurum; 
        #endregion
        #region Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Personelid
        {
            get { return _personelid; }
            set { _personelid = value; }
        }
        public string Islem
        {
            get { return _islem; }
            set { _islem = value; }
        }
        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }
        public bool Personeldurum
        {
            get { return _personeldurum; }
            set { _personeldurum = value; }
        }  
        #endregion
        baglanti bagl = new baglanti();
        public bool personelActionSave(cPersonelHareketleri cph)
        {
            bool result = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into persharaket(personelid,islem,tarih)Values(@personelid,@islem,@tarih)", con);
            
            try 
	        {	        
		          if(con.State==ConnectionState.Closed)
                  {
                      con.Open();
                  }
                cmd.Parameters.Add("@personelid",OleDbType.Integer).Value=cph._personelid;
                cmd.Parameters.Add("@islem",OleDbType.VarChar).Value=cph._islem;
                cmd.Parameters.Add("@tarih",OleDbType.Date).Value=cph._tarih;
                
                result =Convert.ToBoolean(cmd.ExecuteNonQuery());
	        }
	        catch (OleDbException ex)
	        {
                string hata = ex.Message;
	         	throw;
	        }
            return result;
        }
    }
}
