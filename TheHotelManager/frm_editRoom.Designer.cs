namespace TheHotelManager
{
    partial class frm_editRoom
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
            this.btn_backEditRoom = new System.Windows.Forms.Button();
            this.btn_deleteR = new System.Windows.Forms.Button();
            this.btn_saveR = new System.Windows.Forms.Button();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.lbl_editRooms = new System.Windows.Forms.Label();
            this.dgv_rooms = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.MaskedTextBox();
            this.cb_roomNumber = new System.Windows.Forms.ComboBox();
            this.lbl_roomNumber = new System.Windows.Forms.Label();
            this.lbl_roomType = new System.Windows.Forms.Label();
            this.cb_roomType = new System.Windows.Forms.ComboBox();
            this.txt_surname = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_dateTo = new System.Windows.Forms.DateTimePicker();
            this.txt_price = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backEditRoom
            // 
            this.btn_backEditRoom.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backEditRoom.Location = new System.Drawing.Point(341, 409);
            this.btn_backEditRoom.Name = "btn_backEditRoom";
            this.btn_backEditRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_backEditRoom.TabIndex = 49;
            this.btn_backEditRoom.Text = "Back";
            this.btn_backEditRoom.UseVisualStyleBackColor = true;
            this.btn_backEditRoom.Click += new System.EventHandler(this.btn_backEditRoom_Click);
            // 
            // btn_deleteR
            // 
            this.btn_deleteR.BackColor = System.Drawing.Color.Gray;
            this.btn_deleteR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteR.ForeColor = System.Drawing.Color.White;
            this.btn_deleteR.Location = new System.Drawing.Point(6, 397);
            this.btn_deleteR.Name = "btn_deleteR";
            this.btn_deleteR.Size = new System.Drawing.Size(202, 35);
            this.btn_deleteR.TabIndex = 48;
            this.btn_deleteR.Text = "Delete";
            this.btn_deleteR.UseVisualStyleBackColor = false;
            this.btn_deleteR.Click += new System.EventHandler(this.btn_deleteR_Click);
            // 
            // btn_saveR
            // 
            this.btn_saveR.BackColor = System.Drawing.Color.Gray;
            this.btn_saveR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveR.ForeColor = System.Drawing.Color.White;
            this.btn_saveR.Location = new System.Drawing.Point(6, 356);
            this.btn_saveR.Name = "btn_saveR";
            this.btn_saveR.Size = new System.Drawing.Size(202, 35);
            this.btn_saveR.TabIndex = 47;
            this.btn_saveR.Text = "Save";
            this.btn_saveR.UseVisualStyleBackColor = false;
            this.btn_saveR.Click += new System.EventHandler(this.btn_saveR_Click);
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(-1, 0);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 38;
            this.pbx_logo.TabStop = false;
            // 
            // lbl_editRooms
            // 
            this.lbl_editRooms.AutoSize = true;
            this.lbl_editRooms.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editRooms.Location = new System.Drawing.Point(234, 0);
            this.lbl_editRooms.Name = "lbl_editRooms";
            this.lbl_editRooms.Size = new System.Drawing.Size(183, 39);
            this.lbl_editRooms.TabIndex = 54;
            this.lbl_editRooms.Text = "Edit Rooms";
            // 
            // dgv_rooms
            // 
            this.dgv_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rooms.Location = new System.Drawing.Point(6, 190);
            this.dgv_rooms.Name = "dgv_rooms";
            this.dgv_rooms.Size = new System.Drawing.Size(410, 148);
            this.dgv_rooms.TabIndex = 55;
            this.dgv_rooms.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_rooms_RowHeaderMouseClick);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Silver;
            this.txt_name.Location = new System.Drawing.Point(129, 91);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(142, 21);
            this.txt_name.TabIndex = 56;
            this.txt_name.Text = "Name";
            // 
            // cb_roomNumber
            // 
            this.cb_roomNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_roomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_roomNumber.FormattingEnabled = true;
            this.cb_roomNumber.Items.AddRange(new object[] {
            "single bed",
            "double bed",
            "three beds",
            "four beds"});
            this.cb_roomNumber.Location = new System.Drawing.Point(129, 64);
            this.cb_roomNumber.Name = "cb_roomNumber";
            this.cb_roomNumber.Size = new System.Drawing.Size(142, 21);
            this.cb_roomNumber.TabIndex = 57;
            // 
            // lbl_roomNumber
            // 
            this.lbl_roomNumber.AutoSize = true;
            this.lbl_roomNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNumber.Location = new System.Drawing.Point(125, 42);
            this.lbl_roomNumber.Name = "lbl_roomNumber";
            this.lbl_roomNumber.Size = new System.Drawing.Size(103, 19);
            this.lbl_roomNumber.TabIndex = 58;
            this.lbl_roomNumber.Text = "Room Number:";
            // 
            // lbl_roomType
            // 
            this.lbl_roomType.AutoSize = true;
            this.lbl_roomType.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomType.Location = new System.Drawing.Point(277, 42);
            this.lbl_roomType.Name = "lbl_roomType";
            this.lbl_roomType.Size = new System.Drawing.Size(81, 19);
            this.lbl_roomType.TabIndex = 60;
            this.lbl_roomType.Text = "Room Type:";
            // 
            // cb_roomType
            // 
            this.cb_roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_roomType.FormattingEnabled = true;
            this.cb_roomType.Items.AddRange(new object[] {
            "Standard",
            "Luxury",
            "Youth"});
            this.cb_roomType.Location = new System.Drawing.Point(281, 64);
            this.cb_roomType.Name = "cb_roomType";
            this.cb_roomType.Size = new System.Drawing.Size(142, 21);
            this.cb_roomType.TabIndex = 61;
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_surname.ForeColor = System.Drawing.Color.Silver;
            this.txt_surname.Location = new System.Drawing.Point(281, 91);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(142, 21);
            this.txt_surname.TabIndex = 62;
            this.txt_surname.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "To:";
            // 
            // dtp_dateFrom
            // 
            this.dtp_dateFrom.Location = new System.Drawing.Point(129, 137);
            this.dtp_dateFrom.Name = "dtp_dateFrom";
            this.dtp_dateFrom.Size = new System.Drawing.Size(142, 20);
            this.dtp_dateFrom.TabIndex = 65;
            // 
            // dtp_dateTo
            // 
            this.dtp_dateTo.Location = new System.Drawing.Point(281, 137);
            this.dtp_dateTo.Name = "dtp_dateTo";
            this.dtp_dateTo.Size = new System.Drawing.Size(142, 20);
            this.dtp_dateTo.TabIndex = 66;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.Color.Silver;
            this.txt_price.Location = new System.Drawing.Point(129, 163);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(288, 21);
            this.txt_price.TabIndex = 67;
            this.txt_price.Text = "Price";
            // 
            // frm_editRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.dtp_dateTo);
            this.Controls.Add(this.dtp_dateFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.cb_roomType);
            this.Controls.Add(this.lbl_roomType);
            this.Controls.Add(this.lbl_roomNumber);
            this.Controls.Add(this.cb_roomNumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_rooms);
            this.Controls.Add(this.lbl_editRooms);
            this.Controls.Add(this.btn_backEditRoom);
            this.Controls.Add(this.btn_deleteR);
            this.Controls.Add(this.btn_saveR);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_editRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_editRoom";
            this.Load += new System.EventHandler(this.frm_editRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_backEditRoom;
        private System.Windows.Forms.Button btn_deleteR;
        private System.Windows.Forms.Button btn_saveR;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_editRooms;
        private System.Windows.Forms.DataGridView dgv_rooms;
        private System.Windows.Forms.MaskedTextBox txt_name;
        private System.Windows.Forms.ComboBox cb_roomNumber;
        private System.Windows.Forms.Label lbl_roomNumber;
        private System.Windows.Forms.Label lbl_roomType;
        private System.Windows.Forms.ComboBox cb_roomType;
        private System.Windows.Forms.MaskedTextBox txt_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_dateFrom;
        private System.Windows.Forms.DateTimePicker dtp_dateTo;
        private System.Windows.Forms.MaskedTextBox txt_price;
    }
}