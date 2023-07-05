namespace WindowsFormsApp1.resume_project
{
    partial class frm_cv
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
            this.btn_upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_data_input = new System.Windows.Forms.TextBox();
            this.btn_read_write = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(43, 198);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(132, 39);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_data_input
            // 
            this.txt_data_input.Location = new System.Drawing.Point(322, 37);
            this.txt_data_input.Name = "txt_data_input";
            this.txt_data_input.Size = new System.Drawing.Size(178, 26);
            this.txt_data_input.TabIndex = 2;
            // 
            // btn_read_write
            // 
            this.btn_read_write.Location = new System.Drawing.Point(322, 114);
            this.btn_read_write.Name = "btn_read_write";
            this.btn_read_write.Size = new System.Drawing.Size(156, 38);
            this.btn_read_write.TabIndex = 3;
            this.btn_read_write.Text = "R/W";
            this.btn_read_write.UseVisualStyleBackColor = true;
            this.btn_read_write.Click += new System.EventHandler(this.btn_read_write_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(449, 207);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(51, 20);
            this.lbl_output.TabIndex = 4;
            this.lbl_output.Text = "label1";
            // 
            // frm_cv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_read_write);
            this.Controls.Add(this.txt_data_input);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_upload);
            this.Name = "frm_cv";
            this.Text = "frm_cv";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_data_input;
        private System.Windows.Forms.Button btn_read_write;
        private System.Windows.Forms.Label lbl_output;
    }
}