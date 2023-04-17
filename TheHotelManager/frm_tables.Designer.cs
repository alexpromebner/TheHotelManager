namespace TheHotelManager
{
    partial class frm_tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tables));
            this.btn_backRooms = new System.Windows.Forms.Button();
            this.edit_reservation = new System.Windows.Forms.Button();
            this.btn_addR = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_Tsurname = new System.Windows.Forms.MaskedTextBox();
            this.txt_Tname = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_roomType = new System.Windows.Forms.Label();
            this.nud_amount = new System.Windows.Forms.NumericUpDown();
            this.nud_tNumber = new System.Windows.Forms.NumericUpDown();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backRooms
            // 
            this.btn_backRooms.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backRooms.Location = new System.Drawing.Point(339, 409);
            this.btn_backRooms.Name = "btn_backRooms";
            this.btn_backRooms.Size = new System.Drawing.Size(75, 23);
            this.btn_backRooms.TabIndex = 46;
            this.btn_backRooms.Text = "Back";
            this.btn_backRooms.UseVisualStyleBackColor = true;
            this.btn_backRooms.Click += new System.EventHandler(this.btn_backRooms_Click);
            // 
            // edit_reservation
            // 
            this.edit_reservation.BackColor = System.Drawing.Color.Gray;
            this.edit_reservation.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_reservation.ForeColor = System.Drawing.Color.White;
            this.edit_reservation.Location = new System.Drawing.Point(9, 356);
            this.edit_reservation.Name = "edit_reservation";
            this.edit_reservation.Size = new System.Drawing.Size(217, 64);
            this.edit_reservation.TabIndex = 45;
            this.edit_reservation.Text = "Edit/Show Reservations";
            this.edit_reservation.UseVisualStyleBackColor = false;
            this.edit_reservation.Click += new System.EventHandler(this.edit_reservation_Click);
            // 
            // btn_addR
            // 
            this.btn_addR.BackColor = System.Drawing.Color.Gray;
            this.btn_addR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addR.ForeColor = System.Drawing.Color.White;
            this.btn_addR.Location = new System.Drawing.Point(9, 315);
            this.btn_addR.Name = "btn_addR";
            this.btn_addR.Size = new System.Drawing.Size(217, 35);
            this.btn_addR.TabIndex = 43;
            this.btn_addR.Text = "Add Reservation";
            this.btn_addR.UseVisualStyleBackColor = false;
            this.btn_addR.Click += new System.EventHandler(this.btn_addR_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(9, 214);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(405, 20);
            this.dtp_date.TabIndex = 41;
            // 
            // txt_Tsurname
            // 
            this.txt_Tsurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tsurname.ForeColor = System.Drawing.Color.Silver;
            this.txt_Tsurname.Location = new System.Drawing.Point(9, 187);
            this.txt_Tsurname.Name = "txt_Tsurname";
            this.txt_Tsurname.Size = new System.Drawing.Size(405, 21);
            this.txt_Tsurname.TabIndex = 40;
            this.txt_Tsurname.Text = "Surname";
            this.txt_Tsurname.Click += new System.EventHandler(this.txt_Tsurname_Click);
            // 
            // txt_Tname
            // 
            this.txt_Tname.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tname.ForeColor = System.Drawing.Color.Silver;
            this.txt_Tname.Location = new System.Drawing.Point(9, 160);
            this.txt_Tname.Name = "txt_Tname";
            this.txt_Tname.Size = new System.Drawing.Size(405, 21);
            this.txt_Tname.TabIndex = 39;
            this.txt_Tname.Text = "Name";
            this.txt_Tname.Click += new System.EventHandler(this.txt_Tname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "Table Number:";
            // 
            // lbl_roomType
            // 
            this.lbl_roomType.AutoSize = true;
            this.lbl_roomType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomType.Location = new System.Drawing.Point(128, 9);
            this.lbl_roomType.Name = "lbl_roomType";
            this.lbl_roomType.Size = new System.Drawing.Size(166, 22);
            this.lbl_roomType.TabIndex = 35;
            this.lbl_roomType.Text = "How many people?";
            // 
            // nud_amount
            // 
            this.nud_amount.Location = new System.Drawing.Point(132, 35);
            this.nud_amount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_amount.Name = "nud_amount";
            this.nud_amount.Size = new System.Drawing.Size(282, 20);
            this.nud_amount.TabIndex = 47;
            this.nud_amount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nud_tNumber
            // 
            this.nud_tNumber.Location = new System.Drawing.Point(132, 83);
            this.nud_tNumber.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud_tNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_tNumber.Name = "nud_tNumber";
            this.nud_tNumber.Size = new System.Drawing.Size(282, 20);
            this.nud_tNumber.TabIndex = 48;
            this.nud_tNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_notes
            // 
            this.txt_notes.ForeColor = System.Drawing.Color.Silver;
            this.txt_notes.Location = new System.Drawing.Point(9, 240);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(405, 51);
            this.txt_notes.TabIndex = 50;
            this.txt_notes.Text = "Notes";
            this.txt_notes.Click += new System.EventHandler(this.txt_notes_Click);
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(0, 0);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 34;
            this.pbx_logo.TabStop = false;
            // 
            // frm_tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.nud_tNumber);
            this.Controls.Add(this.nud_amount);
            this.Controls.Add(this.btn_backRooms);
            this.Controls.Add(this.edit_reservation);
            this.Controls.Add(this.btn_addR);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_Tsurname);
            this.Controls.Add(this.txt_Tname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_roomType);
            this.Controls.Add(this.pbx_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables";
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backRooms;
        private System.Windows.Forms.Button edit_reservation;
        private System.Windows.Forms.Button btn_addR;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.MaskedTextBox txt_Tsurname;
        private System.Windows.Forms.MaskedTextBox txt_Tname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_roomType;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.NumericUpDown nud_amount;
        private System.Windows.Forms.NumericUpDown nud_tNumber;
        private System.Windows.Forms.TextBox txt_notes;
    }
}