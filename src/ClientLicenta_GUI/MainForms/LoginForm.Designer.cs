namespace ClientLicenta_GUI
{
    partial class LoginForm
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
            this.Username = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(197, 81);
            this.Username.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 17);
            this.Username.TabIndex = 8;
            this.Username.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(292, 81);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(132, 22);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelSimpleButton.Location = new System.Drawing.Point(204, 181);
            this.CancelSimpleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(91, 30);
            this.CancelSimpleButton.TabIndex = 13;
            this.CancelSimpleButton.Text = "Close";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(292, 129);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(132, 22);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // LoginSimpleButton
            // 
            this.LoginSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginSimpleButton.Location = new System.Drawing.Point(340, 181);
            this.LoginSimpleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginSimpleButton.Name = "LoginSimpleButton";
            this.LoginSimpleButton.Size = new System.Drawing.Size(85, 30);
            this.LoginSimpleButton.TabIndex = 12;
            this.LoginSimpleButton.Text = "Login";
            this.LoginSimpleButton.Click += new System.EventHandler(this.LoginSimpleButton_Click);
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(200, 129);
            this.Password.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 10;
            this.Password.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 352);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.CancelSimpleButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginSimpleButton);
            this.Controls.Add(this.Password);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private DevExpress.XtraEditors.SimpleButton LoginSimpleButton;
        private System.Windows.Forms.Label Password;

    }
}

