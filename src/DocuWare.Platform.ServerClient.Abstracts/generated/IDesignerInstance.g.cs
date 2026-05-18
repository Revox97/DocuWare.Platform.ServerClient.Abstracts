using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerInstance
    {
		Link[] Links { get; set; }
		List<IColumnValue> ColumnValues { get; set; }
		string Id { get; set; }
		string WorkflowVersionId { get; set; }
		InstanceExecutionStateEnum ExecutionState { get; set; }
		string HibernationStateValue { get; set; }
		int DocId { get; set; }
		DateTime CreateDate { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDesignerInstance GetDesignerInstanceFromSelfRelation();
		Task<DeserializedHttpResponse<IDesignerInstance>> GetDesignerInstanceFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDesignerInstance>> GetDesignerInstanceFromSelfRelationAsync(CancellationToken cancellationToken);
		string DeleteSelfRelation();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken);
    }
}
