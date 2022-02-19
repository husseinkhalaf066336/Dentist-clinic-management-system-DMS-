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
    public partial class form_choos_pat : Form
    {
        PL1.Class_patient Class_patient = new PL1.Class_patient();
        public form_choos_pat()
        {
            InitializeComponent();
            this.dgv_pat.DataSource = Class_patient.get_all_pateint();
            this.dgv_pat.Columns[0].Visible = false;
            this.dgv_pat.Columns[6].Visible = false;
        }

        private void form_choos_pat_Load(object sender, EventArgs e)
        {
            this.dgv_pat.DataSource = Class_patient.get_all_pateint();
            this.dgv_pat.Columns[0].Visible = false;
            this.dgv_pat.Columns[6].Visible = false;
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Class_patient.search_patein(textBox1.Text);
            this.dgv_pat.DataSource = dt;
        }

        private void dgv_pat_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
