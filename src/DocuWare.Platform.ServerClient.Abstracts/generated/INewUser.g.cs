using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface INewUser{3}
    {
		string Name { get; set; }
		string DbName { get; set; }
		string Email { get; set; }
		string NetworkId { get; set; }
		string Password { get; set; }
		string ExternalId { get; set; }
		string ExternalProvider { get; set; }
    }
}
