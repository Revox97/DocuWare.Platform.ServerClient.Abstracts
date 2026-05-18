using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRetryPolicyOptions
    {
		int MaxRetryAttempts { get; }
		TimeSpan FirstRetryDelay { get; }
    }
}
