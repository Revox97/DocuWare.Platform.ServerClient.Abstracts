using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TimeoutHistoryStep(SDK.TimeoutHistoryStep obj) : ITimeoutHistoryStep
    {
        internal SDK.TimeoutHistoryStep Obj { get; } = obj;

        public string OutputName
        {
            get => Obj.OutputName;
            set => Obj.OutputName = value;
        }
    }
}
