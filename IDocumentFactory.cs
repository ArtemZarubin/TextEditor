namespace TextEditor
{
    public interface IDocumentFactory
    {
        IDocumentLoader CreateDocumentLoader(string extension);
    }
}