using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ReadStatus(SDK.ReadStatus obj) : IReadStatus
    {
        internal SDK.ReadStatus Obj { get; } = obj;

        public bool IsRead
        {
            get => Obj.IsRead;
            set => Obj.IsRead = value;
        }
    }
}
