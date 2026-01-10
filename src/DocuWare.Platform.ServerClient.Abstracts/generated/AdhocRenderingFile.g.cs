using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AdhocRenderingFile(DocuWare.Platform.ServerClient.AdhocRenderingFile obj) : IAdhocRenderingFile
    {
        internal DocuWare.Platform.ServerClient.AdhocRenderingFile Obj { get; } = obj;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IAdhocRenderingFile GetAdhocRenderingFileFromSelfRelation() => new AdhocRenderingFile(Obj.GetAdhocRenderingFileFromSelfRelation());

        public async Task<DeserializedHttpResponse<IAdhocRenderingFile>> GetAdhocRenderingFileFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFile> result = await Obj.GetAdhocRenderingFileFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFile(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAdhocRenderingFile>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAdhocRenderingFile>> GetAdhocRenderingFileFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.AdhocRenderingFile> result = await Obj.GetAdhocRenderingFileFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new AdhocRenderingFile(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAdhocRenderingFile>(temp).ConfigureAwait(false);
        }

		public Stream PostToRenderingRelationForStream(IAdhocRenderingQuery dataToSend) => Obj.PostToRenderingRelationForStream(((AdhocRenderingQuery)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToRenderingRelationForStreamAsync(IAdhocRenderingQuery dataToSend) => await Obj.PostToRenderingRelationForStreamAsync(((AdhocRenderingQuery)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToRenderingRelationForStreamAsync(CancellationToken cancellationToken, IAdhocRenderingQuery dataToSend) => await Obj.PostToRenderingRelationForStreamAsync(cancellationToken, ((AdhocRenderingQuery)dataToSend).Obj);
    }
}
