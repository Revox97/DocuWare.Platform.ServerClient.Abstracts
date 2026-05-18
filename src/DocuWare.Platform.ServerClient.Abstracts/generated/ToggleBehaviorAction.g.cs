using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ToggleBehaviorAction(SDK.ToggleBehaviorAction obj) : IToggleBehaviorAction
    {
        internal SDK.ToggleBehaviorAction Obj { get; } = obj;

        public bool Enabled
        {
            get => Obj.Enabled;
            set => Obj.Enabled = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
