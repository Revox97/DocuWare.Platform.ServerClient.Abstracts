using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RetryPolicyOptions(DocuWare.Platform.ServerClient.Policy.Retry.RetryPolicyOptions obj) : IRetryPolicyOptions
    {
        internal DocuWare.Platform.ServerClient.Policy.Retry.RetryPolicyOptions Obj { get; } = obj;

        public int MaxRetryAttempts => Obj.MaxRetryAttempts;

        public TimeSpan FirstRetryDelay => Obj.FirstRetryDelay;
    }
}
