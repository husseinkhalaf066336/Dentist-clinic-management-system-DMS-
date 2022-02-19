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
    public partial class form_updat_user : Form
    {
        PL1.Class_login c = new PL1.Class_login();
        public form_updat_user()
        {
            InitializeComponent();
            textBox2.Focus();
            textBox2.SelectionStart = 0;
            textBox2.SelectionLength = textBox1.TextLength;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

    
                string t;
                if (radioButton1.Checked == true) { t = "admin"; } else { t = "user"; }
                c.edet_user(textBox1.Text, textBox2.Text, t);
                MessageBox.Show(" تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_user.getform.dataGridView1.DataSource = c.serch_user("");
            this.Close();
            
        }
    }
}
