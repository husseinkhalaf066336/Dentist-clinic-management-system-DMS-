using CrystalDecisions.Shared;
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
    public partial class Form_order_list : Form
    {
        private static Form_order_list frm;        //لتحديث الداتا غريد فيو من فورم اخر لا بد ان نتبع هذه الطريقى هاندلر

        static void frm_close(object sender, FormClosedEventArgs e)//handler
        { frm = null; }

        public static Form_order_list getform
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_order_list();
                    frm.FormClosed += new FormClosedEventHandler(frm_close);
                }
                return frm;
            }
        }
        PL1.class_bills class_bills = new PL1.class_bills();
        Forme_bills1 form_bills = new Forme_bills1();
        form_fin form_fin = new form_fin();
        form_datil_order1 form_datil_order1 = new form_datil_order1();
        public Form_order_list()
        {
            InitializeComponent();

            if (frm == null)
                frm = this;

              //   this.dataGridView1.DataSource = class_bills.serch_order("");
            this.dataGridView1.DataSource = class_bills.serch_datils_order("");
        }

        private void Form_order_list_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = class_bills.serch_datils_order("");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                  //  this.dataGridView1.DataSource = class_bills.serch_order(textBox1.Text );
                this.dataGridView1.DataSource = class_bills.serch_datils_order(textBox1.Text);

            }
            catch { return; }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = class_bills.show_ditails();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
                    int ii = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    //  int ii = Convert.ToInt32(class_bills.last_order_print().Rows[0][0]);
                    RPT.CrystalReport_orders myreport = new RPT.CrystalReport_orders();

                    Form_RPT_State Form_RPT_State = new Form_RPT_State();

                    myreport.SetDataSource(class_bills.get_order_detils(ii));
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

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
       

        }

        private void btn2_Click(object sender, EventArgs e)
        {
           try { 
                DataTable dt = new DataTable();
                dt = class_bills.show_ditails();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {

                    if (MessageBox.Show("هل تريد حذف الفاتورة  المحددة", "عملبة الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        int ii = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        class_bills.dlete_order(ii);
                        MessageBox.Show(" تم الحذف بنحاح ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //   this.dataGridView1.DataSource = class_bills.serch_order("");
                        this.dataGridView1.DataSource = class_bills.serch_datils_order(textBox1.Text);


                    }
                    else
                    {
                    }
                }
                else
                {
                    MessageBox.Show("  لايوجد اية عناصر للحذف  ", "عملبة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

        }
            catch { return; }


           
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            form_bills.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = class_bills.show_ditails();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {
                    this.Cursor = Cursors.WaitCursor;
              
                    RPT.CrystalReport_orders myreport = new RPT.CrystalReport_orders();

                    ExportOptions export = new ExportOptions();
                    //create opject for destintion
                    DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();//يمكننا من تحديد مسار الحفظ
                                                                                            //    ExcelFormatOptions excelformat = new ExcelFormatOptions();//تنسيق ملف اكسل
                    PdfFormatOptions pdfformat = new PdfFormatOptions();//تنسيق ملف pdf

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
                    MessageBox.Show("  لايوجد اية عناصر للحفظ  ", "عملبة الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch { return; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click_2(object sender, EventArgs e)
        {
            try {
                DataTable dt = new DataTable();
                dt = class_bills.show_ditails();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {
                    form_fin.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                form_fin.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //     form_fin.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                form_fin.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                form_fin.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                form_fin.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                form_fin.textBox6.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                form_fin.textBox7.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                form_fin.textBox8.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();

                    form_fin. textBox7.Focus();
                    form_fin.textBox7.SelectionStart = 0;
                    form_fin.textBox7.SelectionLength = textBox1.TextLength;


                    form_fin.ShowDialog();
                }


                else
                {
                    MessageBox.Show(" لا توجد فواتير لإضافة دفعات لها", "الدفعات ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

     
            }
            catch { return; }





        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = class_bills.show_ditails();
                int numper_of_states = dt.Rows.Count;
                if (numper_of_states > 0)
                {
                    int id_current_order =Convert .ToInt32 ( this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            form_datil_order1.dataGridView1.DataSource = class_bills.VEIU_DATAILS_ORDER(id_current_order);
        
            form_datil_order1.ShowDialog();
                }


                else
                {
                    MessageBox.Show(" لا توجد فواتير للعرض تفاصيلها", "عملبة الطباعة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            catch { return; }

        }
    }
}
