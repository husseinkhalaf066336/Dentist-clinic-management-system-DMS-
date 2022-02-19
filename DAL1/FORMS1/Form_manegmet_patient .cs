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
    public partial class Form_manegmet_patient : Form
    {
        private static Form_manegmet_patient frm;        //لتحديث الداتا غريد فيو من فورم اخر لا بد ان نتبع هذه الطريقى هاندلر

        static void frm_close(object sender, FormClosedEventArgs e)//handler
        { frm = null; }

        public static Form_manegmet_patient getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_manegmet_patient();
                    frm.FormClosed += new FormClosedEventHandler(frm_close);
                }
                return frm;
            }
        }


        PL1.Class_patient Class_patient = new PL1.Class_patient();
        Form_new_pateint Form_new_pateint = new Form_new_pateint();
        public Form_manegmet_patient()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 253, 253);

            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = Class_patient.get_all_pateint();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
        }

        private void Form_manegmet_patient_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Class_patient.get_all_pateint();
            dt.DefaultView.Sort = "الرقم الوطني asc";

            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Class_patient.search_patein(textBox1.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form_new_pateint.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_patient.SHOW_PATIENT();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {
                    if (MessageBox.Show("هل تريد حذف المريض المحدد", "عملبة الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {

                        string idd = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        int id = Convert.ToInt32(idd);

                        Class_patient.delet_pat(id);

                        MessageBox.Show(" تم الحذف بنحاح ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.dataGridView1.DataSource = Class_patient.get_all_pateint();
                        this.dataGridView1.Columns[0].Visible = false;

                        this.dataGridView1.Columns[6].Visible = false;

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
                dt = Class_patient.SHOW_PATIENT();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {
                    Form_new_pateint Form_new_pateint = new Form_new_pateint();

                    Form_new_pateint.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Form_new_pateint.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Form_new_pateint.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    //Form_new_pateint.dateTimePicker.Visible = false;
                    Form_new_pateint.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

                    string g = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    if (g == "male")
                    {
                        Form_new_pateint.ch1.Checked = true;
                        Form_new_pateint.ch2.Checked = false;
                    }
                    else { Form_new_pateint.ch2.Checked = true; Form_new_pateint.ch1.Checked = false; }

                    Form_new_pateint.textBox4.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

                    Form_new_pateint.label1.Text = "تعديل بيانات المريض";
                    Form_new_pateint.bunifuTileButton3.LabelText = "تعديل";
                    Form_new_pateint.s = "update";

                    Form_new_pateint.textBox1.ReadOnly = true;
                    Form_new_pateint.textBox2.ReadOnly = true;
                    Form_new_pateint.textBox3.TabIndex = 0;

                    int i = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    byte[] images = (byte[])Class_patient.get_imade_pat(i).Rows[0][0];
                    MemoryStream ms = new MemoryStream(images);

                    Form_new_pateint.pictureBox1.Image = Image.FromStream(ms);
                    Form_new_pateint.ShowDialog();
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
                dt = Class_patient.SHOW_PATIENT();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {
                    Form_image_pat form_imag = new Form_image_pat();
              
                    int x = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    byte[] images = (byte[])Class_patient.get_imade_pat(x).Rows[0][0];


                    MemoryStream ms = new MemoryStream(images);
                    form_imag.pictureBox1.Image = Image.FromStream(ms);

                    form_imag.ShowDialog();
                }
                else
                {
                    MessageBox.Show("  لايوجد اية عناصر لعرض صورها  ", "صورة المريض ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_patient.SHOW_PATIENT();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    RPT.CrystalReport_all_petint myreport = new RPT.CrystalReport_all_petint();
            ExportOptions export = new ExportOptions();
            //create opject for destintion
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();//يمكننا من تحديد مسار الحفظ
                                                                                    //    ExcelFormatOptions excelformat = new ExcelFormatOptions();//تنسيق ملف اكسل
            PdfFormatOptions pdfformat = new PdfFormatOptions();//تنسيق ملف pdf

            //Set the path of destination
            dfoptions.DiskFileName = @"D:\pateint.pdf";//مسار التخزين مع الللحقة

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
                    MessageBox.Show("  لايوجد اية عناصر للطباعة  ", "عملبة الطباعة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = Class_patient.SHOW_PATIENT();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    RPT.CrystalReport_single_pateint myreport = new RPT.CrystalReport_single_pateint();
                    myreport.SetParameterValue("@id_pat", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Form_RPT_Pateint Form_RPT_Pateint = new Form_RPT_Pateint();
                     Form_RPT_Pateint.crystalReportViewer1.ReportSource = myreport;
                    Form_RPT_Pateint.ShowDialog();
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
                dt = Class_patient.SHOW_PATIENT();
                int numper_of_pateint = dt.Rows.Count;
                if (numper_of_pateint > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    RPT.CrystalReport_all_petint myreport = new RPT.CrystalReport_all_petint();

                    Form_RPT_Pateint Form_RPT_Pateint = new Form_RPT_Pateint();


                    Form_RPT_Pateint.crystalReportViewer1.ReportSource = myreport;
                    Form_RPT_Pateint.ShowDialog();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("  لايوجد اية عناصر للطباعة  ", "عملبة الطباعة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }
        }
    }
    }

