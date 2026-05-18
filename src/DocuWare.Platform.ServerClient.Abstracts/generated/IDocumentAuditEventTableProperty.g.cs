using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventTableProperty
    {
		List<IDocumentAuditEventTablePropertyColumn> Column { get; set; }
		List<List<string>> OldValues { get; set; }
		List<List<string>> NewValues { get; set; }
		string PropertyName { get; set; }
    }
}
