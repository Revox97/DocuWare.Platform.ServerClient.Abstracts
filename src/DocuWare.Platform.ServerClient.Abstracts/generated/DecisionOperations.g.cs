using SDK = DocuWare.Platform.ServerClient;

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

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
