namespace TheHotelManager
{
    partial class frm_addemployee
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
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.btn_finished = new System.Windows.Forms.Button();
            this.txt_repeatpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(12, 12);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(88, 74);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 1;
            this.pbx_logo.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(151, 57);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(183, 29);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Add Employee";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(169, 279);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(157, 20);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(32, 277);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(77, 20);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "password";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(32, 150);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(91, 20);
            this.lbl_department.TabIndex = 6;
            this.lbl_department.Text = "department";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(169, 195);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 20);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(32, 193);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 20);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "name";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(169, 235);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(157, 20);
            this.txt_surname.TabIndex = 3;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(32, 233);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(71, 20);
            this.lbl_surname.TabIndex = 12;
            this.lbl_surname.Text = "surname";
            // 
            // btn_finished
            // 
            this.btn_finished.BackColor = System.Drawing.Color.Gray;
            this.btn_finished.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finished.ForeColor = System.Drawing.Color.White;
            this.btn_finished.Location = new System.Drawing.Point(65, 356);
            this.btn_finished.Name = "btn_finished";
            this.btn_finished.Size = new System.Drawing.Size(232, 54);
            this.btn_finished.TabIndex = 6;
            this.btn_finished.Text = "Finished";
            this.btn_finished.UseVisualStyleBackColor = false;
            this.btn_finished.Click += new System.EventHandler(this.btn_finished_Click);
            // 
            // txt_repeatpw
            // 
            this.txt_repeatpw.Location = new System.Drawing.Point(169, 319);
            this.txt_repeatpw.Name = "txt_repeatpw";
            this.txt_repeatpw.Size = new System.Drawing.Size(157, 20);
            this.txt_repeatpw.TabIndex = 5;
            this.txt_repeatpw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "repeat password";
            // 
            // cmb_department
            // 
            this.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Items.AddRange(new object[] {
            "Cleaning",
            "Reception",
            "Restaurant"});
            this.cmb_department.Location = new System.Drawing.Point(169, 149);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(157, 21);
            this.cmb_department.TabIndex = 1;
            // 
            // frm_addemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 439);
            this.Controls.Add(this.cmb_department);
            this.Controls.Add(this.txt_repeatpw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_finished);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_addemployee";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.frm_editemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Button btn_finished;
        private System.Windows.Forms.TextBox txt_repeatpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_department;
    }
}