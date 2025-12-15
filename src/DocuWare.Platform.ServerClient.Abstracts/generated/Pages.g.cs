using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Pages(SDK.Pages obj) : IPages
    {
        internal SDK.Pages Obj { get; } = obj;

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

        public string NextBlockRelationLink => Obj.NextBlockRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IPages GetPagesFromNextBlockRelation() => new Pages(Obj.GetPagesFromNextBlockRelation());

        public async Task<DeserializedHttpResponse<IPages>> GetPagesFromNextBlockRelationAsync()
        {
            DocuWare.Platform.ServerClient.IPages result = await Obj.GetPagesFromNextBlockRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IPages(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPages>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IPages>> GetPagesFromNextBlockRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IPages result = await Obj.GetPagesFromNextBlockRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IPages(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPages>(temp).ConfigureAwait(false);
        }
    }
}
