using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExtendedDecisionOperations
    {
		Link[] Links { get; set; }
		string ConfirmRelationLink { get; }
		string StampBestPositionRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		string PostToConfirmRelationForString(IConfirmedData dataToSend);
		Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(IConfirmedData dataToSend);
		Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(CancellationToken cancellationToken, IConfirmedData dataToSend);
		IDWPoint PostToStampBestPositionRelationForDWPoint(IStampPositionData dataToSend);
		Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(IStampPositionData dataToSend);
		Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(CancellationToken cancellationToken, IStampPositionData dataToSend);
    }
}
