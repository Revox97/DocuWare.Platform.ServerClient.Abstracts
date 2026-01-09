using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchUpdateIndexFieldsResult{3}
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
