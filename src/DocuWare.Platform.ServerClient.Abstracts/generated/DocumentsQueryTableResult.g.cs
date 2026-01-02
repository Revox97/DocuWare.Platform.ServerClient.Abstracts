using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentsQueryTableResult(SDK.DocumentsQueryTableResult obj) : IDocumentsQueryTableResult
    {
        internal SDK.DocumentsQueryTableResult Obj { get; } = obj;

        public ICountPlusValue Count
        {
            get => new CountPlusValue(Obj.Count);
            set => Obj.Count = ((CountPlusValue)value).Obj;
        }

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

        public DocumentsQueryTableResult GetDocumentsQueryTableResultFromNextRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromNextRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryTableResult GetDocumentsQueryTableResultFromPrevRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryTableResult GetDocumentsQueryTableResultFromSelfRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryTableResult GetDocumentsQueryTableResultFromFirstRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

		public async XElementWrapper GetXElementWrapperFromFeedRelation() => Obj.GetXElementWrapperFromFeedRelation();

        public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync()
        {
            DeserializedHttpResponse<XElementWrapper> result = await Obj.GetXElementWrapperFromFeedRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XElementWrapper(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XElementWrapper>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<XElementWrapper> result = await Obj.GetXElementWrapperFromFeedRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XElementWrapper(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XElementWrapper>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryTableResult GetDocumentsQueryTableResultFromDownloadRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromDownloadRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDownloadRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromDownloadRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDownloadRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromDownloadRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public BatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcessData dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcessData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcessData dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public Dialog PostToCreateUserDefinedSearchRelationForDialog(IUserDefinedSearchInfo dataToSend) => new Dialog(Obj.PostToCreateUserDefinedSearchRelationForDialog(dataToSend));

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(IUserDefinedSearchInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(CancellationToken cancellationToken, IUserDefinedSearchInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.PostToCreateUserDefinedSearchRelationForDialogAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

		public async Stream PostToExportDocumentsRelationForStream(IExportSettings dataToSend) => Obj.PostToExportDocumentsRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToExportDocumentsRelationForStreamAsync(IExportSettings dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToExportDocumentsRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToExportDocumentsRelationForStreamAsync(CancellationToken cancellationToken, IExportSettings dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToExportDocumentsRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }
    }
}
