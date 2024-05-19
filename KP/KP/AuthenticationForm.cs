using Users;
using Utils;

namespace KP
{
    public partial class AuthenticationForm : Form
    {

        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar < 'a' || e.KeyChar > 'z'))
            {
                e.Handled = true;
            }
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "" || !InputUtils.IsValidLogin(loginBox.Text))
            {
                MessageBox.Show("Введіть логін !");
                return;
            }
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Введіть пароль !");
                return;
            }
            try
            {
                Program.CatalogForm = new CatalogForm(UserUtils.Auth(loginBox.Text, passwordBox.Text));
                Hide();
                loginBox.Text = "";
                passwordBox.Text = "";
                Program.CatalogForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка авторизації!" + ex.Message);
            }

        }

        private void AuthenticationForm_Shown(object sender, EventArgs e)
        {
            UserUtils userUtils = new UserUtils();
            User authUser = userUtils.AuthUser();
            if (authUser != null)
            {
                this.Hide();
                Program.CatalogForm = new CatalogForm(authUser);
                Program.CatalogForm.Show();
            }
        }
    }
}
