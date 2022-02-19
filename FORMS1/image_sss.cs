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
    public partial class image_sss : Form
    {
        PL1.Class_patient Class_patient = new PL1.Class_patient();
        picteres_pat form_picter_pat = new picteres_pat();
        doctor_notes doctor_notes = new doctor_notes();



        public image_sss()
        {
            InitializeComponent();


        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
        }



        private void image_sss_Load(object sender, EventArgs e)
        {
            // DataTable dt = new DataTable();
            //    dt = Class_patient.search_patein(textBox1.Text);
            //     this.dataGridView1.DataSource = dt;

            int id = Convert.ToInt32(textBox1.Text);
            DataTable dt = new DataTable();
            dt = Class_patient.get_order_datales_of_the_pateint(id);
            this.dataGridView1.DataSource = dt;


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {


            int id1 = Convert.ToInt32(textBox1.Text);
            DataTable dt = new DataTable();
            dt = Class_patient.get_picter_of_patient(id1);
            form_picter_pat.id_pic = id1;
            if (dt.Rows.Count <= 0)
            {
                form_picter_pat.pictureBox1.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox2.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox3.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox4.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox5.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox6.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox7.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox8.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox9.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.pictureBox10.Image = dentis.Properties.Resources._5420686_539182681;
                form_picter_pat.s = "add";

            }
            else
            {
                byte[] images = (byte[])dt.Rows[0][0];
                MemoryStream ms = new MemoryStream(images);
                form_picter_pat.pictureBox1.Image = Image.FromStream(ms);

                byte[] images2 = (byte[])dt.Rows[0][1];
                MemoryStream ms2 = new MemoryStream(images2);
                form_picter_pat.pictureBox2.Image = Image.FromStream(ms2);

                byte[] images3 = (byte[])dt.Rows[0][2];
                MemoryStream ms3 = new MemoryStream(images3);
                form_picter_pat.pictureBox3.Image = Image.FromStream(ms3);

                byte[] images4 = (byte[])dt.Rows[0][3];
                MemoryStream ms4 = new MemoryStream(images4);
                form_picter_pat.pictureBox4.Image = Image.FromStream(ms4);

                byte[] images5 = (byte[])dt.Rows[0][4];
                MemoryStream ms5 = new MemoryStream(images5);
                form_picter_pat.pictureBox5.Image = Image.FromStream(ms5);

                byte[] images6 = (byte[])dt.Rows[0][5];
                MemoryStream ms6 = new MemoryStream(images6);
                form_picter_pat.pictureBox6.Image = Image.FromStream(ms6);


                byte[] images7 = (byte[])dt.Rows[0][6];
                MemoryStream ms7 = new MemoryStream(images7);
                form_picter_pat.pictureBox7.Image = Image.FromStream(ms7);


                byte[] images8 = (byte[])dt.Rows[0][7];
                MemoryStream ms8 = new MemoryStream(images8);
                form_picter_pat.pictureBox8.Image = Image.FromStream(ms8);


                byte[] images9 = (byte[])dt.Rows[0][8];
                MemoryStream ms9 = new MemoryStream(images9);
                form_picter_pat.pictureBox9.Image = Image.FromStream(ms9);

                byte[] images10 = (byte[])dt.Rows[0][9];
                MemoryStream ms10 = new MemoryStream(images10);
                form_picter_pat.pictureBox10.Image = Image.FromStream(ms10);
                form_picter_pat.s = "ubdat";
            }

            form_picter_pat.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            int id1 = Convert.ToInt32(textBox1.Text);
            doctor_notes.id_pateint = id1;
            DataTable dt = new DataTable();
            dt = Class_patient.get_doctor_notes_of_pateint(id1);
        
            if (dt.Rows.Count <= 0)
            { doctor_notes.type_option = "add";
                doctor_notes.textBox1.Clear();
            }
            else {
                doctor_notes.type_option = "edit";
                string note = dt.Rows[0][0].ToString();
                doctor_notes.textBox1.Text = note;
               
            }
            doctor_notes.ShowDialog();
        }    
    }
}
