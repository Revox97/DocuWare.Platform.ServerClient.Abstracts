using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListResult(SDK.SelectListResult obj) : ISelectListResult
    {
        internal SDK.SelectListResult Obj { get; } = obj;

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
        public ISelectListResult GetSelectListResultFromNextRelation() => new SelectListResult(Obj.GetSelectListResultFromNextRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromNextRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult GetSelectListResultFromPrevRelation() => new SelectListResult(Obj.GetSelectListResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromPrevRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult GetSelectListResultFromSelfRelation() => new SelectListResult(Obj.GetSelectListResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public ISelectListResult GetSelectListResultFromFirstRelation() => new SelectListResult(Obj.GetSelectListResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromFirstRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISelectListResult result = await Obj.GetSelectListResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISelectListResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISelectListResult>(temp).ConfigureAwait(false);
        }

    }
}
