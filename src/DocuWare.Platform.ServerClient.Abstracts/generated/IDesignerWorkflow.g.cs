using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWorkflow
    {
		Link[] Links { get; set; }
		IColumnsDefinition ColumnDefinition { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		int InstanceCount { get; set; }
		string FileCabinetId { get; set; }
		DateTime TimeStamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDesignerWorkflow GetDesignerWorkflowFromSelfRelation();
		Task<DeserializedHttpResponse<IDesignerWorkflow>> GetDesignerWorkflowFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWorkflow>> GetDesignerWorkflowFromSelfRelationAsync(CancellationToken cancellationToken);
		IDesignerInstances GetDesignerInstancesFromInstancesRelation();
		Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync();
		Task<DeserializedHttpResponse<IDesignerInstances>> GetDesignerInstancesFromInstancesRelationAsync(CancellationToken cancellationToken);
		IDesignerInstances PostToInstancesRelationForDesignerInstances(IInstancesQuery dataToSend);
		Task<DeserializedHttpResponse<IDesignerInstances>> PostToInstancesRelationForDesignerInstancesAsync(IInstancesQuery dataToSend);
		Task<DeserializedHttpResponse<IDesignerInstances>> PostToInstancesRelationForDesignerInstancesAsync(CancellationToken cancellationToken, IInstancesQuery dataToSend);
		IDesignerWaitingInstances GetDesignerWaitingInstancesFromWaitingInstancesRelation();
		Task<DeserializedHttpResponse<IDesignerWaitingInstances>> GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWaitingInstances>> GetDesignerWaitingInstancesFromWaitingInstancesRelationAsync(CancellationToken cancellationToken);
		IDesignerWorkflowVersions GetDesignerWorkflowVersionsFromVersionsRelation();
		Task<DeserializedHttpResponse<IDesignerWorkflowVersions>> GetDesignerWorkflowVersionsFromVersionsRelationAsync();
		Task<DeserializedHttpResponse<IDesignerWorkflowVersions>> GetDesignerWorkflowVersionsFromVersionsRelationAsync(CancellationToken cancellationToken);
		IHistoryInstances GetHistoryInstancesFromHistoryInstancesRelation();
		Task<DeserializedHttpResponse<IHistoryInstances>> GetHistoryInstancesFromHistoryInstancesRelationAsync();
		Task<DeserializedHttpResponse<IHistoryInstances>> GetHistoryInstancesFromHistoryInstancesRelationAsync(CancellationToken cancellationToken);
		IHistoryInstances PostToHistoryInstancesRelationForHistoryInstances(IInstancesQuery dataToSend);
		Task<DeserializedHttpResponse<IHistoryInstances>> PostToHistoryInstancesRelationForHistoryInstancesAsync(IInstancesQuery dataToSend);
		Task<DeserializedHttpResponse<IHistoryInstances>> PostToHistoryInstancesRelationForHistoryInstancesAsync(CancellationToken cancellationToken, IInstancesQuery dataToSend);
		IWorkflowInstancesCount GetWorkflowInstancesCountFromCountRelation();
		Task<DeserializedHttpResponse<IWorkflowInstancesCount>> GetWorkflowInstancesCountFromCountRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowInstancesCount>> GetWorkflowInstancesCountFromCountRelationAsync(CancellationToken cancellationToken);
    }
}
