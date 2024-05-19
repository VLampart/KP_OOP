using Users;
using Utils;
using Products;

namespace KP
{
    public partial class CatalogForm : Form
    {
        private ProductUtils productUtils;
        public User user;
        private ProductForm productForm;
        public bool ForceClose { get; set; }

        public CatalogForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.ForceClose = false;
            headerControl.loginLabel.Text = user.Login;
            if (user.IsAdmin)
                addButton.Visible = true;
            productUtils = new ProductUtils();
            this.updateCatalogList();
        }

        private void CatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ForceClose)
                if (DialogResult.Yes != MessageBox.Show("Бажаєте вийти з додатку?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) e.Cancel = true;
                else Program.authenticationForm.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            productForm = new ProductForm(OperationType.Add);
            productForm.ShowDialog();
        }

        public void updateCatalogList()
        {
            productUtils.LoadProductFromJson();
            flowLayoutPanel.Controls.Clear();
            foreach (Product product in productUtils.Products.Values)
            {
                this.addProductToCatalogList(product);
            }
        }

        public void addProductToCatalogList(Product product)
        {
            ListItem listItem = new ListItem(product, user.IsAdmin);
            flowLayoutPanel.Controls.Add(listItem);
        }


        public void updateProductInList(Product product)
        {
            foreach (var item in flowLayoutPanel.Controls)
            {
                if (!(item is ListItem)) continue;
                var li = item as ListItem;
                if (li != null && li.ProductId == product.ProductID)
                {
                    li.update(product);
                    break;
                }
            }
        }

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private IEnumerable<Product> filterProducts()
        {
            List<string> selectedCategories = new List<string>();
            string filteredName = headerControl.searchBox.Text;
            double minPrice = double.TryParse(minPriceBox.Text, out double min) ? min : 0;
            double maxPrice = double.TryParse(maxPriceBox.Text, out double max) ? max : double.MaxValue;

            if (cpuCheckBox.Checked)
            {
                selectedCategories.Add("CPU");
            }

            if (motherboardCheckBox.Checked)
            {
                selectedCategories.Add("Motherboard");
            }

            if (ramCheckBox.Checked)
            {
                selectedCategories.Add("RAM");
            }

            if (gpuCheckBox.Checked)
            {
                selectedCategories.Add("GPU");
            }

            if (driveCheckBox.Checked)
            {
                selectedCategories.Add("Drive");
            }

            if (powersupplyCheckBox.Checked)
            {
                selectedCategories.Add("Power Supply");
            }

            var filteredProducts = productUtils.Products
                .Where(p => (selectedCategories.Count == 0 || selectedCategories.Contains(ProductUtils.GetCategory(p.Value))) &&
                     (p.Value.ProductPrice >= minPrice) &&
                     (p.Value.ProductPrice <= maxPrice) &&
                     (string.IsNullOrEmpty(filteredName) || p.Value.ProductCaption.ToLower().Contains(filteredName.ToLower())))
            .Select(p => p.Value);

            return filteredProducts;
        }

        private void displayFilteredProducts()
        {
            flowLayoutPanel.Controls.Clear();
            var filteredProducts = filterProducts().OrderBy(product => product.ProductPrice);
            foreach (var product in filteredProducts)
            {
                addProductToCatalogList(product);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            displayFilteredProducts();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            cpuCheckBox.Checked = false;
            motherboardCheckBox.Checked = false;
            ramCheckBox.Checked = false;
            gpuCheckBox.Checked = false;
            driveCheckBox.Checked = false;
            powersupplyCheckBox.Checked = false;
            headerControl.searchBox.Text = "";
            minPriceBox.Text = "0";
            maxPriceBox.Text = "";

            updateCatalogList();
        }

        private void minPriceBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.StartsWith(","))
            {
                textBox.Text = textBox.Text.Substring(1);
                textBox.SelectionStart = 0;
            }

            if (textBox.Text.Contains(",,"))
            {
                textBox.Text = textBox.Text.Replace(",,", ",");
                textBox.SelectionStart = textBox.Text.LastIndexOf(",") + 1;
            }
        }
    }
}
