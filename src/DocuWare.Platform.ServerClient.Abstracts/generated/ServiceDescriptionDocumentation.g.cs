using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceDescriptionDocumentation(SDK.ServiceDescriptionDocumentation obj) : IServiceDescriptionDocumentation
    {
        internal SDK.ServiceDescriptionDocumentation Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string LinkModelOverviewRelationLink => Obj.LinkModelOverviewRelationLink;

        public string SchemasRelationLink => Obj.SchemasRelationLink;

        public string FunctionDescriptionsRelationLink => Obj.FunctionDescriptionsRelationLink;

        public string SchemaSearchRelationLink => Obj.SchemaSearchRelationLink;

        public string UriTemplatesDocumentationRelationLink => Obj.UriTemplatesDocumentationRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

		public async Stream GetStreamFromLinkModelOverviewRelation() => Obj.GetStreamFromLinkModelOverviewRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLinkModelOverviewRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLinkModelOverviewRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLinkModelOverviewRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromLinkModelOverviewRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public XmlSchemas GetXmlSchemasFromSchemasRelation() => new XmlSchemas(Obj.GetXmlSchemasFromSchemasRelation());

        public async Task<DeserializedHttpResponse<IXmlSchemas>> GetXmlSchemasFromSchemasRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.XmlSchemas> result = await Obj.GetXmlSchemasFromSchemasRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XmlSchemas(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XmlSchemas>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IXmlSchemas>> GetXmlSchemasFromSchemasRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.XmlSchemas> result = await Obj.GetXmlSchemasFromSchemasRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new XmlSchemas(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<XmlSchemas>(temp).ConfigureAwait(false);
        }

        public FunctionDescriptions GetFunctionDescriptionsFromFunctionDescriptionsRelation() => new FunctionDescriptions(Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelation());

        public async Task<DeserializedHttpResponse<IFunctionDescriptions>> GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FunctionDescriptions> result = await Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FunctionDescriptions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<FunctionDescriptions>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFunctionDescriptions>> GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.FunctionDescriptions> result = await Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new FunctionDescriptions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<FunctionDescriptions>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromSchemaSearchRelation() => Obj.GetStreamFromSchemaSearchRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaSearchRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromSchemaSearchRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaSearchRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromSchemaSearchRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromUriTemplatesDocumentationRelation() => Obj.GetStreamFromUriTemplatesDocumentationRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromUriTemplatesDocumentationRelationAsync()
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromUriTemplatesDocumentationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromUriTemplatesDocumentationRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<Stream> result = await Obj.GetStreamFromUriTemplatesDocumentationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }
    }
}
