using DocuWare.Platform.ServerClient;

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
    }
}
