using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestDecision
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string Label { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IRequestDecision GetRequestDecisionFromSelfRelation();
		Task<DeserializedHttpResponse<IRequestDecision>> GetRequestDecisionFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IRequestDecision>> GetRequestDecisionFromSelfRelationAsync(CancellationToken cancellationToken);
		string PostToConfirmRelationForString(IRequestConfirmedData dataToSend);
		Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(IRequestConfirmedData dataToSend);
		Task<DeserializedHttpResponse<string>> PostToConfirmRelationForStringAsync(CancellationToken cancellationToken, IRequestConfirmedData dataToSend);
    }
}
