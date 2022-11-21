namespace TheHotelManager
{
    partial class frm_warehouse
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
            this.btn_backWh = new System.Windows.Forms.Button();
            this.edit_cancelOrder = new System.Windows.Forms.Button();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.lbl_openOrders = new System.Windows.Forms.Label();
            this.lb_openOrders = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
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
            // btn_backWh
            // 
            this.btn_backWh.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backWh.Location = new System.Drawing.Point(342, 409);
            this.btn_backWh.Name = "btn_backWh";
            this.btn_backWh.Size = new System.Drawing.Size(75, 23);
            this.btn_backWh.TabIndex = 46;
            this.btn_backWh.Text = "Back";
            this.btn_backWh.UseVisualStyleBackColor = true;
            this.btn_backWh.Click += new System.EventHandler(this.btn_backWh_Click);
            // 
            // edit_cancelOrder
            // 
            this.edit_cancelOrder.BackColor = System.Drawing.Color.Gray;
            this.edit_cancelOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_cancelOrder.ForeColor = System.Drawing.Color.White;
            this.edit_cancelOrder.Location = new System.Drawing.Point(8, 388);
            this.edit_cancelOrder.Name = "edit_cancelOrder";
            this.edit_cancelOrder.Size = new System.Drawing.Size(202, 35);
            this.edit_cancelOrder.TabIndex = 45;
            this.edit_cancelOrder.Text = "Cancel Order";
            this.edit_cancelOrder.UseVisualStyleBackColor = false;
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.Color.Gray;
            this.btn_addOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOrder.ForeColor = System.Drawing.Color.White;
            this.btn_addOrder.Location = new System.Drawing.Point(8, 347);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(202, 35);
            this.btn_addOrder.TabIndex = 43;
            this.btn_addOrder.Text = "Add New Order";
            this.btn_addOrder.UseVisualStyleBackColor = false;
            // 
            // lbl_openOrders
            // 
            this.lbl_openOrders.AutoSize = true;
            this.lbl_openOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_openOrders.Location = new System.Drawing.Point(4, 148);
            this.lbl_openOrders.Name = "lbl_openOrders";
            this.lbl_openOrders.Size = new System.Drawing.Size(118, 22);
            this.lbl_openOrders.TabIndex = 35;
            this.lbl_openOrders.Text = "Open Orders:";
            // 
            // lb_openOrders
            // 
            this.lb_openOrders.FormattingEnabled = true;
            this.lb_openOrders.Location = new System.Drawing.Point(8, 173);
            this.lb_openOrders.Name = "lb_openOrders";
            this.lb_openOrders.Size = new System.Drawing.Size(409, 147);
            this.lb_openOrders.TabIndex = 47;
            // 
            // frm_warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 444);
            this.Controls.Add(this.lb_openOrders);
            this.Controls.Add(this.btn_backWh);
            this.Controls.Add(this.edit_cancelOrder);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.lbl_openOrders);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Button btn_backWh;
        private System.Windows.Forms.Button edit_cancelOrder;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Label lbl_openOrders;
        private System.Windows.Forms.ListBox lb_openOrders;
    }
}