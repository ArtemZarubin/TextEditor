namespace TextEditor
{
    public class TxtDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument(string text)
        {
            return new TxtDocument(text);
        }
    }
}
