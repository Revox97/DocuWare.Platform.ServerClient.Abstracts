using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BaseDecisionOperations(SDK.BaseDecisionOperations obj) : IBaseDecisionOperations
    {
        internal SDK.BaseDecisionOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDecision GetDecisionFromSelfRelation() => new Decision(Obj.GetDecisionFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDecision result = await Obj.GetDecisionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDecision(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDecision>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDecision result = await Obj.GetDecisionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDecision(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDecision>(temp).ConfigureAwait(false);
        }
    }
}
