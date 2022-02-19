using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace dentis
{
    public partial class Form_new_pateint : Form
    {
        PL1.Class_patient Class_patient = new PL1.Class_patient();
        //Form_manegmet_patient form_manegment_pat = new Form_manegmet_patient();
        public string s = "add";
        public Form_new_pateint()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 253, 253);
            ch1.Checked = true;
            ch2.Checked = false;

            DataTable dt = new DataTable();
            dt = Class_patient.show_id_pat();
            textBox1.Text = dt.Rows[0][0].ToString();

            textBox2.Focus();
            textBox2.SelectionStart = 0;
            textBox2.SelectionLength = textBox2.TextLength;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            if (s == "add")//نتحقق من قيمة المتغير للتفريق بين الاضافة والتعديل 
            {
               
                string g;
                if (ch1.Checked == true) { g = "male"; }
                else { g = "famale"; }

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] baytimage = ms.ToArray();

                string d = dateTimePicker1.Text.ToString();

                if (textBox2.Text != "" && textBox3.Text != "")
                {
                    Class_patient.add_patient(textBox2.Text, textBox3.Text, d, g, textBox4.Text, baytimage);
                    MessageBox.Show("تمت الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                    textBox2.Focus();
                    textBox2.SelectionStart = 0;
                    textBox2.SelectionLength = textBox1.TextLength;

                    pictureBox1.Image = dentis.Properties.Resources.patient_hospital_injured_sick_5121;
                    ch1.Checked = true;
                    ch2.Checked = false;

                    //لتعبئة حقل المعرف بعد كل عملية اضافة
                    DataTable dt = new DataTable();
                    dt = Class_patient.show_id_pat();
                    textBox1.Text = dt.Rows[0][0].ToString();
                }


                else
                {
                    MessageBox.Show("يجب ادخال الرقم الوطني واسم المريض لتتم عملية الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //تعديل
               

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] baytimag = ms.ToArray();

                string d = dateTimePicker1.Text.ToString();

                string g;
                if (ch1.Checked == true) { g = "male"; }
                else { g = "famale"; }
                int id = Convert.ToInt32(textBox1.Text);
                Class_patient.edit_patient(textBox2.Text, textBox3.Text, d, g, textBox4.Text, baytimag, id);
                MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            Form_manegmet_patient.getform.dataGridView1.DataSource = Class_patient.get_all_pateint();
            Form_manegmet_patient.getform.dataGridView1.Columns[0].Visible = false;
            Form_manegmet_patient.getform.dataGridView1.Columns[6].Visible = false;
        }
    

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(x.FileName);
            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Close();

            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            textBox2.Focus();
            textBox2.SelectionStart = 0;
            textBox2.SelectionLength = textBox1.TextLength;

            pictureBox1.Image = dentis.Properties.Resources.patient_hospital_injured_sick_5121;
            ch1.Checked = true;
            ch2.Checked = false;



        }

        private void ch2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void ch1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (s == "add")
            {
                DataTable dt = new DataTable();
                dt = Class_patient.chech_tc(textBox2.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم الوطني  موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    textBox1.SelectionStart = 0;
                    textBox1.SelectionLength = textBox1.TextLength;
                }
            }
        }

        private void ch1_OnChange(object sender, EventArgs e)
        {
            ch2.Checked = false;
            ch1.Checked = true;

        }

        private void ch2_OnChange(object sender, EventArgs e)
        {
            ch1.Checked = false;
            ch2.Checked = true;

        }

        private void Form_new_pateint_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Class_patient.show_id_pat();
            textBox1.Text = dt.Rows[0][0].ToString();



            textBox2.Focus();
            textBox2.SelectionStart = 0;
            textBox2.SelectionLength = textBox2.TextLength;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("  لا يمكن ادخال إلا ارقام في خانة هاتف المريض  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("  لا يمكن ادخال إلاالأرقام في خانة الرقم الوطني  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox2.Text != string.Empty)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox3.Text != string.Empty)
            {

                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dateTimePicker1.Text != string.Empty)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox4.Text != string.Empty)
            {
                bunifuThinButton21.Focus();
            }
        }

        private void textBox3_ImeModeChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

            }
        }

        private void dateTimePicker_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

            }
        }
    }
}
         


