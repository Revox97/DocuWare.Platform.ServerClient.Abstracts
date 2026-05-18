using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface INewUser
    {
		IRegionalSettings RegionalSettings { get; set; }
		string Name { get; set; }
		string DbName { get; set; }
		string Email { get; set; }
		string NetworkId { get; set; }
		string Password { get; set; }
		string ExternalId { get; set; }
		string ExternalProvider { get; set; }
		string ExternalIdpUserId { get; set; }
		string ExternalIdp { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		bool SkipCreatingDocumentTray { get; set; }
    }
}
