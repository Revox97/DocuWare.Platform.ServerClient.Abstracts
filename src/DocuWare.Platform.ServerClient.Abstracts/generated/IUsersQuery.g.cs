using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUsersQuery
    {
		bool Active { get; set; }
		string Name { get; set; }
    }
}
