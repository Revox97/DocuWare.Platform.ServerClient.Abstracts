using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Exceptions
{
    public interface IClientTimeoutException
    {
		MethodBase TargetSite { get; }
		string Message { get; }
		System.Collections.IDictionary Data { get; }
		Exception InnerException { get; }
		string HelpLink { get; set; }
		string Source { get; set; }
		int HResult { get; set; }
		string StackTrace { get; }
    }
}
