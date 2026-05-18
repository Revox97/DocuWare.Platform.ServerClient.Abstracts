using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBaseDecisionOperations
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDecision GetDecisionFromSelfRelation();
		Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
