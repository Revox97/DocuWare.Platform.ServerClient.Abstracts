using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Section(SDK.Section obj) : ISection
    {
        internal SDK.Section Obj { get; } = obj;

        public List<DocuWare.Platform.ServerClient.SignatureStatus> SignatureStatus
        {
            get => Obj.SignatureStatus;
            set => Obj.SignatureStatus = value;
        }

        public IPages Pages
        {
            get => new Pages(Obj.Pages);
            set => Obj.Pages = ((Pages)value).Obj;
        }

        public IPages Thumbnails
        {
            get => new Pages(Obj.Thumbnails);
            set => Obj.Thumbnails = ((Pages)value).Obj;
        }

        public IUploadedFileChunk FileChunk
        {
            get => new UploadedFileChunk(Obj.FileChunk);
            set => Obj.FileChunk = ((UploadedFileChunk)value).Obj;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string ContentType
        {
            get => Obj.ContentType;
            set => Obj.ContentType = value;
        }

        public bool HaveMorePages
        {
            get => Obj.HaveMorePages;
            set => Obj.HaveMorePages = value;
        }

        public int PageCount
        {
            get => Obj.PageCount;
            set => Obj.PageCount = value;
        }

        public long FileSize
        {
            get => Obj.FileSize;
            set => Obj.FileSize = value;
        }

        public string OriginalFileName
        {
            get => Obj.OriginalFileName;
            set => Obj.OriginalFileName = value;
        }

        public DateTime ContentModified
        {
            get => Obj.ContentModified;
            set => Obj.ContentModified = value;
        }

        public bool HasTextAnnotation
        {
            get => Obj.HasTextAnnotation;
            set => Obj.HasTextAnnotation = value;
        }

        public bool AnnotationsPreview
        {
            get => Obj.AnnotationsPreview;
            set => Obj.AnnotationsPreview = value;
        }

        public string DocumentRelationLink => Obj.DocumentRelationLink;

        public string DeepZoomImageRelationLink => Obj.DeepZoomImageRelationLink;

        public string DeepZoomImageWithAnnotationRelationLink => Obj.DeepZoomImageWithAnnotationRelationLink;

        public string PositionsRelationLink => Obj.PositionsRelationLink;

        public string TextshotRelationLink => Obj.TextshotRelationLink;

        public string ContentRelationLink => Obj.ContentRelationLink;

        public string FileDownloadRelationLink => Obj.FileDownloadRelationLink;

        public string SelfRelationLink => Obj.SelfRelationLink;

        public string ThumbnailRelationLink => Obj.ThumbnailRelationLink;

        public string IconRelationLink => Obj.IconRelationLink;

        public string TextAnnotationRelationLink => Obj.TextAnnotationRelationLink;

        public string PagesBlockRelationLink => Obj.PagesBlockRelationLink;

        public string AnnotationAsSvgRelationLink => Obj.AnnotationAsSvgRelationLink;

        public string AppPropertiesRelationLink => Obj.AppPropertiesRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public Document GetDocumentFromDocumentRelation() => new Document(Obj.GetDocumentFromDocumentRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromDocumentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromDocumentRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Document>(temp).ConfigureAwait(false);
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

        public WordSearchResult GetWordSearchResultFromPositionsRelation() => new WordSearchResult(Obj.GetWordSearchResultFromPositionsRelation());

        public async Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromPositionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.GetWordSearchResultFromPositionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromPositionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.GetWordSearchResultFromPositionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WordSearchResult>(temp).ConfigureAwait(false);
        }

        public WordSearchResult PostToPositionsRelationForWordSearchResult(ISearchPositionQuery dataToSend) => new WordSearchResult(Obj.PostToPositionsRelationForWordSearchResult(dataToSend));

        public async Task<DeserializedHttpResponse<IWordSearchResult>> PostToPositionsRelationForWordSearchResultAsync(ISearchPositionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.PostToPositionsRelationForWordSearchResultAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWordSearchResult>> PostToPositionsRelationForWordSearchResultAsync(CancellationToken cancellationToken, ISearchPositionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.PostToPositionsRelationForWordSearchResultAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<WordSearchResult>(temp).ConfigureAwait(false);
        }

        public DocumentContent GetDocumentContentFromTextshotRelation() => new DocumentContent(Obj.GetDocumentContentFromTextshotRelation());

        public async Task<DeserializedHttpResponse<IDocumentContent>> GetDocumentContentFromTextshotRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentContent> result = await Obj.GetDocumentContentFromTextshotRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentContent(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentContent>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentContent>> GetDocumentContentFromTextshotRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentContent> result = await Obj.GetDocumentContentFromTextshotRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentContent(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentContent>(temp).ConfigureAwait(false);
        }

		public async string PutToTextshotRelationForString(IDocumentContent dataToSend) => Obj.PutToTextshotRelationForString(dataToSend);

        public async Task<DeserializedHttpResponse<string>> PutToTextshotRelationForStringAsync(IDocumentContent dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PutToTextshotRelationForStringAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<string>> PutToTextshotRelationForStringAsync(CancellationToken cancellationToken, IDocumentContent dataToSend)
        {
            DeserializedHttpResponse<string> result = await Obj.PutToTextshotRelationForStringAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new string(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<string>(temp).ConfigureAwait(false);
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

        public Section PutToContentRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PutToContentRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PutToContentRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PutToContentRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PutToContentRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PutToContentRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
        }

        public Section PostToContentRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PostToContentRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PostToContentRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToContentRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PostToContentRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToContentRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
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

        public Section GetSectionFromSelfRelation() => new Section(Obj.GetSectionFromSelfRelation());

        public async Task<DeserializedHttpResponse<ISection>> GetSectionFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.GetSectionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> GetSectionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.GetSectionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Section>(temp).ConfigureAwait(false);
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

		public async Stream GetStreamFromIconRelation() => Obj.GetStreamFromIconRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromIconRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromIconRelationAsync(cancellationToken).ConfigureAwait(false);

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

        public Pages PostToPagesBlockRelationForPages(IPagesBlockQuery dataToSend) => new Pages(Obj.PostToPagesBlockRelationForPages(dataToSend));

        public async Task<DeserializedHttpResponse<IPages>> PostToPagesBlockRelationForPagesAsync(IPagesBlockQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Pages> result = await Obj.PostToPagesBlockRelationForPagesAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Pages(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Pages>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IPages>> PostToPagesBlockRelationForPagesAsync(CancellationToken cancellationToken, IPagesBlockQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Pages> result = await Obj.PostToPagesBlockRelationForPagesAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Pages(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Pages>(temp).ConfigureAwait(false);
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
    }
}
