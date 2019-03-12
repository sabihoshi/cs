using Newtonsoft.Json;
using System;
using System.IO;
using UserData;

namespace CIIT_Grading_System.Classes
{
    public class User
    {
        public Data userData = new Data();

        public string userFile;

        public void CreateUser(string userName)
        {
            userFile = String.Format(@"..\..\Data\Users\{0}.json", userName);
            userData = JsonConvert.DeserializeObject<Data>(ReadFile(userFile));
        }

        public void JsonUpdate(string fileName, object new_object)
        {
            using (StreamWriter file = File.CreateText(fileName))
            {
                var serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };
                serializer.Serialize(file, new_object);
            }
        }

        public void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        public string ReadFile(string fileName)
        {
            string output = null;
            using (var sr = new StreamReader(fileName))
            {
                output = sr.ReadToEnd();
            }
            return output;
        }

        private void MarkdownToHtml(string fileName, string outputName)
        {
            string input = Markdig.Markdown.ToHtml(ReadFile(fileName));
            WriteFile(outputName, input);
        }

        private void WriteFile(string fileName, string input)
        {
            File.WriteAllText(fileName, input);
        }
    }
}