namespace TheHotelManager
{
    partial class frm_main
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_contactAdmin = new System.Windows.Forms.Label();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_restaurant = new System.Windows.Forms.Button();
            this.btn_hotel = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(339, 407);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 13;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_contactAdmin
            // 
            this.lbl_contactAdmin.AutoSize = true;
            this.lbl_contactAdmin.BackColor = System.Drawing.Color.White;
            this.lbl_contactAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactAdmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_contactAdmin.Location = new System.Drawing.Point(20, 403);
            this.lbl_contactAdmin.Name = "lbl_contactAdmin";
            this.lbl_contactAdmin.Size = new System.Drawing.Size(136, 20);
            this.lbl_contactAdmin.TabIndex = 12;
            this.lbl_contactAdmin.Text = "Contact an admin";
            this.lbl_contactAdmin.Click += new System.EventHandler(this.lbl_contactAdmin_Click_1);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.Gray;
            this.btn_employee.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(189, 290);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(166, 49);
            this.btn_employee.TabIndex = 11;
            this.btn_employee.Text = "Employees";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click_1);
            // 
            // btn_restaurant
            // 
            this.btn_restaurant.BackColor = System.Drawing.Color.Gray;
            this.btn_restaurant.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurant.ForeColor = System.Drawing.Color.White;
            this.btn_restaurant.Location = new System.Drawing.Point(189, 211);
            this.btn_restaurant.Name = "btn_restaurant";
            this.btn_restaurant.Size = new System.Drawing.Size(166, 49);
            this.btn_restaurant.TabIndex = 10;
            this.btn_restaurant.Text = "Restaurant";
            this.btn_restaurant.UseVisualStyleBackColor = false;
            this.btn_restaurant.Click += new System.EventHandler(this.btn_restaurant_Click_1);
            // 
            // btn_hotel
            // 
            this.btn_hotel.BackColor = System.Drawing.Color.Gray;
            this.btn_hotel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hotel.ForeColor = System.Drawing.Color.White;
            this.btn_hotel.Location = new System.Drawing.Point(189, 132);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Size = new System.Drawing.Size(166, 49);
            this.btn_hotel.TabIndex = 9;
            this.btn_hotel.Text = "Hotel";
            this.btn_hotel.UseVisualStyleBackColor = false;
            this.btn_hotel.Click += new System.EventHandler(this.btn_hotel_Click_1);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(153, 7);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(264, 39);
            this.lbl_welcome.TabIndex = 8;
            this.lbl_welcome.Text = "Welcome, (user)!";
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(-2, -1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 7;
            this.pbx_logo.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_contactAdmin);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_restaurant);
            this.Controls.Add(this.btn_hotel);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pbx_logo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_contactAdmin;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_restaurant;
        private System.Windows.Forms.Button btn_hotel;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.PictureBox pbx_logo;
    }
}