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
namespace dentis
{
    public partial class picteres_pat : Form
    {
       public  int id_pic;
        PL1.Class_patient class_patient = new PL1.Class_patient();
        public string s;

        public picteres_pat()
        {
            InitializeComponent();
        }

        private void bunifuTileButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] baytimage = ms.ToArray();

            MemoryStream ms1 = new MemoryStream();
            pictureBox2.Image.Save(ms1, pictureBox2.Image.RawFormat);
            byte[] baytimage2 = ms1.ToArray();

            MemoryStream ms2 = new MemoryStream();
            pictureBox3.Image.Save(ms2, pictureBox3.Image.RawFormat);
            byte[] baytimage3 = ms2.ToArray();

            MemoryStream ms3 = new MemoryStream();
            pictureBox4.Image.Save(ms3, pictureBox4.Image.RawFormat);
            byte[] baytimage4 = ms3.ToArray();

            MemoryStream ms4 = new MemoryStream();
            pictureBox5.Image.Save(ms4, pictureBox5.Image.RawFormat);
            byte[] baytimage5 = ms4.ToArray();

            MemoryStream ms5 = new MemoryStream();
            pictureBox6.Image.Save(ms5, pictureBox6.Image.RawFormat);
            byte[] baytimage6 = ms5.ToArray();

            MemoryStream ms6 = new MemoryStream();
            pictureBox7.Image.Save(ms6, pictureBox7.Image.RawFormat);
            byte[] baytimage7 = ms6.ToArray();


            MemoryStream ms7 = new MemoryStream();
            pictureBox8.Image.Save(ms7, pictureBox8.Image.RawFormat);
            byte[] baytimage8 = ms7.ToArray();


            MemoryStream ms8 = new MemoryStream();
            pictureBox9.Image.Save(ms8, pictureBox9.Image.RawFormat);
            byte[] baytimage9 = ms8.ToArray();


            MemoryStream ms9 = new MemoryStream();
            pictureBox10.Image.Save(ms9, pictureBox10.Image.RawFormat);
            byte[] baytimage10 = ms9.ToArray();

            if (s == "add")
            {
                class_patient.add_pic(id_pic, baytimage, baytimage2, baytimage3, baytimage4, baytimage5, baytimage6, baytimage7, baytimage8, baytimage9, baytimage10);
                MessageBox.Show("تمت اضافة الصور العلاجية للمريض", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("تمت  " + id_pic, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                class_patient.edit_pic_of_pateint(id_pic, baytimage, baytimage2, baytimage3, baytimage4, baytimage5, baytimage6, baytimage7, baytimage8, baytimage9, baytimage10);
                MessageBox.Show("تم التعديل", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            pictureBox1.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox2.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox3.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox4.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox5.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox6.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox7.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox8.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox9.Image = dentis.Properties.Resources._5420686_539182681;
            pictureBox10.Image = dentis.Properties.Resources._5420686_539182681;

            //Form_new_pateint form_new_patient = new Form_new_pateint();
           // form_new_patient.bunifuThinButton22.Visible = false;
       //     this.Close();



        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(x.FileName);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(x.FileName);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.Image = Image.FromFile(x.FileName);
            }

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox8.Image = Image.FromFile(x.FileName);
            }

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox10.Image = Image.FromFile(x.FileName);
            }

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(x.FileName);
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(x.FileName);
            }
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.Image = Image.FromFile(x.FileName);
            }
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox7.Image = Image.FromFile(x.FileName);
            }
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Filter = "images=:|*.jpg;*.gif;*.BMP;*.PNG";
            if (x.ShowDialog() == DialogResult.OK)
            {
                pictureBox9.Image = Image.FromFile(x.FileName);
            }
        }

        private void picteres_pat_Load(object sender, EventArgs e)
        {

        }
    }
}
