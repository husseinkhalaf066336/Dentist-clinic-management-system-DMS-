using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentis
{
    public partial class Form_HOME : Form
    {
        Form_new_pateint Form_new_pateint = new Form_new_pateint();
        Form_manegmet_patient Form_manegmet_patient = new Form_manegmet_patient();
        Form_new_state_ Form_new_state_ = new Form_new_state_();
        Form_manegnent_state_cs Form_manegnent_state_cs = new Form_manegnent_state_cs();
        Forme_bills1 Forme_bills1 = new Forme_bills1();
        Form_order_list Form_order_list = new Form_order_list();
        study study = new study();
        form_user form_user = new form_user();
        Form_server_config Form_server_config = new Form_server_config();
        public Form_HOME()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(253, 253, 253);
            patent.color = Color.FromArgb(30, 144, 255);

            btn_add_patient.Visible = true;
            btn_mng_pa.Visible = true;
            btn_add_empl.Visible = false;
            //btn_mng_empl.Visible = false;
            btn_add_sta.Visible = false;
            btn_mng_sta.Visible = false;
            btn_cal_fi.Visible = false;
            btn_study.Visible=true ;
            btn_cal_fi.Visible = false;
            bunifuTileButton2.Visible = false;



            doctor1.Visible = true;
            teeth2.Visible = true;
            doctor2.Visible = false;
            doctor3.Visible = false;
            pic_emp.Visible = false;
            pic_com.Visible = false;
            btn_cal.Visible = false;
            pictureBox_cal.Visible = false;
        }

        private void patent_Click(object sender, EventArgs e)
        {
            patent.color = Color.FromArgb(30, 144, 255);
            btn_empl.color = Color.FromArgb(0, 139, 200);
            btn_state.color = Color.FromArgb(0, 139, 200);
            btn_com.color = Color.FromArgb(0, 139, 200);
           // btn_sting.color = Color.FromArgb(0, 139, 200);
            bunifuTileButton5.color = Color.FromArgb(0, 139, 200);

            btn_add_patient.Visible = true;
            btn_mng_pa.Visible = true;
            btn_add_empl.Visible = false;
          //  btn_mng_empl.Visible = false;
            btn_add_sta.Visible = false;
            btn_mng_sta.Visible = false;
            btn_cal.Visible = false;
            btn_cal_fi.Visible = false;
            btn_study.Visible = true;
            btn_cal_fi.Visible = false;
            bunifuTileButton2.Visible = false;




            doctor1.Visible = true;
            teeth2.Visible = true;
            doctor2.Visible = false;
            doctor3.Visible = false;
            pic_emp.Visible = false;
            pic_com.Visible = false;
            pictureBox_cal.Visible = false;
        }

        private void btn_state_Click(object sender, EventArgs e)
        {
            patent.color = Color.FromArgb(0, 139, 200);
            btn_empl.color = Color.FromArgb(0, 138, 200);
            btn_state.color = Color.FromArgb(30, 144, 255);
            btn_com.color = Color.FromArgb(0, 139, 200);
          //  btn_sting.color = Color.FromArgb(0, 139, 200);
            bunifuTileButton5.color = Color.FromArgb(0, 139, 200);

            btn_add_patient.Visible = false;
            btn_mng_pa.Visible = false;
            btn_add_empl.Visible = false;
     //       btn_mng_empl.Visible = false;
            btn_add_sta.Visible = true;
            btn_mng_sta.Visible = true;
            btn_cal.Visible = false;
            btn_cal_fi.Visible = false;
            btn_study.Visible = false ;
            btn_cal_fi.Visible = false;
            bunifuTileButton2.Visible = false;





            doctor1.Visible = false;
            teeth2.Visible = false;
            doctor2.Visible = true;
            doctor3.Visible = true;
            pic_emp.Visible = false;
            pic_com.Visible = false;
            pictureBox_cal.Visible = false;
        }

        private void btn_com_Click(object sender, EventArgs e)
        {

            patent.color = Color.FromArgb(0, 139, 200);
            btn_empl.color = Color.FromArgb(0, 138, 200);
            btn_state.color = Color.FromArgb(0, 139, 200);
            btn_com.color = Color.FromArgb(30, 144, 255);
          //  btn_sting.color = Color.FromArgb(0, 139, 200);
            bunifuTileButton5.color = Color.FromArgb(0, 139, 200);

            btn_add_patient.Visible = false;
            btn_mng_pa.Visible = false;
            btn_add_empl.Visible = false;
        //    btn_mng_empl.Visible = false;
            btn_add_sta.Visible = false;
            btn_mng_sta.Visible = false;
            btn_cal.Visible = true;
            btn_cal_fi.Visible = true ;
            btn_study.Visible = false;
            btn_cal_fi.Visible = true ;
            bunifuTileButton2.Visible = false;




            doctor1.Visible = false;
            teeth2.Visible = false;
            doctor2.Visible = false;
            doctor3.Visible = false;
            pic_emp.Visible = false;
            pic_com.Visible = true;
            pictureBox_cal.Visible = true;
        }

        private void btn_empl_Click(object sender, EventArgs e)
        {

            patent.color = Color.FromArgb(0, 139, 200);
            btn_empl.color = Color.FromArgb(30, 144, 255);
            btn_state.color = Color.FromArgb(0, 139, 200);
            btn_com.color = Color.FromArgb(0, 139, 200);
         //   btn_sting.color = Color.FromArgb(0, 139, 200);
            bunifuTileButton5.color = Color.FromArgb(0, 139, 200);

            btn_add_patient.Visible = false;
            btn_mng_pa.Visible = false;
            btn_add_empl.Visible = true;
        //    btn_mng_empl.Visible = true;
            btn_add_sta.Visible = false;
            btn_mng_sta.Visible = false;
            btn_cal.Visible = false;
            btn_cal_fi.Visible = false;
            btn_study.Visible = false;
            btn_cal_fi.Visible = false;
            bunifuTileButton2.Visible = true;




            doctor1.Visible = false;
            teeth2.Visible = false;
            doctor2.Visible = false;
            doctor3.Visible = false;

            pic_emp.Visible = true;
            pic_com.Visible = false;
            pictureBox_cal.Visible = false;



        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            if (panel2_left.Visible)
            {
                panel2_left.Visible = false;
                bunifuTileButton5.ImageZoom = 32;
                bunifuTileButton5.color = Color.FromArgb(30, 144, 255);
            }
            else
            {
                panel2_left.Visible = true;
                bunifuTileButton5.ImageZoom = 30;
                bunifuTileButton5.color = Color.FromArgb(0, 139, 200);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("هل تريد إغلاق هذا التطبيق", "إغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            { Application.Exit(); }
            else { }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            this.Close();
           
        }

        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            Form_new_pateint.ShowDialog();
        }

        private void btn_mng_empl_Click(object sender, EventArgs e)
        {
            form_user.ShowDialog();
        }

        private void btn_mng_pa_Click(object sender, EventArgs e)
        {
            Form_manegmet_patient.ShowDialog();

        }

        private void btn_add_sta_Click(object sender, EventArgs e)
        {
            Form_new_state_.ShowDialog();
        }

        private void btn_mng_sta_Click(object sender, EventArgs e)
        {
            Form_manegnent_state_cs.ShowDialog();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            Forme_bills1.ShowDialog();
        }

        private void pictureBox_cal_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Form_order_list.ShowDialog();
        }

        private void Form_HOME_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            study.ShowDialog();
        }

        private void btn_sting_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_empl_Click(object sender, EventArgs e)
        {
            if (Form_LOGINcs.type == "user")
            {
                MessageBox.Show("ليس لديك الصلاحية بلدخول إلى ادارة المستخدمين ،هذه النافذة خاصة فقط بلمسؤلين ", "الصلاحيات ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                form_user.ShowDialog();
            }

            }

        private void bunifuTileButton2_Click_1(object sender, EventArgs e)
        {
            if (Form_LOGINcs.type == "user")
            {
                MessageBox.Show("ليس لديك الصلاحية بلدخول إلى ادارة المستخدمين ،هذه النافذة خاصة فقط بلمسؤلين ", "الصلاحيات ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Form_server_config.ShowDialog();
            }
        }
    }
}
