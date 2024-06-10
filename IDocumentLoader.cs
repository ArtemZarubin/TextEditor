namespace TextEditor
{
    public interface IDocumentLoader
    {
        string Load(string path);
        string ProcessContent(string content);
    }
}