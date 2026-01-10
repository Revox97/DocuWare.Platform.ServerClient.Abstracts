using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SingleColumnSelectListValues(DocuWare.Platform.ServerClient.SingleColumnSelectListValues obj) : ISingleColumnSelectListValues
    {
        internal DocuWare.Platform.ServerClient.SingleColumnSelectListValues Obj { get; } = obj;

        public List<string> Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public List<IDocumentIndexFieldValue> TypedValue
        {
            get => Obj.TypedValue.Select(x => new DocumentIndexFieldValue(x) as IDocumentIndexFieldValue).ToList();
            set => Obj.TypedValue = value.Select(x => ((DocumentIndexFieldValue)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromNextRelation() => new SingleColumnSelectListValues(Obj.GetSingleColumnSelectListValuesFromNextRelation());

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SingleColumnSelectListValues> result = await Obj.GetSingleColumnSelectListValuesFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SingleColumnSelectListValues> result = await Obj.GetSingleColumnSelectListValuesFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromPrevRelation() => new SingleColumnSelectListValues(Obj.GetSingleColumnSelectListValuesFromPrevRelation());

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SingleColumnSelectListValues> result = await Obj.GetSingleColumnSelectListValuesFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SingleColumnSelectListValues> result = await Obj.GetSingleColumnSelectListValuesFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromSelfRelation() => new SingleColumnSelectListValues(Obj.GetSingleColumnSelectListValuesFromSelfRelation());

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SingleColumnSelectListValues> result = await Obj.GetSingleColumnSelectListValuesFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SingleColumnSelectListValues> result = await Obj.GetSingleColumnSelectListValuesFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromFirstRelation() => new SingleColumnSelectListValues(Obj.GetSingleColumnSelectListValuesFromFirstRelation());

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SingleColumnSelectListValues> result = await Obj.GetSingleColumnSelectListValuesFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SingleColumnSelectListValues> result = await Obj.GetSingleColumnSelectListValuesFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }
    }
}
