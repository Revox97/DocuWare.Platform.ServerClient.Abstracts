using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResiliencePolicyOptions(DocuWare.Platform.ServerClient.Policy.Resilience.ResiliencePolicyOptions obj) : IResiliencePolicyOptions
    {
        internal DocuWare.Platform.ServerClient.Policy.Resilience.ResiliencePolicyOptions Obj { get; } = obj;

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
