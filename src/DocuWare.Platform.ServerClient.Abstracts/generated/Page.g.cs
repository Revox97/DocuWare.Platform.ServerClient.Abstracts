using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Page(DocuWare.Platform.ServerClient.Page obj) : IPage
    {
        internal DocuWare.Platform.ServerClient.Page Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public int PageNum
        {
            get => Obj.PageNum;
            set => Obj.PageNum = value;
        }

        public bool HasAnnotation
        {
            get => Obj.HasAnnotation;
            set => Obj.HasAnnotation = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public Stream GetStreamFromThumbnailRelation() => Obj.GetStreamFromThumbnailRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync() => await Obj.GetStreamFromThumbnailRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromThumbnailRelationAsync(cancellationToken);

		public Stream GetStreamFromIconRelation() => Obj.GetStreamFromIconRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync() => await Obj.GetStreamFromIconRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromIconRelationAsync(cancellationToken);

		public Stream GetStreamFromDeepZoomImageRelation() => Obj.GetStreamFromDeepZoomImageRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync() => await Obj.GetStreamFromDeepZoomImageRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromDeepZoomImageRelationAsync(cancellationToken);

		public Stream GetStreamFromDeepZoomImageWithAnnotationRelation() => Obj.GetStreamFromDeepZoomImageWithAnnotationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync() => await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromDeepZoomImageWithAnnotationRelationAsync(cancellationToken);

		public Stream GetStreamFromLowQualityImageRelation() => Obj.GetStreamFromLowQualityImageRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync() => await Obj.GetStreamFromLowQualityImageRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromLowQualityImageRelationAsync(cancellationToken);

		public Stream GetStreamFromLowQualityImageWithAnnotationRelation() => Obj.GetStreamFromLowQualityImageWithAnnotationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageWithAnnotationRelationAsync() => await Obj.GetStreamFromLowQualityImageWithAnnotationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageWithAnnotationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromLowQualityImageWithAnnotationRelationAsync(cancellationToken);

        public IPageContent GetPageContentFromTextshotRelation() => new PageContent(Obj.GetPageContentFromTextshotRelation());

        public async Task<DeserializedHttpResponse<IPageContent>> GetPageContentFromTextshotRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Content.PageContent> result = await Obj.GetPageContentFromTextshotRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new PageContent(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPageContent>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IPageContent>> GetPageContentFromTextshotRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Content.PageContent> result = await Obj.GetPageContentFromTextshotRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new PageContent(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPageContent>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromFileDownloadRelation() => Obj.GetStreamFromFileDownloadRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync() => await Obj.GetStreamFromFileDownloadRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromFileDownloadRelationAsync(cancellationToken);

		public Stream PostToFileDownloadRelationForStream(IFileDownloadPage dataToSend) => Obj.PostToFileDownloadRelationForStream(((FileDownloadPage)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(IFileDownloadPage dataToSend) => await Obj.PostToFileDownloadRelationForStreamAsync(((FileDownloadPage)dataToSend).Obj);

		public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownloadPage dataToSend) => await Obj.PostToFileDownloadRelationForStreamAsync(cancellationToken, ((FileDownloadPage)dataToSend).Obj);

        public IAnnotation GetAnnotationFromAnnotationRelation() => new Annotation(Obj.GetAnnotationFromAnnotationRelation());

        public async Task<DeserializedHttpResponse<IAnnotation>> GetAnnotationFromAnnotationRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.GetAnnotationFromAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAnnotation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAnnotation>> GetAnnotationFromAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.GetAnnotationFromAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAnnotation>(temp).ConfigureAwait(false);
        }

        public IAnnotation PostToAnnotationRelationForAnnotation(IAnnotationsPlacement dataToSend) => new Annotation(Obj.PostToAnnotationRelationForAnnotation(((AnnotationsPlacement)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(IAnnotationsPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToAnnotationRelationForAnnotationAsync(((AnnotationsPlacement)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAnnotation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(CancellationToken cancellationToken, IAnnotationsPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToAnnotationRelationForAnnotationAsync(cancellationToken, ((AnnotationsPlacement)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAnnotation>(temp).ConfigureAwait(false);
        }

        public IAnnotation PostToAnnotationRelationForAnnotation(IAnnotation dataToSend) => new Annotation(Obj.PostToAnnotationRelationForAnnotation(((Annotation)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(IAnnotation dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToAnnotationRelationForAnnotationAsync(((Annotation)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAnnotation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(CancellationToken cancellationToken, IAnnotation dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToAnnotationRelationForAnnotationAsync(cancellationToken, ((Annotation)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAnnotation>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromAnnotationAsSvgRelation() => Obj.GetStreamFromAnnotationAsSvgRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync() => await Obj.GetStreamFromAnnotationAsSvgRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromAnnotationAsSvgRelationAsync(cancellationToken);

		public XElementWrapper GetXElementWrapperFromAnnotationAsXamlRelation() => Obj.GetXElementWrapperFromAnnotationAsXamlRelation();

		public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromAnnotationAsXamlRelationAsync() => await Obj.GetXElementWrapperFromAnnotationAsXamlRelationAsync();

		public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromAnnotationAsXamlRelationAsync(CancellationToken cancellationToken) => await Obj.GetXElementWrapperFromAnnotationAsXamlRelationAsync(cancellationToken);

        public IAnnotation PostToStampRelationForAnnotation(IStampPlacement dataToSend) => new Annotation(Obj.PostToStampRelationForAnnotation(((StampPlacement)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToStampRelationForAnnotationAsync(IStampPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToStampRelationForAnnotationAsync(((StampPlacement)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAnnotation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToStampRelationForAnnotationAsync(CancellationToken cancellationToken, IStampPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToStampRelationForAnnotationAsync(cancellationToken, ((StampPlacement)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IAnnotation>(temp).ConfigureAwait(false);
        }

        public IDWPoint PostToStampBestPositionRelationForDWPoint(IStampFormFieldValues dataToSend) => new DWPoint(Obj.PostToStampBestPositionRelationForDWPoint(((StampFormFieldValues)dataToSend).Obj));

        public async Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(IStampFormFieldValues dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DWPoint> result = await Obj.PostToStampBestPositionRelationForDWPointAsync(((StampFormFieldValues)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DWPoint(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDWPoint>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(CancellationToken cancellationToken, IStampFormFieldValues dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DWPoint> result = await Obj.PostToStampBestPositionRelationForDWPointAsync(cancellationToken, ((StampFormFieldValues)dataToSend).Obj).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DWPoint(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDWPoint>(temp).ConfigureAwait(false);
        }

        public IPage GetPageFromSelfRelation() => new Page(Obj.GetPageFromSelfRelation());

        public async Task<DeserializedHttpResponse<IPage>> GetPageFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Page> result = await Obj.GetPageFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Page(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPage>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IPage>> GetPageFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Page> result = await Obj.GetPageFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Page(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IPage>(temp).ConfigureAwait(false);
        }
    }
}
