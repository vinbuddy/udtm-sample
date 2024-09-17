namespace HuynhTheVinh_20001210660_Buoi02
{
    partial class FormTestUCStudent
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
            this.studentInfo1 = new UCStudent.StudentInfo();
            this.SuspendLayout();
            // 
            // studentInfo1
            // 
            this.studentInfo1.Location = new System.Drawing.Point(0, 46);
            this.studentInfo1.Name = "studentInfo1";
            this.studentInfo1.Size = new System.Drawing.Size(558, 188);
            this.studentInfo1.TabIndex = 0;
            // 
            // FormTestUCStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 294);
            this.Controls.Add(this.studentInfo1);
            this.Name = "FormTestUCStudent";
            this.Text = "FormTestUCStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private UCStudent.StudentInfo studentInfo1;
    }
}