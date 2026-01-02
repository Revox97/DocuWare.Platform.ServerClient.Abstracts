using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Page(SDK.Page obj) : IPage
    {
        internal SDK.Page Obj { get; } = obj;

        public IPageData Data
        {
            get => new PageData(Obj.Data);
            set => Obj.Data = ((PageData)value).Obj;
        }

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

        public string ThumbnailRelationLink => Obj.ThumbnailRelationLink;

        public string IconRelationLink => Obj.IconRelationLink;

        public string DeepZoomImageRelationLink => Obj.DeepZoomImageRelationLink;

        public string DeepZoomImageWithAnnotationRelationLink => Obj.DeepZoomImageWithAnnotationRelationLink;

        public string LowQualityImageRelationLink => Obj.LowQualityImageRelationLink;

        public string LowQualityImageWithAnnotationRelationLink => Obj.LowQualityImageWithAnnotationRelationLink;

        public string TextshotRelationLink => Obj.TextshotRelationLink;

        public string FileDownloadRelationLink => Obj.FileDownloadRelationLink;

        public string AnnotationRelationLink => Obj.AnnotationRelationLink;

        public string AnnotationAsSvgRelationLink => Obj.AnnotationAsSvgRelationLink;

        public string AnnotationAsXamlRelationLink => Obj.AnnotationAsXamlRelationLink;

        public string StampRelationLink => Obj.StampRelationLink;

        public string StampBestPositionRelationLink => Obj.StampBestPositionRelationLink;

        public string SelfRelationLink => Obj.SelfRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

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

		public async Stream GetStreamFromLowQualityImageWithAnnotationRelation() => Obj.GetStreamFromLowQualityImageWithAnnotationRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageWithAnnotationRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLowQualityImageWithAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageWithAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLowQualityImageWithAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public PageContent GetPageContentFromTextshotRelation() => new PageContent(Obj.GetPageContentFromTextshotRelation());

        public async Task<DeserializedHttpResponse<IPageContent>> GetPageContentFromTextshotRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.PageContent> result = await Obj.GetPageContentFromTextshotRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new PageContent(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<PageContent>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IPageContent>> GetPageContentFromTextshotRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.PageContent> result = await Obj.GetPageContentFromTextshotRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new PageContent(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<PageContent>(temp).ConfigureAwait(false);
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

		public async Stream PostToFileDownloadRelationForStream(IFileDownloadPage dataToSend) => Obj.PostToFileDownloadRelationForStream(dataToSend);

        public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(IFileDownloadPage dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToFileDownloadRelationForStreamAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownloadPage dataToSend)
        {
            DeserializedHttpResponse<Stream> result = await Obj.PostToFileDownloadRelationForStreamAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public Annotation GetAnnotationFromAnnotationRelation() => new Annotation(Obj.GetAnnotationFromAnnotationRelation());

        public async Task<DeserializedHttpResponse<IAnnotation>> GetAnnotationFromAnnotationRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.GetAnnotationFromAnnotationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Annotation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAnnotation>> GetAnnotationFromAnnotationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.GetAnnotationFromAnnotationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Annotation>(temp).ConfigureAwait(false);
        }

        public Annotation PostToAnnotationRelationForAnnotation(IAnnotationsPlacement dataToSend) => new Annotation(Obj.PostToAnnotationRelationForAnnotation(dataToSend));

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(IAnnotationsPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToAnnotationRelationForAnnotationAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Annotation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(CancellationToken cancellationToken, IAnnotationsPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToAnnotationRelationForAnnotationAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Annotation>(temp).ConfigureAwait(false);
        }

        public Annotation PostToAnnotationRelationForAnnotation(IAnnotation dataToSend) => new Annotation(Obj.PostToAnnotationRelationForAnnotation(dataToSend));

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(IAnnotation dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToAnnotationRelationForAnnotationAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Annotation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(CancellationToken cancellationToken, IAnnotation dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToAnnotationRelationForAnnotationAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Annotation>(temp).ConfigureAwait(false);
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

		public async XElementWrapper GetXElementWrapperFromAnnotationAsXamlRelation() => Obj.GetXElementWrapperFromAnnotationAsXamlRelation();

        public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromAnnotationAsXamlRelationAsync()
        {
            DeserializedHttpResponse<XElementWrapper> result = await Obj.GetXElementWrapperFromAnnotationAsXamlRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XElementWrapper(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XElementWrapper>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromAnnotationAsXamlRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<XElementWrapper> result = await Obj.GetXElementWrapperFromAnnotationAsXamlRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XElementWrapper(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XElementWrapper>(temp).ConfigureAwait(false);
        }

        public Annotation PostToStampRelationForAnnotation(IStampPlacement dataToSend) => new Annotation(Obj.PostToStampRelationForAnnotation(dataToSend));

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToStampRelationForAnnotationAsync(IStampPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToStampRelationForAnnotationAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Annotation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IAnnotation>> PostToStampRelationForAnnotationAsync(CancellationToken cancellationToken, IStampPlacement dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Annotation> result = await Obj.PostToStampRelationForAnnotationAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Annotation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Annotation>(temp).ConfigureAwait(false);
        }

        public DWPoint PostToStampBestPositionRelationForDWPoint(IStampFormFieldValues dataToSend) => new DWPoint(Obj.PostToStampBestPositionRelationForDWPoint(dataToSend));

        public async Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(IStampFormFieldValues dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DWPoint> result = await Obj.PostToStampBestPositionRelationForDWPointAsync(dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DWPoint(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DWPoint>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(CancellationToken cancellationToken, IStampFormFieldValues dataToSend)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DWPoint> result = await Obj.PostToStampBestPositionRelationForDWPointAsync(cancellationToken, dataToSend).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DWPoint(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DWPoint>(temp).ConfigureAwait(false);
        }

        public Page GetPageFromSelfRelation() => new Page(Obj.GetPageFromSelfRelation());

        public async Task<DeserializedHttpResponse<IPage>> GetPageFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Page> result = await Obj.GetPageFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Page(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Page>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IPage>> GetPageFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.Page> result = await Obj.GetPageFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Page(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Page>(temp).ConfigureAwait(false);
        }
    }
}
