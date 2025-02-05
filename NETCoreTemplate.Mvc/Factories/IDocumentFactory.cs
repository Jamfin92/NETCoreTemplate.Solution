using NETCoreTemplate.Mvc.Models.Documents;

namespace NETCoreTemplate.Mvc.Factories
{
    public interface IDocumentFactory
    {
        IDocument CreateDocument(string type);
    }
} 