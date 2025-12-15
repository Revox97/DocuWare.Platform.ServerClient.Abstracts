using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AdhocRenderingFile(SDK.AdhocRenderingFile obj) : IAdhocRenderingFile
    {
        internal SDK.AdhocRenderingFile Obj { get; } = obj;

        public List<IKeyValuePair> MetaData
        {
            get => Obj.MetaData.Select(x => new KeyValuePair(x) as IKeyValuePair).ToList();
            set => Obj.MetaData = value.Select(x => ((KeyValuePair)x).Obj).ToList();
        }

        public IPages Pages
        {
            get => new Pages(Obj.Pages);
            set => Obj.Pages = ((Pages)value).Obj;
        }

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

        public int PageCount
        {
            get => Obj.PageCount;
            set => Obj.PageCount = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string RenderingRelationLink => Obj.RenderingRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IAdhocRenderingFile GetAdhocRenderingFileFromSelfRelation() => new AdhocRenderingFile(Obj.GetAdhocRenderingFileFromSelfRelation());

        public async Task<DeserializedHttpResponse<IAdhocRenderingFile>> GetAdhocRenderingFileFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IAdhocRenderingFile result = await Obj.GetAdhocRenderingFileFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IAdhocRenderingFile(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAdhocRenderingFile>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAdhocRenderingFile>> GetAdhocRenderingFileFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IAdhocRenderingFile result = await Obj.GetAdhocRenderingFileFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IAdhocRenderingFile(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAdhocRenderingFile>(temp).ConfigureAwait(false);
        }

		public async Stream PostToRenderingRelationForStream(IAdhocRenderingQuery dataToSend) => Obj.PostToRenderingRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToRenderingRelationForStreamAsync(IAdhocRenderingQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToRenderingRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToRenderingRelationForStreamAsync(CancellationToken cancellationToken, IAdhocRenderingQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToRenderingRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }
    }
}
