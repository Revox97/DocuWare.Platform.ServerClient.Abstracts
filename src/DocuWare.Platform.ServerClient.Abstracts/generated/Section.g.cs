using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Section(DocuWare.Platform.ServerClient.Section obj) : ISection
    {
        internal DocuWare.Platform.ServerClient.Section Obj { get; } = obj;

        public List<SignatureStatus> SignatureStatus
        {
            get => Obj.SignatureStatus.ConvertAll(o => (SignatureStatus)o);
            set => Obj.SignatureStatus = value.ConvertAll(v => (DocuWare.Platform.ServerClient.SignatureStatus)v);
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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDocument GetDocumentFromDocumentRelation() => new Document(Obj.GetDocumentFromDocumentRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromDocumentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Document> result = await Obj.GetDocumentFromDocumentRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Document(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromDeepZoomImageRelation() => Obj.GetStreamFromDeepZoomImageRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync() => await Obj.GetStreamFromDeepZoomImageRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromDeepZoomImageRelationAsync(cancellationToken);

		public Stream GetStreamFromDeepZoomImageWithAnnotationRelation() => Obj.GetStreamFromDeepZoomImageWithAnnotationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync() => await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync(cancellationToken);

        public IWordSearchResult GetWordSearchResultFromPositionsRelation() => new WordSearchResult(Obj.GetWordSearchResultFromPositionsRelation());

        public async Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromPositionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.GetWordSearchResultFromPositionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromPositionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.GetWordSearchResultFromPositionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWordSearchResult>(temp).ConfigureAwait(false);
        }

        public IWordSearchResult PostToPositionsRelationForWordSearchResult(ISearchPositionQuery dataToSend) => new WordSearchResult(Obj.PostToPositionsRelationForWordSearchResult(((SearchPositionQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IWordSearchResult>> PostToPositionsRelationForWordSearchResultAsync(ISearchPositionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.PostToPositionsRelationForWordSearchResultAsync(((SearchPositionQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWordSearchResult>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IWordSearchResult>> PostToPositionsRelationForWordSearchResultAsync(CancellationToken cancellationToken, ISearchPositionQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.WordSearchResult> result = await Obj.PostToPositionsRelationForWordSearchResultAsync(cancellationToken, ((SearchPositionQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new WordSearchResult(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IWordSearchResult>(temp).ConfigureAwait(false);
        }

        public IDocumentContent GetDocumentContentFromTextshotRelation() => new DocumentContent(Obj.GetDocumentContentFromTextshotRelation());

        public async Task<DeserializedHttpResponse<IDocumentContent>> GetDocumentContentFromTextshotRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Content.DocumentContent> result = await Obj.GetDocumentContentFromTextshotRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentContent(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentContent>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentContent>> GetDocumentContentFromTextshotRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Content.DocumentContent> result = await Obj.GetDocumentContentFromTextshotRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentContent(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentContent>(temp).ConfigureAwait(false);
        }

		public string PutToTextshotRelationForString(IDocumentContent dataToSend) => Obj.PutToTextshotRelationForString(((DocumentContent)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PutToTextshotRelationForStringAsync(IDocumentContent dataToSend) => await Obj.PutToTextshotRelationForStringAsync(((DocumentContent)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<string>> PutToTextshotRelationForStringAsync(CancellationToken cancellationToken, IDocumentContent dataToSend) => await Obj.PutToTextshotRelationForStringAsync(cancellationToken, ((DocumentContent)dataToSend).Obj);

		public Stream GetStreamFromContentRelation() => Obj.GetStreamFromContentRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync() => await Obj.GetStreamFromContentRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromContentRelationAsync(cancellationToken);

        public ISection PutToContentRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PutToContentRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PutToContentRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PutToContentRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PutToContentRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PutToContentRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

        public ISection PostToContentRelationForSection(string requestedContentType, Stream dataToSend) => new Section(Obj.PostToContentRelationForSection(requestedContentType, dataToSend));

        public async Task<DeserializedHttpResponse<ISection>> PostToContentRelationForSectionAsync(string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToContentRelationForSectionAsync(requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> PostToContentRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.PostToContentRelationForSectionAsync(cancellationToken, requestedContentType, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromFileDownloadRelation() => Obj.GetStreamFromFileDownloadRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync() => await Obj.GetStreamFromFileDownloadRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromFileDownloadRelationAsync(cancellationToken);

		public Stream PostToFileDownloadRelationForStream(IFileDownload dataToSend) => Obj.PostToFileDownloadRelationForStream(((FileDownload)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(IFileDownload dataToSend) => await Obj.PostToFileDownloadRelationForStreamAsync(((FileDownload)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownload dataToSend) => await Obj.PostToFileDownloadRelationForStreamAsync(cancellationToken, ((FileDownload)dataToSend).Obj);

        public ISection GetSectionFromSelfRelation() => new Section(Obj.GetSectionFromSelfRelation());

        public async Task<DeserializedHttpResponse<ISection>> GetSectionFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.GetSectionFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<ISection>> GetSectionFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Section> result = await Obj.GetSectionFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Section(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<ISection>(temp).ConfigureAwait(false);
        }

		public string DeleteSelfRelation() => Obj.DeleteSelfRelation();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync() => await Obj.DeleteSelfRelationAsync();

		public async Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken) => await Obj.DeleteSelfRelationAsync(cancellationToken);

		public Stream GetStreamFromThumbnailRelation() => Obj.GetStreamFromThumbnailRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync() => await Obj.GetStreamFromThumbnailRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromThumbnailRelationAsync(cancellationToken);

		public Stream GetStreamFromIconRelation() => Obj.GetStreamFromIconRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync() => await Obj.GetStreamFromIconRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromIconRelationAsync(cancellationToken);

		public Stream GetStreamFromTextAnnotationRelation() => Obj.GetStreamFromTextAnnotationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync() => await Obj.GetStreamFromTextAnnotationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromTextAnnotationRelationAsync(cancellationToken);

		public Stream PostToTextAnnotationRelationForStream(Stream dataToSend) => Obj.PostToTextAnnotationRelationForStream(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(Stream dataToSend) => await Obj.PostToTextAnnotationRelationForStreamAsync(dataToSend);

		public async Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend) => await Obj.PostToTextAnnotationRelationForStreamAsync(cancellationToken, dataToSend);

        public IPages PostToPagesBlockRelationForPages(IPagesBlockQuery dataToSend) => new Pages(Obj.PostToPagesBlockRelationForPages(((PagesBlockQuery)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IPages>> PostToPagesBlockRelationForPagesAsync(IPagesBlockQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Pages> result = await Obj.PostToPagesBlockRelationForPagesAsync(((PagesBlockQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Pages(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPages>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IPages>> PostToPagesBlockRelationForPagesAsync(CancellationToken cancellationToken, IPagesBlockQuery dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Pages> result = await Obj.PostToPagesBlockRelationForPagesAsync(cancellationToken, ((PagesBlockQuery)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Pages(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPages>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromAnnotationAsSvgRelation() => Obj.GetStreamFromAnnotationAsSvgRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync() => await Obj.GetStreamFromAnnotationAsSvgRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromAnnotationAsSvgRelationAsync(cancellationToken);

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
    }
}
