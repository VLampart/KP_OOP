namespace KP
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            loginBox = new TextBox();
            passwordBox = new TextBox();
            phoneBox = new TextBox();
            nameBox = new TextBox();
            isAdminCheckBox = new CheckBox();
            registerButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            loginBox.Location = new Point(22, 29);
            loginBox.Name = "loginBox";
            loginBox.PlaceholderText = "Введіть логін";
            loginBox.Size = new Size(200, 23);
            loginBox.TabIndex = 0;
            loginBox.KeyPress += loginBox_KeyPress;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            passwordBox.Location = new Point(20, 79);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Введіть пароль";
            passwordBox.Size = new Size(200, 23);
            passwordBox.TabIndex = 1;
            passwordBox.KeyPress += loginBox_KeyPress;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            phoneBox.Location = new Point(20, 179);
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "+380000000000";
            phoneBox.Size = new Size(200, 23);
            phoneBox.TabIndex = 3;
            phoneBox.Text = "+380";
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nameBox.Location = new Point(20, 129);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Прізвище Ім'я Побатькові";
            nameBox.Size = new Size(200, 23);
            nameBox.TabIndex = 2;
            nameBox.TextChanged += nameBox_TextChanged;
            nameBox.KeyPress += nameBox_KeyPress;
            // 
            // isAdminCheckBox
            // 
            isAdminCheckBox.AutoSize = true;
            isAdminCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            isAdminCheckBox.Location = new Point(22, 219);
            isAdminCheckBox.Name = "isAdminCheckBox";
            isAdminCheckBox.Size = new Size(157, 19);
            isAdminCheckBox.TabIndex = 4;
            isAdminCheckBox.Text = "Чи є адміністратором ?";
            isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.Highlight;
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerButton.Location = new Point(66, 246);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(110, 23);
            registerButton.TabIndex = 5;
            registerButton.Text = "Зареєструватись";
            registerButton.TextAlign = ContentAlignment.TopLeft;
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(22, 11);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 7;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(22, 111);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "ПІБ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(22, 161);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 9;
            label4.Text = "Номер телефону";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 281);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerButton);
            Controls.Add(isAdminCheckBox);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(259, 320);
            MinimumSize = new Size(259, 320);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox isAdminCheckBox;
        private Button registerButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox loginBox;
        public TextBox passwordBox;
        public TextBox phoneBox;
        public TextBox nameBox;
    }
}