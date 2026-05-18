using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFields(SDK.DocumentIndexFields obj) : IDocumentIndexFields
    {
        internal SDK.DocumentIndexFields Obj { get; } = obj;

        public List<IDocumentIndexField> Field
        {
            get => Obj.Field.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.Field = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
        }
    }
}
