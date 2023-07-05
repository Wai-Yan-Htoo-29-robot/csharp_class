namespace WindowsFormsApp1
{
    partial class frm_list
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_show_list = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btn_show_list
            // 
            this.btn_show_list.Location = new System.Drawing.Point(253, 165);
            this.btn_show_list.Name = "btn_show_list";
            this.btn_show_list.Size = new System.Drawing.Size(147, 35);
            this.btn_show_list.TabIndex = 1;
            this.btn_show_list.Text = "show list";
            this.btn_show_list.UseVisualStyleBackColor = true;
            this.btn_show_list.Click += new System.EventHandler(this.btn_show_list_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(73, 165);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 35);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "functional programming",
            "oop"});
            this.comboBox1.Location = new System.Drawing.Point(494, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frm_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_show_list);
            this.Controls.Add(this.textBox1);
            this.Name = "frm_list";
            this.Text = "frm_list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_show_list;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}