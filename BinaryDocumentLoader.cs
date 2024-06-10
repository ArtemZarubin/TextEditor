using System.IO;
using System.Text;

namespace TextEditor
{
    public class BinaryDocumentLoader : IDocumentLoader
    {
        public string Load(string path)
        {
            byte[] binaryData = File.ReadAllBytes(path);
            return Encoding.UTF8.GetString(binaryData);
        }

        public string ProcessContent(string content)
        {
            return content; // Вміст вже у текстовому форматі
        }
    }
}
