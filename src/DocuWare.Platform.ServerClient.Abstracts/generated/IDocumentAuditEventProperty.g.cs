using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventProperty
    {
		string PropertyName { get; set; }
		string OldValue { get; set; }
		string NewValue { get; set; }
		DWFieldType DWFieldType { get; set; }
    }
}
