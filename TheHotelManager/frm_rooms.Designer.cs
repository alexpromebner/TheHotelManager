namespace TheHotelManager
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
            this.lbl_roomType = new System.Windows.Forms.Label();
            this.cb_peopleNumber = new System.Windows.Forms.ComboBox();
            this.cb_roomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.MaskedTextBox();
            this.txt_surname = new System.Windows.Forms.MaskedTextBox();
            this.dtp_dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_addR = new System.Windows.Forms.Button();
            this.edit_reservation = new System.Windows.Forms.Button();
            this.btn_backRooms = new System.Windows.Forms.Button();
            this.dtp_dateTo = new System.Windows.Forms.DateTimePicker();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_pricePerDay = new System.Windows.Forms.Label();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
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
            // cb_peopleNumber
            // 
            this.cb_peopleNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_peopleNumber.FormattingEnabled = true;
            this.cb_peopleNumber.Items.AddRange(new object[] {
            "single bed",
            "double bed",
            "three beds",
            "four beds"});
            this.cb_peopleNumber.Location = new System.Drawing.Point(135, 34);
            this.cb_peopleNumber.Name = "cb_peopleNumber";
            this.cb_peopleNumber.Size = new System.Drawing.Size(282, 21);
            this.cb_peopleNumber.TabIndex = 23;
            this.cb_peopleNumber.SelectedIndexChanged += new System.EventHandler(this.cb_peopleNumber_SelectedIndexChanged);
            // 
            // cb_roomType
            // 
            this.cb_roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_roomType.FormattingEnabled = true;
            this.cb_roomType.Items.AddRange(new object[] {
            "Standard",
            "Luxury",
            "Youth"});
            this.cb_roomType.Location = new System.Drawing.Point(135, 83);
            this.cb_roomType.Name = "cb_roomType";
            this.cb_roomType.Size = new System.Drawing.Size(282, 21);
            this.cb_roomType.TabIndex = 25;
            this.cb_roomType.SelectedIndexChanged += new System.EventHandler(this.cb_roomType_SelectedIndexChanged);
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
            this.txt_surname.Click += new System.EventHandler(this.txt_surname_Click);
            // 
            // dtp_dateFrom
            // 
            this.dtp_dateFrom.Location = new System.Drawing.Point(12, 228);
            this.dtp_dateFrom.Name = "dtp_dateFrom";
            this.dtp_dateFrom.Size = new System.Drawing.Size(197, 20);
            this.dtp_dateFrom.TabIndex = 28;
            this.dtp_dateFrom.ValueChanged += new System.EventHandler(this.dtp_dateFrom_ValueChanged);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(12, 289);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(80, 31);
            this.lbl_price.TabIndex = 29;
            this.lbl_price.Text = "Price:";
            // 
            // btn_addR
            // 
            this.btn_addR.BackColor = System.Drawing.Color.Gray;
            this.btn_addR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addR.ForeColor = System.Drawing.Color.White;
            this.btn_addR.Location = new System.Drawing.Point(7, 356);
            this.btn_addR.Name = "btn_addR";
            this.btn_addR.Size = new System.Drawing.Size(202, 35);
            this.btn_addR.TabIndex = 30;
            this.btn_addR.Text = "Add Reservation";
            this.btn_addR.UseVisualStyleBackColor = false;
            this.btn_addR.Click += new System.EventHandler(this.btn_addR_Click);
            // 
            // edit_reservation
            // 
            this.edit_reservation.BackColor = System.Drawing.Color.Gray;
            this.edit_reservation.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_reservation.ForeColor = System.Drawing.Color.White;
            this.edit_reservation.Location = new System.Drawing.Point(7, 397);
            this.edit_reservation.Name = "edit_reservation";
            this.edit_reservation.Size = new System.Drawing.Size(202, 35);
            this.edit_reservation.TabIndex = 32;
            this.edit_reservation.Text = "Edit Reservation";
            this.edit_reservation.UseVisualStyleBackColor = false;
            this.edit_reservation.Click += new System.EventHandler(this.edit_reservation_Click);
            // 
            // btn_backRooms
            // 
            this.btn_backRooms.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backRooms.Location = new System.Drawing.Point(342, 409);
            this.btn_backRooms.Name = "btn_backRooms";
            this.btn_backRooms.Size = new System.Drawing.Size(75, 23);
            this.btn_backRooms.TabIndex = 33;
            this.btn_backRooms.Text = "Back";
            this.btn_backRooms.UseVisualStyleBackColor = true;
            this.btn_backRooms.Click += new System.EventHandler(this.btn_backRooms_Click);
            // 
            // dtp_dateTo
            // 
            this.dtp_dateTo.Location = new System.Drawing.Point(220, 228);
            this.dtp_dateTo.Name = "dtp_dateTo";
            this.dtp_dateTo.Size = new System.Drawing.Size(197, 20);
            this.dtp_dateTo.TabIndex = 34;
            this.dtp_dateTo.ValueChanged += new System.EventHandler(this.dtp_dateTo_ValueChanged);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.Location = new System.Drawing.Point(9, 211);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(37, 16);
            this.lbl_from.TabIndex = 35;
            this.lbl_from.Text = "From:";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(217, 211);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(23, 16);
            this.lbl_to.TabIndex = 36;
            this.lbl_to.Text = "To:";
            // 
            // lbl_pricePerDay
            // 
            this.lbl_pricePerDay.AutoSize = true;
            this.lbl_pricePerDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pricePerDay.Location = new System.Drawing.Point(14, 320);
            this.lbl_pricePerDay.Name = "lbl_pricePerDay";
            this.lbl_pricePerDay.Size = new System.Drawing.Size(92, 19);
            this.lbl_pricePerDay.TabIndex = 37;
            this.lbl_pricePerDay.Text = "Price per day:";
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(0, 0);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 17;
            this.pbx_logo.TabStop = false;
            // 
            // frm_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.lbl_pricePerDay);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.dtp_dateTo);
            this.Controls.Add(this.btn_backRooms);
            this.Controls.Add(this.edit_reservation);
            this.Controls.Add(this.btn_addR);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.dtp_dateFrom);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cb_roomType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_peopleNumber);
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
        private System.Windows.Forms.ComboBox cb_peopleNumber;
        private System.Windows.Forms.ComboBox cb_roomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_name;
        private System.Windows.Forms.MaskedTextBox txt_surname;
        private System.Windows.Forms.DateTimePicker dtp_dateFrom;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_addR;
        private System.Windows.Forms.Button edit_reservation;
        private System.Windows.Forms.Button btn_backRooms;
        private System.Windows.Forms.DateTimePicker dtp_dateTo;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_pricePerDay;
    }
}