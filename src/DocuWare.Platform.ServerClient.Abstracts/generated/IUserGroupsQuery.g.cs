using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserGroupsQuery
    {
		string UserId { get; set; }
		bool Active { get; set; }
		string Name { get; set; }
    }
}
