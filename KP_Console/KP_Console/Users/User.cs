using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

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
            IsAuth = false;
            Cart = new Dictionary<uint, uint>();
        }

        public User(string login, string password, string phone, string firstName, string middleName, string lastName, bool isAdmin, bool isAuth)
        {
            Login = login;
            Password = password;
            Phone = phone;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            IsAdmin = isAdmin;
            IsAuth = isAuth;
            Cart = new Dictionary<uint, uint>();
        }

        void IUserActions.LogOut()
        {
            if (IsAuth)
            {
                IsAuth = false;
                Console.WriteLine("Logout successful!");
            }
            else
            {
                throw new Exception("Error! You are not authorized.");
            }
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

            Console.WriteLine("Product added to cart!");
        }

        void IUserActions.RemoveFromCart(uint productId)
        {
            if (Cart.ContainsKey(productId))
            {
                Cart.Remove(productId);
                Console.WriteLine("Product removed from cart!");
            }
            else
            {
                throw new Exception("Error! Product not found in cart.");
            }
        }

        void IUserActions.ConfirmOrder()
        {
            if (Cart.Count > 0)
            {
                Console.WriteLine("Order confirmed!");
                Cart.Clear();
            }
            else
            {
                throw new Exception("Error! Cart is empty.");
            }
        }

        public override string ToString()
        {
            return $"Login: {Login} \nPassword: {Password} \nPhone: {FirstName} \nMiddleName: {MiddleName} \nLastName: {LastName} \nIsAdmin: {IsAdmin} \nIsAuth: {IsAuth}";
        }
    }
}
