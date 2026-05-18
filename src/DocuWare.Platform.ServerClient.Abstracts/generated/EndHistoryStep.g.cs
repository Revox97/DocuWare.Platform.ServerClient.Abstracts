using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EndHistoryStep(SDK.EndHistoryStep obj) : IEndHistoryStep
    {
        internal SDK.EndHistoryStep Obj { get; } = obj;

        public string UserName
        {
            get => Obj.UserName;
            set => Obj.UserName = value;
        }

        public string DocumentUserVersion
        {
            get => Obj.DocumentUserVersion;
            set => Obj.DocumentUserVersion = value;
        }

        public string EndState
        {
            get => Obj.EndState;
            set => Obj.EndState = value;
        }

        public bool DocumentDeleted
        {
            get => Obj.DocumentDeleted;
            set => Obj.DocumentDeleted = value;
        }
    }
}
