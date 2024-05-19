using Interfaces;

namespace TestProject
{
    [TestClass]
    public class UserTests
    {
        /*[TestMethod]
        public void TestRegister()
        {
            // Arrange
            string login = "testuser";
            string password = "testpassword";
            string phone = "1234567890";
            string firstName = "Test";
            string middleName = "User";
            string lastName = "Testuser";
            bool isAdmin = false;

            // Act
            UserUtils.Register(login, password, phone, firstName, middleName, lastName, isAdmin);
            UserUtils userUtils = new UserUtils();

            // Assert
            Assert.IsTrue(userUtils.Users.ContainsKey(login));
        }*/

        [TestMethod]
        public void TestAuth()
        {
            // Arrange
            string login = "testuser";
            string password = "testpassword";

            // Act
            User user = UserUtils.Auth(login, password);

            // Assert
            Assert.IsTrue(user.IsAuth);
        }

        [TestMethod]
        public void TestLogOut()
        {
            // Arrange
            string login = "testuser";
            string password = "testpassword";
            User user = UserUtils.Auth(login, password);

            // Act
            IUserActions userActions = user as IUserActions;
            userActions.LogOut();

            // Assert
            Assert.IsFalse(user.IsAuth);
        }

        [TestMethod]
        public void TestAddToCart()
        {
            // Arrange
            string login = "testuser";
            string password = "testpassword";

            User user = UserUtils.Auth(login, password);
            user.Cart = new Dictionary<uint, uint>(); // Ensure the cart is empty before the test

            uint productId = 1;
            uint productCount = 2;

            // Act
            IUserActions userActions = user as IUserActions;
            userActions.AddToCart(productId, productCount);

            // Assert
            Assert.IsTrue(user.Cart.ContainsKey(productId));
            Assert.AreEqual(productCount, user.Cart[productId]);
        }
    

    [TestMethod]
        public void TestRemoveFromCart()
        {
            // Arrange
            string login = "testuser";
            string password = "testpassword";

            User user = UserUtils.Auth(login, password);

            uint productId = 1;
            uint productCount = 2;
            IUserActions userActions = user as IUserActions;
            userActions.AddToCart(productId, productCount);

            // Act

            userActions.RemoveFromCart(productId);

            // Assert
            Assert.IsFalse(user.Cart.ContainsKey(productId));
        }
    }
}
