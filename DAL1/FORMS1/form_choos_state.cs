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
    public partial class form_choos_state : Form
    {
        PL1.Class_state Class_state = new PL1.Class_state();
        public form_choos_state()
        {
            InitializeComponent();
            this.dgv_pat.DataSource = Class_state.grt_all_state();

        }

        private void form_choos_state_Load(object sender, EventArgs e)
        {
            this.dgv_pat.DataSource = Class_state.grt_all_state();
        }

        private void dgv_pat_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Class_state.serch_state(textBox1.Text);
            this.dgv_pat.DataSource = dt;

        }
    }
}
