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

        public DWFieldType Type
        {
            get => (DWFieldType)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.DWFieldType)value;
        }
    }
}
