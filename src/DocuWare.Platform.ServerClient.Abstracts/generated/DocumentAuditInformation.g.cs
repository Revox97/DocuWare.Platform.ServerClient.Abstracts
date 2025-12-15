using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditInformation(SDK.DocumentAuditInformation obj) : IDocumentAuditInformation
    {
        internal SDK.DocumentAuditInformation Obj { get; } = obj;

		public List<IDocumentAuditEvent> Events
		{
			get => Obj.Events.Select(x => new DocumentAuditEvent(x) as IDocumentAuditEvent).ToList();
			set => Obj.Events = value.Select(x => ((DocumentAuditEvent)x).Obj).ToList();
		}

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string NextRelationLink => Obj.NextRelationLink;

		public string PrevRelationLink => Obj.PrevRelationLink;

		public string FirstRelationLink => Obj.FirstRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IDocumentAuditInformation GetDocumentAuditInformationFromNextRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromNextRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromNextRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.GetDocumentAuditInformationFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.GetDocumentAuditInformationFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public IDocumentAuditInformation GetDocumentAuditInformationFromPrevRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromPrevRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromPrevRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.GetDocumentAuditInformationFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.GetDocumentAuditInformationFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public IDocumentAuditInformation GetDocumentAuditInformationFromFirstRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromFirstRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromFirstRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.GetDocumentAuditInformationFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentAuditInformation result = await Obj.GetDocumentAuditInformationFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditInformation>(temp).ConfigureAwait(false);
        }

    }
}
