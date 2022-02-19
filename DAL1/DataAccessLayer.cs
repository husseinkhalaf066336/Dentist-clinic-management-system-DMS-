using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dentis.DAL1
{
    class DataAccessLayer
    {
        SqlConnection sqlconn;

        //this constructor inisialise the connection object
        public DataAccessLayer()
        {
           // sqlconn = new SqlConnection("Server=HUSSEIN-PC ; Database=dentist1 ;Integrated Security=true");

            string mode = Properties.Settings.Default.mode;
            if (mode == "SQL")
            {
                sqlconn = new SqlConnection("Server=" + Properties.Settings.Default.server +
                                         " ; Database=" + Properties.Settings.Default.databas +
                                         " ;Integrated Security=fals; User ID ="+Properties .Settings.Default .id +
                                          ";password="+Properties .Settings .Default .pass +"");
            }
            else
            {
                sqlconn = new SqlConnection("Server=" + Properties.Settings.Default.server + " ; Database=" + Properties.Settings.Default.databas + " ;Integrated Security=true");
            }

        }


        //method to open connection 
        public void open()
        {
            if (sqlconn.State != ConnectionState.Open)
            { sqlconn.Open(); }
        }

        //method to close connection 
        public void close()
        {
            if (sqlconn.State != ConnectionState.Closed )
            { sqlconn.Close (); }
        }


        //method to read data from database
        //دور هذا   الاجراء  قراءة البيانات المرجودة في قاعدة البيانات 
        //يستقبل اسم الاجراء المخزن ويستقبل بارامترات الاجراء المخزن 

        public DataTable selectdata(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcom = new SqlCommand(); //sqlcommand of execut stored procedure command   (نحدد نوع الامر (كومند
            sqlcom.CommandType = CommandType.StoredProcedure; //type command of the stored procedureنص هذا المر هو نفسه نص الاجراء المخزن 
            sqlcom.CommandText = stored_procedure;//text command 
            sqlcom.Connection = sqlconn;
            if (param != null)//نتحقق هل يوجد بارمترات ام لايوجد 
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcom.Parameters.Add(param [i]);//add parameter to sqlcommand
                }

            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcom); //داتا ادابتر مكلف بتنفيذ سكول كومند 
            DataTable dt = new DataTable();//ننشئ داتا تيبل لنضع نتيجة ادابتر به 
            da.Fill(dt);//للتعبئة في الداتا تيل
            return dt;

        }
        //method to insert and updat and delete data from database
        //هنا لانحتاج الى دالة فانكشن وانما سنستخدم اجراء بروسجر  فويد 
        public void executecommand(string stord_procedure ,SqlParameter []param)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom .CommandType=CommandType.StoredProcedure;
            sqlcom.CommandText = stord_procedure;
            sqlcom.Connection = sqlconn;
            if (param != null)
            {
                sqlcom.Parameters.AddRange(param);//الفرق بين اد واد رينج هو ان الاولى تضيف عنصر واحد بيد ان الثانية تضيف مصفوفة من العناصر ولذالك استغنينا عن الحلقة التكرارية 
            }
            sqlcom.ExecuteNonQuery();
        }
    }
}
