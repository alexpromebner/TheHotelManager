﻿namespace TheHotelManager
{
    partial class frm_restaurant
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
            this.lbl_choose = new System.Windows.Forms.Label();
            this.btn_backR = new System.Windows.Forms.Button();
            this.btn_warehouseR = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_tables = new System.Windows.Forms.Button();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose.Location = new System.Drawing.Point(139, 9);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(282, 28);
            this.lbl_choose.TabIndex = 15;
            this.lbl_choose.Text = "What do you want to do?";
            // 
            // btn_backR
            // 
            this.btn_backR.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backR.Location = new System.Drawing.Point(342, 409);
            this.btn_backR.Name = "btn_backR";
            this.btn_backR.Size = new System.Drawing.Size(75, 23);
            this.btn_backR.TabIndex = 14;
            this.btn_backR.Text = "Back";
            this.btn_backR.UseVisualStyleBackColor = true;
            // 
            // btn_warehouseR
            // 
            this.btn_warehouseR.BackColor = System.Drawing.Color.Gray;
            this.btn_warehouseR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_warehouseR.ForeColor = System.Drawing.Color.White;
            this.btn_warehouseR.Location = new System.Drawing.Point(192, 292);
            this.btn_warehouseR.Name = "btn_warehouseR";
            this.btn_warehouseR.Size = new System.Drawing.Size(166, 49);
            this.btn_warehouseR.TabIndex = 13;
            this.btn_warehouseR.Text = "Warehouse";
            this.btn_warehouseR.UseVisualStyleBackColor = false;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Gray;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Location = new System.Drawing.Point(192, 213);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(166, 49);
            this.btn_menu.TabIndex = 12;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            // 
            // btn_tables
            // 
            this.btn_tables.BackColor = System.Drawing.Color.Gray;
            this.btn_tables.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tables.ForeColor = System.Drawing.Color.White;
            this.btn_tables.Location = new System.Drawing.Point(192, 134);
            this.btn_tables.Name = "btn_tables";
            this.btn_tables.Size = new System.Drawing.Size(166, 49);
            this.btn_tables.TabIndex = 11;
            this.btn_tables.Text = "Tables";
            this.btn_tables.UseVisualStyleBackColor = false;
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(1, 1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 10;
            this.pbx_logo.TabStop = false;
            // 
            // frm_restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.btn_backR);
            this.Controls.Add(this.btn_warehouseR);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_tables);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_restaurant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choose;
        private System.Windows.Forms.Button btn_backR;
        private System.Windows.Forms.Button btn_warehouseR;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_tables;
        private System.Windows.Forms.PictureBox pbx_logo;
    }
}