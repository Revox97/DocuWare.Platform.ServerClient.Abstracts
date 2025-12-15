using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBaseDecisionOperations
    {
		Link[] Links { get; set; }
		string SelfRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IDecision GetDecisionFromSelfRelation();
		Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDecision>> GetDecisionFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
