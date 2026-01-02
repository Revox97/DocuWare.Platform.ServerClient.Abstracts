using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceDescriptionStatistics(SDK.ServiceDescriptionStatistics obj) : IServiceDescriptionStatistics
    {
        internal SDK.ServiceDescriptionStatistics Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string CfsRelationLink => Obj.CfsRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public async Stream PostToCfsRelationForStream(ICFSStatisticGeneral dataToSend) => Obj.PostToCfsRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToCfsRelationForStreamAsync(ICFSStatisticGeneral dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToCfsRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToCfsRelationForStreamAsync(CancellationToken cancellationToken, ICFSStatisticGeneral dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToCfsRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }
    }
}
