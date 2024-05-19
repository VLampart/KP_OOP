namespace KP
{
    partial class CatalogForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            tableLayoutPanel = new TableLayoutPanel();
            resetButton = new Button();
            powersupplyCheckBox = new CheckBox();
            driveCheckBox = new CheckBox();
            gpuCheckBox = new CheckBox();
            ramCheckBox = new CheckBox();
            motherboardCheckBox = new CheckBox();
            cpuCheckBox = new CheckBox();
            categoryLabel = new Label();
            minPriceLabel = new Label();
            maxPriceLabel = new Label();
            minPriceBox = new TextBox();
            maxPriceBox = new TextBox();
            filterButton = new Button();
            headerControl = new HeaderControl();
            flowLayoutPanel = new FlowLayoutPanel();
            addButton = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(resetButton, 0, 13);
            tableLayoutPanel.Controls.Add(powersupplyCheckBox, 0, 6);
            tableLayoutPanel.Controls.Add(driveCheckBox, 0, 5);
            tableLayoutPanel.Controls.Add(gpuCheckBox, 0, 4);
            tableLayoutPanel.Controls.Add(ramCheckBox, 0, 3);
            tableLayoutPanel.Controls.Add(motherboardCheckBox, 0, 2);
            tableLayoutPanel.Controls.Add(cpuCheckBox, 0, 1);
            tableLayoutPanel.Controls.Add(categoryLabel, 0, 0);
            tableLayoutPanel.Controls.Add(minPriceLabel, 0, 7);
            tableLayoutPanel.Controls.Add(maxPriceLabel, 0, 9);
            tableLayoutPanel.Controls.Add(minPriceBox, 0, 8);
            tableLayoutPanel.Controls.Add(maxPriceBox, 0, 10);
            tableLayoutPanel.Controls.Add(filterButton, 0, 12);
            tableLayoutPanel.Dock = DockStyle.Left;
            tableLayoutPanel.Location = new Point(0, 53);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 14;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.Size = new Size(144, 397);
            tableLayoutPanel.TabIndex = 1;
            // 
            // resetButton
            // 
            resetButton.BackColor = SystemColors.Highlight;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resetButton.Location = new Point(4, 359);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(136, 34);
            resetButton.TabIndex = 12;
            resetButton.Text = "Скинути фільтри";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // powersupplyCheckBox
            // 
            powersupplyCheckBox.AutoSize = true;
            powersupplyCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            powersupplyCheckBox.Location = new Point(4, 160);
            powersupplyCheckBox.Name = "powersupplyCheckBox";
            powersupplyCheckBox.Size = new Size(120, 19);
            powersupplyCheckBox.TabIndex = 5;
            powersupplyCheckBox.Text = "Блоки живлення";
            powersupplyCheckBox.UseVisualStyleBackColor = true;
            // 
            // driveCheckBox
            // 
            driveCheckBox.AutoSize = true;
            driveCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            driveCheckBox.Location = new Point(4, 134);
            driveCheckBox.Name = "driveCheckBox";
            driveCheckBox.Size = new Size(104, 19);
            driveCheckBox.TabIndex = 4;
            driveCheckBox.Text = "Накопичувачі";
            driveCheckBox.UseVisualStyleBackColor = true;
            // 
            // gpuCheckBox
            // 
            gpuCheckBox.AutoSize = true;
            gpuCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            gpuCheckBox.Location = new Point(4, 108);
            gpuCheckBox.Name = "gpuCheckBox";
            gpuCheckBox.Size = new Size(87, 19);
            gpuCheckBox.TabIndex = 1;
            gpuCheckBox.Text = "Відеокарти";
            gpuCheckBox.UseVisualStyleBackColor = true;
            // 
            // ramCheckBox
            // 
            ramCheckBox.AutoSize = true;
            ramCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ramCheckBox.Location = new Point(4, 82);
            ramCheckBox.Name = "ramCheckBox";
            ramCheckBox.Size = new Size(136, 19);
            ramCheckBox.TabIndex = 3;
            ramCheckBox.Text = "Оперативна пам'ять";
            ramCheckBox.UseVisualStyleBackColor = true;
            // 
            // motherboardCheckBox
            // 
            motherboardCheckBox.AutoSize = true;
            motherboardCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            motherboardCheckBox.Location = new Point(4, 56);
            motherboardCheckBox.Name = "motherboardCheckBox";
            motherboardCheckBox.Size = new Size(131, 19);
            motherboardCheckBox.TabIndex = 2;
            motherboardCheckBox.Text = "Материнські плати";
            motherboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // cpuCheckBox
            // 
            cpuCheckBox.AutoSize = true;
            cpuCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cpuCheckBox.Location = new Point(4, 30);
            cpuCheckBox.Name = "cpuCheckBox";
            cpuCheckBox.Size = new Size(89, 19);
            cpuCheckBox.TabIndex = 0;
            cpuCheckBox.Text = "Процесори";
            cpuCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Dock = DockStyle.Fill;
            categoryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            categoryLabel.Location = new Point(4, 1);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(136, 25);
            categoryLabel.TabIndex = 7;
            categoryLabel.Text = "Категорії";
            categoryLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.Dock = DockStyle.Fill;
            minPriceLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            minPriceLabel.Location = new Point(4, 183);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new Size(136, 20);
            minPriceLabel.TabIndex = 8;
            minPriceLabel.Text = "Мінімальна ціна";
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.Dock = DockStyle.Fill;
            maxPriceLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            maxPriceLabel.Location = new Point(4, 230);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(136, 20);
            maxPriceLabel.TabIndex = 9;
            maxPriceLabel.Text = "Максимальна ціна";
            // 
            // minPriceBox
            // 
            minPriceBox.Dock = DockStyle.Fill;
            minPriceBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            minPriceBox.Location = new Point(4, 207);
            minPriceBox.Name = "minPriceBox";
            minPriceBox.PlaceholderText = "-";
            minPriceBox.Size = new Size(136, 23);
            minPriceBox.TabIndex = 10;
            minPriceBox.Text = "0";
            minPriceBox.TextChanged += minPriceBox_TextChanged;
            minPriceBox.KeyPress += PriceBox_KeyPress;
            // 
            // maxPriceBox
            // 
            maxPriceBox.Dock = DockStyle.Fill;
            maxPriceBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            maxPriceBox.Location = new Point(4, 254);
            maxPriceBox.Name = "maxPriceBox";
            maxPriceBox.PlaceholderText = "-";
            maxPriceBox.Size = new Size(136, 23);
            maxPriceBox.TabIndex = 11;
            maxPriceBox.TextChanged += minPriceBox_TextChanged;
            maxPriceBox.KeyPress += PriceBox_KeyPress;
            // 
            // filterButton
            // 
            filterButton.BackColor = SystemColors.Highlight;
            filterButton.FlatStyle = FlatStyle.Popup;
            filterButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            filterButton.Location = new Point(4, 318);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(136, 34);
            filterButton.TabIndex = 6;
            filterButton.Text = "Фільтрувати";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // headerControl
            // 
            headerControl.BorderStyle = BorderStyle.FixedSingle;
            headerControl.Dock = DockStyle.Top;
            headerControl.Location = new Point(0, 0);
            headerControl.Name = "headerControl";
            headerControl.Size = new Size(800, 53);
            headerControl.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel.Location = new Point(144, 53);
            flowLayoutPanel.Margin = new Padding(0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(656, 357);
            flowLayoutPanel.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.Highlight;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.Location = new Point(690, 415);
            addButton.Name = "addButton";
            addButton.Size = new Size(104, 28);
            addButton.TabIndex = 4;
            addButton.Text = "Додати товар";
            addButton.UseVisualStyleBackColor = false;
            addButton.Visible = false;
            addButton.Click += addButton_Click;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(flowLayoutPanel);
            Controls.Add(tableLayoutPanel);
            Controls.Add(headerControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "CatalogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalog";
            FormClosing += CatalogForm_FormClosing;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private HeaderControl headerControl;
        private TableLayoutPanel tableLayoutPanel;
        private CheckBox cpuCheckBox;
        private CheckBox gpuCheckBox;
        private CheckBox motherboardCheckBox;
        private CheckBox ramCheckBox;
        private CheckBox driveCheckBox;
        private CheckBox powersupplyCheckBox;
        private Button filterButton;
        private Label categoryLabel;
        private Label minPriceLabel;
        private Label maxPriceLabel;
        private TextBox minPriceBox;
        private TextBox maxPriceBox;
        private FlowLayoutPanel flowLayoutPanel;
        private ListItem listItem;
        private Button addButton;
        private Button resetButton;
    }
}
