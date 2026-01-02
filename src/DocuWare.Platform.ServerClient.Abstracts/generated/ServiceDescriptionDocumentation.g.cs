using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceDescriptionDocumentation(DocuWare.Platform.ServerClient.ServiceDescriptionDocumentation obj) : IServiceDescriptionDocumentation
    {
        internal DocuWare.Platform.ServerClient.ServiceDescriptionDocumentation Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public Stream GetStreamFromLinkModelOverviewRelation() => Obj.GetStreamFromLinkModelOverviewRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLinkModelOverviewRelationAsync() => await Obj.GetStreamFromLinkModelOverviewRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLinkModelOverviewRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromLinkModelOverviewRelationAsync(cancellationToken);

        public IXmlSchemas GetXmlSchemasFromSchemasRelation() => new XmlSchemas(Obj.GetXmlSchemasFromSchemasRelation());

        public async Task<DeserializedHttpResponse<IXmlSchemas>> GetXmlSchemasFromSchemasRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.XmlSchemas> result = await Obj.GetXmlSchemasFromSchemasRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XmlSchemas(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IXmlSchemas>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IXmlSchemas>> GetXmlSchemasFromSchemasRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.XmlSchemas> result = await Obj.GetXmlSchemasFromSchemasRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XmlSchemas(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IXmlSchemas>(temp).ConfigureAwait(false);
        }

        public IFunctionDescriptions GetFunctionDescriptionsFromFunctionDescriptionsRelation() => new FunctionDescriptions(Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelation());

        public async Task<DeserializedHttpResponse<IFunctionDescriptions>> GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FunctionDescriptions> result = await Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FunctionDescriptions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFunctionDescriptions>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFunctionDescriptions>> GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FunctionDescriptions> result = await Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FunctionDescriptions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFunctionDescriptions>(temp).ConfigureAwait(false);
        }

		public Stream GetStreamFromSchemaSearchRelation() => Obj.GetStreamFromSchemaSearchRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaSearchRelationAsync() => await Obj.GetStreamFromSchemaSearchRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaSearchRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromSchemaSearchRelationAsync(cancellationToken);

		public Stream GetStreamFromUriTemplatesDocumentationRelation() => Obj.GetStreamFromUriTemplatesDocumentationRelation();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromUriTemplatesDocumentationRelationAsync() => await Obj.GetStreamFromUriTemplatesDocumentationRelationAsync();

		public async Task<DeserializedHttpResponse<Stream>> GetStreamFromUriTemplatesDocumentationRelationAsync(CancellationToken cancellationToken) => await Obj.GetStreamFromUriTemplatesDocumentationRelationAsync(cancellationToken);
    }
}
