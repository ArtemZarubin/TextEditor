using System.IO;
using System.Text;

namespace TextEditor
{
    public class BinaryDocument : Document
    {
        public BinaryDocument(string text) : base(text)
        {
            // ...
        }

        public override void Save(string path)
        {
            byte[] binaryData = Encoding.UTF8.GetBytes(text_);
            File.WriteAllBytes(path, binaryData);
        }
    }
}