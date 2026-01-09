using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserRolesQuery{3}
    {
		string UserId { get; set; }
		bool Active { get; set; }
		string Type { get; set; }
		string Name { get; set; }
    }
}
