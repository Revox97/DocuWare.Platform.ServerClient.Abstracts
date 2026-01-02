using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventTablePropertyColumn(DocuWare.Platform.ServerClient.DocumentAuditEventTablePropertyColumn obj) : IDocumentAuditEventTablePropertyColumn
    {
        internal DocuWare.Platform.ServerClient.DocumentAuditEventTablePropertyColumn Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public DocuWare.Platform.ServerClient.DWFieldType Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
