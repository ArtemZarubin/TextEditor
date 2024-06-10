using System;
using System.IO;

namespace TextEditor
{
    public class HtmlDocument : Document
    {
        public HtmlDocument(string text = "") : base(text)
        {
        }




        public override void Save(string path)
        {
            string htmlText = "<!DOCTYPE html><html lang=\"ru\"><head><meta charset=\"UTF-8\"><title>HTML Document</title></head><body>";
            string[] paragraphs = text_.Split(new string[] { "\n\n" }, StringSplitOptions.None);
            foreach (string paragraph in paragraphs)
            {
                htmlText += $"<p>{paragraph}</p>";
            }
            htmlText += "</body></html>";
            File.WriteAllText(path, htmlText);
        }

        internal void LoadHtml(string content)
        {
            throw new NotImplementedException();
        }
    }
}
