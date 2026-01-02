using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IInstanceHistory
    {
		Link[] Links { get; set; }
		List<IHistoryStep> HistorySteps { get; set; }
		string Id { get; set; }
		string WorkflowId { get; set; }
		string Name { get; set; }
		int Version { get; set; }
		bool WorkflowRequest { get; set; }
		DateTime StartedAt { get; set; }
		int DocId { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IInstanceHistory GetInstanceHistoryFromSelfRelation();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
