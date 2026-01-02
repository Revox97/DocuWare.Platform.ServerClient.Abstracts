using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WordSearchResult(SDK.WordSearchResult obj) : IWordSearchResult
    {
        internal SDK.WordSearchResult Obj { get; } = obj;

        public string Search
        {
            get => Obj.Search;
            set => Obj.Search = value;
        }

        public List<IWordSearchResultPageHit> PageHits
        {
            get => Obj.PageHits.Select(x => new WordSearchResultPageHit(x) as IWordSearchResultPageHit).ToList();
            set => Obj.PageHits = value.Select(x => ((WordSearchResultPageHit)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string NextRelationLink => Obj.NextRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public WordSearchResult GetWordSearchResultFromNextRelation() => new WordSearchResult(Obj.GetWordSearchResultFromNextRelation());

        public async Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.GetWordSearchResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.GetWordSearchResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WordSearchResult>(temp).ConfigureAwait(false);
        }
    }
}
