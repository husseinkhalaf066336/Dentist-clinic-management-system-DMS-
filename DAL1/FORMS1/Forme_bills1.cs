using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentis
{
    public partial class Forme_bills1 : Form
    {
        PL1.class_bills class_bills = new PL1.class_bills();
        form_choos_pat form_choos_pat = new form_choos_pat();
        form_choos_state form_choos_state = new form_choos_state();

        DataTable dt = new DataTable();

        void calculatamount()
        {
            if (textBox_cost.Text != string.Empty && textBox_qnt.Text != string.Empty)
            {
                try
                {
                    double amount = Convert.ToDouble(textBox_cost.Text) * Convert.ToDouble(textBox_qnt.Text);
                    textBox_amount.Text = amount.ToString();
                }
                catch { }

            }

        }

        void calculat_tatal_amount()
        {
            try
            {
                if (textBox_des.Text != string.Empty && textBox_amount.Text != string.Empty)
                {
                    double discount = Convert.ToDouble(textBox_des.Text);
                    double amount = Convert.ToDouble(textBox_amount.Text);
                    double tatalamunt1 = amount - (amount * (discount / 100));
                    textBox_total.Text = tatalamunt1.ToString();

                }

            }
            catch { }



        }


        void clear_boxes()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_cost.Clear();
            textBox_qnt.Clear();
            textBox_amount.Clear();
            textBox_des.Clear();
            textBox_total.Clear();
            bunifuThinButton25.Focus();

        }
        void creatdt()
        {
            dt.Columns.Add(" رمز الحالة المرضية");
            dt.Columns.Add("اسم الحالة المرضية");
            dt.Columns.Add("تكلفة الحالة المرضية");
            dt.Columns.Add("الكمية الحالة المرضية");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("نسبة الخصم (%) ");
            dt.Columns.Add("المبلغ الإجمالي");

            dataGridView1.DataSource = dt;

        }
        void resizedgv()
        {
             this.dataGridView1.RowHeadersWidth = 98;
         /*   this.dataGridView1.Columns[0].Width = 187;
            this.dataGridView1.Columns[1].Width = 230;
            this.dataGridView1.Columns[2].Width = 132;
            this.dataGridView1.Columns[3].Width = 124;
            this.dataGridView1.Columns[4].Width = 162; 
            this.dataGridView1.Columns[5].Width = 164;
            this.dataGridView1.Columns[6].Width = 200; */


        }

        public Forme_bills1()
        {
            InitializeComponent();
             resizedgv();

            this.BackColor = Color.FromArgb(253, 253, 253);
            textBox8.Enabled = false;

            bunifuThinButton27.Visible = false;
            bunifuThinButton23.Visible = false;






            creatdt();
           
            textBox1.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Forme_bills1_Load(object sender, EventArgs e)
        {

            textBox8.Enabled = false;
        
            bunifuThinButton27.Visible = false;
            bunifuThinButton23.Visible = false;

            bunifuThinButton21.Visible = false;
            bunifuThinButton26.Visible = false;
            bunifuThinButton25.Visible = false;
         


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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            clear_boxes();
            bunifuThinButton21.Visible = true;
            bunifuThinButton26.Visible = true;


            form_choos_state.ShowDialog();
            this.textBox_id.Text = form_choos_state.dgv_pat.CurrentRow.Cells[0].Value.ToString();
            this.textBox_name.Text = form_choos_state.dgv_pat.CurrentRow.Cells[1].Value.ToString();
            this.textBox_cost.Text = form_choos_state.dgv_pat.CurrentRow.Cells[2].Value.ToString();
            textBox_cost.Focus();
            textBox_cost.SelectionStart = 0;
            textBox_cost.SelectionLength = textBox_cost.TextLength;
            this.textBox_des.Text = "0";
            this.textBox_qnt.Text = "1";


        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            clear_boxes();

            textBox1.Clear();
            textBox8.Clear();

            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox1.Image = dentis.Properties.Resources.patient_hospital_injured_sick_5122;

            dt.Clear();
            dataGridView1.DataSource = null;

            this.Close();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox_cost.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_qnt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox_amount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox_des.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox_total.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                textBox_cost.Focus();
                textBox_cost.SelectionStart = 0;
                textBox_cost.SelectionLength = textBox_cost.TextLength;
            }
            catch { return; }
        }

        private void textBox_cost_KeyPress(object sender, KeyPressEventArgs e)
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

            if (textBox_id.Text == string.Empty && textBox_name.Text == string.Empty)
            {
                e.Handled = true;
            }

        }

        private void textBox_qnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("لا يمكن ادخال إلا القيم الرقمية ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (textBox_id.Text == string.Empty && textBox_name.Text == string.Empty)
            {
                e.Handled = true;
            }
        }

        private void textBox_cost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox_cost.Text != string.Empty)
            {
                textBox_qnt.Focus();
            }
        }

        private void textBox_qnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox_qnt.Text != string.Empty)
            {
                textBox_des.Focus();
            }
        }

        private void textBox_cost_KeyUp(object sender, KeyEventArgs e)
        {
            calculatamount();
            calculatamount();
        }

        private void textBox_qnt_KeyUp(object sender, KeyEventArgs e)
        {
            calculatamount();
            calculatamount();
            if (textBox_qnt.Text == "")
            {
                textBox_des.Text = "1";
            }
        }

        private void textBox_des_KeyPress(object sender, KeyPressEventArgs e)
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
            if (textBox_id.Text == string.Empty && textBox_name.Text == string.Empty)
            {
                e.Handled = true;
            }
        }

        private void textBox_des_KeyUp(object sender, KeyEventArgs e)
        {
            calculat_tatal_amount();


            if (textBox_des.Text == "")
            {
                textBox_des.Text = "0";
            }
        }

        private void textBox_des_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox_id.Text)
                    {
                        MessageBox.Show("هذه الحالة تم ادخالها مسبق,", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;


                    }

                }

                DataRow r = dt.NewRow();
                r[0] = textBox_id.Text;
                r[1] = textBox_name.Text;
                r[2] = textBox_cost.Text;
                r[3] = textBox_qnt.Text;
                r[4] = textBox_amount.Text;
                r[5] = textBox_des.Text;
                r[6] = textBox_total.Text;

                dt.Rows.Add(r);
                dataGridView1.DataSource = dt;

                clear_boxes();
                tex_sum.Text = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[6].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                textBox2.Focus();


            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tex_sum.Text = (from DataGridViewRow row in dataGridView1.Rows
                            where row.Cells[6].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text == string.Empty || textBox8.Text == string.Empty || dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("   يجب  اختيار مريض وحالة مرضية وتحديد اسم للفاتورة لتتم عملية الحفظ ", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                else
                {
                    class_bills.Add_order1(dateTimePicker1.Value, textBox8.Text, textBox6.Text);

                    MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bunifuThinButton23.Visible = true;
                    bunifuThinButton27.Visible = false;
                    bunifuThinButton25.Visible = false;
                    //      Form_order_list.getform.dataGridView1.DataSource = class_bills.serch_datils_order("");

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        class_bills.add_order_datals(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                         Convert.ToInt32(textBox1.Text),
                        Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                        dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value),
                        dataGridView1.Rows[i].Cells[4].Value.ToString(),
                        dataGridView1.Rows[i].Cells[6].Value.ToString(),
                         tex_sum.Text, textBox2.Text, textBox3.Text);
                    }
                    //MessageBox.Show("تمت الإضافة التفاصيل  بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bunifuThinButton23.Visible = true;
                    bunifuThinButton27.Visible = false;
                    bunifuThinButton25.Visible = false;
                    Form_order_list.getform.dataGridView1.DataSource = class_bills.serch_datils_order("");
                }


            }
            catch { return; }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int i = Convert.ToInt32(class_bills.last_order_print().Rows[0][0]);

                RPT.CrystalReport_orders myreport = new RPT.CrystalReport_orders();
                Form_RPT_State Form_RPT_State = new Form_RPT_State();
                myreport.SetDataSource(class_bills.get_order_detils(i));
                Form_RPT_State.crystalReportViewer1.ReportSource = myreport;
                Form_RPT_State.ShowDialog();

                this.Cursor = Cursors.Default;
            }
            catch { return; }



        }

        private void label19_Click(object sender, EventArgs e)
        {

        }


        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            bunifuThinButton27.Visible = true;
            bunifuThinButton25.Visible = true;
            bunifuThinButton23.Visible = false;

            DataTable dtt = new DataTable();
            dtt = class_bills.show_id_orderr();
            textBox1.Text = dtt.Rows[0][0].ToString();

            textBox8.Enabled = true;
            textBox8.Focus();


            if (textBox1.Text != string.Empty)
            {
                clear_boxes();
                textBox1.Clear();
                textBox8.Clear();

                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                pictureBox1.Image = dentis.Properties.Resources.patient_hospital_injured_sick_5122;

                dt.Clear();
                dataGridView1.DataSource = null;
            }



            dtt = class_bills.show_id_orderr();
            textBox1.Text = dtt.Rows[0][0].ToString();

            textBox8.Enabled = true;
            textBox8.Focus();
            Form_order_list.getform.dataGridView1.DataSource = class_bills.serch_datils_order("");


        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox8.Text != string.Empty)
            {
                dateTimePicker1.Focus();
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            { e.Handled = true; }
        }

        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {
            if (textBox_total.Text == string.Empty)
            { textBox_total.Text = textBox_amount.Text; }
        }

        private void textBox_total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow r = dt.NewRow();
                r[0] = textBox_id.Text;
                r[1] = textBox_name.Text;
                r[2] = textBox_cost.Text;
                r[3] = textBox_qnt.Text;
                r[4] = textBox_amount.Text;
                r[5] = textBox_des.Text;
                r[6] = textBox_total.Text;

                dt.Rows.Add(r);
                dataGridView1.DataSource = dt;

                clear_boxes();
                tex_sum.Text = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[6].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }

        private void textBox_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            { e.Handled = true; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty) { textBox3.Text = tex_sum.Text; }
                double total = Convert.ToDouble(tex_sum.Text) - Convert.ToDouble(textBox2.Text);
                textBox3.Text = total.ToString();
            }
            catch { return; }

        }

        private void tex_sum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty)
                { textBox2.Text = "0"; }
                double total = Convert.ToDouble(tex_sum.Text) - Convert.ToDouble(textBox2.Text);
                textBox3.Text = total.ToString();
            }
            catch { return; }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox8.Text != string.Empty)
            {
                textBox3.Focus();
            }
        }

        private void tex_sum_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {


        }

        private void bunifuThinButton28_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox_qnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox_des_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

