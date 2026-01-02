using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TypedSelectListResult(SDK.TypedSelectListResult obj) : ITypedSelectListResult
    {
        internal SDK.TypedSelectListResult Obj { get; } = obj;

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

        public string NextRelationLink => Obj.NextRelationLink;

        public string PrevRelationLink => Obj.PrevRelationLink;

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string FirstRelationLink => Obj.FirstRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public TypedSelectListResult GetTypedSelectListResultFromNextRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromNextRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public TypedSelectListResult GetTypedSelectListResultFromPrevRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public TypedSelectListResult GetTypedSelectListResultFromSelfRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public TypedSelectListResult GetTypedSelectListResultFromFirstRelation() => new TypedSelectListResult(Obj.GetTypedSelectListResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ITypedSelectListResult>> GetTypedSelectListResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.TypedSelectListResult> result = await Obj.GetTypedSelectListResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new TypedSelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<TypedSelectListResult>(temp).ConfigureAwait(false);
        }
    }
}
