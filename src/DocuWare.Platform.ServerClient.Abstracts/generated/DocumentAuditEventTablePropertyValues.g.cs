using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventTablePropertyValues(SDK.DocumentAuditEventTablePropertyValues obj) : IDocumentAuditEventTablePropertyValues
    {
        internal SDK.DocumentAuditEventTablePropertyValues Obj { get; } = obj;

        public List<List<string>> Row
        {
            get => Obj.Row;
            set => Obj.Row = value;
        }
    }
}
