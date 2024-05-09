using Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class UserUtils
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private JsonUtils jsonUtils = new JsonUtils();
        public string fileName = "users.json";

        public Dictionary<string, User> Users { get => users; set => users = value; }

        public UserUtils(string filename = "users.json")
        {
            fileName = filename;
            LoadUserFromJson();
            foreach (User user in users.Values)
            {
                Console.WriteLine(Convert.ChangeType(user, user.GetType()));
            }
        }

        public void AddUser(User user)
        {
            users.Add(user.Login, user);
            SaveUserToJson();
        }

        public void EditUser(User user)
        {
            users[user.Login] = user;
            SaveUserToJson();
        }

        public void DeleteUser(string login)
        {
            if (users.ContainsKey(login))
            {
                users.Remove(login);
                SaveUserToJson();
            }
            else throw new Exception("Error! User not found");
        }

        public void SaveUserToJson()
        {
            jsonUtils.SaveToJson(users, fileName);
        }

        public void LoadUserFromJson()
        {
            users = jsonUtils.LoadFromJson<Dictionary<string, User>>(fileName);
            if (users == null) users = new Dictionary<string, User>();
        }

        public static void Register(string login, string password, string phone, string firstName, string middleName, string lastName, bool isAdmin)
        {
            UserUtils userUtils = new UserUtils();
            if (userUtils.Users.ContainsKey(login))
            {
                throw new Exception("Error! User with this login already exists.");
            }
            User newUser = new User(login, password, phone, firstName, middleName, lastName, false, true);

            userUtils.AddUser(newUser);

            Console.WriteLine("Registration successful!");
        }

        public static User Auth(string login, string password)
        {
            UserUtils userUtils = new UserUtils();
            if (userUtils.Users.ContainsKey(login) && userUtils.Users[login].Password == password)
            {
                User user = userUtils.Users[login];
                user.IsAuth = true;
                Console.WriteLine("Authorization successful!");
                return user;
            }
            throw new Exception("Authorization failed. Incorrect login or password.");
        }
    }
}
