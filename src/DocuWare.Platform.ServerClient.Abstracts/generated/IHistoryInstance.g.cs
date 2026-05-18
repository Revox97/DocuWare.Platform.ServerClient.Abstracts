using DocuWare.Platform.ServerClient;

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
