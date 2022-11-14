namespace TheHotelManager
{
    partial class frm_hotel
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
            this.btn_warehouse = new System.Windows.Forms.Button();
            this.btn_cleaning = new System.Windows.Forms.Button();
            this.btn_rooms = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_choose = new System.Windows.Forms.Label();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_warehouse
            // 
            this.btn_warehouse.BackColor = System.Drawing.Color.Gray;
            this.btn_warehouse.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_warehouse.ForeColor = System.Drawing.Color.White;
            this.btn_warehouse.Location = new System.Drawing.Point(192, 292);
            this.btn_warehouse.Name = "btn_warehouse";
            this.btn_warehouse.Size = new System.Drawing.Size(166, 49);
            this.btn_warehouse.TabIndex = 7;
            this.btn_warehouse.Text = "Warehouse";
            this.btn_warehouse.UseVisualStyleBackColor = false;
            this.btn_warehouse.Click += new System.EventHandler(this.btn_warehouse_Click);
            // 
            // btn_cleaning
            // 
            this.btn_cleaning.BackColor = System.Drawing.Color.Gray;
            this.btn_cleaning.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleaning.ForeColor = System.Drawing.Color.White;
            this.btn_cleaning.Location = new System.Drawing.Point(192, 213);
            this.btn_cleaning.Name = "btn_cleaning";
            this.btn_cleaning.Size = new System.Drawing.Size(166, 49);
            this.btn_cleaning.TabIndex = 6;
            this.btn_cleaning.Text = "Cleaning";
            this.btn_cleaning.UseVisualStyleBackColor = false;
            this.btn_cleaning.Click += new System.EventHandler(this.btn_cleaning_Click);
            // 
            // btn_rooms
            // 
            this.btn_rooms.BackColor = System.Drawing.Color.Gray;
            this.btn_rooms.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rooms.ForeColor = System.Drawing.Color.White;
            this.btn_rooms.Location = new System.Drawing.Point(192, 134);
            this.btn_rooms.Name = "btn_rooms";
            this.btn_rooms.Size = new System.Drawing.Size(166, 49);
            this.btn_rooms.TabIndex = 5;
            this.btn_rooms.Text = "Rooms";
            this.btn_rooms.UseVisualStyleBackColor = false;
            this.btn_rooms.Click += new System.EventHandler(this.btn_rooms_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(342, 409);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose.Location = new System.Drawing.Point(139, 9);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(282, 28);
            this.lbl_choose.TabIndex = 9;
            this.lbl_choose.Text = "What do you want to do?";
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(1, 1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 1;
            this.pbx_logo.TabStop = false;
            // 
            // frm_hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_warehouse);
            this.Controls.Add(this.btn_cleaning);
            this.Controls.Add(this.btn_rooms);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Button btn_warehouse;
        private System.Windows.Forms.Button btn_cleaning;
        private System.Windows.Forms.Button btn_rooms;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_choose;
    }
}