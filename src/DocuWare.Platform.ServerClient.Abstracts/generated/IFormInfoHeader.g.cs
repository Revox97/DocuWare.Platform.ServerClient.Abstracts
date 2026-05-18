using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormInfoHeader
    {
		string Id { get; set; }
		string Name { get; set; }
		string SanitizedName { get; set; }
		string Description { get; set; }
		bool Usage { get; set; }
		bool Admin { get; set; }
		bool Active { get; set; }
		bool Public { get; set; }
    }
}
