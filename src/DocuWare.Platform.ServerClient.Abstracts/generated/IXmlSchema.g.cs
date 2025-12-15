using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IXmlSchema
    {
		Link[] Links { get; set; }
		string Name { get; set; }
		string TargetNamespace { get; set; }
		string SchemaRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		Stream GetStreamFromSchemaRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaRelationAsync(CancellationToken cancellationToken);
    }
}
