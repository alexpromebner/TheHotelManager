namespace TheHotelManager
{
    partial class frm_cleaning
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
            this.txt_addSearch = new System.Windows.Forms.TextBox();
            this.lb_rooms = new System.Windows.Forms.ListBox();
            this.lbl_choose = new System.Windows.Forms.Label();
            this.btn_backR = new System.Windows.Forms.Button();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.btn_cleaned = new System.Windows.Forms.Button();
            this.btn_dirty = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_addSearch
            // 
            this.txt_addSearch.ForeColor = System.Drawing.Color.Silver;
            this.txt_addSearch.Location = new System.Drawing.Point(147, 91);
            this.txt_addSearch.Name = "txt_addSearch";
            this.txt_addSearch.Size = new System.Drawing.Size(273, 20);
            this.txt_addSearch.TabIndex = 33;
            this.txt_addSearch.Text = "Enter a room number";
            // 
            // lb_rooms
            // 
            this.lb_rooms.FormattingEnabled = true;
            this.lb_rooms.Location = new System.Drawing.Point(147, 117);
            this.lb_rooms.Name = "lb_rooms";
            this.lb_rooms.Size = new System.Drawing.Size(273, 277);
            this.lb_rooms.TabIndex = 32;
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose.Location = new System.Drawing.Point(182, 9);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(238, 39);
            this.lbl_choose.TabIndex = 29;
            this.lbl_choose.Text = "Choose a room";
            // 
            // btn_backR
            // 
            this.btn_backR.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backR.Location = new System.Drawing.Point(345, 415);
            this.btn_backR.Name = "btn_backR";
            this.btn_backR.Size = new System.Drawing.Size(75, 23);
            this.btn_backR.TabIndex = 28;
            this.btn_backR.Text = "Back";
            this.btn_backR.UseVisualStyleBackColor = true;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(0, 0);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 26;
            this.pbx_logo.TabStop = false;
            // 
            // btn_cleaned
            // 
            this.btn_cleaned.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cleaned.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cleaned.ForeColor = System.Drawing.Color.White;
            this.btn_cleaned.Location = new System.Drawing.Point(12, 315);
            this.btn_cleaned.Name = "btn_cleaned";
            this.btn_cleaned.Size = new System.Drawing.Size(113, 35);
            this.btn_cleaned.TabIndex = 31;
            this.btn_cleaned.Text = "Cleaned";
            this.btn_cleaned.UseVisualStyleBackColor = false;
            // 
            // btn_dirty
            // 
            this.btn_dirty.BackColor = System.Drawing.Color.DarkRed;
            this.btn_dirty.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dirty.ForeColor = System.Drawing.Color.White;
            this.btn_dirty.Location = new System.Drawing.Point(12, 356);
            this.btn_dirty.Name = "btn_dirty";
            this.btn_dirty.Size = new System.Drawing.Size(113, 35);
            this.btn_dirty.TabIndex = 27;
            this.btn_dirty.Text = "Dirty";
            this.btn_dirty.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Gray;
            this.btn_save.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(12, 397);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 35);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // frm_cleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_addSearch);
            this.Controls.Add(this.lb_rooms);
            this.Controls.Add(this.btn_cleaned);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.btn_backR);
            this.Controls.Add(this.btn_dirty);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_cleaning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleaning";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_addSearch;
        private System.Windows.Forms.ListBox lb_rooms;
        private System.Windows.Forms.Label lbl_choose;
        private System.Windows.Forms.Button btn_backR;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Button btn_cleaned;
        private System.Windows.Forms.Button btn_dirty;
        private System.Windows.Forms.Button btn_save;
    }
}