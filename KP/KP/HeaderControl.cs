using Interfaces;

namespace KP
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            CartForm CartForm = new CartForm(((CatalogForm)this.Parent).user);
            CartForm.ShowDialog();
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < 'а' || e.KeyChar > 'я') && (e.KeyChar < 'А' || e.KeyChar > 'Я') && (e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("Бажаєте вийти з акаунта?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) return;

            IUserActions user = ((CatalogForm)this.Parent).user;
            user.LogOut();
            Program.CatalogForm.ForceClose = true;
            (Program.CatalogForm).Close();
            Program.authenticationForm.Show();
        }
    }
}
