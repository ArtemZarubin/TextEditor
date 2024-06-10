using System.Collections.Generic;
using System.IO;
using System.Linq;
using HtmlAgilityPack;

namespace TextEditor
{
    public class HtmlDocumentLoader : IDocumentLoader
    {
        public string Load(string path)
        {
            return File.ReadAllText(path);
        }

        public string ProcessContent(string content)
        {
            var doc = new HtmlAgilityPack.HtmlDocument(); // Явно указываем пространство имен HtmlAgilityPack
            doc.LoadHtml(content);

            var bodyNode = doc.DocumentNode.SelectSingleNode("//body");
            if (bodyNode == null)
            {
                return "";
            }

            var paragraphs = new List<string>();
            foreach (var node in bodyNode.Descendants())
            {
                if (node.Name == "p" || node.Name == "br")
                {
                    paragraphs.Add(node.InnerText.Trim());
                }
            }

            return string.Join("\n\n", paragraphs);
        }
    }
}
