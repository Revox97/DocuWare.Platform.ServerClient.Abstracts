using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CreatedInfo(SDK.CreatedInfo obj) : ICreatedInfo
    {
        internal SDK.CreatedInfo Obj { get; } = obj;

        public string User
        {
            get => Obj.User;
            set => Obj.User = value;
        }

        public DateTime Time
        {
            get => Obj.Time;
            set => Obj.Time = value;
        }
    }
}
