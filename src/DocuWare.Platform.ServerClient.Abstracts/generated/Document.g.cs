using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Document(SDK.Document obj) : IDocument
    {
        internal SDK.Document Obj { get; } = obj;

        public string MediaType => Obj.MediaType;

        public IDocumentIndexField Item
        {
            get => new DocumentIndexField(Obj.Item);
            set => Obj.Item = ((DocumentIndexField)value).Obj;
        }

        public List<IDocumentIndexField> Fields
        {
            get => Obj.Fields.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.Fields = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
        }

        public IChecksumInfo ChecksumInfo
        {
            get => new ChecksumInfo(Obj.ChecksumInfo);
            set => Obj.ChecksumInfo = ((ChecksumInfo)value).Obj;
        }

        public List<ISuggestionField> Suggestions
        {
            get => Obj.Suggestions.Select(x => new SuggestionField(x) as ISuggestionField).ToList();
            set => Obj.Suggestions = value.Select(x => ((SuggestionField)x).Obj).ToList();
        }

        public List<ISuggestionTableField> TableFieldSuggestions
        {
            get => Obj.TableFieldSuggestions.Select(x => new SuggestionTableField(x) as ISuggestionTableField).ToList();
            set => Obj.TableFieldSuggestions = value.Select(x => ((SuggestionTableField)x).Obj).ToList();
        }

        public IDocumentFlags Flags
        {
            get => new DocumentFlags(Obj.Flags);
            set => Obj.Flags = ((DocumentFlags)value).Obj;
        }

        public IDocumentVersion Version
        {
            get => new DocumentVersion(Obj.Version);
            set => Obj.Version = ((DocumentVersion)value).Obj;
        }

        public List<IDocumentContent> TextShot
        {
            get => Obj.TextShot.Select(x => new DocumentContent(x) as IDocumentContent).ToList();
            set => Obj.TextShot = value.Select(x => ((DocumentContent)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public List<ISection> Sections
        {
            get => Obj.Sections.Select(x => new Section(x) as ISection).ToList();
            set => Obj.Sections = value.Select(x => ((Section)x).Obj).ToList();
        }

        public XElementWrapper Preview
        {
            get => Obj.Preview;
            set => Obj.Preview = value;
        }

        public string ContentType
        {
            get => Obj.ContentType;
            set => Obj.ContentType = value;
        }

        public IUploadedFileChunk FileChunk
        {
            get => new UploadedFileChunk(Obj.FileChunk);
            set => Obj.FileChunk = ((UploadedFileChunk)value).Obj;
        }

        public List<IDocumentApplicationProperty> ApplicationProperties
        {
            get => Obj.ApplicationProperties.Select(x => new DocumentApplicationProperty(x) as IDocumentApplicationProperty).ToList();
            set => Obj.ApplicationProperties = value.Select(x => ((DocumentApplicationProperty)x).Obj).ToList();
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

        public bool HaveMoreTotalPages
        {
            get => Obj.HaveMoreTotalPages;
            set => Obj.HaveMoreTotalPages = value;
        }

        public bool HasTextAnnotation
        {
            get => Obj.HasTextAnnotation;
            set => Obj.HasTextAnnotation = value;
        }

        public bool HasXmlDigitalSignatures
        {
            get => Obj.HasXmlDigitalSignatures;
            set => Obj.HasXmlDigitalSignatures = value;
        }

        public bool AnnotationsPreview
        {
            get => Obj.AnnotationsPreview;
            set => Obj.AnnotationsPreview = value;
        }

        public int TotalPages
        {
            get => Obj.TotalPages;
            set => Obj.TotalPages = value;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string Title
        {
            get => Obj.Title;
            set => Obj.Title = value;
        }

        public DateTime LastModified
        {
            get => Obj.LastModified;
            set => Obj.LastModified = value;
        }

        public bool LastModifiedSpecified
        {
            get => Obj.LastModifiedSpecified;
            set => Obj.LastModifiedSpecified = value;
        }

        public DateTime CreatedAt
        {
            get => Obj.CreatedAt;
            set => Obj.CreatedAt = value;
        }

        public bool CreatedAtSpecified
        {
            get => Obj.CreatedAtSpecified;
            set => Obj.CreatedAtSpecified = value;
        }

        public long FileSize
        {
            get => Obj.FileSize;
            set => Obj.FileSize = value;
        }

        public int SectionCount
        {
            get => Obj.SectionCount;
            set => Obj.SectionCount = value;
        }

        public DocuWare.Platform.ServerClient.IntellixTrust IntellixTrust
        {
            get => Obj.IntellixTrust;
            set => Obj.IntellixTrust = value;
        }

        public DocuWare.Platform.ServerClient.VersionManagementStatus VersionStatus
        {
            get => Obj.VersionStatus;
            set => Obj.VersionStatus = value;
        }

        public string ExternalContentLocation
        {
            get => Obj.ExternalContentLocation;
            set => Obj.ExternalContentLocation = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string ContentDivideOperationRelationLink => Obj.ContentDivideOperationRelationLink;

        public string ClippedDocumentsRelationLink => Obj.ClippedDocumentsRelationLink;

        public string UnclipRelationLink => Obj.UnclipRelationLink;

        public string PositionsRelationLink => Obj.PositionsRelationLink;

        public string LockRelationLink => Obj.LockRelationLink;

        public string ThumbnailRelationLink => Obj.ThumbnailRelationLink;

        public string ThumbnailWithoutAnnotationRelationLink => Obj.ThumbnailWithoutAnnotationRelationLink;

        public string AnnotationAsSvgRelationLink => Obj.AnnotationAsSvgRelationLink;

        public string LowQualityImageRelationLink => Obj.LowQualityImageRelationLink;

        public string DeepZoomImageRelationLink => Obj.DeepZoomImageRelationLink;

        public string DeepZoomImageWithAnnotationRelationLink => Obj.DeepZoomImageWithAnnotationRelationLink;

        public string ResultListIconRelationLink => Obj.ResultListIconRelationLink;

        public string FieldsRelationLink => Obj.FieldsRelationLink;

        public string SuggestionsRelationLink => Obj.SuggestionsRelationLink;

        public string TableFieldsSuggestionsRelationLink => Obj.TableFieldsSuggestionsRelationLink;

        public string SectionsRelationLink => Obj.SectionsRelationLink;

        public string ContentRelationLink => Obj.ContentRelationLink;

        public string FileDownloadRelationLink => Obj.FileDownloadRelationLink;

        public string TextAnnotationRelationLink => Obj.TextAnnotationRelationLink;

        public string ChecksumStatusRelationLink => Obj.ChecksumStatusRelationLink;

        public string XmlDSigContentRelationLink => Obj.XmlDSigContentRelationLink;

        public string RightsRelationLink => Obj.RightsRelationLink;

        public string ProcessDocumentActionRelationLink => Obj.ProcessDocumentActionRelationLink;

        public string AppPropertiesRelationLink => Obj.AppPropertiesRelationLink;

        public string DocumentLinksRelationLink => Obj.DocumentLinksRelationLink;

        public string LatestVersionRelationLink => Obj.LatestVersionRelationLink;

        public string VersionHistoryRelationLink => Obj.VersionHistoryRelationLink;

        public string IntellixRelationLink => Obj.IntellixRelationLink;

        public string CheckoutDocumentRelationLink => Obj.CheckoutDocumentRelationLink;

        public string CheckoutToFileSystemRelationLink => Obj.CheckoutToFileSystemRelationLink;

        public string CheckInFromFileSystemRelationLink => Obj.CheckInFromFileSystemRelationLink;

        public string DownloadAsArchiveRelationLink => Obj.DownloadAsArchiveRelationLink;

        public string AnnotationRelationLink => Obj.AnnotationRelationLink;

        public string WorkflowHistoryRelationLink => Obj.WorkflowHistoryRelationLink;

        public string AuditInformationRelationLink => Obj.AuditInformationRelationLink;

		public async string ToString() => Obj.ToString();

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public Document GetDocumentFromSelfRelation() => new Document(Obj.GetDocumentFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

		public async string DeleteSelfRelation() => Obj.DeleteSelfRelation();

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public Document PostToSelfRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToSelfRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToSelfRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToSelfRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PutToContentDivideOperationRelationForDocumentsQueryResult(IContentDivideOperationInfo dataToSend) => new DocumentsQueryResult(Obj.PutToContentDivideOperationRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PutToContentDivideOperationRelationForDocumentsQueryResultAsync(IContentDivideOperationInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PutToContentDivideOperationRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PutToContentDivideOperationRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IContentDivideOperationInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PutToContentDivideOperationRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public Document PutToClippedDocumentsRelationForDocument(IIntegerList dataToSend) => new Document(Obj.PutToClippedDocumentsRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(IIntegerList dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IIntegerList dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public DocumentWordSearchResult GetDocumentWordSearchResultFromPositionsRelation() => new DocumentWordSearchResult(Obj.GetDocumentWordSearchResultFromPositionsRelation());

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromPositionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.GetDocumentWordSearchResultFromPositionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromPositionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.GetDocumentWordSearchResultFromPositionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public DocumentWordSearchResult PostToPositionsRelationForDocumentWordSearchResult(ISearchPositionQuery dataToSend) => new DocumentWordSearchResult(Obj.PostToPositionsRelationForDocumentWordSearchResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> PostToPositionsRelationForDocumentWordSearchResultAsync(ISearchPositionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.PostToPositionsRelationForDocumentWordSearchResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> PostToPositionsRelationForDocumentWordSearchResultAsync(CancellationToken cancellationToken, ISearchPositionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.PostToPositionsRelationForDocumentWordSearchResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

		public async string PostToLockRelationForString(ILockInfo dataToSend) => Obj.PostToLockRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(ILockInfo dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToLockRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(CancellationToken cancellationToken, ILockInfo dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PostToLockRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

		public async string DeleteLockRelation() => Obj.DeleteLockRelation();

        public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteLockRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.DeleteLockRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromThumbnailRelation() => Obj.GetStreamFromThumbnailRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromThumbnailRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromThumbnailRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromThumbnailWithoutAnnotationRelation() => Obj.GetStreamFromThumbnailWithoutAnnotationRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromAnnotationAsSvgRelation() => Obj.GetStreamFromAnnotationAsSvgRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromAnnotationAsSvgRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromAnnotationAsSvgRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromLowQualityImageRelation() => Obj.GetStreamFromLowQualityImageRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLowQualityImageRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLowQualityImageRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromDeepZoomImageRelation() => Obj.GetStreamFromDeepZoomImageRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromDeepZoomImageRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromDeepZoomImageRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromDeepZoomImageWithAnnotationRelation() => Obj.GetStreamFromDeepZoomImageWithAnnotationRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromResultListIconRelation() => Obj.GetStreamFromResultListIconRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResultListIconRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromResultListIconRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResultListIconRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromResultListIconRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public DocumentIndexFields GetDocumentIndexFieldsFromFieldsRelation() => new DocumentIndexFields(Obj.GetDocumentIndexFieldsFromFieldsRelation());

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public DocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IDocumentIndexFields dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public DocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IUpdateIndexFieldsInfo dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IUpdateIndexFieldsInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IUpdateIndexFieldsInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public SuggestionFields GetSuggestionFieldsFromSuggestionsRelation() => new SuggestionFields(Obj.GetSuggestionFieldsFromSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionFields> result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SuggestionFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionFields> result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SuggestionFields>(temp).ConfigureAwait(false);
        }

        public SuggestionTableFields GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation() => new SuggestionTableFields(Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionTableFields> result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionTableFields> result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<SuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public Sections GetSectionsFromSectionsRelation() => new Sections(Obj.GetSectionsFromSectionsRelation());

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Sections> result = await Obj.GetSectionsFromSectionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Sections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Sections>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Sections> result = await Obj.GetSectionsFromSectionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Sections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Sections>(temp).ConfigureAwait(false);
        }

        public Section PostToSectionsRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PostToSectionsRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToSectionsRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToSectionsRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromContentRelation() => Obj.GetStreamFromContentRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromContentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromContentRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToContentRelationForStream(IIntegerList dataToSend) => Obj.PostToContentRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToContentRelationForStreamAsync(IIntegerList dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToContentRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToContentRelationForStreamAsync(CancellationToken cancellationToken, IIntegerList dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToContentRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromFileDownloadRelation() => Obj.GetStreamFromFileDownloadRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromFileDownloadRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromFileDownloadRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToFileDownloadRelationForStream(IFileDownload dataToSend) => Obj.PostToFileDownloadRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(IFileDownload dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToFileDownloadRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownload dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToFileDownloadRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromTextAnnotationRelation() => Obj.GetStreamFromTextAnnotationRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromTextAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromTextAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToTextAnnotationRelationForStream(Stream dataToSend) => Obj.PostToTextAnnotationRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToTextAnnotationRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToTextAnnotationRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async string GetStringFromChecksumStatusRelation() => Obj.GetStringFromChecksumStatusRelation();

        public async Task<DeserializedHttpResponse<string>> GetStringFromChecksumStatusRelationAsync()
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromChecksumStatusRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> GetStringFromChecksumStatusRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<string> result = await Obj.GetStringFromChecksumStatusRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public XmlDSigContentType GetXmlDSigContentTypeFromXmlDSigContentRelation() => new XmlDSigContentType(Obj.GetXmlDSigContentTypeFromXmlDSigContentRelation());

        public async Task<DeserializedHttpResponse<IXmlDSigContentType>> GetXmlDSigContentTypeFromXmlDSigContentRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.XmlDSigContentType> result = await Obj.GetXmlDSigContentTypeFromXmlDSigContentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XmlDSigContentType(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XmlDSigContentType>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IXmlDSigContentType>> GetXmlDSigContentTypeFromXmlDSigContentRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.XmlDSigContentType> result = await Obj.GetXmlDSigContentTypeFromXmlDSigContentRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XmlDSigContentType(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XmlDSigContentType>(temp).ConfigureAwait(false);
        }

        public Rights PostToRightsRelationForRights(IRights dataToSend) => new Rights(Obj.PostToRightsRelationForRights(dataToSend));

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(IRights dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Rights> result = await Obj.PostToRightsRelationForRightsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Rights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Rights>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(CancellationToken cancellationToken, IRights dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Rights> result = await Obj.PostToRightsRelationForRightsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Rights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Rights>(temp).ConfigureAwait(false);
        }

        public Document PutToProcessDocumentActionRelationForDocument(IDocumentActionInfo dataToSend) => new Document(Obj.PutToProcessDocumentActionRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PutToProcessDocumentActionRelationForDocumentAsync(IDocumentActionInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToProcessDocumentActionRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToProcessDocumentActionRelationForDocumentAsync(CancellationToken cancellationToken, IDocumentActionInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToProcessDocumentActionRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public DocumentApplicationProperties GetDocumentApplicationPropertiesFromAppPropertiesRelation() => new DocumentApplicationProperties(Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelation());

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentApplicationProperties> result = await Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentApplicationProperties> result = await Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public DocumentApplicationProperties PostToAppPropertiesRelationForDocumentApplicationProperties(IDocumentApplicationProperties dataToSend) => new DocumentApplicationProperties(Obj.PostToAppPropertiesRelationForDocumentApplicationProperties(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(IDocumentApplicationProperties dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentApplicationProperties> result = await Obj.PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(CancellationToken cancellationToken, IDocumentApplicationProperties dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentApplicationProperties> result = await Obj.PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public DocumentLinks GetDocumentLinksFromDocumentLinksRelation() => new DocumentLinks(Obj.GetDocumentLinksFromDocumentLinksRelation());

        public async Task<DeserializedHttpResponse<IDocumentLinks>> GetDocumentLinksFromDocumentLinksRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentLinks> result = await Obj.GetDocumentLinksFromDocumentLinksRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentLinks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentLinks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentLinks>> GetDocumentLinksFromDocumentLinksRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentLinks> result = await Obj.GetDocumentLinksFromDocumentLinksRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentLinks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentLinks>(temp).ConfigureAwait(false);
        }

        public Document GetDocumentFromLatestVersionRelation() => new Document(Obj.GetDocumentFromLatestVersionRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromLatestVersionRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromLatestVersionRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromLatestVersionRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromLatestVersionRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult GetDocumentsQueryResultFromVersionHistoryRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromVersionHistoryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromVersionHistoryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromVersionHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromVersionHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromVersionHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public DocumentsQueryResult PostToVersionHistoryRelationForDocumentsQueryResult(IResultListQuery dataToSend) => new DocumentsQueryResult(Obj.PostToVersionHistoryRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToVersionHistoryRelationForDocumentsQueryResultAsync(IResultListQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToVersionHistoryRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToVersionHistoryRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IResultListQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToVersionHistoryRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentsQueryResult>(temp).ConfigureAwait(false);
        }

		public async Stream PostToCheckoutDocumentRelationForStream(ICheckOutToFileSystemInfo dataToSend) => Obj.PostToCheckoutDocumentRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutDocumentRelationForStreamAsync(ICheckOutToFileSystemInfo dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToCheckoutDocumentRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutDocumentRelationForStreamAsync(CancellationToken cancellationToken, ICheckOutToFileSystemInfo dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToCheckoutDocumentRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream PostToCheckoutToFileSystemRelationForStream(ICheckOutToFileSystemInfo dataToSend) => Obj.PostToCheckoutToFileSystemRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutToFileSystemRelationForStreamAsync(ICheckOutToFileSystemInfo dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToCheckoutToFileSystemRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutToFileSystemRelationForStreamAsync(CancellationToken cancellationToken, ICheckOutToFileSystemInfo dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToCheckoutToFileSystemRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public Document PostToCheckInFromFileSystemRelationForDocument(Stream dataToSend) => new Document(Obj.PostToCheckInFromFileSystemRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToCheckInFromFileSystemRelationForDocumentAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToCheckInFromFileSystemRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToCheckInFromFileSystemRelationForDocumentAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToCheckInFromFileSystemRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

		public async Stream PostToDownloadAsArchiveRelationForStream(IExportSettings dataToSend) => Obj.PostToDownloadAsArchiveRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToDownloadAsArchiveRelationForStreamAsync(IExportSettings dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToDownloadAsArchiveRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToDownloadAsArchiveRelationForStreamAsync(CancellationToken cancellationToken, IExportSettings dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToDownloadAsArchiveRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public DocumentAnnotations GetDocumentAnnotationsFromAnnotationRelation() => new DocumentAnnotations(Obj.GetDocumentAnnotationsFromAnnotationRelation());

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> GetDocumentAnnotationsFromAnnotationRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAnnotations> result = await Obj.GetDocumentAnnotationsFromAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> GetDocumentAnnotationsFromAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAnnotations> result = await Obj.GetDocumentAnnotationsFromAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public DocumentAnnotations PostToAnnotationRelationForDocumentAnnotations(IDocumentAnnotationsPlacement dataToSend) => new DocumentAnnotations(Obj.PostToAnnotationRelationForDocumentAnnotations(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> PostToAnnotationRelationForDocumentAnnotationsAsync(IDocumentAnnotationsPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAnnotations> result = await Obj.PostToAnnotationRelationForDocumentAnnotationsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> PostToAnnotationRelationForDocumentAnnotationsAsync(CancellationToken cancellationToken, IDocumentAnnotationsPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAnnotations> result = await Obj.PostToAnnotationRelationForDocumentAnnotationsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public WorkflowDocumentHistory GetWorkflowDocumentHistoryFromWorkflowHistoryRelation() => new WorkflowDocumentHistory(Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelation());

        public async Task<DeserializedHttpResponse<IWorkflowDocumentHistory>> GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowDocumentHistory> result = await Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowDocumentHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowDocumentHistory>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowDocumentHistory>> GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowDocumentHistory> result = await Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowDocumentHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WorkflowDocumentHistory>(temp).ConfigureAwait(false);
        }

        public DocumentAuditInformation GetDocumentAuditInformationFromAuditInformationRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromAuditInformationRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromAuditInformationRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromAuditInformationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromAuditInformationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromAuditInformationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public DocumentAuditInformation PostToAuditInformationRelationForDocumentAuditInformation(IDocumentAuditQuery dataToSend) => new DocumentAuditInformation(Obj.PostToAuditInformationRelationForDocumentAuditInformation(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> PostToAuditInformationRelationForDocumentAuditInformationAsync(IDocumentAuditQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.PostToAuditInformationRelationForDocumentAuditInformationAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> PostToAuditInformationRelationForDocumentAuditInformationAsync(CancellationToken cancellationToken, IDocumentAuditQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.PostToAuditInformationRelationForDocumentAuditInformationAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }
    }
}
