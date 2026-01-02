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

        public List<DocuWare.Platform.ServerClient.Right> Rights
        {
            get => Obj.Rights;
            set => Obj.Rights = value;
        }

        public IExtendedUserRights ExtendedUserRights
        {
            get => new ExtendedUserRights(Obj.ExtendedUserRights);
            set => Obj.ExtendedUserRights = ((ExtendedUserRights)value).Obj;
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

        public string DocumentsRelationLink => Obj.DocumentsRelationLink;

        public string DocumentsTableRelationLink => Obj.DocumentsTableRelationLink;

        public string ContentMergeOperationRelationLink => Obj.ContentMergeOperationRelationLink;

        public string AdvancedDocumentUploadRelationLink => Obj.AdvancedDocumentUploadRelationLink;

        public string ImportDocumentsRelationLink => Obj.ImportDocumentsRelationLink;

        public string UnprocessedDocumentUploadRelationLink => Obj.UnprocessedDocumentUploadRelationLink;

        public string QueryRelationLink => Obj.QueryRelationLink;

        public string DialogsRelationLink => Obj.DialogsRelationLink;

        public string SearchesRelationLink => Obj.SearchesRelationLink;

        public string CustomSearchRelationLink => Obj.CustomSearchRelationLink;

        public string ResultTreesRelationLink => Obj.ResultTreesRelationLink;

        public string StoresRelationLink => Obj.StoresRelationLink;

        public string TaskListsRelationLink => Obj.TaskListsRelationLink;

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string StampsRelationLink => Obj.StampsRelationLink;

        public string NotificationsRelationLink => Obj.NotificationsRelationLink;

        public string TransferRelationLink => Obj.TransferRelationLink;

        public string VersionHistoryResultListRelationLink => Obj.VersionHistoryResultListRelationLink;

        public string BatchUpdateRelationLink => Obj.BatchUpdateRelationLink;

        public string FieldValueStatisticsRelationLink => Obj.FieldValueStatisticsRelationLink;

        public string ReplicationDataRelationLink => Obj.ReplicationDataRelationLink;

        public string ReplicationDeleteDataRelationLink => Obj.ReplicationDeleteDataRelationLink;

        public string SetupReplicationRelationLink => Obj.SetupReplicationRelationLink;

        public string ReplicationInfoRelationLink => Obj.ReplicationInfoRelationLink;

        public string NextSequenceElementRelationLink => Obj.NextSequenceElementRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public DocumentsQueryResult GetDocumentsQueryResultFromDocumentsRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromDocumentsRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDocumentsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public Document PostToDocumentsRelationForDocument(IDocument dataToSend) => new Document(Obj.PostToDocumentsRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToDocumentsRelationForDocumentAsync(IDocument dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToDocumentsRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IDocument dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToDocumentsRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryTableResult GetDocumentsQueryTableResultFromDocumentsTableRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromDocumentsTableRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDocumentsTableRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromDocumentsTableRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDocumentsTableRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromDocumentsTableRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public Document PutToContentMergeOperationRelationForDocument(IContentMergeOperationInfo dataToSend) => new Document(Obj.PutToContentMergeOperationRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PutToContentMergeOperationRelationForDocumentAsync(IContentMergeOperationInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToContentMergeOperationRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToContentMergeOperationRelationForDocumentAsync(CancellationToken cancellationToken, IContentMergeOperationInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToContentMergeOperationRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public Document PostToAdvancedDocumentUploadRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToAdvancedDocumentUploadRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToAdvancedDocumentUploadRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToAdvancedDocumentUploadRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToAdvancedDocumentUploadRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToAdvancedDocumentUploadRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public ImportResult PostToImportDocumentsRelationForImportResult(IImportSettings dataToSend) => new ImportResult(Obj.PostToImportDocumentsRelationForImportResult(dataToSend));

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(IImportSettings dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.ImportResult> result = await Obj.PostToImportDocumentsRelationForImportResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ImportResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(CancellationToken cancellationToken, IImportSettings dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.ImportResult> result = await Obj.PostToImportDocumentsRelationForImportResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ImportResult>(temp).ConfigureAwait(false);
        }

        public ImportResult PostToImportDocumentsRelationForImportResult(ISynchronizationSettings dataToSend) => new ImportResult(Obj.PostToImportDocumentsRelationForImportResult(dataToSend));

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(ISynchronizationSettings dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.ImportResult> result = await Obj.PostToImportDocumentsRelationForImportResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ImportResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(CancellationToken cancellationToken, ISynchronizationSettings dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.ImportResult> result = await Obj.PostToImportDocumentsRelationForImportResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ImportResult>(temp).ConfigureAwait(false);
        }

        public Document PostToUnprocessedDocumentUploadRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToUnprocessedDocumentUploadRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToUnprocessedDocumentUploadRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToUnprocessedDocumentUploadRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToUnprocessedDocumentUploadRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToUnprocessedDocumentUploadRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryTableResult GetDocumentsQueryTableResultFromQueryRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromQueryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromQueryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromQueryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromQueryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.GetDocumentsQueryTableResultFromQueryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult GetDocumentsQueryResultFromQueryRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromQueryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromQueryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromQueryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromQueryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromQueryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PostToQueryRelationForDocumentsQueryResult(IFunctionExpressionQuery dataToSend) => new DocumentsQueryResult(Obj.PostToQueryRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToQueryRelationForDocumentsQueryResultAsync(IFunctionExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToQueryRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToQueryRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFunctionExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToQueryRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryTableResult PostToQueryRelationForDocumentsQueryTableResult(IFunctionExpressionQuery dataToSend) => new DocumentsQueryTableResult(Obj.PostToQueryRelationForDocumentsQueryTableResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToQueryRelationForDocumentsQueryTableResultAsync(IFunctionExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.PostToQueryRelationForDocumentsQueryTableResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToQueryRelationForDocumentsQueryTableResultAsync(CancellationToken cancellationToken, IFunctionExpressionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryTableResult> result = await Obj.PostToQueryRelationForDocumentsQueryTableResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public DialogInfos GetDialogInfosFromDialogsRelation() => new DialogInfos(Obj.GetDialogInfosFromDialogsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromDialogsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromDialogsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public DialogInfos GetDialogInfosFromSearchesRelation() => new DialogInfos(Obj.GetDialogInfosFromSearchesRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSearchesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromSearchesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSearchesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromSearchesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public Dialog GetDialogFromCustomSearchRelation() => new Dialog(Obj.GetDialogFromCustomSearchRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromCustomSearchRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromCustomSearchRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromCustomSearchRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Dialog> result = await Obj.GetDialogFromCustomSearchRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Dialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Dialog>(temp).ConfigureAwait(false);
        }

        public DialogInfos GetDialogInfosFromResultTreesRelation() => new DialogInfos(Obj.GetDialogInfosFromResultTreesRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromResultTreesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromResultTreesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromResultTreesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromResultTreesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public DialogInfos GetDialogInfosFromStoresRelation() => new DialogInfos(Obj.GetDialogInfosFromStoresRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromStoresRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromStoresRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromStoresRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromStoresRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public DialogInfos GetDialogInfosFromTaskListsRelation() => new DialogInfos(Obj.GetDialogInfosFromTaskListsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromTaskListsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromTaskListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromTaskListsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromTaskListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public FileCabinet GetFileCabinetFromSelfRelation() => new FileCabinet(Obj.GetFileCabinetFromSelfRelation());

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinet> result = await Obj.GetFileCabinetFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<FileCabinet>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FileCabinet> result = await Obj.GetFileCabinetFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<FileCabinet>(temp).ConfigureAwait(false);
        }

        public Stamps GetStampsFromStampsRelation() => new Stamps(Obj.GetStampsFromStampsRelation());

        public async Task<DeserializedHttpResponse<IStamps>> GetStampsFromStampsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Stamps> result = await Obj.GetStampsFromStampsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stamps(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stamps>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IStamps>> GetStampsFromStampsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Stamps> result = await Obj.GetStampsFromStampsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stamps(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stamps>(temp).ConfigureAwait(false);
        }

        public Notifications GetNotificationsFromNotificationsRelation() => new Notifications(Obj.GetNotificationsFromNotificationsRelation());

        public async Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromNotificationsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Notifications> result = await Obj.GetNotificationsFromNotificationsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Notifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Notifications>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromNotificationsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Notifications> result = await Obj.GetNotificationsFromNotificationsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Notifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Notifications>(temp).ConfigureAwait(false);
        }

        public Notifications PostToNotificationsRelationForNotifications(INotifications dataToSend) => new Notifications(Obj.PostToNotificationsRelationForNotifications(dataToSend));

        public async Task<DeserializedHttpResponse<INotifications>> PostToNotificationsRelationForNotificationsAsync(INotifications dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Notifications> result = await Obj.PostToNotificationsRelationForNotificationsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Notifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Notifications>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<INotifications>> PostToNotificationsRelationForNotificationsAsync(CancellationToken cancellationToken, INotifications dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Notifications> result = await Obj.PostToNotificationsRelationForNotificationsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Notifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Notifications>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IFileCabinetTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IFileCabinetTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFileCabinetTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IDocumentsTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IDocumentsTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentsTransferInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DialogInfo GetDialogInfoFromVersionHistoryResultListRelation() => new DialogInfo(Obj.GetDialogInfoFromVersionHistoryResultListRelation());

        public async Task<DeserializedHttpResponse<IDialogInfo>> GetDialogInfoFromVersionHistoryResultListRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfo> result = await Obj.GetDialogInfoFromVersionHistoryResultListRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfo>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfo>> GetDialogInfoFromVersionHistoryResultListRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfo> result = await Obj.GetDialogInfoFromVersionHistoryResultListRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfo>(temp).ConfigureAwait(false);
        }

        public BatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcess dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcess dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcess dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public BatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchAppendKeywordValues dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchAppendKeywordValues dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchAppendKeywordValues dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.BatchUpdateIndexFieldsResult> result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new BatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<BatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public FieldValueStatisticsResult PostToFieldValueStatisticsRelationForFieldValueStatisticsResult(IFieldValueStatisticsExpression dataToSend) => new FieldValueStatisticsResult(Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IFieldValueStatisticsResult>> PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(IFieldValueStatisticsExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FieldValueStatisticsResult> result = await Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FieldValueStatisticsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<FieldValueStatisticsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFieldValueStatisticsResult>> PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(CancellationToken cancellationToken, IFieldValueStatisticsExpression dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FieldValueStatisticsResult> result = await Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FieldValueStatisticsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<FieldValueStatisticsResult>(temp).ConfigureAwait(false);
        }

		public async Stream PostToReplicationDataRelationForStream(Stream dataToSend) => Obj.PostToReplicationDataRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDataRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToReplicationDataRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDataRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToReplicationDataRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToReplicationDeleteDataRelationForStream(Stream dataToSend) => Obj.PostToReplicationDeleteDataRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDeleteDataRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToReplicationDeleteDataRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDeleteDataRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToReplicationDeleteDataRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async string PostToSetupReplicationRelationForString(Stream dataToSend) => Obj.PostToSetupReplicationRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToSetupReplicationRelationForStringAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToSetupReplicationRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToSetupReplicationRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToSetupReplicationRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromReplicationInfoRelation() => Obj.GetStreamFromReplicationInfoRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromReplicationInfoRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromReplicationInfoRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromReplicationInfoRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromReplicationInfoRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public SequenceResult PostToNextSequenceElementRelationForSequenceResult(ISequenceRequest dataToSend) => new SequenceResult(Obj.PostToNextSequenceElementRelationForSequenceResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISequenceResult>> PostToNextSequenceElementRelationForSequenceResultAsync(ISequenceRequest dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SequenceResult> result = await Obj.PostToNextSequenceElementRelationForSequenceResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SequenceResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SequenceResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISequenceResult>> PostToNextSequenceElementRelationForSequenceResultAsync(CancellationToken cancellationToken, ISequenceRequest dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SequenceResult> result = await Obj.PostToNextSequenceElementRelationForSequenceResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SequenceResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SequenceResult>(temp).ConfigureAwait(false);
        }
    }
}
