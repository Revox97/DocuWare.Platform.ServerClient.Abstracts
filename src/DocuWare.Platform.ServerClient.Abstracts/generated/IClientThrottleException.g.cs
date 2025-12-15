using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IClientThrottleException
    {
		TimeSpan RetryAfterInterval { get; }
		string Message { get; }
		MethodBase TargetSite { get; }
		IDictionary Data { get; }
		Exception InnerException { get; }
		string HelpLink { get; set; }
		string Source { get; set; }
		int HResult { get; set; }
		string StackTrace { get; }
    }
}
