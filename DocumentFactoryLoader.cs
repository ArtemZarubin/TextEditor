using System;

namespace TextEditor
{
    public class DocumentFactoryLoader : IDocumentFactory
    {
        public IDocumentLoader CreateDocumentLoader(string extension)
        {
            switch (extension.ToLower())
            {
                case ".html":
                    return new HtmlDocumentLoader();
                case ".txt":
                    return new TxtDocumentLoader();
                case ".bin":
                    return new BinaryDocumentLoader();
                default:
                    throw new NotSupportedException($"Розширення файлу '{extension}' не підтримується.");
            }
        }
    }
}
