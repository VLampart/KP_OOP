namespace TestProject
{
    [TestClass]
    public class UserUtilsTests
    {
        private UserUtils _userUtils;
        private string _testFileName = "test_users.json";

        [TestInitialize]
        public void TestInitialize()
        {
            _userUtils = new UserUtils(_testFileName);

            if (File.Exists(_testFileName))
            {
                File.Delete(_testFileName);
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            File.Delete(_testFileName);
        }

        [TestMethod]
        public void AddUser_Success()
        {
            // Arrange
            User user = new User { Login = "testuser", Password = "testpassword" };

            // Act
            _userUtils.AddUser(user);

            // Assert
            Assert.IsTrue(_userUtils.Users.ContainsKey(user.Login));
            Assert.AreEqual(user, _userUtils.Users[user.Login]);
        }

        [TestMethod]
        public void EditUser_Success()
        {
            // Arrange
            User originalUser = new User { Login = "testuser", Password = "testpassword" };
            User updatedUser = new User { Login = "testuser", Password = "updatedtestpassword" };
            _userUtils.AddUser(originalUser);

            // Act
            _userUtils.EditUser(updatedUser);

            // Assert
            Assert.IsTrue(_userUtils.Users.ContainsKey(updatedUser.Login));
            Assert.AreEqual(updatedUser, _userUtils.Users[updatedUser.Login]);
        }

        [TestMethod]
        public void DeleteUser_Success()
        {
            // Arrange
            User user = new User { Login = "testuser", Password = "testpassword" };
            _userUtils.AddUser(user);

            // Act
            _userUtils.DeleteUser(user.Login);

            // Assert
            Assert.IsFalse(_userUtils.Users.ContainsKey(user.Login));
        }

        [TestMethod]
        public void AddUser_Failed_UserAlreadyExists()
        {
            // Arrange
            User user = new User { Login = "testuser", Password = "testpassword" };
            _userUtils.AddUser(user);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _userUtils.AddUser(user));
        }


        [TestMethod]
        public void EditUser_Failed_UserDoesNotExist()
        {
            // Arrange
            User user = new User { Login = "DoesNotExist", Password = "DoesNotExist" };

            // Act & Assert
            Assert.ThrowsException<Exception>(() => _userUtils.EditUser(user));
        }

        [TestMethod]
        public void DeleteUser_Failed_UserDoesNotExist()
        {
            // Arrange
            string nonExistentUser = "nonExistentUser";

            // Act & Assert
            Assert.ThrowsException<Exception>(() => _userUtils.DeleteUser(nonExistentUser));
        }
    }
}
