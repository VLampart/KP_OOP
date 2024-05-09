namespace TestProject
{
    [TestClass]
    public class InputUtilsTests
    {
        private StringWriter _consoleOutput;
        private StringReader _consoleInput;

        [TestInitialize]
        public void TestInitialize()
        {
            _consoleOutput = new StringWriter();
            Console.SetOut(_consoleOutput);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }

        [TestMethod]
        public void ReadValidInt_ValidInput_ReturnsExpectedValue()
        {
            // Arrange
            _consoleInput = new StringReader("123");
            Console.SetIn(_consoleInput);

            // Act
            int result = InputUtils.ReadValidInt();

            // Assert
            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void ReadValidDouble_ValidInput_ReturnsExpectedValue()
        {
            // Arrange
            _consoleInput = new StringReader("123,45");
            Console.SetIn(_consoleInput);

            // Act
            double result = InputUtils.ReadValidDouble();

            // Assert
            Assert.AreEqual(123.45, result);
        }

        [TestMethod]
        public void ReadValidPhone_ValidInput_ReturnsExpectedValue()
        {
            // Arrange
            _consoleInput = new StringReader("+380123456789");
            Console.SetIn(_consoleInput);

            // Act
            string result = InputUtils.ReadValidPhone();

            // Assert
            Assert.AreEqual("+380123456789", result);
        }

        [TestMethod]
        public void ReadValidLogin_ValidInput_ReturnsExpectedValue()
        {
            // Arrange
            _consoleInput = new StringReader("abcde123");
            Console.SetIn(_consoleInput);

            // Act
            string result = InputUtils.ReadValidLogin();

            // Assert
            Assert.AreEqual("abcde123", result);
        }
    }
}