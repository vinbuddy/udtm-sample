namespace HuynhTheVinh_20001210660_Buoi02
{
    partial class FormTestUCLogin
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
            this.login1 = new UCLogin.Login();
            this.SuspendLayout();
            // 
            // login1
            // 
            this.login1.ConnectionString = null;
            this.login1.Location = new System.Drawing.Point(40, 63);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(325, 146);
            this.login1.TabIndex = 0;
            // 
            // FormTestUCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 286);
            this.Controls.Add(this.login1);
            this.Name = "FormTestUCLogin";
            this.Text = "FormTestUCLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private UCLogin.Login login1;
    }
}