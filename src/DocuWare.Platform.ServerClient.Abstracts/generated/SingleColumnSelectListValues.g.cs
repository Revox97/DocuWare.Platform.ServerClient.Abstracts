using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SingleColumnSelectListValues(SDK.SingleColumnSelectListValues obj) : ISingleColumnSelectListValues
    {
        internal SDK.SingleColumnSelectListValues Obj { get; } = obj;

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

		public string NextRelationLink => Obj.NextRelationLink;

		public string PrevRelationLink => Obj.PrevRelationLink;

		public string SelfRelationLink => Obj.SelfRelationLink;

		public string FirstRelationLink => Obj.FirstRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromNextRelation() => new SingleColumnSelectListValues(Obj.GetSingleColumnSelectListValuesFromNextRelation());

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromNextRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISingleColumnSelectListValues result = await Obj.GetSingleColumnSelectListValuesFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISingleColumnSelectListValues result = await Obj.GetSingleColumnSelectListValuesFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromPrevRelation() => new SingleColumnSelectListValues(Obj.GetSingleColumnSelectListValuesFromPrevRelation());

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromPrevRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISingleColumnSelectListValues result = await Obj.GetSingleColumnSelectListValuesFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISingleColumnSelectListValues result = await Obj.GetSingleColumnSelectListValuesFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromSelfRelation() => new SingleColumnSelectListValues(Obj.GetSingleColumnSelectListValuesFromSelfRelation());

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISingleColumnSelectListValues result = await Obj.GetSingleColumnSelectListValuesFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISingleColumnSelectListValues result = await Obj.GetSingleColumnSelectListValuesFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public ISingleColumnSelectListValues GetSingleColumnSelectListValuesFromFirstRelation() => new SingleColumnSelectListValues(Obj.GetSingleColumnSelectListValuesFromFirstRelation());

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromFirstRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISingleColumnSelectListValues result = await Obj.GetSingleColumnSelectListValuesFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISingleColumnSelectListValues>> GetSingleColumnSelectListValuesFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISingleColumnSelectListValues result = await Obj.GetSingleColumnSelectListValuesFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISingleColumnSelectListValues(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISingleColumnSelectListValues>(temp).ConfigureAwait(false);
        }

    }
}
