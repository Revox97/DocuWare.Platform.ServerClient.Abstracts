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

        public Decision GetDecisionFromSelfRelation() => new Decision(Obj.GetDecisionFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Decision> result = await Obj.GetDecisionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Decision(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Decision>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Decision> result = await Obj.GetDecisionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Decision(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Decision>(temp).ConfigureAwait(false);
        }
    }
}
