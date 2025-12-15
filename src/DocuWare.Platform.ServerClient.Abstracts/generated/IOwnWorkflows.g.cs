using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOwnWorkflows
    {
		Link[] Links { get; set; }
		List<IOwnWorkflow> Workflow { get; set; }
		int Count { get; set; }
		DateTime TimeStamp { get; set; }
		string NextRelationLink { get; }
		string PrevRelationLink { get; }
		string SelfRelationLink { get; }
		string FirstRelationLink { get; }

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
