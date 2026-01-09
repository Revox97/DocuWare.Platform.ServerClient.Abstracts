using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Document(DocuWare.Platform.ServerClient.Document obj) : IDocument
    {
        internal DocuWare.Platform.ServerClient.Document Obj { get; } = obj;

        public List<IDocumentIndexField> Fields
        {
            get => Obj.Fields.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.Fields = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
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

        public DateTime CreatedAt
        {
            get => Obj.CreatedAt;
            set => Obj.CreatedAt = value;
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
            get => (IntellixTrust)Obj.IntellixTrust;
            set => Obj.IntellixTrust = (DocuWare.Platform.ServerClient.IntellixTrust)value;
        }

        public VersionManagementStatus VersionStatus
        {
            get => (VersionManagementStatus)Obj.VersionStatus;
            set => Obj.VersionStatus = (DocuWare.Platform.ServerClient.VersionManagementStatus)value;
        }

        public string ExternalContentLocation
        {
            get => Obj.ExternalContentLocation;
            set => Obj.ExternalContentLocation = value;
        }

		public override string ToString() => Obj.ToString();

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDocument GetDocumentFromSelfRelation() => new Document(Obj.GetDocumentFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

		public string DeleteSelfRelation() => Obj.DeleteSelfRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync() => await Obj.DeleteSelfRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteSelfRelationAsync(cancellationToken);

        public IDocument PostToSelfRelationForDocument(string requestedContentType, Stream dataToSend) => new Document(Obj.PostToSelfRelationForDocument(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToSelfRelationForDocumentAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToSelfRelationForDocumentAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PutToContentDivideOperationRelationForDocumentsQueryResult(IContentDivideOperationInfo dataToSend) => new DocumentsQueryResult(Obj.PutToContentDivideOperationRelationForDocumentsQueryResult(((ContentDivideOperationInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PutToContentDivideOperationRelationForDocumentsQueryResultAsync(IContentDivideOperationInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PutToContentDivideOperationRelationForDocumentsQueryResultAsync(((ContentDivideOperationInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PutToContentDivideOperationRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IContentDivideOperationInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PutToContentDivideOperationRelationForDocumentsQueryResultAsync(cancellationToken, ((ContentDivideOperationInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocument PutToClippedDocumentsRelationForDocument(IIntegerList dataToSend) => new Document(Obj.PutToClippedDocumentsRelationForDocument(((IntegerList)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(IIntegerList dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(((IntegerList)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IIntegerList dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToClippedDocumentsRelationForDocumentAsync(cancellationToken, ((IntegerList)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentWordSearchResult GetDocumentWordSearchResultFromPositionsRelation() => new DocumentWordSearchResult(Obj.GetDocumentWordSearchResultFromPositionsRelation());

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromPositionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.GetDocumentWordSearchResultFromPositionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromPositionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.GetDocumentWordSearchResultFromPositionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public IDocumentWordSearchResult PostToPositionsRelationForDocumentWordSearchResult(ISearchPositionQuery dataToSend) => new DocumentWordSearchResult(Obj.PostToPositionsRelationForDocumentWordSearchResult(((SearchPositionQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> PostToPositionsRelationForDocumentWordSearchResultAsync(ISearchPositionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.PostToPositionsRelationForDocumentWordSearchResultAsync(((SearchPositionQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentWordSearchResult>> PostToPositionsRelationForDocumentWordSearchResultAsync(CancellationToken cancellationToken, ISearchPositionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentWordSearchResult> result = await Obj.PostToPositionsRelationForDocumentWordSearchResultAsync(cancellationToken, ((SearchPositionQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentWordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentWordSearchResult>(temp).ConfigureAwait(false);
        }

		public string PostToLockRelationForString(ILockInfo dataToSend) => Obj.PostToLockRelationForString(((LockInfo)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(ILockInfo dataToSend) => await Obj.PostToLockRelationForStringAsync(((LockInfo)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(CancellationToken cancellationToken, ILockInfo dataToSend) => await Obj.PostToLockRelationForStringAsync(cancellationToken, ((LockInfo)dataToSend).Obj);

		public string DeleteLockRelation() => Obj.DeleteLockRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync() => await Obj.DeleteLockRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteLockRelationAsync(cancellationToken);

		public Stream GetStreamFromThumbnailRelation() => Obj.GetStreamFromThumbnailRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync() => await Obj.GetStreamFromThumbnailRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromThumbnailRelationAsync(cancellationToken);

		public Stream GetStreamFromThumbnailWithoutAnnotationRelation() => Obj.GetStreamFromThumbnailWithoutAnnotationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync() => await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromThumbnailWithoutAnnotationRelationAsync(cancellationToken);

		public Stream GetStreamFromAnnotationAsSvgRelation() => Obj.GetStreamFromAnnotationAsSvgRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync() => await Obj.GetStreamFromAnnotationAsSvgRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromAnnotationAsSvgRelationAsync(cancellationToken);

		public Stream GetStreamFromLowQualityImageRelation() => Obj.GetStreamFromLowQualityImageRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync() => await Obj.GetStreamFromLowQualityImageRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromLowQualityImageRelationAsync(cancellationToken);

		public Stream GetStreamFromDeepZoomImageRelation() => Obj.GetStreamFromDeepZoomImageRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync() => await Obj.GetStreamFromDeepZoomImageRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromDeepZoomImageRelationAsync(cancellationToken);

		public Stream GetStreamFromDeepZoomImageWithAnnotationRelation() => Obj.GetStreamFromDeepZoomImageWithAnnotationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync() => await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync(cancellationToken);

		public Stream GetStreamFromResultListIconRelation() => Obj.GetStreamFromResultListIconRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResultListIconRelationAsync() => await Obj.GetStreamFromResultListIconRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromResultListIconRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromResultListIconRelationAsync(cancellationToken);

        public IDocumentIndexFields GetDocumentIndexFieldsFromFieldsRelation() => new DocumentIndexFields(Obj.GetDocumentIndexFieldsFromFieldsRelation());

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.GetDocumentIndexFieldsFromFieldsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public IDocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IDocumentIndexFields dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(((DocumentIndexFields)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(((DocumentIndexFields)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, ((DocumentIndexFields)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public IDocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IUpdateIndexFieldsInfo dataToSend) => new DocumentIndexFields(Obj.PutToFieldsRelationForDocumentIndexFields(((UpdateIndexFieldsInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IUpdateIndexFieldsInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(((UpdateIndexFieldsInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IUpdateIndexFieldsInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentIndexFields> result = await Obj.PutToFieldsRelationForDocumentIndexFieldsAsync(cancellationToken, ((UpdateIndexFieldsInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentIndexFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentIndexFields>(temp).ConfigureAwait(false);
        }

        public ISuggestionFields GetSuggestionFieldsFromSuggestionsRelation() => new SuggestionFields(Obj.GetSuggestionFieldsFromSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionFields> result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionFields> result = await Obj.GetSuggestionFieldsFromSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionFields>(temp).ConfigureAwait(false);
        }

        public ISuggestionTableFields GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation() => new SuggestionTableFields(Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation());

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionTableFields> result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.SuggestionTableFields> result = await Obj.GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new SuggestionTableFields(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISuggestionTableFields>(temp).ConfigureAwait(false);
        }

        public ISections GetSectionsFromSectionsRelation() => new Sections(Obj.GetSectionsFromSectionsRelation());

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Sections> result = await Obj.GetSectionsFromSectionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Sections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISections>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Sections> result = await Obj.GetSectionsFromSectionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Sections(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISections>(temp).ConfigureAwait(false);
        }

        public ISection PostToSectionsRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PostToSectionsRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToSectionsRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToSectionsRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromContentRelation() => Obj.GetStreamFromContentRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync() => await Obj.GetStreamFromContentRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromContentRelationAsync(cancellationToken);

		public Stream PostToContentRelationForStream(IIntegerList dataToSend) => Obj.PostToContentRelationForStream(((IntegerList)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToContentRelationForStreamAsync(IIntegerList dataToSend) => await Obj.PostToContentRelationForStreamAsync(((IntegerList)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToContentRelationForStreamAsync(CancellationToken cancellationToken, IIntegerList dataToSend) => await Obj.PostToContentRelationForStreamAsync(cancellationToken, ((IntegerList)dataToSend).Obj);

		public Stream GetStreamFromFileDownloadRelation() => Obj.GetStreamFromFileDownloadRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync() => await Obj.GetStreamFromFileDownloadRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromFileDownloadRelationAsync(cancellationToken);

		public Stream PostToFileDownloadRelationForStream(IFileDownload dataToSend) => Obj.PostToFileDownloadRelationForStream(((FileDownload)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(IFileDownload dataToSend) => await Obj.PostToFileDownloadRelationForStreamAsync(((FileDownload)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownload dataToSend) => await Obj.PostToFileDownloadRelationForStreamAsync(cancellationToken, ((FileDownload)dataToSend).Obj);

		public Stream GetStreamFromTextAnnotationRelation() => Obj.GetStreamFromTextAnnotationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync() => await Obj.GetStreamFromTextAnnotationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromTextAnnotationRelationAsync(cancellationToken);

		public Stream PostToTextAnnotationRelationForStream(Stream dataToSend) => Obj.PostToTextAnnotationRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(Stream dataToSend) => await Obj.PostToTextAnnotationRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToTextAnnotationRelationForStreamAsync(cancellationToken, dataToSend);

		public string GetStringFromChecksumStatusRelation() => Obj.GetStringFromChecksumStatusRelation();

		public async Task<DeserializedHttpResponse<string>> GetStringFromChecksumStatusRelationAsync() => await Obj.GetStringFromChecksumStatusRelationAsync();

		public async Task<DeserializedHttpResponse<string>> GetStringFromChecksumStatusRelationAsync(CancellationToken cancellationToken) => await Obj.GetStringFromChecksumStatusRelationAsync(cancellationToken);

        public IXmlDSigContentType GetXmlDSigContentTypeFromXmlDSigContentRelation() => new XmlDSigContentType(Obj.GetXmlDSigContentTypeFromXmlDSigContentRelation());

        public async Task<DeserializedHttpResponse<IXmlDSigContentType>> GetXmlDSigContentTypeFromXmlDSigContentRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.XmlDSigContentType> result = await Obj.GetXmlDSigContentTypeFromXmlDSigContentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XmlDSigContentType(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IXmlDSigContentType>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IXmlDSigContentType>> GetXmlDSigContentTypeFromXmlDSigContentRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.XmlDSigContentType> result = await Obj.GetXmlDSigContentTypeFromXmlDSigContentRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XmlDSigContentType(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IXmlDSigContentType>(temp).ConfigureAwait(false);
        }

        public IRights PostToRightsRelationForRights(IRights dataToSend) => new Rights(Obj.PostToRightsRelationForRights(((Rights)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(IRights dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Rights> result = await Obj.PostToRightsRelationForRightsAsync(((Rights)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Rights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRights>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(CancellationToken cancellationToken, IRights dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Rights> result = await Obj.PostToRightsRelationForRightsAsync(cancellationToken, ((Rights)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Rights(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IRights>(temp).ConfigureAwait(false);
        }

        public IDocument PutToProcessDocumentActionRelationForDocument(IDocumentActionInfo dataToSend) => new Document(Obj.PutToProcessDocumentActionRelationForDocument(((DocumentActionInfo)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocument>> PutToProcessDocumentActionRelationForDocumentAsync(IDocumentActionInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToProcessDocumentActionRelationForDocumentAsync(((DocumentActionInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PutToProcessDocumentActionRelationForDocumentAsync(CancellationToken cancellationToken, IDocumentActionInfo dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PutToProcessDocumentActionRelationForDocumentAsync(cancellationToken, ((DocumentActionInfo)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentApplicationProperties GetDocumentApplicationPropertiesFromAppPropertiesRelation() => new DocumentApplicationProperties(Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelation());

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentApplicationProperties> result = await Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentApplicationProperties> result = await Obj.GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public IDocumentApplicationProperties PostToAppPropertiesRelationForDocumentApplicationProperties(IDocumentApplicationProperties dataToSend) => new DocumentApplicationProperties(Obj.PostToAppPropertiesRelationForDocumentApplicationProperties(((DocumentApplicationProperties)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(IDocumentApplicationProperties dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentApplicationProperties> result = await Obj.PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(((DocumentApplicationProperties)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(CancellationToken cancellationToken, IDocumentApplicationProperties dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentApplicationProperties> result = await Obj.PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(cancellationToken, ((DocumentApplicationProperties)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentApplicationProperties(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentApplicationProperties>(temp).ConfigureAwait(false);
        }

        public IDocumentLinks GetDocumentLinksFromDocumentLinksRelation() => new DocumentLinks(Obj.GetDocumentLinksFromDocumentLinksRelation());

        public async Task<DeserializedHttpResponse<IDocumentLinks>> GetDocumentLinksFromDocumentLinksRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentLinks> result = await Obj.GetDocumentLinksFromDocumentLinksRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentLinks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentLinks>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentLinks>> GetDocumentLinksFromDocumentLinksRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentLinks> result = await Obj.GetDocumentLinksFromDocumentLinksRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentLinks(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentLinks>(temp).ConfigureAwait(false);
        }

        public IDocument GetDocumentFromLatestVersionRelation() => new Document(Obj.GetDocumentFromLatestVersionRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromLatestVersionRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromLatestVersionRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromLatestVersionRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromLatestVersionRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult GetDocumentsQueryResultFromVersionHistoryRelation() => new DocumentsQueryResult(Obj.GetDocumentsQueryResultFromVersionHistoryRelation());

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromVersionHistoryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromVersionHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromVersionHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.GetDocumentsQueryResultFromVersionHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public IDocumentsQueryResult PostToVersionHistoryRelationForDocumentsQueryResult(IResultListQuery dataToSend) => new DocumentsQueryResult(Obj.PostToVersionHistoryRelationForDocumentsQueryResult(((ResultListQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToVersionHistoryRelationForDocumentsQueryResultAsync(IResultListQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToVersionHistoryRelationForDocumentsQueryResultAsync(((ResultListQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToVersionHistoryRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IResultListQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentsQueryResult> result = await Obj.PostToVersionHistoryRelationForDocumentsQueryResultAsync(cancellationToken, ((ResultListQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentsQueryResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentsQueryResult>(temp).ConfigureAwait(false);
        }

		public Stream PostToCheckoutDocumentRelationForStream(ICheckOutToFileSystemInfo dataToSend) => Obj.PostToCheckoutDocumentRelationForStream(((CheckOutToFileSystemInfo)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutDocumentRelationForStreamAsync(ICheckOutToFileSystemInfo dataToSend) => await Obj.PostToCheckoutDocumentRelationForStreamAsync(((CheckOutToFileSystemInfo)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutDocumentRelationForStreamAsync(CancellationToken cancellationToken, ICheckOutToFileSystemInfo dataToSend) => await Obj.PostToCheckoutDocumentRelationForStreamAsync(cancellationToken, ((CheckOutToFileSystemInfo)dataToSend).Obj);

		public Stream PostToCheckoutToFileSystemRelationForStream(ICheckOutToFileSystemInfo dataToSend) => Obj.PostToCheckoutToFileSystemRelationForStream(((CheckOutToFileSystemInfo)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutToFileSystemRelationForStreamAsync(ICheckOutToFileSystemInfo dataToSend) => await Obj.PostToCheckoutToFileSystemRelationForStreamAsync(((CheckOutToFileSystemInfo)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToCheckoutToFileSystemRelationForStreamAsync(CancellationToken cancellationToken, ICheckOutToFileSystemInfo dataToSend) => await Obj.PostToCheckoutToFileSystemRelationForStreamAsync(cancellationToken, ((CheckOutToFileSystemInfo)dataToSend).Obj);

        public IDocument PostToCheckInFromFileSystemRelationForDocument(Stream dataToSend) => new Document(Obj.PostToCheckInFromFileSystemRelationForDocument(dataToSend));

        public async Task<DeserializedHttpResponse<IDocument>> PostToCheckInFromFileSystemRelationForDocumentAsync(Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToCheckInFromFileSystemRelationForDocumentAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> PostToCheckInFromFileSystemRelationForDocumentAsync(CancellationToken cancellationToken, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.PostToCheckInFromFileSystemRelationForDocumentAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

		public Stream PostToDownloadAsArchiveRelationForStream(IExportSettings dataToSend) => Obj.PostToDownloadAsArchiveRelationForStream(((ExportSettings)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToDownloadAsArchiveRelationForStreamAsync(IExportSettings dataToSend) => await Obj.PostToDownloadAsArchiveRelationForStreamAsync(((ExportSettings)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToDownloadAsArchiveRelationForStreamAsync(CancellationToken cancellationToken, IExportSettings dataToSend) => await Obj.PostToDownloadAsArchiveRelationForStreamAsync(cancellationToken, ((ExportSettings)dataToSend).Obj);

        public IDocumentAnnotations GetDocumentAnnotationsFromAnnotationRelation() => new DocumentAnnotations(Obj.GetDocumentAnnotationsFromAnnotationRelation());

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> GetDocumentAnnotationsFromAnnotationRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAnnotations> result = await Obj.GetDocumentAnnotationsFromAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> GetDocumentAnnotationsFromAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAnnotations> result = await Obj.GetDocumentAnnotationsFromAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public IDocumentAnnotations PostToAnnotationRelationForDocumentAnnotations(IDocumentAnnotationsPlacement dataToSend) => new DocumentAnnotations(Obj.PostToAnnotationRelationForDocumentAnnotations(((DocumentAnnotationsPlacement)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> PostToAnnotationRelationForDocumentAnnotationsAsync(IDocumentAnnotationsPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAnnotations> result = await Obj.PostToAnnotationRelationForDocumentAnnotationsAsync(((DocumentAnnotationsPlacement)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAnnotations>> PostToAnnotationRelationForDocumentAnnotationsAsync(CancellationToken cancellationToken, IDocumentAnnotationsPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAnnotations> result = await Obj.PostToAnnotationRelationForDocumentAnnotationsAsync(cancellationToken, ((DocumentAnnotationsPlacement)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAnnotations(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAnnotations>(temp).ConfigureAwait(false);
        }

        public IWorkflowDocumentHistory GetWorkflowDocumentHistoryFromWorkflowHistoryRelation() => new WorkflowDocumentHistory(Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelation());

        public async Task<DeserializedHttpResponse<IWorkflowDocumentHistory>> GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowDocumentHistory> result = await Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowDocumentHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowDocumentHistory>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWorkflowDocumentHistory>> GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WorkflowDocumentHistory> result = await Obj.GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WorkflowDocumentHistory(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWorkflowDocumentHistory>(temp).ConfigureAwait(false);
        }

        public IDocumentAuditInformation GetDocumentAuditInformationFromAuditInformationRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromAuditInformationRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromAuditInformationRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromAuditInformationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromAuditInformationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromAuditInformationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public IDocumentAuditInformation PostToAuditInformationRelationForDocumentAuditInformation(IDocumentAuditQuery dataToSend) => new DocumentAuditInformation(Obj.PostToAuditInformationRelationForDocumentAuditInformation(((DocumentAuditQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> PostToAuditInformationRelationForDocumentAuditInformationAsync(IDocumentAuditQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.PostToAuditInformationRelationForDocumentAuditInformationAsync(((DocumentAuditQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> PostToAuditInformationRelationForDocumentAuditInformationAsync(CancellationToken cancellationToken, IDocumentAuditQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.PostToAuditInformationRelationForDocumentAuditInformationAsync(cancellationToken, ((DocumentAuditQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }
    }
}
