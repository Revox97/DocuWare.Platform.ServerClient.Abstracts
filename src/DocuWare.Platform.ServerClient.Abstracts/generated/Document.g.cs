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

		public IntellixTrust IntellixTrust
		{
			get => new ntellixTrust(Obj.IntellixTrust);
			set => Obj.IntellixTrust = ((ntellixTrust)value).Obj;
		}

		public VersionManagementStatus VersionStatus
		{
			get => new ersionManagementStatus(Obj.VersionStatus);
			set => Obj.VersionStatus = ((ersionManagementStatus)value).Obj;
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
        public IDocument GetDocumentFromSelfRelation() => new Document(Obj.GetDocumentFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.GetDocumentFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.GetDocumentFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

		public async string DeleteSelfRelation() => Obj.DeleteSelfRelation();
        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync()
        {
            DocuWare.Platform.ServerClient.string result = await Obj.DeleteSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.DeleteSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public IDocument PostToSelfRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToSelfRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToSelfRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToSelfRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PutToContentDivideOperationRelationForDocumentsQueryResult(IContentDivideOperationInfo dataToSend) => new DocumentsQueryResult(Obj.PutToContentDivideOperationRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PutToContentDivideOperationRelationForDocumentsQueryResultAsync(IContentDivideOperationInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PutToContentDivideOperationRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PutToContentDivideOperationRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IContentDivideOperationInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PutToContentDivideOperationRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocument PutToClippedDocumentsRelationForDocument(IIntegerList dataToSend) => new Document(Obj.PutToClippedDocumentsRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(IIntegerList dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IIntegerList dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentWordSearchResult GetDocumentWordSearchResultFromPositionsRelation() => new DocumentWordSearchResult(Obj.GetDocumentWordSearchResultFromPositionsRelation());

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromPositionsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentWordSearchResult result = await Obj.GetDocumentWordSearchResultFromPositionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromPositionsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentWordSearchResult result = await Obj.GetDocumentWordSearchResultFromPositionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public IDocumentWordSearchResult PostToPositionsRelationForDocumentWordSearchResult(ISearchPositionQuery dataToSend) => new DocumentWordSearchResult(Obj.PostToPositionsRelationForDocumentWordSearchResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> PostToPositionsRelationForDocumentWordSearchResultAsync(ISearchPositionQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentWordSearchResult result = await Obj.PostToPositionsRelationForDocumentWordSearchResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> PostToPositionsRelationForDocumentWordSearchResultAsync(CancellationToken cancellationToken, ISearchPositionQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentWordSearchResult result = await Obj.PostToPositionsRelationForDocumentWordSearchResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

		public async string PostToLockRelationForString(ILockInfo dataToSend) => Obj.PostToLockRelationForString(dataToSend);
        public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(ILockInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToLockRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(CancellationToken cancellationToken, ILockInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.PostToLockRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.string result = await Obj.DeleteLockRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.DeleteLockRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromThumbnailRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromThumbnailRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromAnnotationAsSvgRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromAnnotationAsSvgRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromLowQualityImageRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromLowQualityImageRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromDeepZoomImageRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromDeepZoomImageRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromResultListIconRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResultListIconRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromResultListIconRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public IDocumentIndexFields GetDocumentIndexFieldsFromFieldsRelation() => new DocumentIndexFields(Obj.GetDocumentIndexFieldsFromFieldsRelation());

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentIndexFields result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentIndexFields result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public IDocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IDocumentIndexFields dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IDocumentIndexFields dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentIndexFields result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentIndexFields result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public IDocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IUpdateIndexFieldsInfo dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IUpdateIndexFieldsInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentIndexFields result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IUpdateIndexFieldsInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentIndexFields result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public ISuggestionFields GetSuggestionFieldsFromSuggestionsRelation() => new SuggestionFields(Obj.GetSuggestionFieldsFromSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISuggestionFields result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISuggestionFields result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionFields>(temp).ConfigureAwait(false);
        }

        public ISuggestionTableFields GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation() => new SuggestionTableFields(Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISuggestionTableFields result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISuggestionTableFields result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public ISections GetSectionsFromSectionsRelation() => new Sections(Obj.GetSectionsFromSectionsRelation());

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync()
        {
            DocuWare.Platform.ServerClient.ISections result = await Obj.GetSectionsFromSectionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISections>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.ISections result = await Obj.GetSectionsFromSectionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISections>(temp).ConfigureAwait(false);
        }

        public ISection PostToSectionsRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PostToSectionsRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.ISection result = await Obj.PostToSectionsRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISection(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.ISection result = await Obj.PostToSectionsRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new ISection(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromContentRelation() => Obj.GetStreamFromContentRelation();
        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync()
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromContentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromContentRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToContentRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToContentRelationForStreamAsync(CancellationToken cancellationToken, IIntegerList dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToContentRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromFileDownloadRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromFileDownloadRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToFileDownloadRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownload dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToFileDownloadRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromTextAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromTextAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToTextAnnotationRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToTextAnnotationRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.string result = await Obj.GetStringFromChecksumStatusRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> GetStringFromChecksumStatusRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.string result = await Obj.GetStringFromChecksumStatusRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public IXmlDSigContentType GetXmlDSigContentTypeFromXmlDSigContentRelation() => new XmlDSigContentType(Obj.GetXmlDSigContentTypeFromXmlDSigContentRelation());

        public async Task<DeserializedHttpResponse<IXmlDSigContentType>> GetXmlDSigContentTypeFromXmlDSigContentRelationAsync()
        {
            DocuWare.Platform.ServerClient.IXmlDSigContentType result = await Obj.GetXmlDSigContentTypeFromXmlDSigContentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IXmlDSigContentType(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IXmlDSigContentType>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IXmlDSigContentType>> GetXmlDSigContentTypeFromXmlDSigContentRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IXmlDSigContentType result = await Obj.GetXmlDSigContentTypeFromXmlDSigContentRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IXmlDSigContentType(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IXmlDSigContentType>(temp).ConfigureAwait(false);
        }

        public IRights PostToRightsRelationForRights(IRights dataToSend) => new Rights(Obj.PostToRightsRelationForRights(dataToSend));

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(IRights dataToSend)
        {
            DocuWare.Platform.ServerClient.IRights result = await Obj.PostToRightsRelationForRightsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRights>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(CancellationToken cancellationToken, IRights dataToSend)
        {
            DocuWare.Platform.ServerClient.IRights result = await Obj.PostToRightsRelationForRightsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IRights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRights>(temp).ConfigureAwait(false);
        }

        public IDocument PutToProcessDocumentActionRelationForDocument(IDocumentActionInfo dataToSend) => new Document(Obj.PutToProcessDocumentActionRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PutToProcessDocumentActionRelationForDocumentAsync(IDocumentActionInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PutToProcessDocumentActionRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToProcessDocumentActionRelationForDocumentAsync(CancellationToken cancellationToken, IDocumentActionInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PutToProcessDocumentActionRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentApplicationProperties GetDocumentApplicationPropertiesFromAppPropertiesRelation() => new DocumentApplicationProperties(Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelation());

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentApplicationProperties result = await Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentApplicationProperties result = await Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public IDocumentApplicationProperties PostToAppPropertiesRelationForDocumentApplicationProperties(IDocumentApplicationProperties dataToSend) => new DocumentApplicationProperties(Obj.PostToAppPropertiesRelationForDocumentApplicationProperties(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(IDocumentApplicationProperties dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentApplicationProperties result = await Obj.PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(CancellationToken cancellationToken, IDocumentApplicationProperties dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentApplicationProperties result = await Obj.PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public IDocumentLinks GetDocumentLinksFromDocumentLinksRelation() => new DocumentLinks(Obj.GetDocumentLinksFromDocumentLinksRelation());

        public async Task<DeserializedHttpResponse<IDocumentLinks>> GetDocumentLinksFromDocumentLinksRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentLinks result = await Obj.GetDocumentLinksFromDocumentLinksRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentLinks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentLinks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentLinks>> GetDocumentLinksFromDocumentLinksRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentLinks result = await Obj.GetDocumentLinksFromDocumentLinksRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentLinks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentLinks>(temp).ConfigureAwait(false);
        }

        public IDocument GetDocumentFromLatestVersionRelation() => new Document(Obj.GetDocumentFromLatestVersionRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromLatestVersionRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.GetDocumentFromLatestVersionRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromLatestVersionRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.GetDocumentFromLatestVersionRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromVersionHistoryRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromVersionHistoryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromVersionHistoryRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromVersionHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromVersionHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.GetDocumentsQueryResultFromVersionHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToVersionHistoryRelationForDocumentsQueryResult(IResultListQuery dataToSend) => new DocumentsQueryResult(Obj.PostToVersionHistoryRelationForDocumentsQueryResult(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToVersionHistoryRelationForDocumentsQueryResultAsync(IResultListQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToVersionHistoryRelationForDocumentsQueryResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToVersionHistoryRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IResultListQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentsQueryResult result = await Obj.PostToVersionHistoryRelationForDocumentsQueryResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

		public async Stream PostToCheckoutDocumentRelationForStream(ICheckOutToFileSystemInfo dataToSend) => Obj.PostToCheckoutDocumentRelationForStream(dataToSend);
        public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutDocumentRelationForStreamAsync(ICheckOutToFileSystemInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToCheckoutDocumentRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutDocumentRelationForStreamAsync(CancellationToken cancellationToken, ICheckOutToFileSystemInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToCheckoutDocumentRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToCheckoutToFileSystemRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutToFileSystemRelationForStreamAsync(CancellationToken cancellationToken, ICheckOutToFileSystemInfo dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToCheckoutToFileSystemRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public IDocument PostToCheckInFromFileSystemRelationForDocument(Stream dataToSend) => new Document(Obj.PostToCheckInFromFileSystemRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToCheckInFromFileSystemRelationForDocumentAsync(Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToCheckInFromFileSystemRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToCheckInFromFileSystemRelationForDocumentAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.PostToCheckInFromFileSystemRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

		public async Stream PostToDownloadAsArchiveRelationForStream(IExportSettings dataToSend) => Obj.PostToDownloadAsArchiveRelationForStream(dataToSend);
        public async Task<DeserializedHttpResponse<Stream>> PostToDownloadAsArchiveRelationForStreamAsync(IExportSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToDownloadAsArchiveRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToDownloadAsArchiveRelationForStreamAsync(CancellationToken cancellationToken, IExportSettings dataToSend)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.PostToDownloadAsArchiveRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public IDocumentAnnotations GetDocumentAnnotationsFromAnnotationRelation() => new DocumentAnnotations(Obj.GetDocumentAnnotationsFromAnnotationRelation());

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> GetDocumentAnnotationsFromAnnotationRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentAnnotations result = await Obj.GetDocumentAnnotationsFromAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> GetDocumentAnnotationsFromAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentAnnotations result = await Obj.GetDocumentAnnotationsFromAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public IDocumentAnnotations PostToAnnotationRelationForDocumentAnnotations(IDocumentAnnotationsPlacement dataToSend) => new DocumentAnnotations(Obj.PostToAnnotationRelationForDocumentAnnotations(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> PostToAnnotationRelationForDocumentAnnotationsAsync(IDocumentAnnotationsPlacement dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentAnnotations result = await Obj.PostToAnnotationRelationForDocumentAnnotationsAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> PostToAnnotationRelationForDocumentAnnotationsAsync(CancellationToken cancellationToken, IDocumentAnnotationsPlacement dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentAnnotations result = await Obj.PostToAnnotationRelationForDocumentAnnotationsAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public IWorkflowDocumentHistory GetWorkflowDocumentHistoryFromWorkflowHistoryRelation() => new WorkflowDocumentHistory(Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelation());

        public async Task<DeserializedHttpResponse<IWorkflowDocumentHistory>> GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync()
        {
            DocuWare.Platform.ServerClient.IWorkflowDocumentHistory result = await Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowDocumentHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowDocumentHistory>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowDocumentHistory>> GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IWorkflowDocumentHistory result = await Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IWorkflowDocumentHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowDocumentHistory>(temp).ConfigureAwait(false);
        }

        public IDocumentAuditInformation GetDocumentAuditInformationFromAuditInformationRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromAuditInformationRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromAuditInformationRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.GetDocumentAuditInformationFromAuditInformationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromAuditInformationRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.GetDocumentAuditInformationFromAuditInformationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public IDocumentAuditInformation PostToAuditInformationRelationForDocumentAuditInformation(IDocumentAuditQuery dataToSend) => new DocumentAuditInformation(Obj.PostToAuditInformationRelationForDocumentAuditInformation(dataToSend));

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> PostToAuditInformationRelationForDocumentAuditInformationAsync(IDocumentAuditQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.PostToAuditInformationRelationForDocumentAuditInformationAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> PostToAuditInformationRelationForDocumentAuditInformationAsync(CancellationToken cancellationToken, IDocumentAuditQuery dataToSend)
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.PostToAuditInformationRelationForDocumentAuditInformationAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

    }
}
