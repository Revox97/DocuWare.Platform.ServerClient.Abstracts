using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowTasks
    {
		Link[] Links { get; set; }
		List<IWorkflowTask> Task { get; set; }
		int Count { get; set; }
		DateTime TimeStamp { get; set; }
		bool HasDocumentFields { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IWorkflowTasks GetWorkflowTasksFromNextRelation();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromNextRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromNextRelationAsync(CancellationToken cancellationToken);
		IWorkflowTasks GetWorkflowTasksFromPrevRelation();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromPrevRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromPrevRelationAsync(CancellationToken cancellationToken);
		IWorkflowTasks GetWorkflowTasksFromSelfRelation();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromSelfRelationAsync(CancellationToken cancellationToken);
		IWorkflowTasks GetWorkflowTasksFromFirstRelation();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromFirstRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowTasks>> GetWorkflowTasksFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}
