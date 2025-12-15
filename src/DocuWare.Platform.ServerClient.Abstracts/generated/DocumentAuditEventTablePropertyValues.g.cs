using SDK = DocuWare.Platform.ServerClient;

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
