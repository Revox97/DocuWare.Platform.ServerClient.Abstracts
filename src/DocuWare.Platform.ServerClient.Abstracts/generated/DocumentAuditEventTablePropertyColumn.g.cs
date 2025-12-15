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

		public DWFieldType Type
		{
			get => new WFieldType(Obj.Type);
			set => Obj.Type = ((WFieldType)value).Obj;
		}
    }
}
