using System.IO;
using Newtonsoft.Json;

namespace Library.Classes
{
    public class Manager
    {
        public static void JsonUpdate(string fileName, object new_object)
        {
            using (var file = File.CreateText(fileName))
            {
                var serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };
                serializer.Serialize(file, new_object);
            }
        }

        public static string ReadFile(string fileName)
        {
            string output = null;
            using (var sr = new StreamReader(fileName))
            {
                output = sr.ReadToEnd();
            }

            return output;
        }
    }
}