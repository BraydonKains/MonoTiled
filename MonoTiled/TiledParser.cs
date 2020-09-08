using System.IO;
using System.Text.Json;

namespace MonoTiled {
    public static class TiledParser {
        public static TiledModel ReadMapJson(string fileName) {
			string json = File.ReadAllText(fileName);
			var options = new JsonSerializerOptions {
				PropertyNameCaseInsensitive = true,
			};
			return JsonSerializer.Deserialize<TiledModel>(json, options);
        }
    }
}