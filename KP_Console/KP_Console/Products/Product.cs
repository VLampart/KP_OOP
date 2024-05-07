using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal abstract class Product
    {
        protected uint productID;
        protected string productCaption;
        protected string productManufacturer;
        protected double productPrice;
        protected string productDescription;
        protected uint productCount;

        public uint ProductID { get => productID; set => productID = value; }
        public string ProductCaption { get => productCaption; set => productCaption = value; }
        public string ProductManufacturer { get => productManufacturer; set => productManufacturer = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
        public string ProductDescription { get => productDescription; set => productDescription = value; }
        public uint ProductCount { get => productCount; set => productCount = value; }

        public Product()
        {
            ProductID = (uint)Guid.NewGuid().GetHashCode();
            ProductCaption = "";
            ProductManufacturer = "";
            ProductPrice = 0;
            ProductDescription = "";
            ProductCount = 0;
        }

        public Product(string productCaption, string productManufacturer, double productPrice, string productDescription, uint productCount)
        {
            ProductID = (uint)Guid.NewGuid().GetHashCode();
            ProductCaption = productCaption;
            ProductManufacturer = productManufacturer;
            ProductPrice = productPrice;
            ProductDescription = productDescription;
            ProductCount = productCount;
        }

        public override string? ToString()
        {
            return "";
        }
    }
}
