using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateDocumentsSource(SDK.BatchUpdateDocumentsSource obj) : IBatchUpdateDocumentsSource
    {
        internal SDK.BatchUpdateDocumentsSource Obj { get; } = obj;

        public List<int> Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
