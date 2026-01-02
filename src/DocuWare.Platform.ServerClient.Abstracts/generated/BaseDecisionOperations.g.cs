using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BaseDecisionOperations(DocuWare.Platform.ServerClient.BaseDecisionOperations obj) : IBaseDecisionOperations
    {
        internal DocuWare.Platform.ServerClient.BaseDecisionOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDecision GetDecisionFromSelfRelation() => new Decision(Obj.GetDecisionFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Decision> result = await Obj.GetDecisionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Decision(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDecision>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Decision> result = await Obj.GetDecisionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Decision(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDecision>(temp).ConfigureAwait(false);
        }
    }
}
