using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldTableRow(DocuWare.Platform.ServerClient.DocumentIndexFieldTableRow obj) : IDocumentIndexFieldTableRow
    {
        internal DocuWare.Platform.ServerClient.DocumentIndexFieldTableRow Obj { get; } = obj;

        public List<IDocumentIndexField> ColumnValue
        {
            get => Obj.ColumnValue.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.ColumnValue = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
        }
    }
}
