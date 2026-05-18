using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWorkflowVersion
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		int InstanceCount { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDesignerWorkflowVersion GetDesignerWorkflowVersionFromSelfRelation();
		Task<DeserializedHttpResponse<IDesignerWorkflowVersion>> GetDesignerWorkflowVersionFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWorkflowVersion>> GetDesignerWorkflowVersionFromSelfRelationAsync(CancellationToken cancellationToken);
		IDesignerInstances GetDesignerInstancesFromInstancesRelation();
		Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync();
		Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync(CancellationToken cancellationToken);
    }
}
