using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Pages(DocuWare.Platform.ServerClient.Pages obj) : IPages
    {
        internal DocuWare.Platform.ServerClient.Pages Obj { get; } = obj;

        public List<IPage> Page
        {
            get => Obj.Page.Select(x => new Page(x) as IPage).ToList();
            set => Obj.Page = value.Select(x => ((Page)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IPages GetPagesFromNextBlockRelation() => new Pages(Obj.GetPagesFromNextBlockRelation());

        public async Task<DeserializedHttpResponse<IPages>> GetPagesFromNextBlockRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Pages> result = await Obj.GetPagesFromNextBlockRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Pages(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPages>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IPages>> GetPagesFromNextBlockRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Pages> result = await Obj.GetPagesFromNextBlockRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Pages(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPages>(temp).ConfigureAwait(false);
        }
    }
}
