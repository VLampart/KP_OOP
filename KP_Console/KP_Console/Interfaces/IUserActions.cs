using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUserActions
    {
        public void LogOut();
        public void AddToCart(uint productID, uint productCount);
        public void RemoveFromCart(uint productID);
        public void ConfirmOrder(string folderpath, bool open = false);
    }
}
