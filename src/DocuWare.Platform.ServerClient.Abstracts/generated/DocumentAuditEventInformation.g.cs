using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventInformation(DocuWare.Platform.ServerClient.DocumentAuditEventInformation obj) : IDocumentAuditEventInformation
    {
        internal DocuWare.Platform.ServerClient.DocumentAuditEventInformation Obj { get; } = obj;

        public List<IDocumentAuditEventProperty> DocumentAuditEventProperties
        {
            get => Obj.DocumentAuditEventProperties.Select(x => new DocumentAuditEventProperty(x) as IDocumentAuditEventProperty).ToList();
            set => Obj.DocumentAuditEventProperties = value.Select(x => ((DocumentAuditEventProperty)x).Obj).ToList();
        }

        public List<IDocumentAuditEventTableProperty> DocumentAuditEventTableProperties
        {
            get => Obj.DocumentAuditEventTableProperties.Select(x => new DocumentAuditEventTableProperty(x) as IDocumentAuditEventTableProperty).ToList();
            set => Obj.DocumentAuditEventTableProperties = value.Select(x => ((DocumentAuditEventTableProperty)x).Obj).ToList();
        }
    }
}
