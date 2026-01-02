using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentsQueryResult(DocuWare.Platform.ServerClient.DocumentsQueryResult obj) : IDocumentsQueryResult
    {
        internal DocuWare.Platform.ServerClient.DocumentsQueryResult Obj { get; } = obj;

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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDocumentsQueryResult GetDocumentsQueryResultFromNextRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromNextRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromPrevRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromSelfRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromFirstRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

		public XElementWrapper GetXElementWrapperFromFeedRelation() => Obj.GetXElementWrapperFromFeedRelation();

		public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync() => await Obj.GetXElementWrapperFromFeedRelationAsync();

		public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync(CancellationToken cancellationToken) => await Obj.GetXElementWrapperFromFeedRelationAsync(cancellationToken);

        public IDocumentsQueryResult GetDocumentsQueryResultFromDownloadRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromDownloadRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDownloadRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromDownloadRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDownloadRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromDownloadRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcessData dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(((BatchUpdateProcessData)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcessData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(((BatchUpdateProcessData)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcessData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, ((BatchUpdateProcessData)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public IDialog PostToCreateUserDefinedSearchRelationForDialog(IUserDefinedSearchInfo dataToSend) => new Dialog(Obj.PostToCreateUserDefinedSearchRelationForDialog(((UserDefinedSearchInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(IUserDefinedSearchInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(((UserDefinedSearchInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(CancellationToken cancellationToken, IUserDefinedSearchInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(cancellationToken, ((UserDefinedSearchInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

		public Stream PostToExportDocumentsRelationForStream(IExportSettings dataToSend) => Obj.PostToExportDocumentsRelationForStream(((ExportSettings)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToExportDocumentsRelationForStreamAsync(IExportSettings dataToSend) => await Obj.PostToExportDocumentsRelationForStreamAsync(((ExportSettings)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToExportDocumentsRelationForStreamAsync(CancellationToken cancellationToken, IExportSettings dataToSend) => await Obj.PostToExportDocumentsRelationForStreamAsync(cancellationToken, ((ExportSettings)dataToSend).Obj);
    }
}
