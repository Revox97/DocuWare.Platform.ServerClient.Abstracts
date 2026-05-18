using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOwnWorkflows
    {
		Link[] Links { get; set; }
		List<IOwnWorkflow> Workflow { get; set; }
		int Count { get; set; }
		DateTime TimeStamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IOwnWorkflows GetOwnWorkflowsFromNextRelation();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromNextRelationAsync();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromNextRelationAsync(CancellationToken cancellationToken);
		IOwnWorkflows GetOwnWorkflowsFromPrevRelation();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromPrevRelationAsync();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromPrevRelationAsync(CancellationToken cancellationToken);
		IOwnWorkflows GetOwnWorkflowsFromSelfRelation();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromSelfRelationAsync(CancellationToken cancellationToken);
		IOwnWorkflows GetOwnWorkflowsFromFirstRelation();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromFirstRelationAsync();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}
