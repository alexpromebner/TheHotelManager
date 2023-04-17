namespace TheHotelManager
{
    partial class frm_editReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editReservation));
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.lbl_headline = new System.Windows.Forms.Label();
            this.dgv_tables = new System.Windows.Forms.DataGridView();
            this.btn_backEditRoom = new System.Windows.Forms.Button();
            this.btn_deleteR = new System.Windows.Forms.Button();
            this.btn_saveR = new System.Windows.Forms.Button();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.nud_tNumber = new System.Windows.Forms.NumericUpDown();
            this.nud_amount = new System.Windows.Forms.NumericUpDown();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_Tsurname = new System.Windows.Forms.MaskedTextBox();
            this.txt_Tname = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_roomType = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_notes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(12, 12);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(109, 84);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 0;
            this.pbx_logo.TabStop = false;
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline.Location = new System.Drawing.Point(175, 67);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(340, 29);
            this.lbl_headline.TabIndex = 1;
            this.lbl_headline.Text = "Show and Edit Reservations";
            // 
            // dgv_tables
            // 
            this.dgv_tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tables.Location = new System.Drawing.Point(311, 129);
            this.dgv_tables.Name = "dgv_tables";
            this.dgv_tables.Size = new System.Drawing.Size(757, 312);
            this.dgv_tables.TabIndex = 2;
            this.dgv_tables.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tables_RowHeaderMouseClick);
            // 
            // btn_backEditRoom
            // 
            this.btn_backEditRoom.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backEditRoom.Location = new System.Drawing.Point(993, 526);
            this.btn_backEditRoom.Name = "btn_backEditRoom";
            this.btn_backEditRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_backEditRoom.TabIndex = 52;
            this.btn_backEditRoom.Text = "Back";
            this.btn_backEditRoom.UseVisualStyleBackColor = true;
            this.btn_backEditRoom.Click += new System.EventHandler(this.btn_backEditRoom_Click);
            // 
            // btn_deleteR
            // 
            this.btn_deleteR.BackColor = System.Drawing.Color.Gray;
            this.btn_deleteR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteR.ForeColor = System.Drawing.Color.White;
            this.btn_deleteR.Location = new System.Drawing.Point(313, 516);
            this.btn_deleteR.Name = "btn_deleteR";
            this.btn_deleteR.Size = new System.Drawing.Size(202, 35);
            this.btn_deleteR.TabIndex = 51;
            this.btn_deleteR.Text = "Delete";
            this.btn_deleteR.UseVisualStyleBackColor = false;
            this.btn_deleteR.Click += new System.EventHandler(this.btn_deleteR_Click);
            // 
            // btn_saveR
            // 
            this.btn_saveR.BackColor = System.Drawing.Color.Gray;
            this.btn_saveR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveR.ForeColor = System.Drawing.Color.White;
            this.btn_saveR.Location = new System.Drawing.Point(313, 474);
            this.btn_saveR.Name = "btn_saveR";
            this.btn_saveR.Size = new System.Drawing.Size(202, 35);
            this.btn_saveR.TabIndex = 50;
            this.btn_saveR.Text = "Save";
            this.btn_saveR.UseVisualStyleBackColor = false;
            this.btn_saveR.Click += new System.EventHandler(this.btn_saveR_Click);
            // 
            // txt_notes
            // 
            this.txt_notes.ForeColor = System.Drawing.Color.Black;
            this.txt_notes.Location = new System.Drawing.Point(23, 435);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(282, 114);
            this.txt_notes.TabIndex = 60;
            // 
            // nud_tNumber
            // 
            this.nud_tNumber.Location = new System.Drawing.Point(23, 237);
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
            this.nud_tNumber.TabIndex = 59;
            this.nud_tNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_amount
            // 
            this.nud_amount.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_amount.Location = new System.Drawing.Point(23, 189);
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
            this.nud_amount.TabIndex = 58;
            this.nud_amount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(23, 384);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(282, 20);
            this.dtp_date.TabIndex = 57;
            // 
            // txt_Tsurname
            // 
            this.txt_Tsurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tsurname.ForeColor = System.Drawing.Color.Black;
            this.txt_Tsurname.Location = new System.Drawing.Point(23, 335);
            this.txt_Tsurname.Name = "txt_Tsurname";
            this.txt_Tsurname.Size = new System.Drawing.Size(282, 21);
            this.txt_Tsurname.TabIndex = 56;
            // 
            // txt_Tname
            // 
            this.txt_Tname.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tname.ForeColor = System.Drawing.Color.Black;
            this.txt_Tname.Location = new System.Drawing.Point(23, 285);
            this.txt_Tname.Name = "txt_Tname";
            this.txt_Tname.Size = new System.Drawing.Size(282, 21);
            this.txt_Tname.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "Table Number:";
            // 
            // lbl_roomType
            // 
            this.lbl_roomType.AutoSize = true;
            this.lbl_roomType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomType.Location = new System.Drawing.Point(19, 163);
            this.lbl_roomType.Name = "lbl_roomType";
            this.lbl_roomType.Size = new System.Drawing.Size(166, 22);
            this.lbl_roomType.TabIndex = 53;
            this.lbl_roomType.Text = "How many people?";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(19, 260);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(58, 22);
            this.lbl_name.TabIndex = 61;
            this.lbl_name.Text = "Name";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(19, 310);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(81, 22);
            this.lbl_surname.TabIndex = 62;
            this.lbl_surname.Text = "Surname";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(19, 359);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(48, 22);
            this.lbl_date.TabIndex = 63;
            this.lbl_date.Text = "Date";
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notes.Location = new System.Drawing.Point(19, 410);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(59, 22);
            this.lbl_notes.TabIndex = 64;
            this.lbl_notes.Text = "Notes";
            // 
            // frm_editReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 561);
            this.Controls.Add(this.lbl_notes);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.nud_tNumber);
            this.Controls.Add(this.nud_amount);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_Tsurname);
            this.Controls.Add(this.txt_Tname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_roomType);
            this.Controls.Add(this.btn_backEditRoom);
            this.Controls.Add(this.btn_deleteR);
            this.Controls.Add(this.btn_saveR);
            this.Controls.Add(this.dgv_tables);
            this.Controls.Add(this.lbl_headline);
            this.Controls.Add(this.pbx_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_editReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show and Edit Reservations";
            this.Load += new System.EventHandler(this.frm_editReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_headline;
        private System.Windows.Forms.DataGridView dgv_tables;
        private System.Windows.Forms.Button btn_backEditRoom;
        private System.Windows.Forms.Button btn_deleteR;
        private System.Windows.Forms.Button btn_saveR;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.NumericUpDown nud_tNumber;
        private System.Windows.Forms.NumericUpDown nud_amount;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.MaskedTextBox txt_Tsurname;
        private System.Windows.Forms.MaskedTextBox txt_Tname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_roomType;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_notes;
    }
}