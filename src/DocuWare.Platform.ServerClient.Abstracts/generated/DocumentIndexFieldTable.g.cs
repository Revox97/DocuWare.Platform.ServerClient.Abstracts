using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldTable(DocuWare.Platform.ServerClient.DocumentIndexFieldTable obj) : IDocumentIndexFieldTable
    {
        internal DocuWare.Platform.ServerClient.DocumentIndexFieldTable Obj { get; } = obj;

        public List<IDocumentIndexFieldTableRow> Row
        {
            get => Obj.Row.Select(x => new DocumentIndexFieldTableRow(x) as IDocumentIndexFieldTableRow).ToList();
            set => Obj.Row = value.Select(x => ((DocumentIndexFieldTableRow)x).Obj).ToList();
        }
    }
}
