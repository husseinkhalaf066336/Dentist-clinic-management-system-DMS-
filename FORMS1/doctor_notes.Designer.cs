namespace dentis
{
    partial class doctor_notes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor_notes));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.con_butt_clos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.con_butt_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Akhbar MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(135, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1025, 278);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akhbar MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(0, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ملاحظات الطبيب";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.con_butt_clos);
            this.panel1.Controls.Add(this.con_butt_save);
            this.panel1.Location = new System.Drawing.Point(7, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 64);
            this.panel1.TabIndex = 101;
            // 
            // con_butt_clos
            // 
            this.con_butt_clos.ActiveBorderThickness = 1;
            this.con_butt_clos.ActiveCornerRadius = 20;
            this.con_butt_clos.ActiveFillColor = System.Drawing.Color.Red;
            this.con_butt_clos.ActiveForecolor = System.Drawing.Color.White;
            this.con_butt_clos.ActiveLineColor = System.Drawing.Color.Red;
            this.con_butt_clos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.con_butt_clos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("con_butt_clos.BackgroundImage")));
            this.con_butt_clos.ButtonText = "خروج";
            this.con_butt_clos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.con_butt_clos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_butt_clos.ForeColor = System.Drawing.Color.Red;
            this.con_butt_clos.IdleBorderThickness = 1;
            this.con_butt_clos.IdleCornerRadius = 20;
            this.con_butt_clos.IdleFillColor = System.Drawing.Color.White;
            this.con_butt_clos.IdleForecolor = System.Drawing.Color.Red;
            this.con_butt_clos.IdleLineColor = System.Drawing.Color.Red;
            this.con_butt_clos.Location = new System.Drawing.Point(505, 2);
            this.con_butt_clos.Margin = new System.Windows.Forms.Padding(5);
            this.con_butt_clos.Name = "con_butt_clos";
            this.con_butt_clos.Size = new System.Drawing.Size(149, 54);
            this.con_butt_clos.TabIndex = 1;
            this.con_butt_clos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.con_butt_clos.Click += new System.EventHandler(this.con_butt_clos_Click);
            // 
            // con_butt_save
            // 
            this.con_butt_save.ActiveBorderThickness = 1;
            this.con_butt_save.ActiveCornerRadius = 20;
            this.con_butt_save.ActiveFillColor = System.Drawing.Color.Green;
            this.con_butt_save.ActiveForecolor = System.Drawing.Color.White;
            this.con_butt_save.ActiveLineColor = System.Drawing.Color.Green;
            this.con_butt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.con_butt_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("con_butt_save.BackgroundImage")));
            this.con_butt_save.ButtonText = "حفظ ";
            this.con_butt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.con_butt_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_butt_save.ForeColor = System.Drawing.Color.Green;
            this.con_butt_save.IdleBorderThickness = 1;
            this.con_butt_save.IdleCornerRadius = 20;
            this.con_butt_save.IdleFillColor = System.Drawing.Color.White;
            this.con_butt_save.IdleForecolor = System.Drawing.Color.Green;
            this.con_butt_save.IdleLineColor = System.Drawing.Color.Green;
            this.con_butt_save.Location = new System.Drawing.Point(664, 2);
            this.con_butt_save.Margin = new System.Windows.Forms.Padding(5);
            this.con_butt_save.Name = "con_butt_save";
            this.con_butt_save.Size = new System.Drawing.Size(149, 54);
            this.con_butt_save.TabIndex = 0;
            this.con_butt_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.con_butt_save.Click += new System.EventHandler(this.con_butt_save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 62);
            this.panel2.TabIndex = 102;
            // 
            // doctor_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doctor_notes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctor_notes";
            this.Load += new System.EventHandler(this.doctor_notes_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 con_butt_clos;
        private Bunifu.Framework.UI.BunifuThinButton2 con_butt_save;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox textBox1;
    }
}