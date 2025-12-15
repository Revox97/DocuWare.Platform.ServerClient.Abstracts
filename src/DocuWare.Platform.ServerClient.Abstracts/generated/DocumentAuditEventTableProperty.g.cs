using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventTableProperty(SDK.DocumentAuditEventTableProperty obj) : IDocumentAuditEventTableProperty
    {
        internal SDK.DocumentAuditEventTableProperty Obj { get; } = obj;

		public List<IDocumentAuditEventTablePropertyColumn> Column
		{
			get => Obj.Column.Select(x => new DocumentAuditEventTablePropertyColumn(x) as IDocumentAuditEventTablePropertyColumn).ToList();
			set => Obj.Column = value.Select(x => ((DocumentAuditEventTablePropertyColumn)x).Obj).ToList();
		}

		public List<List<string>> OldValues
		{
			get => Obj.OldValues;
			set => Obj.OldValues = value;
		}

		public List<List<string>> NewValues
		{
			get => Obj.NewValues;
			set => Obj.NewValues = value;
		}

		public string PropertyName
		{
			get => Obj.PropertyName;
			set => Obj.PropertyName = value;
		}
    }
}
