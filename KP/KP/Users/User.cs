using System.Diagnostics;
using Interfaces;
using Utils;

namespace Users
{
    public class User : IUserActions
    {
        private string login;
        private string password;
        private string phone;
        private string firstName;
        private string middleName;
        private string lastName;
        private bool isAdmin;
        private bool isAuth;

        private Dictionary<uint, uint> cart = new Dictionary<uint, uint>();

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public bool IsAuth { get => isAuth; set => isAuth = value; }
        public Dictionary<uint, uint> Cart { get => cart; set => cart = value; }

        public User()
        {
            Login = "";
            Password = "";
            Phone = "";
            FirstName = "";
            MiddleName = "";
            LastName = "";
            IsAdmin = false;
            Cart = new Dictionary<uint, uint>();
        }

        public User(string login, string password, string phone, string firstName, string middleName, string lastName, bool isAdmin)
        {
            Login = login;
            Password = password;
            Phone = phone;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            IsAdmin = isAdmin;
            Cart = new Dictionary<uint, uint>();
        }

        void IUserActions.LogOut()
        {
            UserUtils userUtils = new UserUtils();
            if (this.IsAuth)
            {
                this.IsAuth = false;
                Console.WriteLine("Logout successful!");
                userUtils.EditUser(this);
            }
            else Console.WriteLine("Error! User is not logged in.");
        }

        void IUserActions.AddToCart(uint productId, uint productCount)
        {
            if (Cart.ContainsKey(productId))
            {
                Cart[productId] += productCount;
            }
            else
            {
                Cart.Add(productId, productCount);
            }
            UserUtils userUtils = new UserUtils();
            userUtils.EditUser(this);
            Console.WriteLine("Product added to cart!");
        }

        void IUserActions.RemoveFromCart(uint productId)
        {
            if (Cart.ContainsKey(productId))
            {
                UserUtils userUtils = new UserUtils();
                Cart.Remove(productId);
                userUtils.EditUser(this);
                Console.WriteLine("Product removed from cart!");
            }
            else
            {
                throw new Exception("Error! Product not found in cart.");
            }
        }

        void IUserActions.ConfirmOrder(string folderpath, bool open)
        {
            if (Cart.Count > 0)
            {
                ProductUtils productUtils = new ProductUtils();
                string check = "Покупка:\n";
                double fullprice = 0;
                foreach (var item in cart)
                {
                    var p = productUtils.Products[item.Key];
                    if (p.ProductCount < item.Value) throw new Exception($"Недостатньо продуктів для замовлення: {p.ProductCaption}, на складі не вистачає {item.Value - p.ProductCount} шт.");
                    p.ProductCount -= item.Value;
                    productUtils.EditProduct(p);
                    var price = productUtils.Products[item.Key].ProductPrice * item.Value;
                    check += $"{item.Key} | {productUtils.Products[item.Key].ProductCaption} | {item.Value} шт. | {price} грн.\n";
                    fullprice += price;
                }
                check += $"Ціна: {fullprice} грн.";
                string filename = Path.Combine(folderpath, DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + "-order.txt");
                StreamWriter writer = new StreamWriter(filename);
                writer.WriteLine(check);
                writer.Close();
                try
                {
                    if (open) Process.Start("notepad.exe", filename);

                }catch(Exception e)
                {
                    Debug.WriteLine("Помилка !" + e.Message);
                }
                Cart.Clear();
                UserUtils userUtils = new UserUtils();
                userUtils.EditUser(this);
                Console.WriteLine("Order confirmed!");
            }
            else
            {
                throw new Exception("Error! Cart is empty.");
            }
        }

        public override string ToString()
        {
            return $"Login: {Login} \nPassword: {Password} \nPhone: {FirstName} \nMiddleName: {MiddleName} \nLastName: {LastName} \nIsAdmin: {IsAdmin}";
        }
    }
}
