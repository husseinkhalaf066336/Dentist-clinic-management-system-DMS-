using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data ;
using System.Data .SqlClient ;


namespace dentis.PL1
{
    class Class_state
    {


        public void add_state(string id_state, string name_state, string cost_state, string dis_state, byte[] image)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id_state", SqlDbType.NVarChar, 50);
            param[0].Value = id_state;

            param[1] = new SqlParameter("@name_state", SqlDbType.NVarChar, 50);
            param[1].Value = name_state;

            param[2] = new SqlParameter("@cost_stat", SqlDbType.NVarChar, 50);
            param[2].Value = cost_state;

            param[3] = new SqlParameter("@discrabtion_state", SqlDbType.NVarChar, 50);
            param[3].Value = dis_state;


            param[4] = new SqlParameter("@image_state", SqlDbType.Image );
            param[4].Value = image;
            DAL.executecommand("add_state", param);
            DAL.close();

          
        }


        public DataTable chech_id(string id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_state", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("check_id", param);
            DAL.close();
            return dt;
        }


        public DataTable grt_all_state( )
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_all_states1", null);
            DAL.close();
            return dt;
        }


        public DataTable serch_state(string id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("serch_state", param);
            DAL.close();
            return dt;
        }


        public void delet_state(string id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_state", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            DAL.executecommand("delet_state", param);
            DAL.close();


        }


        public DataTable get_image_state(string id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_imade_state", param);
            DAL.close();
            return dt;
        }


        public void update_state(string id_state, string name_state, string cost_state, string dis_state, byte[] image)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id_state", SqlDbType.NVarChar, 50);
            param[0].Value = id_state;

            param[1] = new SqlParameter("@name_state", SqlDbType.NVarChar, 50);
            param[1].Value = name_state;

            param[2] = new SqlParameter("@cost_stat", SqlDbType.NVarChar, 50);
            param[2].Value = cost_state;

            param[3] = new SqlParameter("@discrabtion_state", SqlDbType.NVarChar, 50);
            param[3].Value = dis_state;


            param[4] = new SqlParameter("@image_state", SqlDbType.Image);
            param[4].Value = image;
            DAL.executecommand("update_state", param);
            DAL.close();


        }


        public DataTable SHOW_State()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("SHOW_State", null);
            DAL.close();
            return dt;
        }

    }
}
