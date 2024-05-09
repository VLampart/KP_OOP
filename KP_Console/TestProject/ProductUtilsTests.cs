using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class ProductUtilsTests
    {
        private ProductUtils _productUtils;
        private string _testFileName = "test_products.json";

        [TestInitialize]
        public void TestInitialize()
        {
            _productUtils = new ProductUtils(_testFileName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            File.Delete(_testFileName);
        }

        [TestMethod]
        public void AddProduct_Success()
        {
            // Arrange
            CPU cpu = new CPU("test", "test", 2500.50, "good", 2, 5, 3.2, "am4");

            // Act
            _productUtils.AddProduct(cpu);

            // Assert
            Assert.IsTrue(_productUtils.Products.ContainsKey(cpu.ProductID));
            Assert.AreEqual(cpu, _productUtils.Products[cpu.ProductID]);
        }

        [TestMethod]
        public void EdiProduct_Success()
        {
            // Arrange
            CPU oldCpu = new CPU("test", "test", 2500.50, "good", 2, 5, 3.2, "am4");
            CPU newCpu = new CPU("new", "new", 2500.50, "good", 2, 5, 3.2, "am4");
            _productUtils.AddProduct(oldCpu);

            // Act
            _productUtils.EditProduct(newCpu);

            // Assert
            Assert.IsTrue(_productUtils.Products.ContainsKey(newCpu.ProductID));
            Assert.AreEqual(newCpu, _productUtils.Products[newCpu.ProductID]);
        }

        [TestMethod]
        public void DeleteProduct_Success()
        {
            // Arrange
            CPU cpu = new CPU("test", "test", 2500.50, "good", 2, 5, 3.2, "am4");
            _productUtils.AddProduct(cpu);

            // Act
            _productUtils.DeleteProduct(cpu.ProductID);

            // Assert
            Assert.IsFalse(_productUtils.Products.ContainsKey(cpu.ProductID));
        }
    }
}
