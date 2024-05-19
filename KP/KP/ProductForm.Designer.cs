namespace KP
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            productPriceLabel = new Label();
            performtButton = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            manufacturerBox = new TextBox();
            manufacturerLabel = new Label();
            priceBox = new TextBox();
            categoryBox = new ComboBox();
            captionBox = new TextBox();
            countLabel = new Label();
            countBox = new TextBox();
            detailsLabel = new Label();
            descriptionBox = new RichTextBox();
            textBoxCount = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            productPriceLabel.Location = new Point(383, 14);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(29, 15);
            productPriceLabel.TabIndex = 1;
            productPriceLabel.Text = "грн.";
            // 
            // performtButton
            // 
            performtButton.BackColor = SystemColors.MenuHighlight;
            performtButton.FlatStyle = FlatStyle.Popup;
            performtButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            performtButton.Location = new Point(319, 69);
            performtButton.Name = "performtButton";
            performtButton.Size = new Size(112, 41);
            performtButton.TabIndex = 2;
            performtButton.Text = "Придбати";
            performtButton.UseVisualStyleBackColor = false;
            performtButton.Click += performtButton_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61F));
            tableLayoutPanel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tableLayoutPanel.Location = new Point(15, 329);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Size = new Size(258, 137);
            tableLayoutPanel.TabIndex = 3;
            // 
            // manufacturerBox
            // 
            manufacturerBox.Location = new Point(116, 291);
            manufacturerBox.Name = "manufacturerBox";
            manufacturerBox.Size = new Size(152, 23);
            manufacturerBox.TabIndex = 9;
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new Point(17, 294);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new Size(65, 15);
            manufacturerLabel.TabIndex = 8;
            manufacturerLabel.Text = "Виробник:";
            // 
            // priceBox
            // 
            priceBox.BackColor = SystemColors.Control;
            priceBox.BorderStyle = BorderStyle.FixedSingle;
            priceBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            priceBox.Location = new Point(331, 13);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(47, 23);
            priceBox.TabIndex = 5;
            priceBox.TextAlign = HorizontalAlignment.Right;
            priceBox.TextChanged += priceBox_TextChanged;
            priceBox.KeyPress += productPriceBox_KeyPress;
            // 
            // categoryBox
            // 
            categoryBox.BackColor = SystemColors.Window;
            categoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryBox.FlatStyle = FlatStyle.Flat;
            categoryBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "CPU", "Motherboard", "RAM", "GPU", "Drive", "Power Supply" });
            categoryBox.Location = new Point(17, 40);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(126, 23);
            categoryBox.TabIndex = 6;
            categoryBox.TextChanged += categoryBox_TextChanged;
            // 
            // captionBox
            // 
            captionBox.BackColor = SystemColors.Control;
            captionBox.BorderStyle = BorderStyle.None;
            captionBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            captionBox.Location = new Point(17, 14);
            captionBox.Name = "captionBox";
            captionBox.PlaceholderText = "Назва";
            captionBox.Size = new Size(251, 22);
            captionBox.TabIndex = 7;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            countLabel.Location = new Point(15, 73);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(74, 15);
            countLabel.TabIndex = 8;
            countLabel.Text = "В наявності:";
            // 
            // countBox
            // 
            countBox.BackColor = SystemColors.Control;
            countBox.BorderStyle = BorderStyle.FixedSingle;
            countBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            countBox.Location = new Point(91, 73);
            countBox.Name = "countBox";
            countBox.Size = new Size(52, 23);
            countBox.TabIndex = 9;
            countBox.KeyPress += countBox_KeyPress;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            detailsLabel.Location = new Point(12, 99);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(36, 15);
            detailsLabel.TabIndex = 10;
            detailsLabel.Text = "Опис";
            // 
            // descriptionBox
            // 
            descriptionBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            descriptionBox.Location = new Point(15, 117);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            descriptionBox.Size = new Size(416, 162);
            descriptionBox.TabIndex = 11;
            descriptionBox.Text = "";
            // 
            // textBoxCount
            // 
            textBoxCount.BackColor = SystemColors.Control;
            textBoxCount.BorderStyle = BorderStyle.FixedSingle;
            textBoxCount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxCount.Location = new Point(341, 42);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(37, 23);
            textBoxCount.TabIndex = 13;
            textBoxCount.Text = "1";
            textBoxCount.TextAlign = HorizontalAlignment.Right;
            textBoxCount.Visible = false;
            textBoxCount.KeyPress += countBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(383, 44);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 12;
            label1.Text = "шт.";
            label1.Visible = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 478);
            Controls.Add(textBoxCount);
            Controls.Add(label1);
            Controls.Add(manufacturerBox);
            Controls.Add(descriptionBox);
            Controls.Add(detailsLabel);
            Controls.Add(countBox);
            Controls.Add(countLabel);
            Controls.Add(captionBox);
            Controls.Add(categoryBox);
            Controls.Add(priceBox);
            Controls.Add(tableLayoutPanel);
            Controls.Add(performtButton);
            Controls.Add(manufacturerLabel);
            Controls.Add(productPriceLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(459, 307);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label productPriceLabel;
        public Button performtButton;
        private TableLayoutPanel tableLayoutPanel;
        private TextBox priceBox;
        public ComboBox categoryBox;
        private TextBox captionBox;
        private Label countLabel;
        private TextBox countBox;
        private Label detailsLabel;
        private RichTextBox descriptionBox;
        private Label manufacturerLabel;
        private TextBox manufacturerBox;
        private TextBox textBoxCount;
        private Label label1;
    }
}