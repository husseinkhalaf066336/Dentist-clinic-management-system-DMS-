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
    
    public partial class doctor_notes : Form
    {
       PL1 .Class_patient  class_patient =new PL1 .Class_patient();
       public static  int id_pateint;
        public static string type_option;
        public doctor_notes()
        {
            InitializeComponent();
            /*   textBox2.Focus();
               textBox2.SelectionStart = 0;
               textBox2.SelectionLength = textBox2.TextLength;*/
            textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }

        private void doctor_notes_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }

        private void con_butt_save_Click(object sender, EventArgs e)
        {
            if (type_option == "add")
            {
                class_patient.Add_doctor_note(id_pateint, textBox1.Text);
                MessageBox.Show("تمت اضافة الملاحظات الطبية بنجاح", "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                class_patient.edit_doctor_notes(id_pateint, textBox1.Text);
                MessageBox.Show("تم حفظ الملاحظات الطبية ", "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        private void con_butt_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
