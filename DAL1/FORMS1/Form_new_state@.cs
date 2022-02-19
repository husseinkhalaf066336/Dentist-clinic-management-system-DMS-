using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace dentis
{
    public partial class Form_new_state_ : Form
    {
        public string s = "add";
        PL1.Class_state Class_state = new PL1.Class_state();
        public Form_new_state_()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(253, 253, 253);

            textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;

        }

        private void Form_new_state__Load(object sender, EventArgs e)
        {

      
            

            textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();

            pictureBox1.Image = dentis.Properties.Resources.h;
            textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;


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

        private void patent_Click(object sender, EventArgs e)
        {
            if (s == "add")//نتحقق من قيمة المتغير للتفريق بين الاضافة والتعديل 
            {
              

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] baytimage = ms.ToArray();

                if (textBox1.Text != "")
                {
                    Class_state.add_state(textBox1.Text,
                                          textBox2.Text,
                                          textBox3.Text,
                                          textBox4.Text,
                                          baytimage);
                    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();

                    pictureBox1.Image = dentis.Properties.Resources.h;
                    textBox1.Focus();
                    textBox1.SelectionStart = 0;
                    textBox1.SelectionLength = textBox1.TextLength;

                }


                else
                {
                    MessageBox.Show("يجب ادخال رمز الحالة المرضية لتتم عملية الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else {
                //تعديل


                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] baytimage = ms.ToArray();

                Class_state.update_state(textBox1.Text,
                                          textBox2.Text,
                                          textBox3.Text,
                                          textBox4.Text,
                                          baytimage);

                MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //  Form_manegmet_patient.getform.dataGridView1.DataSource = Class_patient.get_all_pateint();
            Form_manegnent_state_cs.getform.dataGridView1.DataSource = Class_state.grt_all_state();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

            if (s == "add")
            {
                DataTable dt = new DataTable();
                dt = Class_state.chech_id(textBox1.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    textBox1.SelectionStart = 0;
                    textBox1.SelectionLength = textBox1.TextLength;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char x = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != x)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(Keys.Enter) && e.KeyChar != x)
            {
                MessageBox.Show("  (,)لا يمكن ادخال إلا القيم الرقميةورمز الفاصلة المعتمدة في نظام حاسوبك كا(.)او  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != string.Empty)
            {
                textBox2.Focus();
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
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && textBox4.Text != string.Empty)
            {
                patent.Focus();
            }
        }

        private void textBox2_ImeModeChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

            }
        }

        private void textBox4_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;

            }
        }
    }
}
