using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUserPropertyQuery
    {
		IOutOfOffice OutOfOffice { get; set; }
		string Id { get; set; }
		bool Active { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Salutation { get; set; }
    }
}
