using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IContentDivideOperationInfo
    {
		List<int> Pages { get; set; }
		List<string> ResultNames { get; set; }
		ContentDivideOperation Operation { get; set; }
		bool Force { get; set; }
    }
}
