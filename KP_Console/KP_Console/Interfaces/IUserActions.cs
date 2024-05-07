using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IUserActions
    {
        public void Register();
        public void Auth(string login, string password, bool isAuth);
        public void LogOut(bool isAuth);
        public void AddToCart(uint productID, uint productCount);
        public void RemoveFromCart(uint productID);
        public void ConfirmOrder();
    }
}
