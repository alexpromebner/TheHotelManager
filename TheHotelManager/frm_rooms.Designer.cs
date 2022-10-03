﻿namespace TheHotelManager
{
    partial class frm_rooms
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
            this.lbl_roomType = new System.Windows.Forms.Label();
            this.cb_roomType = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.MaskedTextBox();
            this.txt_surname = new System.Windows.Forms.MaskedTextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_addR = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(1, 1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 17;
            this.pbx_logo.TabStop = false;
            // 
            // lbl_roomType
            // 
            this.lbl_roomType.AutoSize = true;
            this.lbl_roomType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomType.Location = new System.Drawing.Point(131, 9);
            this.lbl_roomType.Name = "lbl_roomType";
            this.lbl_roomType.Size = new System.Drawing.Size(149, 22);
            this.lbl_roomType.TabIndex = 22;
            this.lbl_roomType.Text = "How many beds?";
            // 
            // cb_roomType
            // 
            this.cb_roomType.FormattingEnabled = true;
            this.cb_roomType.Items.AddRange(new object[] {
            "single bed",
            "double bed",
            "three beds",
            "four beds"});
            this.cb_roomType.Location = new System.Drawing.Point(135, 34);
            this.cb_roomType.Name = "cb_roomType";
            this.cb_roomType.Size = new System.Drawing.Size(282, 21);
            this.cb_roomType.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Standard",
            "Luxury",
            "Kids",
            "Youth"});
            this.comboBox1.Location = new System.Drawing.Point(135, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Room Type:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Silver;
            this.txt_name.Location = new System.Drawing.Point(12, 160);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(405, 21);
            this.txt_name.TabIndex = 26;
            this.txt_name.Text = "Name";
            this.txt_name.Click += new System.EventHandler(this.txt_name_Click);
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_surname.ForeColor = System.Drawing.Color.Silver;
            this.txt_surname.Location = new System.Drawing.Point(12, 187);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(405, 21);
            this.txt_surname.TabIndex = 27;
            this.txt_surname.Text = "Surname";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(12, 214);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(405, 20);
            this.dtp_date.TabIndex = 28;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(12, 292);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(164, 31);
            this.lbl_price.TabIndex = 29;
            this.lbl_price.Text = "Price: (Price)";
            // 
            // btn_addR
            // 
            this.btn_addR.BackColor = System.Drawing.Color.Gray;
            this.btn_addR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addR.ForeColor = System.Drawing.Color.White;
            this.btn_addR.Location = new System.Drawing.Point(12, 356);
            this.btn_addR.Name = "btn_addR";
            this.btn_addR.Size = new System.Drawing.Size(202, 35);
            this.btn_addR.TabIndex = 30;
            this.btn_addR.Text = "Add Reservation";
            this.btn_addR.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gray;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(12, 397);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(202, 35);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // frm_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addR);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_roomType);
            this.Controls.Add(this.lbl_roomType);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.frm_rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_roomType;
        private System.Windows.Forms.ComboBox cb_roomType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_name;
        private System.Windows.Forms.MaskedTextBox txt_surname;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_addR;
        private System.Windows.Forms.Button btn_cancel;
    }
}