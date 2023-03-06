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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
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
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(340, 430);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_contactAdmin
            // 
            this.lbl_contactAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_contactAdmin.AutoSize = true;
            this.lbl_contactAdmin.BackColor = System.Drawing.Color.White;
            this.lbl_contactAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactAdmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_contactAdmin.Location = new System.Drawing.Point(21, 426);
            this.lbl_contactAdmin.Name = "lbl_contactAdmin";
            this.lbl_contactAdmin.Size = new System.Drawing.Size(136, 20);
            this.lbl_contactAdmin.TabIndex = 4;
            this.lbl_contactAdmin.Text = "Contact an admin";
            this.lbl_contactAdmin.Click += new System.EventHandler(this.lbl_contactAdmin_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_employee.BackColor = System.Drawing.Color.Gray;
            this.btn_employee.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(190, 301);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(166, 49);
            this.btn_employee.TabIndex = 3;
            this.btn_employee.Text = "Employees";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_restaurant
            // 
            this.btn_restaurant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_restaurant.BackColor = System.Drawing.Color.Gray;
            this.btn_restaurant.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurant.ForeColor = System.Drawing.Color.White;
            this.btn_restaurant.Location = new System.Drawing.Point(190, 222);
            this.btn_restaurant.Name = "btn_restaurant";
            this.btn_restaurant.Size = new System.Drawing.Size(166, 49);
            this.btn_restaurant.TabIndex = 2;
            this.btn_restaurant.Text = "Restaurant";
            this.btn_restaurant.UseVisualStyleBackColor = false;
            this.btn_restaurant.Click += new System.EventHandler(this.btn_restaurant_Click);
            // 
            // btn_hotel
            // 
            this.btn_hotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hotel.BackColor = System.Drawing.Color.Gray;
            this.btn_hotel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hotel.ForeColor = System.Drawing.Color.White;
            this.btn_hotel.Location = new System.Drawing.Point(190, 143);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Size = new System.Drawing.Size(166, 49);
            this.btn_hotel.TabIndex = 1;
            this.btn_hotel.Text = "Hotel";
            this.btn_hotel.UseVisualStyleBackColor = false;
            this.btn_hotel.Click += new System.EventHandler(this.btn_hotel_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(154, 7);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(264, 39);
            this.lbl_welcome.TabIndex = 6;
            this.lbl_welcome.Text = "Welcome, (user)!";
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(-1, -1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 14;
            this.pbx_logo.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 467);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_contactAdmin);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_restaurant);
            this.Controls.Add(this.btn_hotel);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pbx_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(445, 506);
            this.MinimumSize = new System.Drawing.Size(445, 506);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_contactAdmin;
        private System.Windows.Forms.PictureBox pbx_logo;
        public System.Windows.Forms.Button btn_employee;
        public System.Windows.Forms.Button btn_restaurant;
        public System.Windows.Forms.Button btn_hotel;
        public System.Windows.Forms.Label lbl_welcome;
    }
}