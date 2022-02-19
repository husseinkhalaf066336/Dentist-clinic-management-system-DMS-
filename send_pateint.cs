using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace dentis
{
    public partial class send_pateint : Form
    {
        SerialPort sp = new SerialPort();
        void load() {
            string[] ports = SerialPort.GetPortNames();
            foreach (string item in ports)
            { comboBox1.Items.Add(item ); }
        }

        public send_pateint()
        {
            InitializeComponent();
        }

        private void send_pateint_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
      
                load();
                for (int i = 0; i <= comboBox1.Items.Count - 1; i++)
                {
                    comboBox1.SelectedIndex = i;
                    sp.PortName = comboBox1.Text;
                    sp.ReadTimeout = 2000;
                    sp.Open();
                    sp.Write("AT\r");
                    sp.Write("AT+CMGF-1\r");
                    System.Threading.Thread.Sleep(1500);
                    sp.Write("AT+CMGF= \"" + textBox2.Text + "\"\r\n");
                    System.Threading.Thread.Sleep(1500);
                    sp.Write(textBox3.Text + "1XA");
                    MessageBox.Show("message sent successfuly ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
   




        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
