namespace KP
{
    partial class AuthenticationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationForm));
            authButton = new Button();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // authButton
            // 
            authButton.BackColor = SystemColors.Highlight;
            authButton.FlatStyle = FlatStyle.Popup;
            authButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            authButton.Location = new Point(41, 138);
            authButton.Name = "authButton";
            authButton.Size = new Size(75, 23);
            authButton.TabIndex = 0;
            authButton.Text = "Увійти";
            authButton.UseVisualStyleBackColor = false;
            authButton.Click += authButton_Click;
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            loginBox.Location = new Point(41, 38);
            loginBox.Name = "loginBox";
            loginBox.PlaceholderText = "Логін";
            loginBox.Size = new Size(191, 23);
            loginBox.TabIndex = 1;
            loginBox.KeyPress += loginBox_KeyPress;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            passwordBox.Location = new Point(41, 88);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "Пароль";
            passwordBox.Size = new Size(191, 23);
            passwordBox.TabIndex = 2;
            passwordBox.KeyPress += loginBox_KeyPress;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.Highlight;
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerButton.Location = new Point(122, 138);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(110, 23);
            registerButton.TabIndex = 3;
            registerButton.Text = "Зареєструватись";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // AuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 195);
            Controls.Add(registerButton);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(authButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(291, 234);
            MinimumSize = new Size(291, 234);
            Name = "AuthenticationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            Shown += AuthenticationForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button authButton;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Button registerButton;
    }
}