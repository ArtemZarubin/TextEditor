using System.IO;

namespace TextEditor
{
    public class TxtDocumentLoader : IDocumentLoader
    {
        public string Load(string path)
        {
            return File.ReadAllText(path);
        }

        public string ProcessContent(string content)
        {
            return content;  // Вміст TXT-файлу не потребує обробки
        }
    }
}
