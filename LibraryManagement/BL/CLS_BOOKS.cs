using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManagement.BL
{
    class CLS_BOOKS
    {
        DataAcsisLayer.CLS_DAL DAL = new DataAcsisLayer.CLS_DAL();
        //Load
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKS", pr);
            return dt;
        }
        // Combobox
        public DataTable LOADCAT()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCATTOCOMBOBOX", pr);
            return dt;
        }
        // Insert Date
        public void Insert(string TITLE, string AUTHER, string CAT, string PRICE, string BDATE, int RATE, MemoryStream COVER)
        {
            SqlParameter[] pr = new SqlParameter[7];
            pr[0] = new SqlParameter("TITLE", TITLE);
            pr[1] = new SqlParameter("AUTHER", AUTHER);
            pr[2] = new SqlParameter("CAT", CAT);
            pr[3] = new SqlParameter("PRICE", PRICE);
            pr[4] = new SqlParameter("BDATE", BDATE);
            pr[5] = new SqlParameter("RATE", RATE);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            DAL.Open();
            DAL.Excute("PR_INSERTBOOKS", pr);
            DAL.Close();
        }
        //Load Date for edit
        public DataTable LoadEdit(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEEDITBOOK", pr);
            return dt;
        }
        // Update Date
        public void update(string TITLE, string AUTHER, string CAT, string PRICE, string BDATE, int RATE, MemoryStream COVER, int ID)
        {
            SqlParameter[] pr = new SqlParameter[8];

            pr[0] = new SqlParameter("TITLE", TITLE);
            pr[1] = new SqlParameter("AUTHER", AUTHER);
            pr[2] = new SqlParameter("CAT", CAT);
            pr[3] = new SqlParameter("PRICE", PRICE);
            pr[4] = new SqlParameter("BDATE", BDATE);
            pr[5] = new SqlParameter("RATE", RATE);
            pr[6] = new SqlParameter("COVER", COVER.ToArray());
            pr[7] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PREDITBOOKS", pr);
            DAL.Close();
        }
        // Delete Date
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("P_DELETEBOOKS", pr);
            DAL.Close();
        }
        //Search
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", Search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_BOOKSSEARCH", pr);
            return dt;
        }
    }
}
