using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldKeywords(SDK.DocumentIndexFieldKeywords obj) : IDocumentIndexFieldKeywords
    {
        internal SDK.DocumentIndexFieldKeywords Obj { get; } = obj;

        public List<string> Keyword
        {
            get => Obj.Keyword;
            set => Obj.Keyword = value;
        }
    }
}
