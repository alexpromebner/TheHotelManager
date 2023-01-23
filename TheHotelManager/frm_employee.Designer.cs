namespace TheHotelManager
{
    partial class frm_employee
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.txt_addSearch = new System.Windows.Forms.TextBox();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose.Location = new System.Drawing.Point(139, 9);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(282, 28);
            this.lbl_choose.TabIndex = 21;
            this.lbl_choose.Text = "What do you want to do?";
            // 
            // btn_backR
            // 
            this.btn_backR.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backR.Location = new System.Drawing.Point(586, 409);
            this.btn_backR.Name = "btn_backR";
            this.btn_backR.Size = new System.Drawing.Size(75, 23);
            this.btn_backR.TabIndex = 20;
            this.btn_backR.Text = "Back";
            this.btn_backR.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gray;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(12, 394);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 35);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gray;
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(12, 353);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 35);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Gray;
            this.btn_change.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.ForeColor = System.Drawing.Color.White;
            this.btn_change.Location = new System.Drawing.Point(12, 312);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(113, 35);
            this.btn_change.TabIndex = 23;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = false;
            // 
            // txt_addSearch
            // 
            this.txt_addSearch.ForeColor = System.Drawing.Color.Silver;
            this.txt_addSearch.Location = new System.Drawing.Point(144, 85);
            this.txt_addSearch.Name = "txt_addSearch";
            this.txt_addSearch.Size = new System.Drawing.Size(517, 20);
            this.txt_addSearch.TabIndex = 25;
            this.txt_addSearch.Text = "Search or add employees by their last name";
            this.txt_addSearch.Click += new System.EventHandler(this.txt_addSearch_Click);
            this.txt_addSearch.TextChanged += new System.EventHandler(this.txt_addSearch_TextChanged);
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::TheHotelManager.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(1, 1);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(124, 141);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 16;
            this.pbx_logo.TabStop = false;
            // 
            // dgv_employees
            // 
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Location = new System.Drawing.Point(144, 129);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.Size = new System.Drawing.Size(517, 259);
            this.dgv_employees.TabIndex = 26;
            this.dgv_employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frm_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 444);
            this.Controls.Add(this.dgv_employees);
            this.Controls.Add(this.txt_addSearch);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.btn_backR);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.pbx_logo);
            this.Name = "frm_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frm_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choose;
        private System.Windows.Forms.Button btn_backR;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox txt_addSearch;
        private System.Windows.Forms.DataGridView dgv_employees;
    }
}