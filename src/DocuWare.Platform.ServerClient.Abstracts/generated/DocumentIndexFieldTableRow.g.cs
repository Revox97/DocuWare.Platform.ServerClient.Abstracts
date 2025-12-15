using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldTableRow(SDK.DocumentIndexFieldTableRow obj) : IDocumentIndexFieldTableRow
    {
        internal SDK.DocumentIndexFieldTableRow Obj { get; } = obj;

		public List<IDocumentIndexField> ColumnValue
		{
			get => Obj.ColumnValue.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
			set => Obj.ColumnValue = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
		}
    }
}
