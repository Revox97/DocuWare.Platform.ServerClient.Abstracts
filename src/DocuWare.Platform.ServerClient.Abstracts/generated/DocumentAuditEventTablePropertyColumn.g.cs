using SDK = DocuWare.Platform.ServerClient;

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

        public DocuWare.Platform.ServerClient.DWFieldType Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
