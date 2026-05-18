using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CircuitBreakerPolicyOptions(DocuWare.Platform.ServerClient.Policy.CircuitBreaker.CircuitBreakerPolicyOptions obj) : ICircuitBreakerPolicyOptions
    {
        internal DocuWare.Platform.ServerClient.Policy.CircuitBreaker.CircuitBreakerPolicyOptions Obj { get; } = obj;

        public int ClosedFailureThreshold => Obj.ClosedFailureThreshold;

        public int HalfOpenedFailureThreshold => Obj.HalfOpenedFailureThreshold;

        public TimeSpan BreakDuration => Obj.BreakDuration;
    }
}
