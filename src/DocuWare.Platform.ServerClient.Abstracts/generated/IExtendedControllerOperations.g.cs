using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExtendedControllerOperations
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		string DeleteInstanceRelation();
		Task<DeserializedHttpResponse<string>> DeleteInstanceRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteInstanceRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromInstanceRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromInstanceRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromInstanceRelationAsync(CancellationToken cancellationToken);
    }
}
