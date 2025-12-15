using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRole
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		bool Active { get; set; }
		RoleTypes Type { get; set; }
		string SelfRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IRole GetRoleFromSelfRelation();
		Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
