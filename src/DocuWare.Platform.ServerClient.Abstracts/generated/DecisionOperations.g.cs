using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecisionOperations(DocuWare.Platform.ServerClient.DecisionOperations obj) : IDecisionOperations
    {
        internal DocuWare.Platform.ServerClient.DecisionOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
