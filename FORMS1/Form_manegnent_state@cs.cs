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
using CrystalDecisions.Shared;

namespace dentis
{
    public partial class Form_manegnent_state_cs : Form
    {
        private static Form_manegnent_state_cs frm;        //لتحديث الداتا غريد فيو من فورم اخر لا بد ان نتبع هذه الطريقى هاندلر

        static void frm_close(object sender, FormClosedEventArgs e)//handler
        { frm = null; }

        public static Form_manegnent_state_cs getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_manegnent_state_cs();
                    frm.FormClosed += new FormClosedEventHandler(frm_close);
                }
                return frm;
            }
        }
        PL1.Class_state Class_state = new PL1.Class_state();
        Form_new_state_ Form_new_state_ = new Form_new_state_();
        public Form_manegnent_state_cs()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 253, 253);

            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = Class_state.grt_all_state();
        }

        private void Form_manegnent_state_cs_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Class_state.grt_all_state();
          //  dt.DefaultView.Sort = "asc";

            this.dataGridView1.DataSource = dt;

            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Class_state.serch_state(textBox1.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form_new_state_.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_state.SHOW_State();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {
                    if (MessageBox.Show("هل تريد حذف الحالة المرضية المحددة", "عملبة الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        string idd = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        //  int id = Convert.ToInt32(idd);

                        Class_state.delet_state(idd);

                        MessageBox.Show(" تم الحذف بنحاح ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.dataGridView1.DataSource = Class_state.grt_all_state();
                        //this.dataGridView1.Columns[0].Visible = false;

                        //this.dataGridView1.Columns[6].Visible = false;

                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("  لايوجد اية عناصر للحذف  ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_state.SHOW_State();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {
                    Form_new_state_ .textBox1 .Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Form_new_state_.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Form_new_state_.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    Form_new_state_.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                   
                    Form_new_state_.label1.Text = "تعديل بيانات الحالة المرضية";
                    Form_new_state_.patent.LabelText = "تعديل";
                    Form_new_state_.s = "update";
                    Form_new_state_.textBox1.ReadOnly = true;
                    Form_new_state_.textBox2.TabIndex = 0;
                    /*   
                    Form_new_state_.textBox2.Focus();
                    Form_new_state_.textBox2.SelectionLength = 0;
                    Form_new_state_.textBox2.SelectionLength = Form_new_state_.textBox2.TextLength; */

                    string i = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    byte[] images = (byte[])Class_state.get_image_state(i).Rows[0][0];
                    MemoryStream ms = new MemoryStream(images);
                    Form_new_state_ .pictureBox1 .Image = Image.FromStream(ms);
                    Form_new_state_.ShowDialog();
                }
                else
                {
                    MessageBox.Show("  لايوجد اية عناصر للتعديل  ", "عملبة التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_state.SHOW_State();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {

                    Form_image_state_ Form_image_state_ = new Form_image_state_();

                  
                    string i = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    byte[] images = (byte[])Class_state.get_image_state(i).Rows[0][0];
                    MemoryStream ms = new MemoryStream(images);


                    Form_image_state_.pictureBox1.Image = Image.FromStream(ms);

                    Form_image_state_.ShowDialog();
                }

                else
                {
                MessageBox.Show("  لايوجد اية عناصر للتعديل  ", "عملبة التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
            catch { return; }
      


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_state.SHOW_State();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    RPT.CrystalReport_single_states myreport = new RPT.CrystalReport_single_states();
                    myreport.SetParameterValue("@id", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Form_RPT_State Form_RPT_State = new Form_RPT_State();
                    Form_RPT_State.crystalReportViewer1.ReportSource = myreport;
                    Form_RPT_State.ShowDialog();
                    this.Cursor = Cursors.Default;

                }

                else
                {
                    MessageBox.Show("  لايوجد اية عناصر للطباعة  ", "عملبة الطباعة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_state.SHOW_State();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    //  RPT.CrystalReport_all_state  myreport = new RPT.CrystalReport_all_state();
                    RPT.CrystalReport_all_state myreport = new RPT.CrystalReport_all_state();
                    Form_RPT_State Form_RPT_State = new Form_RPT_State();


                    Form_RPT_State.crystalReportViewer1.ReportSource = myreport;
                    Form_RPT_State.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("  لايوجد اية عناصر للطباعة  ", "عملبة الطباعة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = Class_state.SHOW_State();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {


                    this.Cursor = Cursors.WaitCursor;
                    RPT.CrystalReport_all_state myreport = new RPT.CrystalReport_all_state();
                    ExportOptions export = new ExportOptions();
                    //create opject for destintion
                    DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();//يمكننا من تحديد مسار الحفظ
                                                                                            //    ExcelFormatOptions excelformat = new ExcelFormatOptions();//تنسيق ملف اكسل
                    //PdfFormatOptions pdfformat = new PdfFormatOptions();//تنسيق ملف pdf  
                    PdfFormatOptions pdfformat = new PdfFormatOptions();
                    //Set the path of destination
                    dfoptions.DiskFileName = @"D:\states.pdf";//مسار التخزين مع الللحقة

                    export = myreport.ExportOptions;//ربط الأوبجكت اكسبورت الخاص بإعدادات التصدير بلربورت
                    export.ExportDestinationType = ExportDestinationType.DiskFile;//تحديد الدستانيشن تايب
                    export.ExportFormatType = ExportFormatType.PortableDocFormat;//تحديد نوع تنسيق الملف
                    export.ExportFormatOptions = pdfformat;//تنسيق هذا الملف هو نفسه اعدادات التنسيق التي اعلنا عنها في الاعلى
                    export.ExportDestinationOptions = dfoptions;//مسار التخزين

                    myreport.Export();
                    MessageBox.Show(" D في القرصpdfتم حفظ تقرير المرضى  بصيغة  ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }

                else
                {
                    MessageBox.Show("  لايوجد اية عناصر للتعديل  ", "عملبة التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                }
            catch { return; }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
