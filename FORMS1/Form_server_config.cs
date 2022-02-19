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
    public partial class Form_server_config : Form
    {
        public Form_server_config()
        {
            InitializeComponent();
            text_servername.Text = Properties.Settings.Default.server;
            text_databasename.Text = Properties.Settings.Default.databas ;
            if (Properties.Settings.Default.mode == "SQL")
            {
                rb_sql.Checked = true;
                text_serve_username.Text = Properties.Settings.Default.id;
                text_serve_pass.Text = Properties.Settings.Default.pass;
            }
            else
            { rb_windows.Checked = true;
                text_serve_username.Clear();
                text_serve_pass.Clear();
                text_serve_username.Enabled  = false ;
                text_serve_pass.Enabled  = false ;
            }
        }

        private void Form_server_config_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void con_butt_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = text_servername.Text;
            Properties.Settings.Default.databas  = text_databasename .Text;
            Properties.Settings.Default.mode = rb_sql.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.id = text_serve_username.Text;
            Properties.Settings.Default.pass  = text_serve_pass.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم ضبط الإعدادات بشكل ناجح", "الإعدادات", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void rb_sql_CheckedChanged(object sender, EventArgs e)
        {
            text_serve_username.Enabled = true ;
            text_serve_pass.Enabled = true ;
        }

        private void rb_windows_CheckedChanged(object sender, EventArgs e)
        {
            text_serve_username.Enabled  = false  ;
            text_serve_pass.Enabled  = false  ;

        }

        private void con_butt_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
