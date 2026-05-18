using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestEndHistoryStep(SDK.RequestEndHistoryStep obj) : IRequestEndHistoryStep
    {
        internal SDK.RequestEndHistoryStep Obj { get; } = obj;

        public string UserName
        {
            get => Obj.UserName;
            set => Obj.UserName = value;
        }

        public bool DocumentDeleted
        {
            get => Obj.DocumentDeleted;
            set => Obj.DocumentDeleted = value;
        }
    }
}
