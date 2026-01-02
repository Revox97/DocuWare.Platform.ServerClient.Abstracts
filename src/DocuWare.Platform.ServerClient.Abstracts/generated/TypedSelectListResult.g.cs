using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TypedSelectListResult(DocuWare.Platform.ServerClient.TypedSelectListResult obj) : ITypedSelectListResult
    {
        internal DocuWare.Platform.ServerClient.TypedSelectListResult Obj { get; } = obj;

        public List<IDocumentIndexFieldValue> Value
        {
            get => Obj.Value.Select(x => new DocumentIndexFieldValue(x) as IDocumentIndexFieldValue).ToList();
            set => Obj.Value = value.Select(x => ((DocumentIndexFieldValue)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public ITypedSelectListResult GetTypedSelectListResultFromNextRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromNextRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public ITypedSelectListResult GetTypedSelectListResultFromPrevRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public ITypedSelectListResult GetTypedSelectListResultFromSelfRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public ITypedSelectListResult GetTypedSelectListResultFromFirstRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ITypedSelectListResult>(temp).ConfigureAwait(false);
        }
    }
}
