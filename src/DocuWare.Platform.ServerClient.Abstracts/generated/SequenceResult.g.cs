using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SequenceResult(SDK.SequenceResult obj) : ISequenceResult
    {
        internal SDK.SequenceResult Obj { get; } = obj;

        public string NextElement
        {
            get => Obj.NextElement;
            set => Obj.NextElement = value;
        }
    }
}
