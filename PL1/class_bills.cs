using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dentis.PL1
{
    class class_bills
    {
        public DataTable show_id_orderr()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("show_id_orderr", null);
            DAL.close();
            return dt;

        }

        public void Add_order1(DateTime date_order, string des, string tc_pateint)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@date_order", SqlDbType.DateTime);
            param[0].Value = date_order;

            param[1] = new SqlParameter("@descrition_order", SqlDbType.NVarChar, 50);
            param[1].Value = des;

            param[2] = new SqlParameter("@TC_PATEINT", SqlDbType.NVarChar, 50);
            param[2].Value = tc_pateint;


            DAL.executecommand("Add_order", param);
            DAL.close();


        }

        public void add_order_datals(string state_id, int order_id, int qte, string pric, double discount, string amount ,string total_amount
            
           , string numper_total, string numper_was, string numper_paq)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@state_id", SqlDbType.NVarChar, 50);
            param[0].Value = state_id;

            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = order_id;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@pric", SqlDbType.NVarChar, 50);
            param[3].Value = pric;

            param[4] = new SqlParameter("@discount", SqlDbType.Float);
            param[4].Value = discount;

            param[5] = new SqlParameter("@amount", SqlDbType.NVarChar, 50);
            param[5].Value = amount;

            param[6] = new SqlParameter("@total_amount", SqlDbType.NVarChar, 50);
            param[6].Value = total_amount;

            param[7] = new SqlParameter("@numper_total", SqlDbType.NVarChar, 50);
            param[7].Value = numper_total;

            param[8] = new SqlParameter("@numper_was", SqlDbType.NVarChar, 50);
            param[8].Value = numper_was;

            param[9] = new SqlParameter("@numper_paq", SqlDbType.NVarChar, 50);
            param[9].Value = numper_paq;

            DAL.executecommand("add_order_datals", param);
            DAL.close();


        }

        public DataTable last_order_print()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("last_order_print", null);
            DAL.close();
            return dt;

        }
        public DataTable get_order_detils(int id_or)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_or;

            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_order_detils", param);
            DAL.close();
            return dt;

        }
        public DataTable serch_order(string word)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@word", SqlDbType.NVarChar, 50);
            param[0].Value = word;

            DataTable dt = new DataTable();
            dt = DAL.selectdata("serch_order", param);
            DAL.close();
            return dt;

        }
        public void dlete_order(int id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DAL.executecommand("dlete_order", param);
            DAL.close();

        }

        public DataTable sow_order()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sow_order", null);
            DAL.close();
            return dt;
        }

        public DataTable serch_datils_order(string word)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@word", SqlDbType.NVarChar, 50);
            param[0].Value = word;

            DataTable dt = new DataTable();
            dt = DAL.selectdata("serch_datils_order", param);
            DAL.close();
            return dt;

        }

        public void edet_detals_order(int  order_id, string numper_total , string numper_was, string numper_paq)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@order_id ", SqlDbType.Int);
            param[0].Value = order_id;

            param[1] = new SqlParameter("@numper_total ", SqlDbType.NVarChar, 50);
            param[1].Value = numper_total;

            param[2] = new SqlParameter("@numper_was", SqlDbType.NVarChar, 50);
            param[2].Value = numper_was;

            param[3] = new SqlParameter("@numper_paq", SqlDbType.NVarChar, 50);
            param[3].Value = numper_paq;



            DAL.executecommand("edet_detals_order", param);
            DAL.close();


        }
        public void date_order(int id_order, DateTime date_ord)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id_order ", SqlDbType.Int);
            param[0].Value = id_order;

            param[1] = new SqlParameter("@date_ord ", SqlDbType.DateTime);
            param[1].Value = date_ord;

           


            DAL.executecommand("date_order", param);
            DAL.close();


        }
        public DataTable VEIU_DATAILS_ORDER(int id_order)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            DataTable dt = new DataTable();
            dt = DAL.selectdata("VEIU_DATAILS_ORDER", param);
            DAL.close();
            return dt;

        }

        public DataTable show_ditails()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("show_ditails", null);
            DAL.close();
            return dt;
        }

        public DataTable serch_order_datils_1(string word)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@word", SqlDbType.NVarChar, 50);
            param[0].Value = word;

            DataTable dt = new DataTable();
            dt = DAL.selectdata("serch_order_datils_1", param);
            DAL.close();
            return dt;

        }

    }
}
