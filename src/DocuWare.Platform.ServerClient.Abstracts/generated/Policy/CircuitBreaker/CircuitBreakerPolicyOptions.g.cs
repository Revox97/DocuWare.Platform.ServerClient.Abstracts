using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker
{
    public class CircuitBreakerPolicyOptions(SDK.Policy.CircuitBreaker.CircuitBreakerPolicyOptions obj) : ICircuitBreakerPolicyOptions
    {
        internal SDK.Policy.CircuitBreaker.CircuitBreakerPolicyOptions Obj { get; } = obj;

        public int ClosedFailureThreshold => Obj.ClosedFailureThreshold;

        public int HalfOpenedFailureThreshold => Obj.HalfOpenedFailureThreshold;

        public TimeSpan BreakDuration => Obj.BreakDuration;
    }
}
