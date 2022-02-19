using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dentis.PL1
{
    class Class_login
    {

        public DataTable login(string username, string userpass, string user_type)
        {
            DAL1.DataAccessLayer DAL1 = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@USNAME", SqlDbType.VarChar, 50);
            param[0].Value = username;

            param[1] = new SqlParameter("@USPASS", SqlDbType.VarChar, 50);
            param[1].Value = userpass;

            param[2] = new SqlParameter("@user_type", SqlDbType.VarChar, 50);
            param[2].Value = user_type;

            DAL1.open();
            DataTable dt = new DataTable();
            dt = DAL1.selectdata("SP_LOGIN", param);
            DAL1.close();
            return dt;

        }

        public void add_user(string user_name, string user_pass, string user_type)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            param[0].Value = user_name;

            param[1] = new SqlParameter("@user_pass", SqlDbType.NVarChar, 50);
            param[1].Value = user_pass;

            param[2] = new SqlParameter("@user_type", SqlDbType.NVarChar, 50);
            param[2].Value = user_type;


            DAL.executecommand("add_user", param);
            DAL.close();


        }
        public DataTable serch_user(string word)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            param[0].Value = word;

            DataTable dt = new DataTable();
            dt = DAL.selectdata("serch_user", param);
            DAL.close();
            return dt;

        }
        public void delet_user(string id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;



            DAL.executecommand("delet_user", param);
            DAL.close();

        }

        public void edet_user(string name, string pass, string type)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@pass", SqlDbType.NVarChar, 50);
            param[1].Value = pass;

            param[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            param[2].Value = type;


            DAL.executecommand("edet_user", param);
            DAL.close();


        }
        public DataTable chekh_user(string name)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            DataTable dt = new DataTable();
            dt = DAL.selectdata("chekh_user", param);
            DAL.close();
            return dt;

        }
        public DataTable show_user()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("show_user", null);
            DAL.close();
            return dt;

        }


    }
}