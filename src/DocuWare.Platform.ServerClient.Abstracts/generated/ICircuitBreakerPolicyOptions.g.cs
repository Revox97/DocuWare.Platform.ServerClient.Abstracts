using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICircuitBreakerPolicyOptions
    {
		int ClosedFailureThreshold { get; }
		int HalfOpenedFailureThreshold { get; }
		TimeSpan BreakDuration { get; }
    }
}
