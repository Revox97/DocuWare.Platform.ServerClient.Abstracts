using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRole
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		bool Active { get; set; }
		DocuWare.Platform.ServerClient.RoleTypes Type { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IRole GetRoleFromSelfRelation();
		Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IRole>> GetRoleFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
