using Newtonsoft.Json;

namespace Utils
{
    public class JsonUtils
    {
        private JsonSerializerSettings jsonSettings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
            /*PreserveReferencesHandling = PreserveReferencesHandling.Objects*/
        };

        public void SaveToJson<T>(T data, string fileName)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented, jsonSettings);
            File.WriteAllText(fileName, json);
        }

        public T LoadFromJson<T>(string fileName)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName), jsonSettings);
            }
            catch
            {
                Console.WriteLine($"Error! {fileName} not found");
                return default(T);
            }
        }
    }
}
