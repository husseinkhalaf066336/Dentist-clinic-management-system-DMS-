using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dentis
{
   
    public partial class Form_LOGINcs : Form
    {
        Form_HOME Form_HOME = new Form_HOME();
        PL1.Class_login log = new PL1.Class_login();
        public static string  type;
        Form_server_config Form_server_config = new Form_server_config();

        public Form_LOGINcs()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 253, 253);
            texb_pass.isPassword = true;
            Chbox_show.Checked = false;
          //  radioButton1.Checked = false ;
        //    radioButton2.Checked = false;

        }

        private void Form_LOGINcs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("هل تريد اغلاق هذا التطبيق", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
                this.Close();
            else { }
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Chbox_show_OnChange(object sender, EventArgs e)
        {
           
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

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

        private void btn_close_Click(object sender, EventArgs e)
        {

            DialogResult x = MessageBox.Show("هل تريد الخروج هذا حقاً؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
                this.Close();
            else { }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (texb_username.Text == string.Empty || texb_pass.Text == string.Empty  )
            {
                MessageBox.Show(" يجب ادخال اسم المستخدم  وكلمة المرور وتحديد نوع المستخدم بشكل صحيح", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string t;
                if (radioButton1.Checked == true) { t = "admin"; }
                else if (radioButton3.Checked == true) { t = "doctor"; }
                else { t = "user"; }


                DataTable dt = log.login(texb_username.Text, texb_pass.Text, t);
                if (dt.Rows.Count > 0)
                {

                    bunifuTransition1.ShowSync(Form_HOME);
                    type = t;

                }
                else
                { MessageBox.Show( " عفواً اسم المستخدم أو كلمة المرور غير صحيحة أو قد يكون لم يتم تحديد نوع المستخدم بشكل صحيح", "خطاء", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            }
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Chbox_show_OnChange_1(object sender, EventArgs e)
        {
            if (Chbox_show.Checked)
            {
                texb_pass.isPassword = false;
                open_eye.Visible = true;
                close_eye.Visible = false;
            }
            else
            {

                texb_pass.isPassword = true;
                open_eye.Visible = false;
                close_eye.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          //  radioButton2.Checked = false;

           // radioButton1.Checked = true ;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
       //     radioButton1.Checked = false;
           // radioButton2.Checked = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form_server_config.ShowDialog();
        }

        private void texb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void texb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && texb_username.Text != string.Empty)
            {
                texb_pass.Focus();
            }
        }

        private void texb_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && texb_pass.Text != string.Empty)
            {
                radioButton1.Focus();
            }
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Process.Start("www.facebook.com/profile.php?id=100005113489195");
            this.Cursor = Cursors.Default;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Process.Start("www.facebook.com/profile.php?id=100005113489195");
            this.Cursor = Cursors.Default;

        }
    }
}
