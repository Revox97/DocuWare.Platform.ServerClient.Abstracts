using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowRequests
    {
		Link[] Links { get; set; }
		string MyTasksRelationLink { get; }
		string MyTasksCountRelationLink { get; }
		string CreatedWorkflowsRelationLink { get; }
		string CreatedWorkflowsCountRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IRequestTasks GetRequestTasksFromMyTasksRelation();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromMyTasksRelationAsync();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromMyTasksRelationAsync(CancellationToken cancellationToken);
		IRequestTasks PostToMyTasksRelationForRequestTasks(ITasksQuery dataToSend);
		Task<DeserializedHttpResponse<IRequestTasks>> PostToMyTasksRelationForRequestTasksAsync(ITasksQuery dataToSend);
		Task<DeserializedHttpResponse<IRequestTasks>> PostToMyTasksRelationForRequestTasksAsync(CancellationToken cancellationToken, ITasksQuery dataToSend);
		IWorkflowTasksCount GetWorkflowTasksCountFromMyTasksCountRelation();
		Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromMyTasksCountRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromMyTasksCountRelationAsync(CancellationToken cancellationToken);
		IOwnWorkflows GetOwnWorkflowsFromCreatedWorkflowsRelation();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromCreatedWorkflowsRelationAsync();
		Task<DeserializedHttpResponse<IOwnWorkflows>> GetOwnWorkflowsFromCreatedWorkflowsRelationAsync(CancellationToken cancellationToken);
		IOwnWorkflows PostToCreatedWorkflowsRelationForOwnWorkflows(ITasksQuery dataToSend);
		Task<DeserializedHttpResponse<IOwnWorkflows>> PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(ITasksQuery dataToSend);
		Task<DeserializedHttpResponse<IOwnWorkflows>> PostToCreatedWorkflowsRelationForOwnWorkflowsAsync(CancellationToken cancellationToken, ITasksQuery dataToSend);
		IWorkflowTasksCount GetWorkflowTasksCountFromCreatedWorkflowsCountRelation();
		Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCreatedWorkflowsCountRelationAsync(CancellationToken cancellationToken);
    }
}
