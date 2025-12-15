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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromLinkModelOverviewRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromLinkModelOverviewRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromLinkModelOverviewRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public IXmlSchemas GetXmlSchemasFromSchemasRelation() => new XmlSchemas(Obj.GetXmlSchemasFromSchemasRelation());

        public async Task<DeserializedHttpResponse<IXmlSchemas>> GetXmlSchemasFromSchemasRelationAsync()
        {
            DocuWare.Platform.ServerClient.IXmlSchemas result = await Obj.GetXmlSchemasFromSchemasRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IXmlSchemas(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IXmlSchemas>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IXmlSchemas>> GetXmlSchemasFromSchemasRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IXmlSchemas result = await Obj.GetXmlSchemasFromSchemasRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IXmlSchemas(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IXmlSchemas>(temp).ConfigureAwait(false);
        }

        public IFunctionDescriptions GetFunctionDescriptionsFromFunctionDescriptionsRelation() => new FunctionDescriptions(Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelation());

        public async Task<DeserializedHttpResponse<IFunctionDescriptions>> GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync()
        {
            DocuWare.Platform.ServerClient.IFunctionDescriptions result = await Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFunctionDescriptions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFunctionDescriptions>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IFunctionDescriptions>> GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IFunctionDescriptions result = await Obj.GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IFunctionDescriptions(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IFunctionDescriptions>(temp).ConfigureAwait(false);
        }

		public async Stream GetStreamFromSchemaSearchRelation() => Obj.GetStreamFromSchemaSearchRelation();

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaSearchRelationAsync()
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromSchemaSearchRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaSearchRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromSchemaSearchRelationAsync(cancellationToken).ConfigureAwait(false);

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
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromUriTemplatesDocumentationRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<Stream>> GetStreamFromUriTemplatesDocumentationRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.Stream result = await Obj.GetStreamFromUriTemplatesDocumentationRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new Stream(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<Stream>(temp).ConfigureAwait(false);
        }
    }
}
