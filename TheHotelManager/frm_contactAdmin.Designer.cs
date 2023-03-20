namespace TheHotelManager
{
    partial class frm_contactAdmin
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
            this.lbl_problems = new System.Windows.Forms.Label();
            this.btn_backA = new System.Windows.Forms.Button();
            this.lbl_other = new System.Windows.Forms.Label();
            this.txt_other = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cb_problems = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.btn_backWarehouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_problems
            // 
            this.lbl_problems.AutoSize = true;
            this.lbl_problems.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_problems.Location = new System.Drawing.Point(140, 9);
            this.lbl_problems.Name = "lbl_problems";
            this.lbl_problems.Size = new System.Drawing.Size(277, 26);
            this.lbl_problems.TabIndex = 22;
            this.lbl_problems.Text = "Do you have any problems?";
            // 
            // btn_backA
            // 
            this.btn_backA.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backA.Location = new System.Drawing.Point(453, 414);
            this.btn_backA.Name = "btn_backA";
            this.btn_backA.Size = new System.Drawing.Size(75, 23);
            this.btn_backA.TabIndex = 23;
            this.btn_backA.Text = "Back";
            this.btn_backA.UseVisualStyleBackColor = true;
            this.btn_backA.Click += new System.EventHandler(this.btn_backA_Click);
            // 
            // lbl_other
            // 
            this.lbl_other.AutoSize = true;
            this.lbl_other.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_other.Location = new System.Drawing.Point(140, 116);
            this.lbl_other.Name = "lbl_other";
            this.lbl_other.Size = new System.Drawing.Size(54, 26);
            this.lbl_other.TabIndex = 25;
            this.lbl_other.Text = "Text";
            // 
            // txt_other
            // 
            this.txt_other.Location = new System.Drawing.Point(145, 155);
            this.txt_other.Multiline = true;
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(271, 292);
            this.txt_other.TabIndex = 26;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Gray;
            this.btn_send.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(12, 363);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(113, 35);
            this.btn_send.TabIndex = 29;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gray;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(12, 404);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 35);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_problems
            // 
            this.cb_problems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_problems.FormattingEnabled = true;
            this.cb_problems.Items.AddRange(new object[] {
            "Cancellation",
            "User",
            "Role",
            "Password",
            "Other"});
            this.cb_problems.Location = new System.Drawing.Point(145, 40);
            this.cb_problems.Name = "cb_problems";
            this.cb_problems.Size = new System.Drawing.Size(271, 21);
            this.cb_problems.TabIndex = 30;
            this.cb_problems.SelectedIndexChanged += new System.EventHandler(this.cb_problems_SelectedIndexChanged);
            // 
            // txt_email
            // 
            this.txt_email.ForeColor = System.Drawing.Color.Silver;
            this.txt_email.Location = new System.Drawing.Point(145, 77);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(271, 20);
            this.txt_email.TabIndex = 31;
            this.txt_email.Text = "Enter your Email";
            this.txt_email.Click += new System.EventHandler(this.txt_email_Click);
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(1, 1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 1;
            this.pbx_logo.TabStop = false;
            // 
            // btn_backWarehouse
            // 
            this.btn_backWarehouse.Enabled = false;
            this.btn_backWarehouse.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backWarehouse.Location = new System.Drawing.Point(453, 414);
            this.btn_backWarehouse.Name = "btn_backWarehouse";
            this.btn_backWarehouse.Size = new System.Drawing.Size(75, 23);
            this.btn_backWarehouse.TabIndex = 32;
            this.btn_backWarehouse.Text = "Back";
            this.btn_backWarehouse.UseVisualStyleBackColor = true;
            this.btn_backWarehouse.Click += new System.EventHandler(this.btn_backWarehouse_Click);
            // 
            // frm_contactAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 457);
            this.Controls.Add(this.btn_backWarehouse);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.cb_problems);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_other);
            this.Controls.Add(this.lbl_other);
            this.Controls.Add(this.btn_backA);
            this.Controls.Add(this.lbl_problems);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_contactAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.frm_contactAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_problems;
        private System.Windows.Forms.Button btn_backA;
        private System.Windows.Forms.Label lbl_other;
        private System.Windows.Forms.TextBox txt_other;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_email;
        public System.Windows.Forms.ComboBox cb_problems;
        public System.Windows.Forms.Button btn_backWarehouse;
    }
}