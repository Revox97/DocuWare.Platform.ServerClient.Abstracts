using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBaseTaskOperations
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IWorkflowTask GetWorkflowTaskFromSelfRelation();
		Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromSelfRelationAsync(CancellationToken cancellationToken);
		IWorkflowTask GetWorkflowTaskFromMaintenanceSelfRelation();
		Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromMaintenanceSelfRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTask>> GetWorkflowTaskFromMaintenanceSelfRelationAsync(CancellationToken cancellationToken);
		string PostToReassignedTaskRelationForString(IReassignmentData dataToSend);
		Task<DeserializedHttpResponse<string>> PostToReassignedTaskRelationForStringAsync(IReassignmentData dataToSend);
		Task<DeserializedHttpResponse<string>> PostToReassignedTaskRelationForStringAsync(CancellationToken cancellationToken, IReassignmentData dataToSend);
		IInstanceHistory GetInstanceHistoryFromHistoryRelation();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync(CancellationToken cancellationToken);
		IDecisionsStampSettings GetDecisionsStampSettingsFromStampSettingsRelation();
		Task<DeserializedHttpResponse<IDecisionsStampSettings>> GetDecisionsStampSettingsFromStampSettingsRelationAsync();
		Task<DeserializedHttpResponse<IDecisionsStampSettings>> GetDecisionsStampSettingsFromStampSettingsRelationAsync(CancellationToken cancellationToken);
    }
}
