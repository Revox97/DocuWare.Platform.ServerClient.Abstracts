using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldTable(SDK.DocumentIndexFieldTable obj) : IDocumentIndexFieldTable
    {
        internal SDK.DocumentIndexFieldTable Obj { get; } = obj;

        public List<IDocumentIndexFieldTableRow> Row
        {
            get => Obj.Row.Select(x => new DocumentIndexFieldTableRow(x) as IDocumentIndexFieldTableRow).ToList();
            set => Obj.Row = value.Select(x => ((DocumentIndexFieldTableRow)x).Obj).ToList();
        }
    }
}
