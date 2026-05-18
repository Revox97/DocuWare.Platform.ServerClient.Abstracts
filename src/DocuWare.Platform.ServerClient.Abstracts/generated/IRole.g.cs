using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRole
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		bool Active { get; set; }
		RoleTypes Type { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IRole GetRoleFromSelfRelation();
		Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
