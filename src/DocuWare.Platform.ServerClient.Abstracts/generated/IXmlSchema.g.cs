using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IXmlSchema
    {
		Link[] Links { get; set; }
		string Name { get; set; }
		string TargetNamespace { get; set; }

		void SetProxy(HttpClientProxy proxy);
		Stream GetStreamFromSchemaRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromSchemaRelationAsync(CancellationToken cancellationToken);
    }
}
