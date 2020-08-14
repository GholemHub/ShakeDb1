namespace Shaker.Forms
{
    partial class SignInForm
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
            this.SignIn = new System.Windows.Forms.Button();
            this.CheckIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(271, 174);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(171, 22);
            this.Login.TabIndex = 0;
            this.Login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(271, 220);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(171, 22);
            this.Password.TabIndex = 1;
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(271, 265);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(76, 23);
            this.SignIn.TabIndex = 2;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // CheckIn
            // 
            this.CheckIn.Location = new System.Drawing.Point(367, 265);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(75, 23);
            this.CheckIn.TabIndex = 3;
            this.CheckIn.Text = "Check In";
            this.CheckIn.UseVisualStyleBackColor = true;
            this.CheckIn.Click += new System.EventHandler(this.Register_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button CheckIn;
    }
}