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

        public DocumentAuditInformation GetDocumentAuditInformationFromNextRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromNextRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromNextRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromNextRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromNextRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromNextRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public DocumentAuditInformation GetDocumentAuditInformationFromPrevRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromPrevRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromPrevRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromPrevRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromPrevRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromPrevRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public DocumentAuditInformation GetDocumentAuditInformationFromFirstRelation() => new DocumentAuditInformation(Obj.GetDocumentAuditInformationFromFirstRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromFirstRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromFirstRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromFirstRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DocumentAuditInformation> result = await Obj.GetDocumentAuditInformationFromFirstRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DocumentAuditInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DocumentAuditInformation>(temp).ConfigureAwait(false);
        }
    }
}
