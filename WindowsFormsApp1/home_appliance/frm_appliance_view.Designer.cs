namespace WindowsFormsApp1.home_appliance
{
    partial class frm_appliance_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_appliance_view));
            this.btn_search = new System.Windows.Forms.Button();
            this.dg_appliance_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_appliance_type = new System.Windows.Forms.TextBox();
            this.btn_add_to_cart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cart = new System.Windows.Forms.Button();
            this.btn_add_to_cart2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_appliance_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 32);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 34);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dg_appliance_list
            // 
            this.dg_appliance_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_appliance_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_appliance_list.BackgroundColor = System.Drawing.Color.White;
            this.dg_appliance_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_appliance_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_appliance_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dg_appliance_list.Location = new System.Drawing.Point(26, 95);
            this.dg_appliance_list.Name = "dg_appliance_list";
            this.dg_appliance_list.RowHeadersWidth = 62;
            this.dg_appliance_list.RowTemplate.Height = 28;
            this.dg_appliance_list.Size = new System.Drawing.Size(834, 158);
            this.dg_appliance_list.TabIndex = 2;
            this.dg_appliance_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_appliance_list_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Appliance";
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
            // txt_appliance_type
            // 
            this.txt_appliance_type.Location = new System.Drawing.Point(127, 36);
            this.txt_appliance_type.Name = "txt_appliance_type";
            this.txt_appliance_type.Size = new System.Drawing.Size(190, 26);
            this.txt_appliance_type.TabIndex = 3;
            // 
            // btn_add_to_cart
            // 
            this.btn_add_to_cart.Location = new System.Drawing.Point(225, 349);
            this.btn_add_to_cart.Name = "btn_add_to_cart";
            this.btn_add_to_cart.Size = new System.Drawing.Size(109, 33);
            this.btn_add_to_cart.TabIndex = 5;
            this.btn_add_to_cart.Text = "Add to Cart";
            this.btn_add_to_cart.UseVisualStyleBackColor = true;
            this.btn_add_to_cart.Click += new System.EventHandler(this.btn_add_to_cart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.White;
            this.btn_cart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cart.BackgroundImage")));
            this.btn_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cart.FlatAppearance.BorderSize = 0;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cart.Location = new System.Drawing.Point(820, 4);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(66, 54);
            this.btn_cart.TabIndex = 6;
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // btn_add_to_cart2
            // 
            this.btn_add_to_cart2.Location = new System.Drawing.Point(559, 341);
            this.btn_add_to_cart2.Name = "btn_add_to_cart2";
            this.btn_add_to_cart2.Size = new System.Drawing.Size(109, 33);
            this.btn_add_to_cart2.TabIndex = 8;
            this.btn_add_to_cart2.Text = "Add to Cart";
            this.btn_add_to_cart2.UseVisualStyleBackColor = true;
            this.btn_add_to_cart2.Click += new System.EventHandler(this.btn_add_to_cart2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(357, 253);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // frm_appliance_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 589);
            this.Controls.Add(this.btn_add_to_cart2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.btn_add_to_cart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_appliance_type);
            this.Controls.Add(this.dg_appliance_list);
            this.Controls.Add(this.btn_search);
            this.Name = "frm_appliance_view";
            this.Text = "frm_appliance_view";
            ((System.ComponentModel.ISupportInitialize)(this.dg_appliance_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dg_appliance_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_appliance_type;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add_to_cart;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.Button btn_add_to_cart2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}