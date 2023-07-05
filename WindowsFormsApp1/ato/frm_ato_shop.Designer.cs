namespace WindowsFormsApp1.ato
{
    partial class frm_ato_shop
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
            this.txt_item_quantity = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_item_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.txt_buyer_quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_current_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_item_quantity
            // 
            this.txt_item_quantity.Location = new System.Drawing.Point(264, 71);
            this.txt_item_quantity.Name = "txt_item_quantity";
            this.txt_item_quantity.Size = new System.Drawing.Size(100, 26);
            this.txt_item_quantity.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(82, 168);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 35);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_item_id
            // 
            this.txt_item_id.Location = new System.Drawing.Point(94, 71);
            this.txt_item_id.Name = "txt_item_id";
            this.txt_item_id.Size = new System.Drawing.Size(100, 26);
            this.txt_item_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "item id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "item quantity";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(434, 177);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(100, 35);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txt_buyer_quantity
            // 
            this.txt_buyer_quantity.Location = new System.Drawing.Point(434, 71);
            this.txt_buyer_quantity.Name = "txt_buyer_quantity";
            this.txt_buyer_quantity.Size = new System.Drawing.Size(100, 26);
            this.txt_buyer_quantity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buyer Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current Price";
            // 
            // txt_current_price
            // 
            this.txt_current_price.Location = new System.Drawing.Point(269, 177);
            this.txt_current_price.Name = "txt_current_price";
            this.txt_current_price.Size = new System.Drawing.Size(100, 26);
            this.txt_current_price.TabIndex = 8;
            // 
            // frm_ato_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_current_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_buyer_quantity);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_item_id);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_item_quantity);
            this.Name = "frm_ato_shop";
            this.Text = "frm_ato_shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_item_quantity;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_item_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox txt_buyer_quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_current_price;
    }
}