using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Decisions(SDK.Decisions obj) : IDecisions
    {
        internal SDK.Decisions Obj { get; } = obj;

        public List<IDecision> Decision
        {
            get => Obj.Decision.Select(x => new Decision(x) as IDecision).ToList();
            set => Obj.Decision = value.Select(x => ((Decision)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
