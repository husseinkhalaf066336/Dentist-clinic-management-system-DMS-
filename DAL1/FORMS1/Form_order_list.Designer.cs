namespace dentis
{
    partial class Form_order_list
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
            Bunifu.Framework.UI.BunifuTextbox txtbox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_order_list));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn1 = new Bunifu.Framework.UI.BunifuTileButton();
            txtbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox2
            // 
            txtbox2.BackColor = System.Drawing.Color.White;
            txtbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbox2.BackgroundImage")));
            txtbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            txtbox2.Enabled = false;
            txtbox2.Font = new System.Drawing.Font("Tahoma", 8F);
            txtbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            txtbox2.Icon = ((System.Drawing.Image)(resources.GetObject("txtbox2.Icon")));
            txtbox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            txtbox2.Location = new System.Drawing.Point(484, 79);
            txtbox2.Name = "txtbox2";
            txtbox2.Size = new System.Drawing.Size(39, 36);
            txtbox2.TabIndex = 99;
            txtbox2.text = "";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1386, 65);
            this.paneltop.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.label1.Font = new System.Drawing.Font("Akhbar MT", 26F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(501, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "إدارة الفواتير";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(95, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 49);
            this.label2.TabIndex = 81;
            this.label2.Text = "ابحث";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(180, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(343, 34);
            this.textBox1.TabIndex = 80;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Akhbar MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Akhbar MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1349, 506);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Akhbar MT", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1374, 547);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الفواتير";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.panel1.Location = new System.Drawing.Point(0, 662);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 126);
            this.panel1.TabIndex = 82;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::dentis.Properties.Resources.order_ecommerce_payment_bill_512;
            this.bunifuTileButton2.ImagePosition = 0;
            this.bunifuTileButton2.ImageZoom = 45;
            this.bunifuTileButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuTileButton2.LabelPosition = 37;
            this.bunifuTileButton2.LabelText = "تفاصيل الفاتورة";
            this.bunifuTileButton2.Location = new System.Drawing.Point(756, -1);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(186, 109);
            this.bunifuTileButton2.TabIndex = 31;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::dentis.Properties.Resources.Ecommerce_Set_30_512;
            this.bunifuTileButton1.ImagePosition = 0;
            this.bunifuTileButton1.ImageZoom = 35;
            this.bunifuTileButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuTileButton1.LabelPosition = 35;
            this.bunifuTileButton1.LabelText = "اضافة دفعة للفاتورة";
            this.bunifuTileButton1.Location = new System.Drawing.Point(973, 0);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(213, 109);
            this.bunifuTileButton1.TabIndex = 30;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click_2);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Tahoma", 18F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::dentis.Properties.Resources._420_512;
            this.bunifuTileButton3.ImagePosition = 0;
            this.bunifuTileButton3.ImageZoom = 45;
            this.bunifuTileButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuTileButton3.LabelPosition = 37;
            this.bunifuTileButton3.LabelText = "رجوع";
            this.bunifuTileButton3.Location = new System.Drawing.Point(19, 0);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(161, 114);
            this.bunifuTileButton3.TabIndex = 29;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.btn7.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.btn7.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Image = global::dentis.Properties.Resources.PDF_File_Add_2_5121;
            this.btn7.ImagePosition = 0;
            this.btn7.ImageZoom = 45;
            this.btn7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn7.LabelPosition = 37;
            this.btn7.LabelText = "PDFحفظ التقرير";
            this.btn7.Location = new System.Drawing.Point(195, 0);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(169, 114);
            this.btn7.TabIndex = 28;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.btn5.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.btn5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Image = global::dentis.Properties.Resources.icon_157_5121;
            this.btn5.ImagePosition = 0;
            this.btn5.ImageZoom = 45;
            this.btn5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn5.LabelPosition = 37;
            this.btn5.LabelText = "طباعة الفاتورة";
            this.btn5.Location = new System.Drawing.Point(391, 0);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(181, 109);
            this.btn5.TabIndex = 26;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.btn2.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.btn2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Image = global::dentis.Properties.Resources._007_remove_trash_5121;
            this.btn2.ImagePosition = 0;
            this.btn2.ImageZoom = 45;
            this.btn2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn2.LabelPosition = 37;
            this.btn2.LabelText = "حذف";
            this.btn2.Location = new System.Drawing.Point(581, -1);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(152, 110);
            this.btn2.TabIndex = 23;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.btn1.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(173)))));
            this.btn1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Image = global::dentis.Properties.Resources.add1_5121;
            this.btn1.ImagePosition = 0;
            this.btn1.ImageZoom = 45;
            this.btn1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn1.LabelPosition = 37;
            this.btn1.LabelText = "فاتورة جديدة";
            this.btn1.Location = new System.Drawing.Point(1200, 0);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(161, 108);
            this.btn1.TabIndex = 22;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form_order_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(txtbox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_order_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_order_list";
            this.Load += new System.EventHandler(this.Form_order_list_Load);
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton btn7;
        private Bunifu.Framework.UI.BunifuTileButton btn5;
        public Bunifu.Framework.UI.BunifuTileButton btn2;
        private Bunifu.Framework.UI.BunifuTileButton btn1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
    }
}