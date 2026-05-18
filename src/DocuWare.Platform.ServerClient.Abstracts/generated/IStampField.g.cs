using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampField
    {
		IDocumentIndexFieldValue Value { get; set; }
		string Name { get; set; }
		DWFieldType DWType { get; set; }
		int Length { get; set; }
		bool HasFixedEntry { get; set; }
    }
}
