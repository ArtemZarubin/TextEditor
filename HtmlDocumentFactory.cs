namespace TextEditor
{
    public class HtmlDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument(string text)
        {
            return new HtmlDocument(text);
        }
    }
}
