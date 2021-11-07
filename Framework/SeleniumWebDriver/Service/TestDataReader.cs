using NUnit.Framework;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

namespace SeleniumWebDriver.Service
{
    public class TestDataReader
    {
        private static readonly string _filePath = "Resources/";
        private static readonly string _environment = TestContext.Parameters["environment"];

        public static string GetTestData(string key)
        {
            var text = File.ReadAllText($"{_filePath}{_environment}.json");
            JObject json = JObject.Parse(text);

            return json.Descendants().OfType<JProperty>().Where(x => x.Name == key).First().Value.ToString();
        }
    }
}