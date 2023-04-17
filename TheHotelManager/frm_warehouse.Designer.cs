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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_warehouse));
            this.btn_backWh = new System.Windows.Forms.Button();
            this.edit_cancelOrder = new System.Windows.Forms.Button();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.lbl_openOrders = new System.Windows.Forms.Label();
            this.dgv_warehouse = new System.Windows.Forms.DataGridView();
            this.lbl_warehouse = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.btn_delivered = new System.Windows.Forms.Button();
            this.lbl_otherProducts = new System.Windows.Forms.Label();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.pbx_info = new System.Windows.Forms.PictureBox();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backWh
            // 
            this.btn_backWh.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backWh.Location = new System.Drawing.Point(486, 401);
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
            this.edit_cancelOrder.Location = new System.Drawing.Point(420, 348);
            this.edit_cancelOrder.Name = "edit_cancelOrder";
            this.edit_cancelOrder.Size = new System.Drawing.Size(141, 35);
            this.edit_cancelOrder.TabIndex = 45;
            this.edit_cancelOrder.Text = "Cancel Order";
            this.edit_cancelOrder.UseVisualStyleBackColor = false;
            this.edit_cancelOrder.Click += new System.EventHandler(this.edit_cancelOrder_Click);
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.Color.Gray;
            this.btn_addOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOrder.ForeColor = System.Drawing.Color.White;
            this.btn_addOrder.Location = new System.Drawing.Point(216, 348);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(198, 35);
            this.btn_addOrder.TabIndex = 43;
            this.btn_addOrder.Text = "Add New Order";
            this.btn_addOrder.UseVisualStyleBackColor = false;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // lbl_openOrders
            // 
            this.lbl_openOrders.AutoSize = true;
            this.lbl_openOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_openOrders.Location = new System.Drawing.Point(4, 162);
            this.lbl_openOrders.Name = "lbl_openOrders";
            this.lbl_openOrders.Size = new System.Drawing.Size(118, 22);
            this.lbl_openOrders.TabIndex = 35;
            this.lbl_openOrders.Text = "Open Orders:";
            // 
            // dgv_warehouse
            // 
            this.dgv_warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_warehouse.Location = new System.Drawing.Point(12, 193);
            this.dgv_warehouse.Name = "dgv_warehouse";
            this.dgv_warehouse.Size = new System.Drawing.Size(549, 148);
            this.dgv_warehouse.TabIndex = 69;
            // 
            // lbl_warehouse
            // 
            this.lbl_warehouse.AutoSize = true;
            this.lbl_warehouse.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warehouse.Location = new System.Drawing.Point(387, 0);
            this.lbl_warehouse.Name = "lbl_warehouse";
            this.lbl_warehouse.Size = new System.Drawing.Size(182, 39);
            this.lbl_warehouse.TabIndex = 68;
            this.lbl_warehouse.Text = "Warehouse";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.Location = new System.Drawing.Point(126, 46);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(61, 19);
            this.lbl_product.TabIndex = 71;
            this.lbl_product.Text = "Product:";
            // 
            // cb_product
            // 
            this.cb_product.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Items.AddRange(new object[] {
            "towels",
            "soap",
            "shampoo",
            "toilet paper",
            "printer paper",
            "printer cartridge"});
            this.cb_product.Location = new System.Drawing.Point(130, 68);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(142, 21);
            this.cb_product.TabIndex = 70;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.Yellow;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(202, 47);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(28, 16);
            this.lbl_info.TabIndex = 73;
            this.lbl_info.Text = "Info";
            this.lbl_info.Visible = false;
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(280, 69);
            this.nud_quantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(142, 20);
            this.nud_quantity.TabIndex = 74;
            this.nud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(275, 46);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(66, 19);
            this.lbl_quantity.TabIndex = 75;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // btn_delivered
            // 
            this.btn_delivered.BackColor = System.Drawing.Color.Green;
            this.btn_delivered.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivered.ForeColor = System.Drawing.Color.White;
            this.btn_delivered.Location = new System.Drawing.Point(8, 348);
            this.btn_delivered.Name = "btn_delivered";
            this.btn_delivered.Size = new System.Drawing.Size(202, 35);
            this.btn_delivered.TabIndex = 76;
            this.btn_delivered.Text = "Mark as completed";
            this.btn_delivered.UseVisualStyleBackColor = false;
            // 
            // lbl_otherProducts
            // 
            this.lbl_otherProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_otherProducts.AutoSize = true;
            this.lbl_otherProducts.BackColor = System.Drawing.Color.White;
            this.lbl_otherProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_otherProducts.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_otherProducts.Location = new System.Drawing.Point(128, 88);
            this.lbl_otherProducts.Name = "lbl_otherProducts";
            this.lbl_otherProducts.Size = new System.Drawing.Size(87, 16);
            this.lbl_otherProducts.TabIndex = 77;
            this.lbl_otherProducts.Text = "Other products";
            this.lbl_otherProducts.Click += new System.EventHandler(this.lbl_otherProducts_Click);
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notes.Location = new System.Drawing.Point(126, 104);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(49, 19);
            this.lbl_notes.TabIndex = 78;
            this.lbl_notes.Text = "Notes:";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(131, 126);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(430, 50);
            this.txt_notes.TabIndex = 79;
            // 
            // pbx_info
            // 
            this.pbx_info.Image = global::TheHotelManager.Properties.Resources.information;
            this.pbx_info.Location = new System.Drawing.Point(182, 47);
            this.pbx_info.Name = "pbx_info";
            this.pbx_info.Size = new System.Drawing.Size(19, 15);
            this.pbx_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_info.TabIndex = 72;
            this.pbx_info.TabStop = false;
            this.pbx_info.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pbx_info.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
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
            // frm_warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 436);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.lbl_notes);
            this.Controls.Add(this.btn_delivered);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.pbx_info);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.cb_product);
            this.Controls.Add(this.dgv_warehouse);
            this.Controls.Add(this.lbl_warehouse);
            this.Controls.Add(this.btn_backWh);
            this.Controls.Add(this.edit_cancelOrder);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.lbl_openOrders);
            this.Controls.Add(this.pbx_logo);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.lbl_otherProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Warehouse";
            this.Load += new System.EventHandler(this.frm_warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_info)).EndInit();
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
        private System.Windows.Forms.Label lbl_warehouse;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.PictureBox pbx_info;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_delivered;
        private System.Windows.Forms.Label lbl_otherProducts;
        public System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.TextBox txt_notes;
        public System.Windows.Forms.DataGridView dgv_warehouse;
    }
}