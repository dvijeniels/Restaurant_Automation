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
    class cPersonelGorev
    {
        baglanti bagl = new baglanti();
        #region Properties
        private int _personelgorevid;
        private string _tanim;
        public int Personelgorevid
        {
            get { return _personelgorevid; }
            set { _personelgorevid = value; }
        }
        public string Tanim
        {
            get { return _tanim; }
            set { _tanim = value; }
        } 
        #endregion
        public void PersonelGorevGetir(ComboBox cb)
        {
            cb.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select * from gorevler", con);
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
                    cPersonelGorev c = new cPersonelGorev();
                    c._personelgorevid =Convert.ToInt32( dr["gorevid"].ToString());
                    c._tanim = dr["gorev"].ToString();
                    cb.Items.Add(c);
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
        public void PersonelGorevSil(ComboBox cb,int gorevID)
        {
            cb.Items.Clear();
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Delete from gorevler where gorevid=@gorevid", con);
            cmd.Parameters.Add("gorevid", OleDbType.Integer).Value = gorevID;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
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
        public bool personelGorevEkle(cPersonelGorev cp)
        {
            bool sonuc = false;
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Insert into gorevler (gorev) values (@gorev)", con);
            cmd.Parameters.Add("gorev", OleDbType.VarChar).Value = cp._tanim;
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
        public string PersonelGorevTanim(int pers)
        {
            string result="";
            OleDbConnection con = new OleDbConnection(bagl.baglan);
            OleDbCommand cmd = new OleDbCommand("Select gorev from gorevler where gorevid=@gorevid", con);
            cmd.Parameters.Add("gorevid", OleDbType.Integer).Value = pers;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToString(cmd.ExecuteScalar());
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
        public override string ToString()
        {
            return _tanim;
        }

    }
}
