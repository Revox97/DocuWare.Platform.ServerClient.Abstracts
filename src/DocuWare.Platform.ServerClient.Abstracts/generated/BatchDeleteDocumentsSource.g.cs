using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchDeleteDocumentsSource(SDK.BatchDeleteDocumentsSource obj) : IBatchDeleteDocumentsSource
    {
        internal SDK.BatchDeleteDocumentsSource Obj { get; } = obj;

        public List<string> Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
