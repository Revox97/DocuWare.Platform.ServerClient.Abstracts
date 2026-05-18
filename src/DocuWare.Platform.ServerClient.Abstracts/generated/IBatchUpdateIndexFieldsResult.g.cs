using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchUpdateIndexFieldsResult
    {
		List<IBatchUpdateResultItem> Item { get; set; }
		Link[] Links { get; set; }
		int SuccessCount { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IBatchUpdateIndexFieldsResult PostToNextRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcessData dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToNextRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcessData dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToNextRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcessData dataToSend);
    }
}
