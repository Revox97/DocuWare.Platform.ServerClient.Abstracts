using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OutOfOfficeHistoryStep(SDK.OutOfOfficeHistoryStep obj) : IOutOfOfficeHistoryStep
    {
        internal SDK.OutOfOfficeHistoryStep Obj { get; } = obj;

        public string NewUser
        {
            get => Obj.NewUser;
            set => Obj.NewUser = value;
        }

        public string OutOfOfficeUser
        {
            get => Obj.OutOfOfficeUser;
            set => Obj.OutOfOfficeUser = value;
        }
    }
}
