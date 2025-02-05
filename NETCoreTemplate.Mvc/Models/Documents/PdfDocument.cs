namespace NETCoreTemplate.Mvc.Models.Documents
{
    public class PdfDocument : IDocument
    {
        public string Type => "PDF";
        public string Content { get; set; } = string.Empty;

        public string Process()
        {
            return $"Processing PDF Document: {Content}";
        }
    }
} 