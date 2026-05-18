using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentFlags
    {
		bool IsCold { get; set; }
		bool IsDBRecord { get; set; }
		bool IsCheckedOut { get; set; }
		bool IsCopyRightProtected { get; set; }
		bool IsVoiceAvailable { get; set; }
		bool HasAppendedDocuments { get; set; }
		bool IsProtected { get; set; }
		bool IsDeleted { get; set; }
		bool IsEmail { get; set; }
    }
}
