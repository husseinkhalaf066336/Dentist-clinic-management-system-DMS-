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
    public partial class form_user : Form
    {
        private static form_user frm;        //لتحديث الداتا غريد فيو من فورم اخر لا بد ان نتبع هذه الطريقى هاندلر

        static void frm_close(object sender, FormClosedEventArgs e)//handler
        { frm = null; }

        public static form_user getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new form_user();
                    frm.FormClosed += new FormClosedEventHandler(frm_close);
                }
                return frm;
            }
        }

        PL1.Class_login Class_login = new PL1.Class_login();
        form_updat_user form_updat_user = new form_updat_user();
        public form_user()
        {
            InitializeComponent();

            if (frm == null)
                frm = this;
            dataGridView1.DataSource = Class_login.serch_user("");

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton2.Checked = true;
            textBox1.Focus();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Class_login.chekh_user(textBox1.Text);
            int numper_of_pateint = dt.Rows.Count;
            if (numper_of_pateint > 0)
            { MessageBox.Show("عذرَ هذا الأسم موجود مسبقا ينبغي اخنتيار  اسم مستخدم متفرد   ", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else { 
                string t;
                if (radioButton1.Checked == true) { t = "admin"; }
                else if (radioButton3.Checked == true) { t = "doctor"; }
                else { t = "user"; }

                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                {
                    MessageBox.Show("  يجب ادخل جميع معلومات المستخدم لتتم عملية الإضافة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBox2.Text != textBox3.Text)
                    { MessageBox.Show("  كلمتا السر غير متطابقتين", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                    else
                    {
                        Class_login.add_user(textBox1.Text, textBox2.Text, t);
                        MessageBox.Show("تم اضافة مستخدم جديد بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        radioButton2.Checked = true;
                        textBox1.Focus();
                        dataGridView1.DataSource = Class_login.serch_user("");
                    }
                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
         //   radioButton1.Checked = false ;
          //  radioButton2.Checked = true ;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          //  radioButton1.Checked = true ;

           // radioButton2.Checked = false;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Class_login.serch_user(textBox4.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form_user_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Class_login.serch_user("");

            textBox4.Clear();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_login.show_user();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {

                    if (MessageBox.Show("هل تريد حذف المستخدم  المحدد", "عملبة الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string username = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                        Class_login.delet_user(username);

                        MessageBox.Show(" تم الحذف بنحاح ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = Class_login.serch_user("");

                    }
                    else { }
                }
                else
                {
                    MessageBox.Show(" لا توجد أية عناصر للحذف ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch { return; }


        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_login.show_user();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {


                    form_updat_user.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    form_updat_user.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string typ = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    if (typ == "user")
                    {
                        form_updat_user.radioButton2.Checked = true;
                        form_updat_user.radioButton1.Checked = false;
                    }
                    else { form_updat_user.radioButton2.Checked = false; ; form_updat_user.radioButton1.Checked = true; }

                    form_updat_user.ShowDialog();
                }

                else
                {
                    MessageBox.Show(" لا توجد أية عناصر للتعديل ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch { return; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
