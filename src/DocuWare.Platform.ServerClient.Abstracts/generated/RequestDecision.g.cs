using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestDecision(SDK.RequestDecision obj) : IRequestDecision
    {
        internal SDK.RequestDecision Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IRequestDecision GetRequestDecisionFromSelfRelation() => new RequestDecision(Obj.GetRequestDecisionFromSelfRelation());

        public async Task<DeserializedHttpResponse<IRequestDecision>> GetRequestDecisionFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestDecision> result = await Obj.GetRequestDecisionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestDecision(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestDecision>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRequestDecision>> GetRequestDecisionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.RequestDecision> result = await Obj.GetRequestDecisionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new RequestDecision(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRequestDecision>(temp).ConfigureAwait(false);
        }

		public string PostToConfirmRelationForString(IRequestConfirmedData dataToSend) => Obj.PostToConfirmRelationForString(((RequestConfirmedData)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(IRequestConfirmedData dataToSend) => await Obj.PostToConfirmRelationForStringAsync(((RequestConfirmedData)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(CancellationToken cancellationToken, IRequestConfirmedData dataToSend) => await Obj.PostToConfirmRelationForStringAsync(cancellationToken, ((RequestConfirmedData)dataToSend).Obj);
    }
}
