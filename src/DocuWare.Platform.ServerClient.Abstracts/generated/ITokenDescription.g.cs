using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITokenDescription
    {
		List<DWProductTypes> TargetProducts { get; set; }
		TokenUsage Usage { get; set; }
		string Lifetime { get; set; }
    }
}
