using Products;
using Utils;

namespace KP
{
    public partial class ListItem : UserControl
    {
        private bool isAdmin;
        private Product product;
        private ProductForm productForm;
        private ProductUtils productUtils;

        public uint ProductId { get=> this.product.ProductID; private set => this.product.ProductID = value; }

        public ListItem(Product product = null, bool isAdmin = false)
        {

            InitializeComponent();
            this.isAdmin = isAdmin;
            this.product = product;
            productUtils = new ProductUtils();

            if (isAdmin)
            {
                editButton.Visible = true;
                deleteButton.Visible = true;
            }

            if (product != null) this.update(product);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            productForm = new ProductForm(OperationType.Edit, this.product);
            productForm.ShowDialog();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            productForm = new ProductForm(OperationType.AddToCart, this.product);
            productForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            productUtils.DeleteProduct(product.ProductID);
            this.Dispose();
            MessageBox.Show("Товар було видалено!");
        }   

        public void update(Product product)
        {
            this.product = product;
            productCaption.Text = product.ProductCaption;
            productCategory.Text = ProductUtils.GetCategory(product);
            productManufacturer.Text = product.ProductManufacturer;
            productPrice.Text = product.ProductPrice.ToString();
            productCount.Text = product.ProductCount.ToString();
        }
    }
}
