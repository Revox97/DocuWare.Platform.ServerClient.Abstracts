using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestStartHistoryStep(SDK.RequestStartHistoryStep obj) : IRequestStartHistoryStep
    {
        internal SDK.RequestStartHistoryStep Obj { get; } = obj;

        public string RequestText
        {
            get => Obj.RequestText;
            set => Obj.RequestText = value;
        }

        public string UserName
        {
            get => Obj.UserName;
            set => Obj.UserName = value;
        }

        public string Title
        {
            get => Obj.Title;
            set => Obj.Title = value;
        }
    }
}
