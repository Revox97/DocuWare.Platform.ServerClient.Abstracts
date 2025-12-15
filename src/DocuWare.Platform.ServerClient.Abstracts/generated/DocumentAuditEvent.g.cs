using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEvent(SDK.DocumentAuditEvent obj) : IDocumentAuditEvent
    {
        internal SDK.DocumentAuditEvent Obj { get; } = obj;

		public IAuditEvent AuditEvent
		{
			get => new AuditEvent(Obj.AuditEvent);
			set => Obj.AuditEvent = ((AuditEvent)value).Obj;
		}

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string AuditEventInformationRelationLink => Obj.AuditEventInformationRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
        public IDocumentAuditEventInformation GetDocumentAuditEventInformationFromAuditEventInformationRelation() => new DocumentAuditEventInformation(Obj.GetDocumentAuditEventInformationFromAuditEventInformationRelation());

        public async Task<DeserializedHttpResponse<IDocumentAuditEventInformation>> GetDocumentAuditEventInformationFromAuditEventInformationRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDocumentAuditEventInformation result = await Obj.GetDocumentAuditEventInformationFromAuditEventInformationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditEventInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditEventInformation>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDocumentAuditEventInformation>> GetDocumentAuditEventInformationFromAuditEventInformationRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDocumentAuditEventInformation result = await Obj.GetDocumentAuditEventInformationFromAuditEventInformationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDocumentAuditEventInformation(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDocumentAuditEventInformation>(temp).ConfigureAwait(false);
        }

    }
}
