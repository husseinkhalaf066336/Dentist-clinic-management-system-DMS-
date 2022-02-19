namespace dentis
{
    partial class Form_server_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_server_config));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_sql = new System.Windows.Forms.RadioButton();
            this.rb_windows = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_serve_username = new System.Windows.Forms.TextBox();
            this.text_servername = new System.Windows.Forms.TextBox();
            this.text_databasename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_serve_pass = new System.Windows.Forms.TextBox();
            this.con_butt_clos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.con_butt_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 40);
            this.panel2.TabIndex = 101;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.con_butt_clos);
            this.panel1.Controls.Add(this.con_butt_save);
            this.panel1.Location = new System.Drawing.Point(0, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 72);
            this.panel1.TabIndex = 100;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.text_serve_pass);
            this.groupBox3.Controls.Add(this.rb_sql);
            this.groupBox3.Controls.Add(this.rb_windows);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.text_serve_username);
            this.groupBox3.Controls.Add(this.text_servername);
            this.groupBox3.Controls.Add(this.text_databasename);
            this.groupBox3.Font = new System.Drawing.Font("Akhbar MT", 16F);
            this.groupBox3.Location = new System.Drawing.Point(0, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 415);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اعدادات السيرفر";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rb_sql
            // 
            this.rb_sql.AutoSize = true;
            this.rb_sql.Font = new System.Drawing.Font("Akhbar MT", 12F);
            this.rb_sql.Location = new System.Drawing.Point(135, 226);
            this.rb_sql.Name = "rb_sql";
            this.rb_sql.Size = new System.Drawing.Size(239, 32);
            this.rb_sql.TabIndex = 82;
            this.rb_sql.Text = "SQL Server authentication";
            this.rb_sql.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rb_sql.UseVisualStyleBackColor = true;
            this.rb_sql.CheckedChanged += new System.EventHandler(this.rb_sql_CheckedChanged);
            // 
            // rb_windows
            // 
            this.rb_windows.AutoSize = true;
            this.rb_windows.Checked = true;
            this.rb_windows.Font = new System.Drawing.Font("Akhbar MT", 12F);
            this.rb_windows.Location = new System.Drawing.Point(153, 176);
            this.rb_windows.Name = "rb_windows";
            this.rb_windows.Size = new System.Drawing.Size(221, 32);
            this.rb_windows.TabIndex = 81;
            this.rb_windows.TabStop = true;
            this.rb_windows.Text = "windows  Authentication";
            this.rb_windows.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rb_windows.UseVisualStyleBackColor = true;
            this.rb_windows.CheckedChanged += new System.EventHandler(this.rb_windows_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Akhbar MT", 16F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(402, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 47);
            this.label9.TabIndex = 80;
            this.label9.Text = "نوع الإتصال";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Akhbar MT", 16F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(402, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 47);
            this.label6.TabIndex = 79;
            this.label6.Text = "اسم المستخدم ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Akhbar MT", 16F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(402, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 47);
            this.label7.TabIndex = 78;
            this.label7.Text = "قاعدة البيانات";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Akhbar MT", 16F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(402, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 47);
            this.label8.TabIndex = 77;
            this.label8.Text = "اسم السيرفر";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_serve_username
            // 
            this.text_serve_username.BackColor = System.Drawing.SystemColors.Window;
            this.text_serve_username.Enabled = false;
            this.text_serve_username.Font = new System.Drawing.Font("Tahoma", 16F);
            this.text_serve_username.ForeColor = System.Drawing.Color.Black;
            this.text_serve_username.Location = new System.Drawing.Point(146, 293);
            this.text_serve_username.Multiline = true;
            this.text_serve_username.Name = "text_serve_username";
            this.text_serve_username.Size = new System.Drawing.Size(228, 35);
            this.text_serve_username.TabIndex = 3;
            // 
            // text_servername
            // 
            this.text_servername.BackColor = System.Drawing.Color.White;
            this.text_servername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_servername.Font = new System.Drawing.Font("Tahoma", 16F);
            this.text_servername.ForeColor = System.Drawing.Color.Black;
            this.text_servername.Location = new System.Drawing.Point(146, 41);
            this.text_servername.Multiline = true;
            this.text_servername.Name = "text_servername";
            this.text_servername.Size = new System.Drawing.Size(228, 35);
            this.text_servername.TabIndex = 0;
            // 
            // text_databasename
            // 
            this.text_databasename.BackColor = System.Drawing.Color.White;
            this.text_databasename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_databasename.Font = new System.Drawing.Font("Tahoma", 16F);
            this.text_databasename.ForeColor = System.Drawing.Color.Black;
            this.text_databasename.Location = new System.Drawing.Point(146, 97);
            this.text_databasename.Multiline = true;
            this.text_databasename.Name = "text_databasename";
            this.text_databasename.Size = new System.Drawing.Size(228, 35);
            this.text_databasename.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Akhbar MT", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(402, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 47);
            this.label1.TabIndex = 84;
            this.label1.Text = "كلمة المرور";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_serve_pass
            // 
            this.text_serve_pass.BackColor = System.Drawing.SystemColors.Window;
            this.text_serve_pass.Enabled = false;
            this.text_serve_pass.Font = new System.Drawing.Font("Tahoma", 16F);
            this.text_serve_pass.ForeColor = System.Drawing.Color.Black;
            this.text_serve_pass.Location = new System.Drawing.Point(146, 358);
            this.text_serve_pass.Multiline = true;
            this.text_serve_pass.Name = "text_serve_pass";
            this.text_serve_pass.Size = new System.Drawing.Size(228, 35);
            this.text_serve_pass.TabIndex = 83;
            // 
            // con_butt_clos
            // 
            this.con_butt_clos.ActiveBorderThickness = 1;
            this.con_butt_clos.ActiveCornerRadius = 20;
            this.con_butt_clos.ActiveFillColor = System.Drawing.Color.Red;
            this.con_butt_clos.ActiveForecolor = System.Drawing.Color.White;
            this.con_butt_clos.ActiveLineColor = System.Drawing.Color.Red;
            this.con_butt_clos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.con_butt_clos.Location = new System.Drawing.Point(133, 5);
            this.con_butt_clos.Margin = new System.Windows.Forms.Padding(5);
            this.con_butt_clos.Name = "con_butt_clos";
            this.con_butt_clos.Size = new System.Drawing.Size(137, 48);
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
            this.con_butt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.con_butt_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("con_butt_save.BackgroundImage")));
            this.con_butt_save.ButtonText = "حفظ الإعدادات";
            this.con_butt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.con_butt_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_butt_save.ForeColor = System.Drawing.Color.Green;
            this.con_butt_save.IdleBorderThickness = 1;
            this.con_butt_save.IdleCornerRadius = 20;
            this.con_butt_save.IdleFillColor = System.Drawing.Color.White;
            this.con_butt_save.IdleForecolor = System.Drawing.Color.Green;
            this.con_butt_save.IdleLineColor = System.Drawing.Color.Green;
            this.con_butt_save.Location = new System.Drawing.Point(312, 5);
            this.con_butt_save.Margin = new System.Windows.Forms.Padding(5);
            this.con_butt_save.Name = "con_butt_save";
            this.con_butt_save.Size = new System.Drawing.Size(137, 48);
            this.con_butt_save.TabIndex = 0;
            this.con_butt_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.con_butt_save.Click += new System.EventHandler(this.con_butt_save_Click);
            // 
            // Form_server_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 523);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_server_config";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات السيرفر";
            this.Load += new System.EventHandler(this.Form_server_config_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 con_butt_save;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_sql;
        private System.Windows.Forms.RadioButton rb_windows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox text_serve_username;
        public System.Windows.Forms.TextBox text_servername;
        public System.Windows.Forms.TextBox text_databasename;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox text_serve_pass;
        private Bunifu.Framework.UI.BunifuThinButton2 con_butt_clos;
    }
}