using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWorkflow
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		int InstanceCount { get; set; }
		bool InstanceCountSpecified { get; set; }
		string SelfRelationLink { get; }
		string InstancesRelationLink { get; }
		string WaitingInstancesRelationLink { get; }
		string VersionsRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IDesignerWorkflow GetDesignerWorkflowFromSelfRelation();
		Task<DeserializedHttpResponse<IDesignerWorkflow>> GetDesignerWorkflowFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWorkflow>> GetDesignerWorkflowFromSelfRelationAsync(CancellationToken cancellationToken);
		IDesignerInstances GetDesignerInstancesFromInstancesRelation();
		Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync();
		Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync(CancellationToken cancellationToken);
		IDesignerWaitingInstances GetDesignerWaitingInstancesFromWaitingInstancesRelation();
		Task<DeserializedHttpResponse<IDesignerWaitingInstances>> GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWaitingInstances>> GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync(CancellationToken cancellationToken);
		IDesignerWorkflowVersions GetDesignerWorkflowVersionsFromVersionsRelation();
		Task<DeserializedHttpResponse<IDesignerWorkflowVersions>> GetDesignerWorkflowVersionsFromVersionsRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWorkflowVersions>> GetDesignerWorkflowVersionsFromVersionsRelationAsync(CancellationToken cancellationToken);
    }
}
