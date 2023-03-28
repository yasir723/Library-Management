using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.BL
{
    class CLS_CAT
    {
        DataAcsisLayer.CLS_DAL DAL = new DataAcsisLayer.CLS_DAL();
        //Load
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADCAT", pr);
            return dt;
        }
        // SEARCH
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH",Search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_CATSEARCH", pr);
            return dt;
        }
        // Insert Date
        public void Insert(string CAT_NAME)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            DAL.Open();
            DAL.Excute("P_ADDCAT", pr);
            DAL.Close();
        }
        // Update Date
        public void update(string CAT_NAME, int ID)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CAT_NAME", CAT_NAME);
            pr[1] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("P_EDITCAT", pr);
            DAL.Close();
        }
        // Delete Date
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("P_DELETECAT", pr);
            DAL.Close();
        }
    }
}
