using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventTablePropertyColumn(SDK.DocumentAuditEventTablePropertyColumn obj) : IDocumentAuditEventTablePropertyColumn
    {
        internal SDK.DocumentAuditEventTablePropertyColumn Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public DWFieldType Type
        {
            get => (DWFieldType)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.DWFieldType)value;
        }
    }
}
