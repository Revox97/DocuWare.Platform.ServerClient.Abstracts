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

		public List<Right> Rights
		{
			get => Obj.Rights.Select(x => new ight(x) as Right).ToList();
			set => Obj.Rights = value.Select(x => ((ight)x).Obj).ToList();
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

		public VersionManagementMode VersionManagement
		{
			get => new ersionManagementMode(Obj.VersionManagement);
			set => Obj.VersionManagement = ((ersionManagementMode)value).Obj;
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
        public IDocumentsQueryResult GetDocumentsQueryResultFromDocumentsRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromDocumentsRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDocumentsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromDocumentsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDocumentsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromDocumentsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocument PostToDocumentsRelationForDocument(IDocument dataToSend) => new Document(Obj.PostToDocumentsRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToDocumentsRelationForDocumentAsync(IDocument dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToDocumentsRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IDocument dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToDocumentsRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromDocumentsTableRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromDocumentsTableRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDocumentsTableRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.GetDocumentsQueryTableResultFromDocumentsTableRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDocumentsTableRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.GetDocumentsQueryTableResultFromDocumentsTableRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDocument PutToContentMergeOperationRelationForDocument(IContentMergeOperationInfo dataToSend) => new Document(Obj.PutToContentMergeOperationRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PutToContentMergeOperationRelationForDocumentAsync(IContentMergeOperationInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PutToContentMergeOperationRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToContentMergeOperationRelationForDocumentAsync(CancellationToken cancellationToken, IContentMergeOperationInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PutToContentMergeOperationRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocument PostToAdvancedDocumentUploadRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToAdvancedDocumentUploadRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToAdvancedDocumentUploadRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToAdvancedDocumentUploadRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToAdvancedDocumentUploadRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToAdvancedDocumentUploadRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IImportResult PostToImportDocumentsRelationForImportResult(IImportSettings dataToSend) => new ImportResult(Obj.PostToImportDocumentsRelationForImportResult(dataToSend));

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(IImportSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.IImportResult result = await Obj.PostToImportDocumentsRelationForImportResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IImportResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(CancellationToken cancellationToken, IImportSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.IImportResult result = await Obj.PostToImportDocumentsRelationForImportResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IImportResult>(temp).ConfigureAwait(false);
        }

        public IImportResult PostToImportDocumentsRelationForImportResult(ISynchronizationSettings dataToSend) => new ImportResult(Obj.PostToImportDocumentsRelationForImportResult(dataToSend));

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(ISynchronizationSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.IImportResult result = await Obj.PostToImportDocumentsRelationForImportResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IImportResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(CancellationToken cancellationToken, ISynchronizationSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.IImportResult result = await Obj.PostToImportDocumentsRelationForImportResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IImportResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IImportResult>(temp).ConfigureAwait(false);
        }

        public IDocument PostToUnprocessedDocumentUploadRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToUnprocessedDocumentUploadRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToUnprocessedDocumentUploadRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToUnprocessedDocumentUploadRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToUnprocessedDocumentUploadRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToUnprocessedDocumentUploadRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult GetDocumentsQueryTableResultFromQueryRelation() => new DocumentsQueryTableResult(Obj.GetDocumentsQueryTableResultFromQueryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromQueryRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.GetDocumentsQueryTableResultFromQueryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromQueryRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.GetDocumentsQueryTableResultFromQueryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromQueryRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromQueryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromQueryRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromQueryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromQueryRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromQueryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToQueryRelationForDocumentsQueryResult(IFunctionExpressionQuery dataToSend) => new DocumentsQueryResult(Obj.PostToQueryRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToQueryRelationForDocumentsQueryResultAsync(IFunctionExpressionQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToQueryRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToQueryRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFunctionExpressionQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToQueryRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryTableResult PostToQueryRelationForDocumentsQueryTableResult(IFunctionExpressionQuery dataToSend) => new DocumentsQueryTableResult(Obj.PostToQueryRelationForDocumentsQueryTableResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToQueryRelationForDocumentsQueryTableResultAsync(IFunctionExpressionQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.PostToQueryRelationForDocumentsQueryTableResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToQueryRelationForDocumentsQueryTableResultAsync(CancellationToken cancellationToken, IFunctionExpressionQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryTableResult result = await Obj.PostToQueryRelationForDocumentsQueryTableResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryTableResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryTableResult>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromDialogsRelation() => new DialogInfos(Obj.GetDialogInfosFromDialogsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromDialogsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromDialogsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromSearchesRelation() => new DialogInfos(Obj.GetDialogInfosFromSearchesRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSearchesRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromSearchesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSearchesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromSearchesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialog GetDialogFromCustomSearchRelation() => new Dialog(Obj.GetDialogFromCustomSearchRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromCustomSearchRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.GetDialogFromCustomSearchRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromCustomSearchRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.GetDialogFromCustomSearchRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromResultTreesRelation() => new DialogInfos(Obj.GetDialogInfosFromResultTreesRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromResultTreesRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromResultTreesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromResultTreesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromResultTreesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromStoresRelation() => new DialogInfos(Obj.GetDialogInfosFromStoresRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromStoresRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromStoresRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromStoresRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromStoresRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IDialogInfos GetDialogInfosFromTaskListsRelation() => new DialogInfos(Obj.GetDialogInfosFromTaskListsRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromTaskListsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromTaskListsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromTaskListsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialogInfos result = await Obj.GetDialogInfosFromTaskListsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfos>(temp).ConfigureAwait(false);
        }

        public IFileCabinet GetFileCabinetFromSelfRelation() => new FileCabinet(Obj.GetFileCabinetFromSelfRelation());

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IFileCabinet result = await Obj.GetFileCabinetFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinet>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IFileCabinet result = await Obj.GetFileCabinetFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFileCabinet(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFileCabinet>(temp).ConfigureAwait(false);
        }

        public IStamps GetStampsFromStampsRelation() => new Stamps(Obj.GetStampsFromStampsRelation());

        public async Task<DeserializedHttpResponse<IStamps>> GetStampsFromStampsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IStamps result = await Obj.GetStampsFromStampsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IStamps(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IStamps>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IStamps>> GetStampsFromStampsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IStamps result = await Obj.GetStampsFromStampsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IStamps(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IStamps>(temp).ConfigureAwait(false);
        }

        public INotifications GetNotificationsFromNotificationsRelation() => new Notifications(Obj.GetNotificationsFromNotificationsRelation());

        public async Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromNotificationsRelationAsync()
        {
            DocuWare.Platform.ServerClient.INotifications result = await Obj.GetNotificationsFromNotificationsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new INotifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromNotificationsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.INotifications result = await Obj.GetNotificationsFromNotificationsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new INotifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public INotifications PostToNotificationsRelationForNotifications(INotifications dataToSend) => new Notifications(Obj.PostToNotificationsRelationForNotifications(dataToSend));

        public async Task<DeserializedHttpResponse<INotifications>> PostToNotificationsRelationForNotificationsAsync(INotifications dataToSend)
        {
            DocuWare.Platform.ServerClient.INotifications result = await Obj.PostToNotificationsRelationForNotificationsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new INotifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<INotifications>> PostToNotificationsRelationForNotificationsAsync(CancellationToken cancellationToken, INotifications dataToSend)
        {
            DocuWare.Platform.ServerClient.INotifications result = await Obj.PostToNotificationsRelationForNotificationsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new INotifications(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<INotifications>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IFileCabinetTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IFileCabinetTransferInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFileCabinetTransferInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IDocumentsTransferInfo dataToSend) => new DocumentsQueryResult(Obj.PostToTransferRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IDocumentsTransferInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentsTransferInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToTransferRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDialogInfo GetDialogInfoFromVersionHistoryResultListRelation() => new DialogInfo(Obj.GetDialogInfoFromVersionHistoryResultListRelation());

        public async Task<DeserializedHttpResponse<IDialogInfo>> GetDialogInfoFromVersionHistoryResultListRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialogInfo result = await Obj.GetDialogInfoFromVersionHistoryResultListRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfo>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfo>> GetDialogInfoFromVersionHistoryResultListRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialogInfo result = await Obj.GetDialogInfoFromVersionHistoryResultListRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialogInfo(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialogInfo>(temp).ConfigureAwait(false);
        }

        public IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcess dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcess dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchUpdateIndexFieldsResult result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcess dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchUpdateIndexFieldsResult result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchAppendKeywordValues dataToSend) => new BatchUpdateIndexFieldsResult(Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchAppendKeywordValues dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchUpdateIndexFieldsResult result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchAppendKeywordValues dataToSend)
        {
            DocuWare.Platform.ServerClient.IBatchUpdateIndexFieldsResult result = await Obj.PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IBatchUpdateIndexFieldsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IBatchUpdateIndexFieldsResult>(temp).ConfigureAwait(false);
        }

        public IFieldValueStatisticsResult PostToFieldValueStatisticsRelationForFieldValueStatisticsResult(IFieldValueStatisticsExpression dataToSend) => new FieldValueStatisticsResult(Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResult(dataToSend));

        public async Task<DeserializedHttpResponse<IFieldValueStatisticsResult>> PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(IFieldValueStatisticsExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.IFieldValueStatisticsResult result = await Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFieldValueStatisticsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFieldValueStatisticsResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFieldValueStatisticsResult>> PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(CancellationToken cancellationToken, IFieldValueStatisticsExpression dataToSend)
        {
            DocuWare.Platform.ServerClient.IFieldValueStatisticsResult result = await Obj.PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFieldValueStatisticsResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFieldValueStatisticsResult>(temp).ConfigureAwait(false);
        }

		public async Stream PostToReplicationDataRelationForStream(Stream dataToSend) => Obj.PostToReplicationDataRelationForStream(dataToSend);
        public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDataRelationForStreamAsync(Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToReplicationDataRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDataRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToReplicationDataRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToReplicationDeleteDataRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToReplicationDeleteDataRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToReplicationDeleteDataRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.string result = await Obj.PostToSetupReplicationRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToSetupReplicationRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToSetupReplicationRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromReplicationInfoRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromReplicationInfoRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromReplicationInfoRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public ISequenceResult PostToNextSequenceElementRelationForSequenceResult(ISequenceRequest dataToSend) => new SequenceResult(Obj.PostToNextSequenceElementRelationForSequenceResult(dataToSend));

        public async Task<DeserializedHttpResponse<ISequenceResult>> PostToNextSequenceElementRelationForSequenceResultAsync(ISequenceRequest dataToSend)
        {
            DocuWare.Platform.ServerClient.ISequenceResult result = await Obj.PostToNextSequenceElementRelationForSequenceResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISequenceResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISequenceResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISequenceResult>> PostToNextSequenceElementRelationForSequenceResultAsync(CancellationToken cancellationToken, ISequenceRequest dataToSend)
        {
            DocuWare.Platform.ServerClient.ISequenceResult result = await Obj.PostToNextSequenceElementRelationForSequenceResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISequenceResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISequenceResult>(temp).ConfigureAwait(false);
        }

    }
}
