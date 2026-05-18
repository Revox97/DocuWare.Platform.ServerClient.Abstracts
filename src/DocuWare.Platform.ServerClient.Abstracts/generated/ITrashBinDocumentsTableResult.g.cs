using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITrashBinDocumentsTableResult
    {
		ICountPlusValue Count { get; set; }
		List<ITrashBinTableHeader> Headers { get; set; }
		List<ITrashBinTableRow> Rows { get; set; }
		Link[] Links { get; set; }
		DateTime TimeStamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
		ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromNextRelation();
		Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromNextRelationAsync(CancellationToken cancellationToken);
		ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromPrevRelation();
		Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromPrevRelationAsync();
		Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromPrevRelationAsync(CancellationToken cancellationToken);
		ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromSelfRelation();
		Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromSelfRelationAsync();
		Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromSelfRelationAsync(CancellationToken cancellationToken);
		ITrashBinDocumentsTableResult GetTrashBinDocumentsTableResultFromFirstRelation();
		Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromFirstRelationAsync();
		Task<DeserializedHttpResponse<ITrashBinDocumentsTableResult>> GetTrashBinDocumentsTableResultFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}
