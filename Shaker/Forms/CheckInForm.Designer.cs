namespace Shaker.Forms
{
    partial class CheckInForm
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.CheckIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(311, 142);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 22);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(311, 192);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 1;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(311, 247);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 22);
            this.Phone.TabIndex = 2;
            this.Phone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CheckIn
            // 
            this.CheckIn.Location = new System.Drawing.Point(311, 304);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(100, 23);
            this.CheckIn.TabIndex = 3;
            this.CheckIn.Text = "Check In";
            this.CheckIn.UseVisualStyleBackColor = true;
            this.CheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button CheckIn;
    }
}