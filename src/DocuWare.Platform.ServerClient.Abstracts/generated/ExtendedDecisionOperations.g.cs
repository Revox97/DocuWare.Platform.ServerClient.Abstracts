using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedDecisionOperations(DocuWare.Platform.ServerClient.ExtendedDecisionOperations obj) : IExtendedDecisionOperations
    {
        internal DocuWare.Platform.ServerClient.ExtendedDecisionOperations Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public string PostToConfirmRelationForString(IConfirmedData dataToSend) => Obj.PostToConfirmRelationForString(((ConfirmedData)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(IConfirmedData dataToSend) => await Obj.PostToConfirmRelationForStringAsync(((ConfirmedData)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(CancellationToken cancellationToken, IConfirmedData dataToSend) => await Obj.PostToConfirmRelationForStringAsync(cancellationToken, ((ConfirmedData)dataToSend).Obj);

        public IDWPoint PostToStampBestPositionRelationForDWPoint(IStampPositionData dataToSend) => new DWPoint(Obj.PostToStampBestPositionRelationForDWPoint(((StampPositionData)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(IStampPositionData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DWPoint> result = await Obj.PostToStampBestPositionRelationForDWPointAsync(((StampPositionData)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DWPoint(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDWPoint>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(CancellationToken cancellationToken, IStampPositionData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DWPoint> result = await Obj.PostToStampBestPositionRelationForDWPointAsync(cancellationToken, ((StampPositionData)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DWPoint(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDWPoint>(temp).ConfigureAwait(false);
        }
    }
}
