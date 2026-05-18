using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventProperty(SDK.DocumentAuditEventProperty obj) : IDocumentAuditEventProperty
    {
        internal SDK.DocumentAuditEventProperty Obj { get; } = obj;

        public string PropertyName
        {
            get => Obj.PropertyName;
            set => Obj.PropertyName = value;
        }

        public string OldValue
        {
            get => Obj.OldValue;
            set => Obj.OldValue = value;
        }

        public string NewValue
        {
            get => Obj.NewValue;
            set => Obj.NewValue = value;
        }

        public DWFieldType DWFieldType
        {
            get => (DWFieldType)Obj.DWFieldType;
            set => Obj.DWFieldType = (DocuWare.Platform.ServerClient.DWFieldType)value;
        }
    }
}
