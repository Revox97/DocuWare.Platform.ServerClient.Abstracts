using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAdhocRenderingFile
    {
		List<IKeyValuePair> MetaData { get; set; }
		IPages Pages { get; set; }
		Link[] Links { get; set; }
		string Id { get; set; }
		int PageCount { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IAdhocRenderingFile GetAdhocRenderingFileFromSelfRelation();
		Task<DeserializedHttpResponse<IAdhocRenderingFile>> GetAdhocRenderingFileFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IAdhocRenderingFile>> GetAdhocRenderingFileFromSelfRelationAsync(CancellationToken cancellationToken);
		Stream PostToRenderingRelationForStream(IAdhocRenderingQuery dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToRenderingRelationForStreamAsync(IAdhocRenderingQuery dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToRenderingRelationForStreamAsync(CancellationToken cancellationToken, IAdhocRenderingQuery dataToSend);
    }
}
