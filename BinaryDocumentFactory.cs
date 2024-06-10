namespace TextEditor
{
    public class BinaryDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument(string text)
        {
            return new BinaryDocument(text);
        }
    }
}
