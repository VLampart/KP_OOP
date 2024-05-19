namespace KP
{
    partial class ListItem
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
            productCaption = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            productManufacturerLabel = new Label();
            productCountLabel = new Label();
            productPriceLabel = new Label();
            productManufacturer = new Label();
            productCount = new Label();
            productPrice = new Label();
            detailsButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            productCategory = new Label();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // productCaption
            // 
            productCaption.AutoSize = true;
            productCaption.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            productCaption.Location = new Point(3, 0);
            productCaption.Name = "productCaption";
            productCaption.Size = new Size(54, 21);
            productCaption.TabIndex = 0;
            productCaption.Text = "Назва";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.95181F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.04819F));
            tableLayoutPanel.Controls.Add(productManufacturerLabel, 0, 0);
            tableLayoutPanel.Controls.Add(productCountLabel, 0, 1);
            tableLayoutPanel.Controls.Add(productPriceLabel, 0, 2);
            tableLayoutPanel.Controls.Add(productManufacturer, 1, 0);
            tableLayoutPanel.Controls.Add(productCount, 1, 1);
            tableLayoutPanel.Controls.Add(productPrice, 1, 2);
            tableLayoutPanel.Location = new Point(3, 24);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Size = new Size(332, 97);
            tableLayoutPanel.TabIndex = 4;
            // 
            // productManufacturerLabel
            // 
            productManufacturerLabel.AutoSize = true;
            productManufacturerLabel.Dock = DockStyle.Fill;
            productManufacturerLabel.Location = new Point(3, 0);
            productManufacturerLabel.Name = "productManufacturerLabel";
            productManufacturerLabel.Size = new Size(120, 32);
            productManufacturerLabel.TabIndex = 0;
            productManufacturerLabel.Text = "Виробник";
            productManufacturerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productCountLabel
            // 
            productCountLabel.AutoSize = true;
            productCountLabel.Dock = DockStyle.Fill;
            productCountLabel.Location = new Point(3, 32);
            productCountLabel.Name = "productCountLabel";
            productCountLabel.Size = new Size(120, 32);
            productCountLabel.TabIndex = 1;
            productCountLabel.Text = "Кількість на складі";
            productCountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Dock = DockStyle.Fill;
            productPriceLabel.Location = new Point(3, 64);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(120, 33);
            productPriceLabel.TabIndex = 2;
            productPriceLabel.Text = "Ціна";
            productPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productManufacturer
            // 
            productManufacturer.AutoSize = true;
            productManufacturer.Dock = DockStyle.Fill;
            productManufacturer.Location = new Point(129, 0);
            productManufacturer.Name = "productManufacturer";
            productManufacturer.Size = new Size(200, 32);
            productManufacturer.TabIndex = 4;
            productManufacturer.Text = "Виробник";
            productManufacturer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productCount
            // 
            productCount.AutoSize = true;
            productCount.Dock = DockStyle.Fill;
            productCount.Location = new Point(129, 32);
            productCount.Name = "productCount";
            productCount.Size = new Size(200, 32);
            productCount.TabIndex = 5;
            productCount.Text = "0";
            productCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Dock = DockStyle.Fill;
            productPrice.Location = new Point(129, 64);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(200, 33);
            productPrice.TabIndex = 6;
            productPrice.Text = "0,00";
            productPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // detailsButton
            // 
            detailsButton.BackColor = SystemColors.Highlight;
            detailsButton.FlatStyle = FlatStyle.Popup;
            detailsButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            detailsButton.Location = new Point(455, 48);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(170, 40);
            detailsButton.TabIndex = 5;
            detailsButton.Text = "Переглянути";
            detailsButton.UseVisualStyleBackColor = false;
            detailsButton.Click += detailsButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.MediumSpringGreen;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.Location = new Point(455, 94);
            editButton.Name = "editButton";
            editButton.Size = new Size(82, 28);
            editButton.TabIndex = 6;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = false;
            editButton.Visible = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Crimson;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(543, 94);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(82, 28);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // productCategory
            // 
            productCategory.AutoSize = true;
            productCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            productCategory.Location = new Point(375, 5);
            productCategory.Name = "productCategory";
            productCategory.Size = new Size(59, 15);
            productCategory.TabIndex = 8;
            productCategory.Text = "Категорія";
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(productCategory);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(detailsButton);
            Controls.Add(tableLayoutPanel);
            Controls.Add(productCaption);
            Name = "ListItem";
            Size = new Size(630, 128);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label productCaption;
        private TableLayoutPanel tableLayoutPanel;
        private Label productManufacturerLabel;
        private Label productCountLabel;
        private Label productPriceLabel;
        private Label productManufacturer;
        public Label productCount;
        public Label productPrice;
        private Button detailsButton;
        public Button editButton;
        public Button deleteButton;
        private Label productCategory;
    }
}
