using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace school
{
    class veritabani
    {
        static string veritabaniadi = "okul.accdb";
        static string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\"+veritabaniadi;
        OleDbConnection baglan = new OleDbConnection(baglanti);

        public int kayitIslem(OleDbCommand komut)
        {
            int sonuc = 0;
            try
            {
                try
                {
                    baglan.Open();
                }
                catch
                {
                    baglan.Close();
                    baglan.Open();
                }
                komut.Connection = baglan;
                sonuc = komut.ExecuteNonQuery();
            }
            catch
            {
                sonuc = -1;
            }
            finally
            {
                baglan.Close();
            }
            return sonuc;
        }

        public DataTable veriAl(string sql)
        {
            try
            {
                baglan.Open();
            }
            catch
            {
                baglan.Close();
                baglan.Open();
            }
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, baglan);
            DataSet dshasta = new DataSet();
            adapter.Fill(dshasta);
            baglan.Close();
            return dshasta.Tables[0];
        }

        public DataTable veriara(string sql,string where)
        {
            try
            {
                baglan.Open();
            }
            catch
            {
                baglan.Close();
                baglan.Open();
            }
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql + where, baglan);
            DataSet dshasta = new DataSet();
            adapter.Fill(dshasta);
            baglan.Close();
            return dshasta.Tables[0];
        }
    }
}
