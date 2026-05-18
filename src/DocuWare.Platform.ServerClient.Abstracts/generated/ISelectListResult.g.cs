using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListResult
    {
		List<string> Value { get; set; }
		List<IDocumentIndexFieldValue> TypedValue { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		ISelectListResult GetSelectListResultFromNextRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromNextRelationAsync(CancellationToken cancellationToken);
		ISelectListResult GetSelectListResultFromPrevRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromPrevRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromPrevRelationAsync(CancellationToken cancellationToken);
		ISelectListResult GetSelectListResultFromSelfRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelfRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromSelfRelationAsync(CancellationToken cancellationToken);
		ISelectListResult GetSelectListResultFromFirstRelation();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromFirstRelationAsync();
		Task<DeserializedHttpResponse<ISelectListResult>> GetSelectListResultFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}
