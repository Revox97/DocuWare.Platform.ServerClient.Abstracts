using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SequenceRequest(SDK.SequenceRequest obj) : ISequenceRequest
    {
        internal SDK.SequenceRequest Obj { get; } = obj;

        public string SequenceId
        {
            get => Obj.SequenceId;
            set => Obj.SequenceId = value;
        }
    }
}
