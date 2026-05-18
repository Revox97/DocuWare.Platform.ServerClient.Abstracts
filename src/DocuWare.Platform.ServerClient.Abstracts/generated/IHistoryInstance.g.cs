using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryInstance
    {
		Link[] Links { get; set; }
		List<IColumnValue> ColumnValues { get; set; }
		string Id { get; set; }
		int DocId { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IHistoryInstance GetHistoryInstanceFromSelfRelation();
		Task<DeserializedHttpResponse<IHistoryInstance>> GetHistoryInstanceFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IHistoryInstance>> GetHistoryInstanceFromSelfRelationAsync(CancellationToken cancellationToken);
		IInstanceHistory GetInstanceHistoryFromHistoryRelation();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync();
		Task<DeserializedHttpResponse<IInstanceHistory>> GetInstanceHistoryFromHistoryRelationAsync(CancellationToken cancellationToken);
    }
}
