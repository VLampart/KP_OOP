using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class JsonUtils
    {
        private JsonSerializerSettings jsonSettings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects
        };

        public void SaveToJson<T>(T data, string fileName)
        {
        }

        public T LoadFromJson<T>(string fileName)
        {
            return default(T);
        }
    }
}
