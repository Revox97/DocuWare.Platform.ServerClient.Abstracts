using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiColSelectListValuesResult(SDK.MultiColSelectListValuesResult obj) : IMultiColSelectListValuesResult
    {
        internal SDK.MultiColSelectListValuesResult Obj { get; } = obj;

		public List<IMultiColSelectListColumn> Columns
		{
			get => Obj.Columns.Select(x => new MultiColSelectListColumn(x) as IMultiColSelectListColumn).ToList();
			set => Obj.Columns = value.Select(x => ((MultiColSelectListColumn)x).Obj).ToList();
		}

		public List<IMultiColSelectListRow> Rows
		{
			get => Obj.Rows.Select(x => new MultiColSelectListRow(x) as IMultiColSelectListRow).ToList();
			set => Obj.Rows = value.Select(x => ((MultiColSelectListRow)x).Obj).ToList();
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
        public IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromNextRelation() => new MultiColSelectListValuesResult(Obj.GetMultiColSelectListValuesResultFromNextRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromNextRelationAsync()
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromPrevRelation() => new MultiColSelectListValuesResult(Obj.GetMultiColSelectListValuesResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromPrevRelationAsync()
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromSelfRelation() => new MultiColSelectListValuesResult(Obj.GetMultiColSelectListValuesResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public IMultiColSelectListValuesResult GetMultiColSelectListValuesResultFromFirstRelation() => new MultiColSelectListValuesResult(Obj.GetMultiColSelectListValuesResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromFirstRelationAsync()
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IMultiColSelectListValuesResult>> GetMultiColSelectListValuesResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IMultiColSelectListValuesResult result = await Obj.GetMultiColSelectListValuesResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IMultiColSelectListValuesResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IMultiColSelectListValuesResult>(temp).ConfigureAwait(false);
        }

    }
}
