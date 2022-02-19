using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentis
{
    public partial class study : Form
    {
        PL1.class_syudy class_syudy = new PL1.class_syudy();
        form_choos_pat form_choos_pat = new form_choos_pat();
       

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            pictureBox1.Image = dentis.Properties.Resources.patient_hospital_injured_sick_5122;
        }
        public study()
        {
            InitializeComponent();
            dataGridView1.DataSource = class_syudy.getallstudy();
            textBox8.ReadOnly = true ;


        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
            textBox8.ReadOnly = false;
            textBox8.Focus();
            DataTable dtt = new DataTable();
            dtt = class_syudy.show_id_study();
            textBox1.Text = dtt.Rows[0][0].ToString();
            if (textBox1.Text != string.Empty)
            {
                clear();
            }
            dtt = class_syudy.show_id_study();
            textBox1.Text = dtt.Rows[0][0].ToString();
            textBox8.ReadOnly = false;
            textBox8.Focus();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
           // class_syudy.add_study(textBox8.Text, dateTimePicker1.Text, textBox6.Text);
         //   MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                form_choos_pat.ShowDialog();
                textBox5.Text = form_choos_pat.dgv_pat.CurrentRow.Cells[0].Value.ToString();
                textBox6.Text = form_choos_pat.dgv_pat.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = form_choos_pat.dgv_pat.CurrentRow.Cells[2].Value.ToString();
                textBox7.Text = form_choos_pat.dgv_pat.CurrentRow.Cells[5].Value.ToString();

                byte[] pic = (byte[])form_choos_pat.dgv_pat.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch { return; }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Close();
            clear();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == string.Empty || textBox1.Text == string.Empty || textBox6.Text == string.Empty )
            {
                MessageBox.Show("يجب تعبئة معلمومات الجلسة واختيار مريض   ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {


                class_syudy.add_study(textBox8.Text, dateTimePicker1.Text, textBox6.Text , textBox2.Text);
                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = class_syudy.getallstudy();
            }

        }

        private void study_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = class_syudy.getallstudy();
            textBox8.ReadOnly = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = class_syudy.serch_studyyy(textBox3 .Text );
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try {
             
                    DataTable dt = new DataTable();
                    dt = class_syudy.show_study();
                    int numper_of_pateint = dt.Rows.Count;
                    if (numper_of_pateint > 0)
                    {

                        if (MessageBox.Show("هل تريد الجلسة المحددة", "عملبة الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    string idd = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    int id = Convert.ToInt32(idd);

                    class_syudy.delet_study(id);

                    MessageBox.Show(" تم الحذف بنحاح ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.dataGridView1.DataSource = class_syudy.getallstudy();
                }
            }
                else
                {
                    MessageBox.Show("  لايوجد اية عناصر للحذف  ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }



        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            { e.Handled = true; }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { dateTimePicker1.Focus(); }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { bunifuThinButton25.Focus(); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
        
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
    }


