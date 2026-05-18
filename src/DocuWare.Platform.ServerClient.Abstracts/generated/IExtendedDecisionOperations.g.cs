using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExtendedDecisionOperations
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		string PostToConfirmRelationForString(IConfirmedData dataToSend);
		Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(IConfirmedData dataToSend);
		Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(CancellationToken cancellationToken, IConfirmedData dataToSend);
		IDWPoint PostToStampBestPositionRelationForDWPoint(IStampPositionData dataToSend);
		Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(IStampPositionData dataToSend);
		Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(CancellationToken cancellationToken, IStampPositionData dataToSend);
    }
}
