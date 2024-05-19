namespace KP
{
    partial class HeaderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderControl));
            searchBox = new TextBox();
            exitButton = new Button();
            pictureBox = new PictureBox();
            loginLabel = new Label();
            cartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchBox.Location = new Point(147, 15);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Пошук";
            searchBox.Size = new Size(300, 23);
            searchBox.TabIndex = 1;
            searchBox.KeyPress += searchBox_KeyPress;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.MenuHighlight;
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(714, 13);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(71, 28);
            exitButton.TabIndex = 2;
            exitButton.Text = "Вихід";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(10, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(48, 46);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(539, 16);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(50, 21);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "login";
            // 
            // cartButton
            // 
            cartButton.BackColor = Color.DarkOrange;
            cartButton.FlatStyle = FlatStyle.Popup;
            cartButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cartButton.Location = new Point(637, 13);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(71, 28);
            cartButton.TabIndex = 5;
            cartButton.Text = "Кошик";
            cartButton.UseVisualStyleBackColor = false;
            cartButton.Click += cartButton_Click;
            // 
            // HeaderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(cartButton);
            Controls.Add(loginLabel);
            Controls.Add(exitButton);
            Controls.Add(searchBox);
            Controls.Add(pictureBox);
            Name = "HeaderControl";
            Size = new Size(800, 55);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox searchBox;
        private Button exitButton;
        private PictureBox pictureBox;
        private FlowLayoutPanel flowLayoutPanel1;
        public Label loginLabel;
        private Button cartButton;
    }
}
