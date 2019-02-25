using System;
using System.IO;

namespace CIIT_Grading_System.Classes
{
    public class User
    {
        private string ReadFile(string fileName)
        {
            string output = File.ReadAllText(fileName);
            return output;
        }

        private void WriteFile(string fileName, string input)
        {
            File.WriteAllText(fileName, input);
        }

        private void MarkdownToHtml(string fileName, string outputName)
        {
            string input = Markdig.Markdown.ToHtml(ReadFile(fileName));
            WriteFile(outputName, input);
        }

        public void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        public void JsonUpdate(string fileName, dynamic new_object)
        {
            using (StreamWriter file = File.CreateText(fileName))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(file, new_object);
            }
        }

        public dynamic LoadJson(string fileName)
        {
            string json = ReadFile(fileName);
            dynamic array = JsonConvert.DeserializeObject(json);
            foreach (dynamic item in array)
            {
                Console.WriteLine("{0}", item);
            }
            return array;
        }

        public string userFile;
        public JObject userData;

        public void CreateUser(string userName)
        {
            userFile = String.Format(@"..\..\Data\Users\{0}.json", userName);
            userData = new JObject(LoadJson(userFile));
        }
    }
}