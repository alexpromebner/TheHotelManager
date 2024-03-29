﻿namespace TheHotelManager
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.rtb_menuEditor = new System.Windows.Forms.RichTextBox();
            this.btn_Msave = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_backR = new System.Windows.Forms.Button();
            this.btn_bold = new System.Windows.Forms.Button();
            this.btn_underline = new System.Windows.Forms.Button();
            this.btn_italic = new System.Windows.Forms.Button();
            this.cb_fontSize = new System.Windows.Forms.ComboBox();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.btn_center = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(200, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(199, 39);
            this.lbl_welcome.TabIndex = 19;
            this.lbl_welcome.Text = "Menu Editor";
            // 
            // rtb_menuEditor
            // 
            this.rtb_menuEditor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_menuEditor.Location = new System.Drawing.Point(12, 147);
            this.rtb_menuEditor.Name = "rtb_menuEditor";
            this.rtb_menuEditor.Size = new System.Drawing.Size(405, 208);
            this.rtb_menuEditor.TabIndex = 20;
            this.rtb_menuEditor.Text = "";
            // 
            // btn_Msave
            // 
            this.btn_Msave.BackColor = System.Drawing.Color.Gray;
            this.btn_Msave.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Msave.ForeColor = System.Drawing.Color.White;
            this.btn_Msave.Location = new System.Drawing.Point(12, 397);
            this.btn_Msave.Name = "btn_Msave";
            this.btn_Msave.Size = new System.Drawing.Size(113, 35);
            this.btn_Msave.TabIndex = 35;
            this.btn_Msave.Text = "Save";
            this.btn_Msave.UseVisualStyleBackColor = false;
            this.btn_Msave.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Gray;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(131, 397);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 35);
            this.btn_reset.TabIndex = 36;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_backR
            // 
            this.btn_backR.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backR.Location = new System.Drawing.Point(342, 409);
            this.btn_backR.Name = "btn_backR";
            this.btn_backR.Size = new System.Drawing.Size(75, 23);
            this.btn_backR.TabIndex = 37;
            this.btn_backR.Text = "Back";
            this.btn_backR.UseVisualStyleBackColor = true;
            this.btn_backR.Click += new System.EventHandler(this.btn_backR_Click);
            // 
            // btn_bold
            // 
            this.btn_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bold.Location = new System.Drawing.Point(400, 118);
            this.btn_bold.Name = "btn_bold";
            this.btn_bold.Size = new System.Drawing.Size(17, 23);
            this.btn_bold.TabIndex = 38;
            this.btn_bold.Text = "B";
            this.btn_bold.UseVisualStyleBackColor = true;
            this.btn_bold.Click += new System.EventHandler(this.btn_bold_Click);
            // 
            // btn_underline
            // 
            this.btn_underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_underline.Location = new System.Drawing.Point(382, 118);
            this.btn_underline.Name = "btn_underline";
            this.btn_underline.Size = new System.Drawing.Size(17, 23);
            this.btn_underline.TabIndex = 39;
            this.btn_underline.Text = "U";
            this.btn_underline.UseVisualStyleBackColor = true;
            this.btn_underline.Click += new System.EventHandler(this.btn_underline_Click);
            // 
            // btn_italic
            // 
            this.btn_italic.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_italic.Location = new System.Drawing.Point(364, 118);
            this.btn_italic.Name = "btn_italic";
            this.btn_italic.Size = new System.Drawing.Size(17, 23);
            this.btn_italic.TabIndex = 40;
            this.btn_italic.Text = "I";
            this.btn_italic.UseVisualStyleBackColor = true;
            this.btn_italic.Click += new System.EventHandler(this.btn_italic_Click);
            // 
            // cb_fontSize
            // 
            this.cb_fontSize.FormattingEnabled = true;
            this.cb_fontSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cb_fontSize.Location = new System.Drawing.Point(288, 118);
            this.cb_fontSize.Name = "cb_fontSize";
            this.cb_fontSize.Size = new System.Drawing.Size(70, 21);
            this.cb_fontSize.TabIndex = 41;
            this.cb_fontSize.Text = "14";
            this.cb_fontSize.SelectedIndexChanged += new System.EventHandler(this.cb_fontSize_SelectedIndexChanged);
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(0, 0);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 18;
            this.pbx_logo.TabStop = false;
            // 
            // btn_center
            // 
            this.btn_center.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_center.Location = new System.Drawing.Point(130, 116);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(71, 23);
            this.btn_center.TabIndex = 42;
            this.btn_center.Text = "Center";
            this.btn_center.UseVisualStyleBackColor = true;
            this.btn_center.Click += new System.EventHandler(this.btn_center_Click);
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right.Location = new System.Drawing.Point(212, 116);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(70, 23);
            this.btn_right.TabIndex = 43;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_center);
            this.Controls.Add(this.cb_fontSize);
            this.Controls.Add(this.btn_italic);
            this.Controls.Add(this.btn_underline);
            this.Controls.Add(this.btn_bold);
            this.Controls.Add(this.btn_backR);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Msave);
            this.Controls.Add(this.rtb_menuEditor);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pbx_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.RichTextBox rtb_menuEditor;
        private System.Windows.Forms.Button btn_Msave;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_backR;
        private System.Windows.Forms.Button btn_bold;
        private System.Windows.Forms.Button btn_underline;
        private System.Windows.Forms.Button btn_italic;
        private System.Windows.Forms.ComboBox cb_fontSize;
        private System.Windows.Forms.Button btn_center;
        private System.Windows.Forms.Button btn_right;
    }
}