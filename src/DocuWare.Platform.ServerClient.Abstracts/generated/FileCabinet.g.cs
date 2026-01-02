using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinet(SDK.FileCabinet obj) : IFileCabinet
    {
        internal SDK.FileCabinet Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<IFileCabinetField> Fields
        {
            get => Obj.Fields.Select(x => new FileCabinetField(x) as IFileCabinetField).ToList();
            set => Obj.Fields = value.Select(x => ((FileCabinetField)x).Obj).ToList();
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public bool IsBasket
        {
            get => Obj.IsBasket;
            set => Obj.IsBasket = value;
        }

        public bool Usable
        {
            get => Obj.Usable;
            set => Obj.Usable = value;
        }

        public bool Default
        {
            get => Obj.Default;
            set => Obj.Default = value;
        }

        public string AssignedCabinetId
        {
            get => Obj.AssignedCabinetId;
            set => Obj.AssignedCabinetId = value;
        }

        public string IntellixDialogId
        {
            get => Obj.IntellixDialogId;
            set => Obj.IntellixDialogId = value;
        }

        public DocuWare.Platform.ServerClient.VersionManagementMode VersionManagement
        {
            get => Obj.VersionManagement;
            set => Obj.VersionManagement = value;
        }

        public string VersionHistoryResultListId
        {
            get => Obj.VersionHistoryResultListId;
            set => Obj.VersionHistoryResultListId = value;
        }

        public bool WindowsExplorerClientAccess
        {
            get => Obj.WindowsExplorerClientAccess;
            set => Obj.WindowsExplorerClientAccess = value;
        }

        public bool AddIndexEntriesInUpperCase
        {
            get => Obj.AddIndexEntriesInUpperCase;
            set => Obj.AddIndexEntriesInUpperCase = value;
        }

        public bool DocumentAuditingEnabled
        {
            get => Obj.DocumentAuditingEnabled;
            set => Obj.DocumentAuditingEnabled = value;
        }

        public bool HasFullTextSupport
        {
            get => Obj.HasFullTextSupport;
            set => Obj.HasFullTextSupport = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDocumentsQueryResult GetDocumentsQueryResultFromDocumentsRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromDocumentsRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDocumentsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocument PostToDocumentsRelationForDocument(IDocument dataToSend) => new Document(Obj.PostToDocumentsRelationForDocument(((Document)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocument>> PostToDocumentsRelationForDocumentAsync(IDocument dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToDocumentsRelationForDocumentAsync(((Document)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IDocument dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToDocumentsRelationForDocumentAsync(cancellationToken, ((Document)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromDocumentsTableRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromDocumentsTableRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDocumentsTableRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromDocumentsTableRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDocumentsTableRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromDocumentsTableRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDocument PutToContentMergeOperationRelationForDocument(IContentMergeOperationInfo dataToSend) => new Document(Obj.PutToContentMergeOperationRelationForDocument(((ContentMergeOperationInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocument>> PutToContentMergeOperationRelationForDocumentAsync(IContentMergeOperationInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToContentMergeOperationRelationForDocumentAsync(((ContentMergeOperationInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToContentMergeOperationRelationForDocumentAsync(CancellationToken cancellationToken, IContentMergeOperationInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToContentMergeOperationRelationForDocumentAsync(cancellationToken, ((ContentMergeOperationInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocument PostToAdvancedDocumentUploadRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToAdvancedDocumentUploadRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToAdvancedDocumentUploadRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToAdvancedDocumentUploadRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToAdvancedDocumentUploadRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToAdvancedDocumentUploadRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IImportResult PostToImportDocumentsRelationForImportResult(IImportSettings dataToSend) => new ImportResult(Obj.PostToImportDocumentsRelationForImportResult(((ImportSettings)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(IImportSettings dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.ImportResult> result = await Obj.PostToImportDocumentsRelationForImportResultAsync(((ImportSettings)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IImportResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(CancellationToken cancellationToken, IImportSettings dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.ImportResult> result = await Obj.PostToImportDocumentsRelationForImportResultAsync(cancellationToken, ((ImportSettings)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IImportResult>(temp).ConfigureAwait(false);
        }

        public IImportResult PostToImportDocumentsRelationForImportResult(ISynchronizationSettings dataToSend) => new ImportResult(Obj.PostToImportDocumentsRelationForImportResult(((SynchronizationSettings)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(ISynchronizationSettings dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.ImportResult> result = await Obj.PostToImportDocumentsRelationForImportResultAsync(((SynchronizationSettings)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IImportResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(CancellationToken cancellationToken, ISynchronizationSettings dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.ImportResult> result = await Obj.PostToImportDocumentsRelationForImportResultAsync(cancellationToken, ((SynchronizationSettings)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IImportResult>(temp).ConfigureAwait(false);
        }

        public IDocument PostToUnprocessedDocumentUploadRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToUnprocessedDocumentUploadRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToUnprocessedDocumentUploadRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToUnprocessedDocumentUploadRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToUnprocessedDocumentUploadRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToUnprocessedDocumentUploadRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromQueryRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromQueryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromQueryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromQueryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromQueryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromQueryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromQueryRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromQueryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromQueryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromQueryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromQueryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromQueryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToQueryRelationForDocumentsQueryResult(IFunctionExpressionQuery dataToSend) => new DocumentsQueryResult(Obj.PostToQueryRelationForDocumentsQueryResult(((FunctionExpressionQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToQueryRelationForDocumentsQueryResultAsync(IFunctionExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToQueryRelationForDocumentsQueryResultAsync(((FunctionExpressionQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToQueryRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFunctionExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToQueryRelationForDocumentsQueryResultAsync(cancellationToken, ((FunctionExpressionQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult PostToQueryRelationForDocumentsQueryTableResult(IFunctionExpressionQuery dataToSend) => new DocumentsQueryTableResult(Obj.PostToQueryRelationForDocumentsQueryTableResult(((FunctionExpressionQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToQueryRelationForDocumentsQueryTableResultAsync(IFunctionExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.PostToQueryRelationForDocumentsQueryTableResultAsync(((FunctionExpressionQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToQueryRelationForDocumentsQueryTableResultAsync(CancellationToken cancellationToken, IFunctionExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.PostToQueryRelationForDocumentsQueryTableResultAsync(cancellationToken, ((FunctionExpressionQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromDialogsRelation() => new DialogInfos(Obj.GetDialogInfosFromDialogsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromDialogsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromDialogsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromSearchesRelation() => new DialogInfos(Obj.GetDialogInfosFromSearchesRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSearchesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromSearchesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSearchesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromSearchesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialog GetDialogFromCustomSearchRelation() => new Dialog(Obj.GetDialogFromCustomSearchRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromCustomSearchRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromCustomSearchRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromCustomSearchRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromCustomSearchRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromResultTreesRelation() => new DialogInfos(Obj.GetDialogInfosFromResultTreesRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromResultTreesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromResultTreesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromResultTreesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromResultTreesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromStoresRelation() => new DialogInfos(Obj.GetDialogInfosFromStoresRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromStoresRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromStoresRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromStoresRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromStoresRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromTaskListsRelation() => new DialogInfos(Obj.GetDialogInfosFromTaskListsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromTaskListsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromTaskListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromTaskListsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromTaskListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IFileCabinet GetFileCabinetFromSelfRelation() => new FileCabinet(Obj.GetFileCabinetFromSelfRelation());

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinet> result = await Obj.GetFileCabinetFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinet>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinet> result = await Obj.GetFileCabinetFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinet>(temp).ConfigureAwait(false);
        }

        public IStamps GetStampsFromStampsRelation() => new Stamps(Obj.GetStampsFromStampsRelation());

        public async Task<DeserializedHttpResponse<IStamps>> GetStampsFromStampsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Stamps> result = await Obj.GetStampsFromStampsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stamps(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IStamps>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IStamps>> GetStampsFromStampsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Stamps> result = await Obj.GetStampsFromStampsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stamps(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IStamps>(temp).ConfigureAwait(false);
        }

        public INotifications GetNotificationsFromNotificationsRelation() => new Notifications(Obj.GetNotificationsFromNotificationsRelation());

        public async Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromNotificationsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Notifications> result = await Obj.GetNotificationsFromNotificationsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Notifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromNotificationsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Notifications> result = await Obj.GetNotificationsFromNotificationsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Notifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public INotifications PostToNotificationsRelationForNotifications(INotifications dataToSend) => new Notifications(Obj.PostToNotificationsRelationForNotifications(((Notifications)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<INotifications>> PostToNotificationsRelationForNotificationsAsync(INotifications dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Notifications> result = await Obj.PostToNotificationsRelationForNotificationsAsync(((Notifications)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Notifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<INotifications>> PostToNotificationsRelationForNotificationsAsync(CancellationToken cancellationToken, INotifications dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Notifications> result = await Obj.PostToNotificationsRelationForNotificationsAsync(cancellationToken, ((Notifications)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Notifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IFileCabinetTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(((FileCabinetTransferInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IFileCabinetTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(((FileCabinetTransferInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFileCabinetTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, ((FileCabinetTransferInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IDocumentsTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(((DocumentsTransferInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IDocumentsTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(((DocumentsTransferInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentsTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, ((DocumentsTransferInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDialogInfo GetDialogInfoFromVersionHistoryResultListRelation() => new DialogInfo(Obj.GetDialogInfoFromVersionHistoryResultListRelation());

        public async Task<DeserializedHttpResponse<IDialogInfo>> GetDialogInfoFromVersionHistoryResultListRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfo> result = await Obj.GetDialogInfoFromVersionHistoryResultListRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfo>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfo>> GetDialogInfoFromVersionHistoryResultListRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfo> result = await Obj.GetDialogInfoFromVersionHistoryResultListRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfo>(temp).ConfigureAwait(false);
        }

        public IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcess dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(((BatchUpdateProcess)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcess dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(((BatchUpdateProcess)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcess dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, ((BatchUpdateProcess)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchAppendKeywordValues dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(((BatchAppendKeywordValues)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchAppendKeywordValues dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(((BatchAppendKeywordValues)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchAppendKeywordValues dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, ((BatchAppendKeywordValues)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public IFieldValueStatisticsResult PostToFieldValueStatisticsRelationForFieldValueStatisticsResult(IFieldValueStatisticsExpression dataToSend) => new FieldValueStatisticsResult(Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResult(((FieldValueStatisticsExpression)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IFieldValueStatisticsResult>> PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(IFieldValueStatisticsExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FieldValueStatisticsResult> result = await Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(((FieldValueStatisticsExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FieldValueStatisticsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFieldValueStatisticsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFieldValueStatisticsResult>> PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(CancellationToken cancellationToken, IFieldValueStatisticsExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FieldValueStatisticsResult> result = await Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(cancellationToken, ((FieldValueStatisticsExpression)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FieldValueStatisticsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFieldValueStatisticsResult>(temp).ConfigureAwait(false);
        }

		public Stream PostToReplicationDataRelationForStream(Stream dataToSend) => Obj.PostToReplicationDataRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDataRelationForStreamAsync(Stream dataToSend) => await Obj.PostToReplicationDataRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDataRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToReplicationDataRelationForStreamAsync(cancellationToken, dataToSend);

		public Stream PostToReplicationDeleteDataRelationForStream(Stream dataToSend) => Obj.PostToReplicationDeleteDataRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDeleteDataRelationForStreamAsync(Stream dataToSend) => await Obj.PostToReplicationDeleteDataRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDeleteDataRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToReplicationDeleteDataRelationForStreamAsync(cancellationToken, dataToSend);

		public string PostToSetupReplicationRelationForString(Stream dataToSend) => Obj.PostToSetupReplicationRelationForString(dataToSend);

		public async Task<DeserializedHttpResponse<string>> PostToSetupReplicationRelationForStringAsync(Stream dataToSend) => await Obj.PostToSetupReplicationRelationForStringAsync(dataToSend);

		public async Task<DeserializedHttpResponse<string>> PostToSetupReplicationRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToSetupReplicationRelationForStringAsync(cancellationToken, dataToSend);

		public Stream GetStreamFromReplicationInfoRelation() => Obj.GetStreamFromReplicationInfoRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromReplicationInfoRelationAsync() => await Obj.GetStreamFromReplicationInfoRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromReplicationInfoRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromReplicationInfoRelationAsync(cancellationToken);

        public ISequenceResult PostToNextSequenceElementRelationForSequenceResult(ISequenceRequest dataToSend) => new SequenceResult(Obj.PostToNextSequenceElementRelationForSequenceResult(((SequenceRequest)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<ISequenceResult>> PostToNextSequenceElementRelationForSequenceResultAsync(ISequenceRequest dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SequenceResult> result = await Obj.PostToNextSequenceElementRelationForSequenceResultAsync(((SequenceRequest)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SequenceResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISequenceResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISequenceResult>> PostToNextSequenceElementRelationForSequenceResultAsync(CancellationToken cancellationToken, ISequenceRequest dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SequenceResult> result = await Obj.PostToNextSequenceElementRelationForSequenceResultAsync(cancellationToken, ((SequenceRequest)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SequenceResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISequenceResult>(temp).ConfigureAwait(false);
        }
    }
}
