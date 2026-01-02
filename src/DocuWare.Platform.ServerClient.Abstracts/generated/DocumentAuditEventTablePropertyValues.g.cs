using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventTablePropertyValues(DocuWare.Platform.ServerClient.DocumentAuditEventTablePropertyValues obj) : IDocumentAuditEventTablePropertyValues
    {
        internal DocuWare.Platform.ServerClient.DocumentAuditEventTablePropertyValues Obj { get; } = obj;

        public List<List<string>> Row
        {
            get => Obj.Row;
            set => Obj.Row = value;
        }
    }
}
