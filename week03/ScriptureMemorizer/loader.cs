using System.Collections.Concurrent;
using System.Text.Json;
namespace Scripture_Memorizer
{
    public class Loader
    {
        private JsonElement data;
        public void LoadData()
        {
            var json = File.ReadAllText("book-of-mormon.json");
            data = JsonSerializer.Deserialize<JsonElement>(json);
        }
        public JsonElement GetData()
        {
            return data;
        }
    }
}