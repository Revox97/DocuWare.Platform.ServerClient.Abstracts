using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAuditEvent
    {
		string Id { get; set; }
		string Event { get; set; }
		string Type { get; set; }
		string Name { get; set; }
		string User { get; set; }
		DateTime Date { get; set; }
    }
}
