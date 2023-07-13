namespace WindowsFormsApp1.home_appliance
{
    partial class frm_admin_dashboard
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.txt_weekly_costs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_power_usage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_appliance_name = new System.Windows.Forms.TextBox();
            this.txt_appliance_type = new System.Windows.Forms.TextBox();
            this.txt_estimated_annual_running_costs = new System.Windows.Forms.TextBox();
            this.txt_typical_usage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descriptions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_monthly_costs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dg_appliance_lists = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_appliance_lists)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(552, 476);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 36);
            this.btn_delete.TabIndex = 46;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(377, 476);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 36);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(222, 476);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(105, 36);
            this.btn_read.TabIndex = 44;
            this.btn_read.Text = "View";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(47, 476);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(105, 36);
            this.btn_Create.TabIndex = 43;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // txt_weekly_costs
            // 
            this.txt_weekly_costs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weekly_costs.Location = new System.Drawing.Point(206, 291);
            this.txt_weekly_costs.Name = "txt_weekly_costs";
            this.txt_weekly_costs.Size = new System.Drawing.Size(268, 30);
            this.txt_weekly_costs.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Weekly Costs";
            // 
            // txt_power_usage
            // 
            this.txt_power_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_power_usage.Location = new System.Drawing.Point(206, 77);
            this.txt_power_usage.Name = "txt_power_usage";
            this.txt_power_usage.Size = new System.Drawing.Size(270, 30);
            this.txt_power_usage.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Power Usage";
            // 
            // txt_appliance_name
            // 
            this.txt_appliance_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appliance_name.Location = new System.Drawing.Point(206, 34);
            this.txt_appliance_name.Name = "txt_appliance_name";
            this.txt_appliance_name.Size = new System.Drawing.Size(270, 30);
            this.txt_appliance_name.TabIndex = 38;
            // 
            // txt_appliance_type
            // 
            this.txt_appliance_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_appliance_type.Location = new System.Drawing.Point(206, 233);
            this.txt_appliance_type.Name = "txt_appliance_type";
            this.txt_appliance_type.Size = new System.Drawing.Size(268, 30);
            this.txt_appliance_type.TabIndex = 37;
            // 
            // txt_estimated_annual_running_costs
            // 
            this.txt_estimated_annual_running_costs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estimated_annual_running_costs.Location = new System.Drawing.Point(206, 179);
            this.txt_estimated_annual_running_costs.Name = "txt_estimated_annual_running_costs";
            this.txt_estimated_annual_running_costs.Size = new System.Drawing.Size(268, 30);
            this.txt_estimated_annual_running_costs.TabIndex = 36;
            // 
            // txt_typical_usage
            // 
            this.txt_typical_usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_typical_usage.Location = new System.Drawing.Point(206, 126);
            this.txt_typical_usage.Name = "txt_typical_usage";
            this.txt_typical_usage.Size = new System.Drawing.Size(268, 30);
            this.txt_typical_usage.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Appliance Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Typical Usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 50);
            this.label3.TabIndex = 32;
            this.label3.Text = "Estimated_annual \r\nrunning costs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Appliance_Name";
            // 
            // txt_descriptions
            // 
            this.txt_descriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descriptions.Location = new System.Drawing.Point(206, 402);
            this.txt_descriptions.Name = "txt_descriptions";
            this.txt_descriptions.Size = new System.Drawing.Size(268, 30);
            this.txt_descriptions.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Descriptions";
            // 
            // txt_monthly_costs
            // 
            this.txt_monthly_costs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monthly_costs.Location = new System.Drawing.Point(206, 344);
            this.txt_monthly_costs.Name = "txt_monthly_costs";
            this.txt_monthly_costs.Size = new System.Drawing.Size(268, 30);
            this.txt_monthly_costs.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Monthly Costs";
            // 
            // dg_appliance_lists
            // 
            this.dg_appliance_lists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_appliance_lists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_appliance_lists.BackgroundColor = System.Drawing.Color.White;
            this.dg_appliance_lists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_appliance_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_appliance_lists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dg_appliance_lists.Location = new System.Drawing.Point(504, 34);
            this.dg_appliance_lists.Name = "dg_appliance_lists";
            this.dg_appliance_lists.RowHeadersWidth = 62;
            this.dg_appliance_lists.RowTemplate.Height = 28;
            this.dg_appliance_lists.Size = new System.Drawing.Size(772, 398);
            this.dg_appliance_lists.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Appliance Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Power Usage";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Typical Usage";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estimated Annual Running Costs";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Appliance Type";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Weekly Costs";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Descriptions";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // frm_admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1322, 608);
            this.Controls.Add(this.dg_appliance_lists);
            this.Controls.Add(this.txt_descriptions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_monthly_costs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.txt_weekly_costs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_power_usage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_appliance_name);
            this.Controls.Add(this.txt_appliance_type);
            this.Controls.Add(this.txt_estimated_annual_running_costs);
            this.Controls.Add(this.txt_typical_usage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frm_admin_dashboard";
            this.Text = "frm_admin_dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dg_appliance_lists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txt_weekly_costs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_power_usage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_appliance_name;
        private System.Windows.Forms.TextBox txt_appliance_type;
        private System.Windows.Forms.TextBox txt_estimated_annual_running_costs;
        private System.Windows.Forms.TextBox txt_typical_usage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descriptions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_monthly_costs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_appliance_lists;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}