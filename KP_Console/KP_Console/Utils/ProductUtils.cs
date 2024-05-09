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
        }

        public void AddProduct(Product product)
        {
        }

        public void EditProduct(Product product)
        {
        }

        public void DeleteProduct(uint productId)
        {
        }

        public void SaveProductToJson()
        {
        }

        public void LoadProductFromJson()
        {
        }

        public string GetProductDetails(uint productId)
        {
            return "";
        }

        public uint GetProductCount(uint productId)
        {
            return 0;   
        }
    }
}
