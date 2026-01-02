using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentsQueryTableResult(DocuWare.Platform.ServerClient.DocumentsQueryTableResult obj) : IDocumentsQueryTableResult
    {
        internal DocuWare.Platform.ServerClient.DocumentsQueryTableResult Obj { get; } = obj;

        public List<ITableResultHeader> Headers
        {
            get => Obj.Headers.Select(x => new TableResultHeader(x) as ITableResultHeader).ToList();
            set => Obj.Headers = value.Select(x => ((TableResultHeader)x).Obj).ToList();
        }

        public List<ITableResultRow> Rows
        {
            get => Obj.Rows.Select(x => new TableResultRow(x) as ITableResultRow).ToList();
            set => Obj.Rows = value.Select(x => ((TableResultRow)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string FileCabinetId
        {
            get => Obj.FileCabinetId;
            set => Obj.FileCabinetId = value;
        }

        public string OrganizationGuid
        {
            get => Obj.OrganizationGuid;
            set => Obj.OrganizationGuid = value;
        }

        public DateTime TimeStamp
        {
            get => Obj.TimeStamp;
            set => Obj.TimeStamp = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromNextRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromNextRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromPrevRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromSelfRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromFirstRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

		public XElementWrapper GetXElementWrapperFromFeedRelation() => Obj.GetXElementWrapperFromFeedRelation();

		public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync() => await Obj.GetXElementWrapperFromFeedRelationAsync();

		public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync(CancellationToken cancellationToken) => await Obj.GetXElementWrapperFromFeedRelationAsync(cancellationToken);

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromDownloadRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromDownloadRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDownloadRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromDownloadRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDownloadRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromDownloadRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
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
