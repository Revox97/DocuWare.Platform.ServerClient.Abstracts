using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRolesQuery
    {
		bool Active { get; set; }
		string Name { get; set; }
		string Type { get; set; }
    }
}
