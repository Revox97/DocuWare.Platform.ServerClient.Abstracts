using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
