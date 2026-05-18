using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker
{
    public interface ICircuitBreakerPolicyOptions
    {
		int ClosedFailureThreshold { get; }
		int HalfOpenedFailureThreshold { get; }
		TimeSpan BreakDuration { get; }
    }
}
