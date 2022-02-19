using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dentis.PL1
{
    class Class_patient
    {

        public void add_patient(string tc, string name, string   age, string gender,string phon, byte[] imag)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@tc_patien", SqlDbType.NVarChar, 50);
            param[0].Value = tc;

            param[1] = new SqlParameter("@name_patien", SqlDbType.NVarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@age_patien", SqlDbType.NVarChar, 50);
            param[2].Value = age;

            param[3] = new SqlParameter("@gender_patien", SqlDbType.NVarChar, 50);
            param[3].Value = gender;

            param[4] = new SqlParameter("@phon_patien", SqlDbType.NVarChar, 50);
            param[4].Value = phon;

            param[5] = new SqlParameter("@image_patien", SqlDbType.Image);
            param[5].Value = imag;
            DAL.executecommand("add_patientt", param);
            DAL.close();


        }

        public DataTable chech_tc(string id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@tc", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("check_tc", param);
            DAL.close();
            return dt;
        }

        
        public DataTable SHOW_PATIENT()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("SHOW_PATIENT", null);
            DAL.close();
            return dt;
        }

        public DataTable get_all_pateint()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_all_pateint", null);
            DAL.close();
            return dt;
        }

        public DataTable get_imade_pat(int  id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int );
            param[0].Value = id;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_imade_pat", param);
            DAL.close();
            return dt;
        }


        public void edit_patient(string tc, string name, string age, string gender, string phon, byte[] imag, int  id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@tc_patien", SqlDbType.NVarChar, 50);
            param[0].Value = tc;

            param[1] = new SqlParameter("@name_patien", SqlDbType.NVarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@age_patien", SqlDbType.NVarChar, 50);
            param[2].Value = age;

            param[3] = new SqlParameter("@gender_patien", SqlDbType.NVarChar, 50);
            param[3].Value = gender;

            param[4] = new SqlParameter("@phon_patien", SqlDbType.NVarChar, 50);
            param[4].Value = phon;

            param[5] = new SqlParameter("@image_patien", SqlDbType.Image);
            param[5].Value = imag;

            param[6] = new SqlParameter("@id", SqlDbType.Int );
            param[6].Value = id;

            DAL.executecommand("edit_patient", param);
            DAL.close();


        }

        public void delet_pat(int id)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int );
            param[0].Value = id;

    

            DAL.executecommand("delet_pat", param);
            DAL.close();


        }

        public DataTable search_patein(string s)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            DataTable dt = new DataTable();
            SqlParameter[] param=new SqlParameter[1];

            param[0] = new SqlParameter("@s", SqlDbType.NVarChar , (50));
            param[0].Value = s;
            dt = DAL.selectdata("search_patein", param );
            DAL.close();
            return dt;
        }


        public DataTable show_id_pat()
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();

            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("show_id_pat", null);
            DAL.close();
            return dt;
        }


        public void add_pic(int id_patien, byte[] pic1, byte[] pic2, byte[] pic3, byte[] pic4, byte[] pic5,
                                            byte[] pic6 , byte[] pic7 , byte[] pic8 , byte[] pic9 , byte[] pic10)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@id_patein", SqlDbType.Int);
            param[0].Value = id_patien;

            param[1] = new SqlParameter("@pic1", SqlDbType.Image);
            param[1].Value = pic1;

            param[2] = new SqlParameter("@pic2", SqlDbType.Image);
            param[2].Value = pic2;

            param[3] = new SqlParameter("@pic3", SqlDbType.Image);
            param[3].Value = pic3;

            param[4] = new SqlParameter("@pic4", SqlDbType.Image);
            param[4].Value = pic4;

            param[5] = new SqlParameter("@pic5", SqlDbType.Image);
            param[5].Value = pic5;

            param[6] = new SqlParameter("@pic6", SqlDbType.Image);
            param[6].Value = pic6;

            param[7] = new SqlParameter("@pic7", SqlDbType.Image);
            param[7].Value = pic7;

            param[8] = new SqlParameter("@pic8", SqlDbType.Image);
            param[8].Value = pic8;

            param[9] = new SqlParameter("@pic9", SqlDbType.Image);
            param[9].Value = pic9;


            param[10] = new SqlParameter("@pic10", SqlDbType.Image);
            param[10].Value = pic10;

            DAL.executecommand("add_pic", param);
            DAL.close();


        }
        public DataTable get_picter_of_patient(int id_pic_image)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_pic_image", SqlDbType.Int);
            param[0].Value = id_pic_image;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_picter_of_patient", param);
            DAL.close();
            return dt;
        }
        public DataTable get_order_datales_of_the_pateint(int @id_pateint)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_pateint", SqlDbType.Int);
            param[0].Value = @id_pateint;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_order_datales_of_the_pateint", param);
            DAL.close();
            return dt;
        }
        public void edit_pic_of_pateint(int id_patien, byte[] pic1, byte[] pic2, byte[] pic3, byte[] pic4, byte[] pic5,
                                    byte[] pic6, byte[] pic7, byte[] pic8, byte[] pic9, byte[] pic10)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@id_patein", SqlDbType.Int);
            param[0].Value = id_patien;

            param[1] = new SqlParameter("@pic1", SqlDbType.Image);
            param[1].Value = pic1;

            param[2] = new SqlParameter("@pic2", SqlDbType.Image);
            param[2].Value = pic2;

            param[3] = new SqlParameter("@pic3", SqlDbType.Image);
            param[3].Value = pic3;

            param[4] = new SqlParameter("@pic4", SqlDbType.Image);
            param[4].Value = pic4;

            param[5] = new SqlParameter("@pic5", SqlDbType.Image);
            param[5].Value = pic5;

            param[6] = new SqlParameter("@pic6", SqlDbType.Image);
            param[6].Value = pic6;

            param[7] = new SqlParameter("@pic7", SqlDbType.Image);
            param[7].Value = pic7;

            param[8] = new SqlParameter("@pic8", SqlDbType.Image);
            param[8].Value = pic8;

            param[9] = new SqlParameter("@pic9", SqlDbType.Image);
            param[9].Value = pic9;


            param[10] = new SqlParameter("@pic10", SqlDbType.Image);
            param[10].Value = pic10;

            DAL.executecommand("edit_picter_patient", param);
            DAL.close();


        }
        public void Add_doctor_note(int id_pateint, string the_note)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id_pateint", SqlDbType.Int);
            param[0].Value = id_pateint;

            param[1] = new SqlParameter("@the_note", SqlDbType.NVarChar);
            param[1].Value = the_note;

            DAL.executecommand("add_doctoer_notes", param);
            DAL.close();


        }
        public DataTable get_doctor_notes_of_pateint(int id_pateint_notes)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_pateint_notes", SqlDbType.Int);
            param[0].Value = id_pateint_notes;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_doctor_notes_of_pateint", param);
            DAL.close();
            return dt;
        }
        public void edit_doctor_notes(int id_patient_notes, string note)
        {
            DAL1.DataAccessLayer DAL = new DAL1.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id_patient_notes ", SqlDbType.Int);
            param[0].Value = id_patient_notes;

            param[1] = new SqlParameter("@note", SqlDbType.NVarChar);
            param[1].Value = note;

            DAL.executecommand("edit_doctor_notes", param);
            DAL.close();


        }

    }
}
