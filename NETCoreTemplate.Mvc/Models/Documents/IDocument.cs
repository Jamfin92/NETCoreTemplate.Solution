namespace NETCoreTemplate.Mvc.Models.Documents
{
    public interface IDocument
    {
        string Type { get; }
        string Content { get; set; }
        string Process();
    }
} 