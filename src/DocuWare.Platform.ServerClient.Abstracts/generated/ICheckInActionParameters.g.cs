using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckInActionParameters : IDocumentActionParameters
    {
		string MediaType { get; }
		IDocumentVersion DocumentVersion { get; set; }
		CheckInReturnDocument CheckInReturnDocument { get; set; }
		string Comments { get; set; }
    }
}
