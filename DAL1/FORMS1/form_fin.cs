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
    public partial class form_fin : Form
    {
        PL1.class_bills class_bills = new PL1.class_bills();

        void clearbox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
        public form_fin()
        {
            InitializeComponent();
            textBox7.Focus();
            textBox7.SelectionStart = 0;
           textBox7.SelectionLength = textBox1.TextLength;


        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            clearbox();


            this.Close();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            class_bills.edet_detals_order(Convert.ToInt32(textBox1.Text), textBox6.Text, textBox7.Text, textBox8.Text);
            class_bills.date_order(Convert.ToInt32(textBox1.Text), dateTimePicker1.Value);
            MessageBox.Show(" تمت اضافة الدفعة للفاتورة بنجاح ", " الدفعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form_order_list.getform.dataGridView1.DataSource = class_bills.serch_datils_order("");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
              
                double total = Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox7.Text);
                textBox8.Text = total.ToString();
            }
            catch { return; }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (textBox7.Text == string.Empty) { textBox8.Text = textBox6.Text; }

                double total = Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox7.Text);
                textBox8.Text = total.ToString();

                
             

            }
            catch { return; }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox7.Text != string.Empty)
            {
                dateTimePicker1.Focus();
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("  (,)لا يمكن ادخال إلا القيم الرقميةورمز الفاصلة المعتمدة في نظام حاسوبك كا(.)او  ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void form_fin_Load(object sender, EventArgs e)
        {
            {

             
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
