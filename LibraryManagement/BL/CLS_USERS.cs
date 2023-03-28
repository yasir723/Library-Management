using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagement.BL
{
    class CLS_USERS
    {
        DataAcsisLayer.CLS_DAL DAL = new DataAcsisLayer.CLS_DAL();
        //Load
        public DataTable Load()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOADUSER", pr);
            return dt;
        }
        // Insert Date
        public void Insert(string CNAME, string CUSER, string CPASSWORD, string CPREM, String CSTATE)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("CSTATE", CSTATE);
            DAL.Open();
            DAL.Excute("PR_INSERTUSER", pr);
            DAL.Close();
        }
        // UPDATE Date
        public void Update(string CNAME, string CUSER, string CPASSWORD, string CPREM, int ID)
        {
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("CNAME", CNAME);
            pr[1] = new SqlParameter("CUSER", CUSER);
            pr[2] = new SqlParameter("CPASSWORD", CPASSWORD);
            pr[3] = new SqlParameter("CPREM", CPREM);
            pr[4] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PR_EDITUSER", pr);
            DAL.Close();
        }
        public DataTable LoadEdit(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_SELECTEEDITUSER", pr);
            return dt;
        }
        // Delete Date
        public void Delete(int ID)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("ID", ID);
            DAL.Open();
            DAL.Excute("PR_USERSDELETE", pr);
            DAL.Close();
        }
        // Log out
        public void Logout()
        {
            SqlParameter[] pr = null;
            DAL.Open();
            DAL.Excute("PR_LOGOUT", pr);
            DAL.Close();
        }
        //Load DATA FOR LOGIN
        public DataTable Login(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DataTable dt = new DataTable();
            dt = DAL.read("PR_LOGIN", pr);
            return dt;
        }
        // UPDATE Date FOR LOGIN
        public void UpdateLogin(string CUSER, string CPASSWORD)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("CUSER", CUSER);
            pr[1] = new SqlParameter("CPASSWORD", CPASSWORD);
            DAL.Open();
            DAL.Excute("PR_UPDATELOGIN", pr);
            DAL.Close();

        }
        //Load FOR CHECK START
        public DataTable StartLoadDate()
        {
            SqlParameter[] pr = null;
            DataTable dt = new DataTable();
            dt = DAL.read("PR_START", pr);
            return dt;
        }
    }
}
