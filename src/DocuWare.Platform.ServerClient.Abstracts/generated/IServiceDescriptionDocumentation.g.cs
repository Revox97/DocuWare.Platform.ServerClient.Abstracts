using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceDescriptionDocumentation
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		Stream GetStreamFromLinkModelOverviewRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLinkModelOverviewRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLinkModelOverviewRelationAsync(CancellationToken cancellationToken);
		IXmlSchemas GetXmlSchemasFromSchemasRelation();
		Task<DeserializedHttpResponse<IXmlSchemas>> GetXmlSchemasFromSchemasRelationAsync();
		Task<DeserializedHttpResponse<IXmlSchemas>> GetXmlSchemasFromSchemasRelationAsync(CancellationToken cancellationToken);
		IFunctionDescriptions GetFunctionDescriptionsFromFunctionDescriptionsRelation();
		Task<DeserializedHttpResponse<IFunctionDescriptions>> GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync();
		Task<DeserializedHttpResponse<IFunctionDescriptions>> GetFunctionDescriptionsFromFunctionDescriptionsRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromSchemaSearchRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaSearchRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaSearchRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromUriTemplatesDocumentationRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromUriTemplatesDocumentationRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromUriTemplatesDocumentationRelationAsync(CancellationToken cancellationToken);
    }
}
