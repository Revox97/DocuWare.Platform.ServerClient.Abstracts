using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueStatistics(SDK.FieldValueStatistics obj) : IFieldValueStatistics
    {
        internal SDK.FieldValueStatistics Obj { get; } = obj;

        public IDocumentIndexFieldValue Value
        {
            get => new DocumentIndexFieldValue(Obj.Value);
            set => Obj.Value = ((DocumentIndexFieldValue)value).Obj;
        }

        public long Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }
    }
}
