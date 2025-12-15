using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserPropertyQuery
    {
		IOutOfOffice OutOfOffice { get; set; }
		string Id { get; set; }
		bool Active { get; set; }
		bool ActiveSpecified { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Salutation { get; set; }
    }
}
