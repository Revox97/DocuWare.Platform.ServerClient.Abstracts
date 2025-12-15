using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentsQueryResult(SDK.DocumentsQueryResult obj) : IDocumentsQueryResult
    {
        internal SDK.DocumentsQueryResult Obj { get; } = obj;

		public ICountPlusValue Count
		{
			get => new CountPlusValue(Obj.Count);
			set => Obj.Count = ((CountPlusValue)value).Obj;
		}

		public List<IDocument> Items
		{
			get => Obj.Items.Select(x => new Document(x) as IDocument).ToList();
			set => Obj.Items = value.Select(x => ((Document)x).Obj).ToList();
		}

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string Title
		{
			get => Obj.Title;
			set => Obj.Title = value;
		}

		public string OrganizationGuid
		{
			get => Obj.OrganizationGuid;
			set => Obj.OrganizationGuid = value;
		}

		public string FileCabinetId
		{
			get => Obj.FileCabinetId;
			set => Obj.FileCabinetId = value;
		}

		public DateTime TimeStamp
		{
			get => Obj.TimeStamp;
			set => Obj.TimeStamp = value;
		}

		public string NextRelationLink => Obj.NextRelationLink;

		public string PrevRelationLink => Obj.PrevRelationLink;

		public string SelfRelationLink => Obj.SelfRelationLink;

		public string FirstRelationLink => Obj.FirstRelationLink;

		public string FeedRelationLink => Obj.FeedRelationLink;

		public string DownloadRelationLink => Obj.DownloadRelationLink;

		public string BatchUpdateRelationLink => Obj.BatchUpdateRelationLink;

		public string CreateUserDefinedSearchRelationLink => Obj.CreateUserDefinedSearchRelationLink;

		public string ExportDocumentsRelationLink => Obj.ExportDocumentsRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IDocumentsQueryResult GetDocumentsQueryResultFromNextRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromNextRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromNextRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromPrevRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromPrevRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromSelfRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromFirstRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromFirstRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

		public async XElementWrapper GetXElementWrapperFromFeedRelation() => Obj.GetXElementWrapperFromFeedRelation();
        public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync()
        {
            DocuWare.Platform.ServerClient.XElementWrapper result = await Obj.GetXElementWrapperFromFeedRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XElementWrapper(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XElementWrapper>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.XElementWrapper result = await Obj.GetXElementWrapperFromFeedRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XElementWrapper(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XElementWrapper>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromDownloadRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromDownloadRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDownloadRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromDownloadRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDownloadRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromDownloadRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcessData dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcessData dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchUpdateIndexFieldsResult result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcessData dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchUpdateIndexFieldsResult result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public IDialog PostToCreateUserDefinedSearchRelationForDialog(IUserDefinedSearchInfo dataToSend) => new Dialog(Obj.PostToCreateUserDefinedSearchRelationForDialog(dataToSend));

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(IUserDefinedSearchInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(CancellationToken cancellationToken, IUserDefinedSearchInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

		public async Stream PostToExportDocumentsRelationForStream(IExportSettings dataToSend) => Obj.PostToExportDocumentsRelationForStream(dataToSend);
        public async Task<DeserializedHttpResponse<Stream>> PostToExportDocumentsRelationForStreamAsync(IExportSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToExportDocumentsRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToExportDocumentsRelationForStreamAsync(CancellationToken cancellationToken, IExportSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToExportDocumentsRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

    }
}
