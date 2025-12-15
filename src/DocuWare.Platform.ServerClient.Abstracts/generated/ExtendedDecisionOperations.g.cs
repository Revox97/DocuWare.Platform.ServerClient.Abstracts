using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedDecisionOperations(SDK.ExtendedDecisionOperations obj) : IExtendedDecisionOperations
    {
        internal SDK.ExtendedDecisionOperations Obj { get; } = obj;

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string ConfirmRelationLink => Obj.ConfirmRelationLink;

		public string StampBestPositionRelationLink => Obj.StampBestPositionRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
		public async string PostToConfirmRelationForString(IConfirmedData dataToSend) => Obj.PostToConfirmRelationForString(dataToSend);
        public async Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(IConfirmedData dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToConfirmRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(CancellationToken cancellationToken, IConfirmedData dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToConfirmRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public IDWPoint PostToStampBestPositionRelationForDWPoint(IStampPositionData dataToSend) => new DWPoint(Obj.PostToStampBestPositionRelationForDWPoint(dataToSend));

        public async Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(IStampPositionData dataToSend)
        {
            DocuWare.Platform.ServerClient.IDWPoint result = await Obj.PostToStampBestPositionRelationForDWPointAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDWPoint(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDWPoint>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(CancellationToken cancellationToken, IStampPositionData dataToSend)
        {
            DocuWare.Platform.ServerClient.IDWPoint result = await Obj.PostToStampBestPositionRelationForDWPointAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDWPoint(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDWPoint>(temp).ConfigureAwait(false);
        }

    }
}
