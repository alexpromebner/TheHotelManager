namespace TheHotelManager
{
    partial class frm_GuestMenu
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
            this.rtb_menu = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_menu
            // 
            this.rtb_menu.Location = new System.Drawing.Point(8, 3);
            this.rtb_menu.Name = "rtb_menu";
            this.rtb_menu.Size = new System.Drawing.Size(509, 605);
            this.rtb_menu.TabIndex = 0;
            this.rtb_menu.Text = "";
            // 
            // frm_GuestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 611);
            this.Controls.Add(this.rtb_menu);
            this.Name = "frm_GuestMenu";
            this.Text = "GuestMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_menu;
    }
}