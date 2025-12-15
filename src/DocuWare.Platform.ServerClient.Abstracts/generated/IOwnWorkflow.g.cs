using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOwnWorkflow
    {
		Link[] Links { get; set; }
		List<IRequestDataDecision> TakenDecision { get; set; }
		string Id { get; set; }
		int DocId { get; set; }
		string FcGuid { get; set; }
		DateTime CreateDate { get; set; }
		string WorkflowName { get; set; }
		string DocumentName { get; set; }
		RequestExecutionStateEnum ExecutionState { get; set; }
		string TakenDecisionName { get; set; }
		string SelfRelationLink { get; }
		string HistoryRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IOwnWorkflow GetOwnWorkflowFromSelfRelation();
		Task<DeserializedHttpResponse<IOwnWorkflow>> GetOwnWorkflowFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IOwnWorkflow>> GetOwnWorkflowFromSelfRelationAsync(CancellationToken cancellationToken);
		string DeleteSelfRelation();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken);
		IInstanceHistory GetInstanceHistoryFromHistoryRelation();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync(CancellationToken cancellationToken);
    }
}
