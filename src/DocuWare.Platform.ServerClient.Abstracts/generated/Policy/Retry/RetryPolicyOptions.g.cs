using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Policy.Retry
{
    public class RetryPolicyOptions(SDK.Policy.Retry.RetryPolicyOptions obj) : IRetryPolicyOptions
    {
        internal SDK.Policy.Retry.RetryPolicyOptions Obj { get; } = obj;

        public int MaxRetryAttempts => Obj.MaxRetryAttempts;

        public TimeSpan FirstRetryDelay => Obj.FirstRetryDelay;
    }
}
