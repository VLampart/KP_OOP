using Products;

namespace Utils
{
    public class ProductUtils
    {
        Dictionary<uint, Product> products = new Dictionary<uint, Product>();
        private JsonUtils jsonUtils = new JsonUtils();
        private string fileName;

        public Dictionary<uint, Product> Products { get => products; set => products = value; }

        public ProductUtils(string _filename = "products.json")
        {
            fileName = _filename;
            if (File.Exists(fileName))
            {
                LoadProductFromJson();
                foreach (Product product in products.Values)
                {
                    Console.WriteLine(Convert.ChangeType(product, product.GetType()));
                }
            }
            else
            {
                Products = new Dictionary<uint, Product>();
            }
        }

        public uint AddProduct(Product product)
        {
            product.ProductID = (uint)Guid.NewGuid().GetHashCode();
            products.Add(product.ProductID, product);
            SaveProductToJson();
            return product.ProductID;
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

        public static string GetCategory(Product product)
        {
            if (product == null) return "";
            if (product is CPU) return "CPU";
            if (product is Motherboard) return "Motherboard";
            if (product is RAM) return "RAM";
            if (product is GPU) return "GPU";
            if (product is Drive) return "Drive";
            if (product is PowerSupply) return "Power Supply";
            return "";
        }
    }
}
