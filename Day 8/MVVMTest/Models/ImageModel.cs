using System.Drawing;

namespace MVVMTest.Models
{
    public class ImageModel
    {
        public ImageModel(string filename, string name)
        {
            Source = filename;
            Name = name;
        }

        public string Name { get; set; }
        public string Source { get; set; }
    }
}