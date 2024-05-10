using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;


namespace Utils
{
    public class ProductUtils
    {
        Dictionary<uint, Product> products = new Dictionary<uint, Product>();
        private JsonUtils jsonUtils = new JsonUtils();
        public string fileName = "products.json";

        public Dictionary<uint, Product> Products { get => products; set => products = value; }

        public ProductUtils(string filename = "products.json")
        {
            fileName = filename;
            LoadProductFromJson();
            foreach (Product product in products.Values)
            {
                Console.WriteLine(Convert.ChangeType(product, product.GetType()));
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product.ProductID, product);
            SaveProductToJson();
        }

        public void EditProduct(Product product)
        {
            products[product.ProductID] = product;
            SaveProductToJson();
        }

        public void DeleteProduct(uint productId)
        {
            if (products.ContainsKey(productId))
            {
                products.Remove(productId);
                SaveProductToJson();
            }
            else throw new Exception("Error! Product not found");
        }

        public void SaveProductToJson()
        {
            jsonUtils.SaveToJson(products, fileName);
        }

        public void LoadProductFromJson()
        {
            products = jsonUtils.LoadFromJson<Dictionary<uint, Product>>(fileName);
            if (products == null) products = new Dictionary<uint, Product>();
        }

        public string GetProductDetails(uint productId)
        {
            if (products.ContainsKey(productId))
            {
                return Convert.ChangeType(products[productId], products[productId].GetType()).ToString();
            }
            else return "Error! Product not found";
        }

        public uint GetProductCount(uint productId)
        {
            if (products.ContainsKey(productId))
            {
                return products[productId].ProductCount;
            }
            else throw new Exception("Error! Product not found");
        }
    }
}
