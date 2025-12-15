using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TrashBinTableRow(SDK.TrashBinTableRow obj) : ITrashBinTableRow
    {
        internal SDK.TrashBinTableRow Obj { get; } = obj;

		public List<Object> Items
		{
			get => Obj.Items;
			set => Obj.Items = value;
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

		public string DocumentRelationLink => Obj.DocumentRelationLink;

		public string LowQualityImageRelationLink => Obj.LowQualityImageRelationLink;

		public string AnnotationAsSvgRelationLink => Obj.AnnotationAsSvgRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IDocument GetDocumentFromDocumentRelation() => new Document(Obj.GetDocumentFromDocumentRelation());

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.GetDocumentFromDocumentRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocument result = await Obj.GetDocumentFromDocumentRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocument(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocument>(temp).ConfigureAwait(false);
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

    }
}
