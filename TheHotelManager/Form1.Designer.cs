namespace TheHotelManager
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_hotel = new System.Windows.Forms.Button();
            this.btn_restaurant = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.lbl_contactAdmin = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(156, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(264, 39);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome, (user)!";
            // 
            // btn_hotel
            // 
            this.btn_hotel.BackColor = System.Drawing.Color.Gray;
            this.btn_hotel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hotel.ForeColor = System.Drawing.Color.White;
            this.btn_hotel.Location = new System.Drawing.Point(192, 134);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Size = new System.Drawing.Size(166, 49);
            this.btn_hotel.TabIndex = 2;
            this.btn_hotel.Text = "Hotel";
            this.btn_hotel.UseVisualStyleBackColor = false;
            this.btn_hotel.Click += new System.EventHandler(this.btn_hotel_Click);
            // 
            // btn_restaurant
            // 
            this.btn_restaurant.BackColor = System.Drawing.Color.Gray;
            this.btn_restaurant.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurant.ForeColor = System.Drawing.Color.White;
            this.btn_restaurant.Location = new System.Drawing.Point(192, 213);
            this.btn_restaurant.Name = "btn_restaurant";
            this.btn_restaurant.Size = new System.Drawing.Size(166, 49);
            this.btn_restaurant.TabIndex = 3;
            this.btn_restaurant.Text = "Restaurant";
            this.btn_restaurant.UseVisualStyleBackColor = false;
            this.btn_restaurant.Click += new System.EventHandler(this.btn_restaurant_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.Gray;
            this.btn_employee.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(192, 292);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(166, 49);
            this.btn_employee.TabIndex = 4;
            this.btn_employee.Text = "Employees";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // lbl_contactAdmin
            // 
            this.lbl_contactAdmin.AutoSize = true;
            this.lbl_contactAdmin.BackColor = System.Drawing.Color.White;
            this.lbl_contactAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactAdmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_contactAdmin.Location = new System.Drawing.Point(23, 405);
            this.lbl_contactAdmin.Name = "lbl_contactAdmin";
            this.lbl_contactAdmin.Size = new System.Drawing.Size(136, 20);
            this.lbl_contactAdmin.TabIndex = 5;
            this.lbl_contactAdmin.Text = "Contact an admin";
            this.lbl_contactAdmin.Click += new System.EventHandler(this.lbl_contactAdmin_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(342, 409);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(1, 1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 0;
            this.pbx_logo.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_contactAdmin);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_restaurant);
            this.Controls.Add(this.btn_hotel);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheHotelManager";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_hotel;
        private System.Windows.Forms.Button btn_restaurant;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Label lbl_contactAdmin;
        private System.Windows.Forms.Button btn_logout;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

