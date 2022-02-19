namespace dentis
{
    partial class form_choos_state
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_choos_state));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_pat = new System.Windows.Forms.DataGridView();
            this.txtbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(136, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 78;
            this.label1.Text = "ابحث";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(235, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(323, 33);
            this.textBox1.TabIndex = 77;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_pat
            // 
            this.dgv_pat.AllowUserToAddRows = false;
            this.dgv_pat.AllowUserToDeleteRows = false;
            this.dgv_pat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pat.GridColor = System.Drawing.Color.CadetBlue;
            this.dgv_pat.Location = new System.Drawing.Point(-1, 35);
            this.dgv_pat.MultiSelect = false;
            this.dgv_pat.Name = "dgv_pat";
            this.dgv_pat.ReadOnly = true;
            this.dgv_pat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_pat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pat.Size = new System.Drawing.Size(966, 465);
            this.dgv_pat.TabIndex = 76;
            this.dgv_pat.DoubleClick += new System.EventHandler(this.dgv_pat_DoubleClick);
            // 
            // txtbox1
            // 
            this.txtbox1.BackColor = System.Drawing.Color.White;
            this.txtbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbox1.BackgroundImage")));
            this.txtbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbox1.Enabled = false;
            this.txtbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
            this.txtbox1.Icon = ((System.Drawing.Image)(resources.GetObject("txtbox1.Icon")));
            this.txtbox1.Location = new System.Drawing.Point(511, 2);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(47, 34);
            this.txtbox1.TabIndex = 81;
            this.txtbox1.text = "";
            // 
            // form_choos_state
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 502);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_pat);
            this.MaximizeBox = false;
            this.Name = "form_choos_state";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحالات المرضية";
            this.Load += new System.EventHandler(this.form_choos_state_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dgv_pat;
        private Bunifu.Framework.UI.BunifuTextbox txtbox1;
    }
}