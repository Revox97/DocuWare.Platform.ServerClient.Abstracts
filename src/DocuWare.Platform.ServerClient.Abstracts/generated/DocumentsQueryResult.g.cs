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

        public DocumentsQueryResult GetDocumentsQueryResultFromNextRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromNextRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult GetDocumentsQueryResultFromPrevRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromPrevRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult GetDocumentsQueryResultFromSelfRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult GetDocumentsQueryResultFromFirstRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromFirstRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
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

        public DocumentsQueryResult GetDocumentsQueryResultFromDownloadRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromDownloadRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDownloadRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromDownloadRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDownloadRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromDownloadRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
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
