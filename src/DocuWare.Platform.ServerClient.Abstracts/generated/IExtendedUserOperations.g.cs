using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExtendedUserOperations
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		string PutToReadStatusRelationForString(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PutToReadStatusRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend);
    }
}
