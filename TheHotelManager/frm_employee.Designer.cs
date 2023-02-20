namespace TheHotelManager
{
    partial class frm_employee
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
            this.lbl_choose = new System.Windows.Forms.Label();
            this.btn_backR = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose.Location = new System.Drawing.Point(139, 9);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(282, 28);
            this.lbl_choose.TabIndex = 21;
            this.lbl_choose.Text = "What do you want to do?";
            // 
            // btn_backR
            // 
            this.btn_backR.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backR.Location = new System.Drawing.Point(727, 551);
            this.btn_backR.Name = "btn_backR";
            this.btn_backR.Size = new System.Drawing.Size(75, 23);
            this.btn_backR.TabIndex = 20;
            this.btn_backR.Text = "Back";
            this.btn_backR.UseVisualStyleBackColor = true;
            this.btn_backR.Click += new System.EventHandler(this.btn_backR_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gray;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(12, 536);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 35);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gray;
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(12, 495);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 35);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Gray;
            this.btn_change.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.ForeColor = System.Drawing.Color.White;
            this.btn_change.Location = new System.Drawing.Point(12, 454);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(113, 35);
            this.btn_change.TabIndex = 23;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(1, 1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 16;
            this.pbx_logo.TabStop = false;
            // 
            // dgv_employees
            // 
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Location = new System.Drawing.Point(144, 271);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.Size = new System.Drawing.Size(658, 259);
            this.dgv_employees.TabIndex = 26;
            this.dgv_employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_employees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_employees_RowHeaderMouseClick);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(140, 71);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(56, 21);
            this.lbl_name.TabIndex = 27;
            this.lbl_name.Text = "Name";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(140, 106);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(78, 21);
            this.lbl_surname.TabIndex = 28;
            this.lbl_surname.Text = "Surname";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(140, 177);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(102, 21);
            this.lbl_department.TabIndex = 29;
            this.lbl_department.Text = "Department";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(140, 141);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(82, 21);
            this.lbl_password.TabIndex = 30;
            this.lbl_password.Text = "Password";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(256, 74);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(194, 20);
            this.txt_name.TabIndex = 31;
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(507, 158);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(194, 20);
            this.txt_department.TabIndex = 32;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(256, 144);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(194, 20);
            this.txt_password.TabIndex = 33;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(256, 109);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(194, 20);
            this.txt_surname.TabIndex = 34;
            // 
            // cb_department
            // 
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "admin",
            "Cleaning",
            "Reception",
            "Restaurant"});
            this.cb_department.Location = new System.Drawing.Point(256, 180);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(194, 21);
            this.cb_department.TabIndex = 35;
            // 
            // frm_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 586);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.dgv_employees);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.btn_backR);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frm_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choose;
        private System.Windows.Forms.Button btn_backR;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.ComboBox cb_department;
    }
}