using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience
{
    public class ResiliencePolicyOptions(SDK.Policy.Resilience.ResiliencePolicyOptions obj) : IResiliencePolicyOptions
    {
        internal SDK.Policy.Resilience.ResiliencePolicyOptions Obj { get; } = obj;

        public ICircuitBreakerPolicyOptions CircuitBreakerPolicyOptions
        {
            get => new CircuitBreakerPolicyOptions(Obj.CircuitBreakerPolicyOptions);
            set => Obj.CircuitBreakerPolicyOptions = ((CircuitBreakerPolicyOptions)value).Obj;
        }

        public IRetryPolicyOptions RetryPolicyOptions
        {
            get => new RetryPolicyOptions(Obj.RetryPolicyOptions);
            set => Obj.RetryPolicyOptions = ((RetryPolicyOptions)value).Obj;
        }
    }
}
