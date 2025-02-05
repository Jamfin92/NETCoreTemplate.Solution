namespace NETCoreTemplate.Mvc.Models.Documents
{
    public class WordDocument : IDocument
    {
        public string Type => "Word";
        public string Content { get; set; } = string.Empty;

        public string Process()
        {
            return $"Processing Word Document: {Content}";
        }
    }
} 