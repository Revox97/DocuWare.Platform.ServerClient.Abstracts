using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedUserOperations(SDK.ExtendedUserOperations obj) : IExtendedUserOperations
    {
        internal SDK.ExtendedUserOperations Obj { get; } = obj;

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string ReadStatusRelationLink => Obj.ReadStatusRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
		public async string PutToReadStatusRelationForString(Stream dataToSend) => Obj.PutToReadStatusRelationForString(dataToSend);
        public async Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PutToReadStatusRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PutToReadStatusRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

    }
}
