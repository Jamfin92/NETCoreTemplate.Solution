using NETCoreTemplate.Mvc.Models.Documents;

namespace NETCoreTemplate.Mvc.Factories
{
    public class DocumentFactory : IDocumentFactory
    {
        public IDocument CreateDocument(string type)
        {
            return type.ToLower() switch
            {
                "pdf" => new PdfDocument(),
                "word" => new WordDocument(),
                _ => throw new ArgumentException("Invalid document type", nameof(type))
            };
        }
    }
} 