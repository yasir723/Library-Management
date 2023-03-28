using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.BL
{
    class CLS_SELL
    {
        DataAcsisLayer.CLS_DAL DAL = new DataAcsisLayer.CLS_DAL();
        //Load
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSELL", pr);
            return dt;
        }
        //Load FOR SELL THE BOOKS
        public DataTable LoadBOOKS()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADBOOKFORSELL", pr);
            return dt;
        }
        //Load FOR CHOSE THE STUDENT
        public DataTable LoadST()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADSTFORSELL", pr);
            return dt;
        }
        // Insert Date
        public void Insert(string SNAME, string BTITLE, int PRICE, string EDATE)
        {
            SqlParameter[] pr = new SqlParameter[4];
            pr[0] = new SqlParameter("SNAME", SNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("PRICE", PRICE);
            pr[3] = new SqlParameter("EDATE", EDATE);
            DAL.Open();
            DAL.Excute("PR_INSERTSELL", pr);
            DAL.Close();
        }
        // UPDATE Date
        public void Update(string SNAME, string BTITLE, int PRICE, string EDATE,int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("SNAME", SNAME);
            pr[1] = new SqlParameter("BTITLE", BTITLE);
            pr[2] = new SqlParameter("PRICE", PRICE);
            pr[3] = new SqlParameter("EDATE", EDATE);
            pr[4] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PR_UPDATESELL", pr);
            DAL.Close();
        }
        // Delete Date
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PR_SELLDELETE", pr);
            DAL.Close();
        }
        //Search
        public DataTable Search(string Search)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("SEARCH", Search);
            DataTable dt = new DataTable();
            dt = DAL.read("P_SELLSEARCH", pr);
            return dt;
        }
    }
}
