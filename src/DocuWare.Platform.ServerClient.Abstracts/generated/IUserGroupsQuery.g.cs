using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserGroupsQuery{3}
    {
		string UserId { get; set; }
		bool Active { get; set; }
		string Name { get; set; }
    }
}
