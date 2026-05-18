using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
