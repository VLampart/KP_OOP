using Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class UserUtils
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private JsonUtils jsonUtils = new JsonUtils();
        public string fileName = "users.json";

        public Dictionary<string, User> Users { get => users; set => users = value; }

        public UserUtils(string filename = "users.json")
        {
        }

        public void AddUser(User user)
        {
        }

        public void EditUser(User user)
        {
        }

        public void DeleteUser(string login)
        {
        }

        public void SaveUserToJson()
        {
        }

        public void LoadUserFromJson()
        {
        }
    }
}
