using Users;
using Utils;
using Interfaces;

namespace KP
{
    public partial class CartForm : Form
    {
        private User user;
        private double FullPrice = 0;
        public CartForm(User user)
        {
            InitializeComponent();
            this.user = user;

            phoneBox.Text = user.Phone;
            nameBox.Text = user.FirstName + " " + user.MiddleName + " " + user.LastName;

            ProductUtils productUtils = new ProductUtils();
            int n = 1;
            foreach (var item in user.Cart)
            {
                var price = item.Value * productUtils.Products[item.Key].ProductPrice;
                dataGridCart.Rows.Add(n, item.Key, productUtils.Products[item.Key].ProductCaption, item.Value, price);
                n++;
                FullPrice += price;
            }
            costLabel.Text = $"Ціна: {FullPrice}грн.";
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            if ((e.KeyChar < 'а' || e.KeyChar > 'я') && (e.KeyChar < 'А' || e.KeyChar > 'Я') && (e.KeyChar == 'i' || e.KeyChar == 'І'))
            {
                e.Handled = true;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (user.Cart.Count == 0)
            {
                MessageBox.Show("Кошик порожній!");
                return;
            }
            if (nameBox.Text == "" || phoneBox.Text == "")
            {
                MessageBox.Show("Введіть контактні дані!");
                return;
            }
            try
            {
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Оберіть папку для створення чеку:";
                    folderDialog.ShowNewFolderButton = true;

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        IUserActions actions = this.user;
                        actions.ConfirmOrder(folderDialog.SelectedPath, true);
                        MessageBox.Show("Замовлення оформлено !");
                        Program.CatalogForm.updateCatalogList();
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка оформлення замовлення!");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            IUserActions userActions = user;

            userActions.RemoveFromCart(Convert.ToUInt32(dataGridCart.SelectedRows[0].Cells[1].Value));
            dataGridCart.Rows.Remove(dataGridCart.SelectedRows[0]);
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            TextBox nameBox = (TextBox)sender;
            string text = nameBox.Text;
            if (text.Length > 0 && text[0] == ' ')
            {
                nameBox.Text = text.Substring(1);
                nameBox.SelectionStart = 0;
            }
            else if (text.Length > 1 && text[text.Length - 1] == ' ' && text[text.Length - 2] == ' ')
            {
                nameBox.Text = text.Substring(0, text.Length - 1);
                nameBox.SelectionStart = nameBox.Text.Length;
            }
        }
    }
}
