using Utils;
using static System.Net.Mime.MediaTypeNames;

namespace KP
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            nameBox.TextChanged += new EventHandler(nameBox_TextChanged);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!checkParams()) return;
            var pib = nameBox.Text.Split(" ");
            try
            {
                UserUtils.Register(loginBox.Text, passwordBox.Text, phoneBox.Text, pib[1], pib[0], pib[2], isAdminCheckBox.Checked);
                MessageBox.Show("Реєстрація успішна !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка реєстрації !" + ex.Message);
            }
            Close();
        }

        private bool checkParams()
        {
            if (loginBox.Text == "" || !InputUtils.IsValidLogin(loginBox.Text))
            {
                MessageBox.Show("Введіть логін !");
                return false;
            }
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Введіть пароль !");
                return false;
            }
            if (phoneBox.Text == "" || !InputUtils.IsValidPhoneNumber(phoneBox.Text))
            {
                MessageBox.Show("Введіть номер телефону ! (+380000000000)");
                return false;
            }
            if (nameBox.Text == "" || nameBox.Text.Split(" ").Length != 3)
            {
                MessageBox.Show("Введіть свій ПІБ ! (Через пробіл)");
                return false;
            }
            return true;
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar < 'a' || e.KeyChar > 'z'))
            {
                e.Handled = true;
            }
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
            if ((e.KeyChar < 'а' || e.KeyChar > 'я') && (e.KeyChar < 'А' || e.KeyChar > 'Я') && (e.KeyChar == 'і' || e.KeyChar == 'І'))
            {
                e.Handled = true;
            }
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
