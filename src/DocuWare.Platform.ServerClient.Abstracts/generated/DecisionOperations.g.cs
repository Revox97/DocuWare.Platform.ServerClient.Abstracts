using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecisionOperations(SDK.DecisionOperations obj) : IDecisionOperations
    {
        internal SDK.DecisionOperations Obj { get; } = obj;

        public IBaseDecisionOperations BaseDecisionOperations
        {
            get => new BaseDecisionOperations(Obj.BaseDecisionOperations);
            set => Obj.BaseDecisionOperations = ((BaseDecisionOperations)value).Obj;
        }

        public IExtendedDecisionOperations ExtendedDecisionOperations
        {
            get => new ExtendedDecisionOperations(Obj.ExtendedDecisionOperations);
            set => Obj.ExtendedDecisionOperations = ((ExtendedDecisionOperations)value).Obj;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
