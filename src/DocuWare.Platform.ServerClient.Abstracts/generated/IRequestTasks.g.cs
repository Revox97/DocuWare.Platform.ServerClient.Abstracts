using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestTasks
    {
		Link[] Links { get; set; }
		List<IRequestTask> Task { get; set; }
		int Count { get; set; }
		DateTime TimeStamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IRequestTasks GetRequestTasksFromNextRelation();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromNextRelationAsync();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromNextRelationAsync(CancellationToken cancellationToken);
		IRequestTasks GetRequestTasksFromPrevRelation();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromPrevRelationAsync();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromPrevRelationAsync(CancellationToken cancellationToken);
		IRequestTasks GetRequestTasksFromSelfRelation();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromSelfRelationAsync(CancellationToken cancellationToken);
		IRequestTasks GetRequestTasksFromFirstRelation();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromFirstRelationAsync();
		Task<DeserializedHttpResponse<IRequestTasks>> GetRequestTasksFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}
