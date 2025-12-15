using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflow
    {
		Link[] Links { get; set; }
		IColumnsDefinition ColumnDefinition { get; set; }
		IWorkflowBehaviorOptions WorkflowBehaviorOptions { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		int TaskCount { get; set; }
		string FileCabinetId { get; set; }
		DateTime TimeStamp { get; set; }
		string ResultListId { get; set; }
		bool HasDocumentFields { get; set; }
		string SelfRelationLink { get; }
		string TasksRelationLink { get; }
		string CountRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IWorkflow GetWorkflowFromSelfRelation();
		Task<DeserializedHttpResponse<IWorkflow>> GetWorkflowFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IWorkflow>> GetWorkflowFromSelfRelationAsync(CancellationToken cancellationToken);
		IWorkflowTasks GetWorkflowTasksFromTasksRelation();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromTasksRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromTasksRelationAsync(CancellationToken cancellationToken);
		IWorkflowTasks PostToTasksRelationForWorkflowTasks(ITasksQuery dataToSend);
		Task<DeserializedHttpResponse<IWorkflowTasks>> PostToTasksRelationForWorkflowTasksAsync(ITasksQuery dataToSend);
		Task<DeserializedHttpResponse<IWorkflowTasks>> PostToTasksRelationForWorkflowTasksAsync(CancellationToken cancellationToken, ITasksQuery dataToSend);
		IWorkflowTasksCount GetWorkflowTasksCountFromCountRelation();
		Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCountRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTasksCount>> GetWorkflowTasksCountFromCountRelationAsync(CancellationToken cancellationToken);
    }
}
