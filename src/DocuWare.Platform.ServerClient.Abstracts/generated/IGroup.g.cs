using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGroup
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		bool Active { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IGroup GetGroupFromSelfRelation();
		Task<DeserializedHttpResponse<IGroup>> GetGroupFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IGroup>> GetGroupFromSelfRelationAsync(CancellationToken cancellationToken);
		IUsers GetUsersFromUsersRelation();
		Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync();
		Task<DeserializedHttpResponse<IUsers>> GetUsersFromUsersRelationAsync(CancellationToken cancellationToken);
		string PutToUsersRelationForString(IAssignmentOperation dataToSend);
		Task<DeserializedHttpResponse<string>> PutToUsersRelationForStringAsync(IAssignmentOperation dataToSend);
		Task<DeserializedHttpResponse<string>> PutToUsersRelationForStringAsync(CancellationToken cancellationToken, IAssignmentOperation dataToSend);
    }
}
