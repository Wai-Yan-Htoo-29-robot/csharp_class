namespace WindowsFormsApp1.ato
{
    partial class frm_product_list
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
            this.txt_product_code = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dg_product_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_item_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_product_list)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_product_code
            // 
            this.txt_product_code.Location = new System.Drawing.Point(65, 57);
            this.txt_product_code.Name = "txt_product_code";
            this.txt_product_code.Size = new System.Drawing.Size(195, 26);
            this.txt_product_code.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(330, 53);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 35);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dg_product_list
            // 
            this.dg_product_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_product_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_product_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dg_product_list.Location = new System.Drawing.Point(2, 184);
            this.dg_product_list.Name = "dg_product_list";
            this.dg_product_list.RowHeadersWidth = 62;
            this.dg_product_list.RowTemplate.Height = 28;
            this.dg_product_list.Size = new System.Drawing.Size(700, 171);
            this.dg_product_list.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Product Type";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Purchase Price";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Selling price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // btn_item_clear
            // 
            this.btn_item_clear.Location = new System.Drawing.Point(487, 53);
            this.btn_item_clear.Name = "btn_item_clear";
            this.btn_item_clear.Size = new System.Drawing.Size(124, 35);
            this.btn_item_clear.TabIndex = 3;
            this.btn_item_clear.Text = "Clear";
            this.btn_item_clear.UseVisualStyleBackColor = true;
            this.btn_item_clear.Click += new System.EventHandler(this.btn_item_clear_Click);
            // 
            // frm_product_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 555);
            this.Controls.Add(this.btn_item_clear);
            this.Controls.Add(this.dg_product_list);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_product_code);
            this.Name = "frm_product_list";
            this.Text = "frm_product_list";
            ((System.ComponentModel.ISupportInitialize)(this.dg_product_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_product_code;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dg_product_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_item_clear;
    }
}