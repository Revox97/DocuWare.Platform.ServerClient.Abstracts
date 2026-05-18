using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Behaviors(SDK.Behaviors obj) : IBehaviors
    {
        internal SDK.Behaviors Obj { get; } = obj;

        public List<IBehavior> Behavior
        {
            get => Obj.Behavior.Select(x => new Behavior(x) as IBehavior).ToList();
            set => Obj.Behavior = value.Select(x => ((Behavior)x).Obj).ToList();
        }
    }
}
