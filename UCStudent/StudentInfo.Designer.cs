namespace UCStudent
{
    partial class StudentInfo
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_mssv = new System.Windows.Forms.Label();
            this.label_tensv = new System.Windows.Forms.Label();
            this.label_malop = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.label_gioitinh = new System.Windows.Forms.Label();
            this.label_cmnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_mssv
            // 
            this.label_mssv.AutoSize = true;
            this.label_mssv.Location = new System.Drawing.Point(22, 36);
            this.label_mssv.Name = "label_mssv";
            this.label_mssv.Size = new System.Drawing.Size(37, 13);
            this.label_mssv.TabIndex = 0;
            this.label_mssv.Text = "MSSV";
            // 
            // label_tensv
            // 
            this.label_tensv.AutoSize = true;
            this.label_tensv.Location = new System.Drawing.Point(22, 71);
            this.label_tensv.Name = "label_tensv";
            this.label_tensv.Size = new System.Drawing.Size(43, 13);
            this.label_tensv.TabIndex = 0;
            this.label_tensv.Text = "Ten SV";
            // 
            // label_malop
            // 
            this.label_malop.AutoSize = true;
            this.label_malop.Location = new System.Drawing.Point(22, 112);
            this.label_malop.Name = "label_malop";
            this.label_malop.Size = new System.Drawing.Size(39, 13);
            this.label_malop.TabIndex = 0;
            this.label_malop.Text = "Ma lop";
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.Location = new System.Drawing.Point(330, 36);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.label_ngaysinh.TabIndex = 0;
            this.label_ngaysinh.Text = "Ngay sinh";
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.Location = new System.Drawing.Point(330, 71);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(45, 13);
            this.label_gioitinh.TabIndex = 0;
            this.label_gioitinh.Text = "Gioi tinh";
            // 
            // label_cmnd
            // 
            this.label_cmnd.AutoSize = true;
            this.label_cmnd.Location = new System.Drawing.Point(330, 112);
            this.label_cmnd.Name = "label_cmnd";
            this.label_cmnd.Size = new System.Drawing.Size(39, 13);
            this.label_cmnd.TabIndex = 0;
            this.label_cmnd.Text = "CMND";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_cmnd);
            this.Controls.Add(this.label_malop);
            this.Controls.Add(this.label_gioitinh);
            this.Controls.Add(this.label_tensv);
            this.Controls.Add(this.label_ngaysinh);
            this.Controls.Add(this.label_mssv);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(558, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_mssv;
        private System.Windows.Forms.Label label_tensv;
        private System.Windows.Forms.Label label_malop;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.Label label_gioitinh;
        private System.Windows.Forms.Label label_cmnd;
    }
}
