using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dentis.PL1
{
    class class_syudy
    {
        public DataTable show_id_study()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("show_id_study", null);
            DAL.close();
            return dt;

        }
        public void add_study(string type, string date, string TC_PATEINT, string notes )
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            param[0].Value = type;

            param[1] = new SqlParameter("@date", SqlDbType.NVarChar);
            param[1].Value = date;

            param[2] = new SqlParameter("@TC_PATEINT", SqlDbType.NVarChar, 50);
            param[2].Value = TC_PATEINT;

            param[3] = new SqlParameter("@notes", SqlDbType.NVarChar, 50);
            param[3].Value = notes;

        

            DAL.executecommand("add_study", param);
            DAL.close();


        }
        public DataTable getallstudy()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("getallstudy", null);
            DAL.close();
            return dt;

        }

        public void delet_study(int id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id ", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            DAL.executecommand("delet_study", param);
            DAL.close();


        }

        public DataTable serch_studyyy(string id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@word", SqlDbType.NVarChar , 50);
            param[0].Value = id;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("serch_studyyy", param);
            DAL.close();
            return dt;
        }

        public DataTable show_study()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("show_study", null);
            DAL.close();
            return dt;

        }

        public DataTable get_imade_studt(int id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_imade_studt", param);
            DAL.close();
            return dt;

        }



    }
}
