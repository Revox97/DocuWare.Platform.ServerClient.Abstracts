using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerInstance{3}
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string WorkflowVersionId { get; set; }
		InstanceExecutionStateEnum ExecutionState { get; set; }
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
