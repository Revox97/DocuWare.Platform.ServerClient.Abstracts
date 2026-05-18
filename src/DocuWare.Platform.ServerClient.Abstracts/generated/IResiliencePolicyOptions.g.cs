using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IResiliencePolicyOptions
    {
		ICircuitBreakerPolicyOptions CircuitBreakerPolicyOptions { get; set; }
		IRetryPolicyOptions RetryPolicyOptions { get; set; }
    }
}
