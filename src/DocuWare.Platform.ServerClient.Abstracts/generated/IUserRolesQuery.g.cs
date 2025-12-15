using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserRolesQuery
    {
		string UserId { get; set; }
		bool Active { get; set; }
		bool ActiveSpecified { get; set; }
		string Type { get; set; }
		string Name { get; set; }
    }
}
