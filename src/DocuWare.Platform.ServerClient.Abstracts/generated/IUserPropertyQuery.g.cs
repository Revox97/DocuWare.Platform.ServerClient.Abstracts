using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserPropertyQuery{3}
    {
		string Id { get; set; }
		bool Active { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Salutation { get; set; }
    }
}
