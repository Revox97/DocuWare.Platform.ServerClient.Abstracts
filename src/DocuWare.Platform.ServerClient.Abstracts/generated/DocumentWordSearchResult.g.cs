using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentWordSearchResult(SDK.DocumentWordSearchResult obj) : IDocumentWordSearchResult
    {
        internal SDK.DocumentWordSearchResult Obj { get; } = obj;

        public bool FoundInAnnotations
        {
            get => Obj.FoundInAnnotations;
            set => Obj.FoundInAnnotations = value;
        }

        public string Search
        {
            get => Obj.Search;
            set => Obj.Search = value;
        }

        public List<IDocumentWordSearchResultSectionHits> SectionHits
        {
            get => Obj.SectionHits.Select(x => new DocumentWordSearchResultSectionHits(x) as IDocumentWordSearchResultSectionHits).ToList();
            set => Obj.SectionHits = value.Select(x => ((DocumentWordSearchResultSectionHits)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string NextRelationLink => Obj.NextRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public DocumentWordSearchResult GetDocumentWordSearchResultFromNextRelation() => new DocumentWordSearchResult(Obj.GetDocumentWordSearchResultFromNextRelation());

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.GetDocumentWordSearchResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.GetDocumentWordSearchResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentWordSearchResult>(temp).ConfigureAwait(false);
        }
    }
}
