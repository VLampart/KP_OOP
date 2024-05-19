namespace KP
{
    partial class CartForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            confirmButton = new Button();
            costLabel = new Label();
            nameLabel = new Label();
            phoneLabel = new Label();
            nameBox = new TextBox();
            phoneBox = new TextBox();
            dataGridCart = new DataGridView();
            numberColumn = new DataGridViewTextBoxColumn();
            pIDColumn = new DataGridViewTextBoxColumn();
            pCaptionColumn = new DataGridViewTextBoxColumn();
            pCountColumn = new DataGridViewTextBoxColumn();
            pCostColumn = new DataGridViewTextBoxColumn();
            removeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCart).BeginInit();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            confirmButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            confirmButton.BackColor = SystemColors.Highlight;
            confirmButton.FlatStyle = FlatStyle.Popup;
            confirmButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            confirmButton.Location = new Point(572, 272);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(164, 44);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Оформити замовлення";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            costLabel.Location = new Point(4, 272);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(43, 21);
            costLabel.TabIndex = 2;
            costLabel.Text = "Ціна";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(565, 8);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(27, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "ПІБ";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            phoneLabel.Location = new Point(565, 75);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(101, 15);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Номер телефону";
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nameBox.Location = new Point(565, 26);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(164, 23);
            nameBox.TabIndex = 5;
            nameBox.TextChanged += nameBox_TextChanged;
            nameBox.KeyPress += nameBox_KeyPress;
            // 
            // phoneBox
            // 
            phoneBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            phoneBox.Location = new Point(565, 93);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(164, 23);
            phoneBox.TabIndex = 6;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // dataGridCart
            // 
            dataGridCart.AllowUserToAddRows = false;
            dataGridCart.AllowUserToDeleteRows = false;
            dataGridCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCart.Columns.AddRange(new DataGridViewColumn[] { numberColumn, pIDColumn, pCaptionColumn, pCountColumn, pCostColumn });
            dataGridCart.Location = new Point(4, 2);
            dataGridCart.MultiSelect = false;
            dataGridCart.Name = "dataGridCart";
            dataGridCart.ReadOnly = true;
            dataGridCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCart.Size = new Size(555, 264);
            dataGridCart.TabIndex = 7;
            // 
            // numberColumn
            // 
            numberColumn.HeaderText = "№";
            numberColumn.Name = "numberColumn";
            numberColumn.ReadOnly = true;
            numberColumn.Resizable = DataGridViewTriState.False;
            numberColumn.Width = 50;
            // 
            // pIDColumn
            // 
            pIDColumn.HeaderText = "ID продукту";
            pIDColumn.Name = "pIDColumn";
            pIDColumn.ReadOnly = true;
            // 
            // pCaptionColumn
            // 
            pCaptionColumn.HeaderText = "Назва";
            pCaptionColumn.Name = "pCaptionColumn";
            pCaptionColumn.ReadOnly = true;
            pCaptionColumn.Width = 150;
            // 
            // pCountColumn
            // 
            pCountColumn.HeaderText = "Кількість, шт";
            pCountColumn.Name = "pCountColumn";
            pCountColumn.ReadOnly = true;
            // 
            // pCostColumn
            // 
            pCostColumn.HeaderText = "Ціна, грн";
            pCostColumn.Name = "pCostColumn";
            pCostColumn.ReadOnly = true;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            removeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            removeButton.BackColor = Color.Crimson;
            removeButton.FlatStyle = FlatStyle.Popup;
            removeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            removeButton.Location = new Point(4, 296);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(86, 20);
            removeButton.TabIndex = 8;
            removeButton.Text = "Вилучити";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 327);
            Controls.Add(removeButton);
            Controls.Add(dataGridCart);
            Controls.Add(phoneBox);
            Controls.Add(nameBox);
            Controls.Add(phoneLabel);
            Controls.Add(nameLabel);
            Controls.Add(costLabel);
            Controls.Add(confirmButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(481, 366);
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dataGridCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button confirmButton;
        private Label costLabel;
        private Label nameLabel;
        private Label phoneLabel;
        private TextBox nameBox;
        private TextBox phoneBox;
        private DataGridView dataGridCart;
        private DataGridViewTextBoxColumn numberColumn;
        private DataGridViewTextBoxColumn pIDColumn;
        private DataGridViewTextBoxColumn pCaptionColumn;
        private DataGridViewTextBoxColumn pCountColumn;
        private DataGridViewTextBoxColumn pCostColumn;
        private Button removeButton;
    }
}