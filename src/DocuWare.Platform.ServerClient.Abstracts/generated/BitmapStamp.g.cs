using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BitmapStamp(SDK.BitmapStamp obj) : IBitmapStamp
    {
        internal SDK.BitmapStamp Obj { get; } = obj;

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string ContentRelationLink => Obj.ContentRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
		public async Stream GetStreamFromContentRelation() => Obj.GetStreamFromContentRelation();
        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync()
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromContentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromContentRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

    }
}
