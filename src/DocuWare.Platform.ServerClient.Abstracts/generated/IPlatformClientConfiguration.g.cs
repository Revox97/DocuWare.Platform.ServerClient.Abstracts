using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPlatformClientConfiguration
    {

		string GetHostId();
		void AddProductInfoHeaderValueOfExecutingApplication(HttpHeaderValueCollection<ProductInfoHeaderValue> userAgent);
		IRetryPolicyOptions CreateDefaultRetryPolicyOptions();
		ICircuitBreakerPolicyOptions CreateDefaultCircuitBreakerPolicyOptions();
		HttpMessageHandler CreateDefaultHttpMessageHandler();
		HttpClientHandler CreateHandlerForNTLMAuthentication(ICredentials credentials);
		HttpClientHandler CreateHandlerForNTLMAuthentication(Uri serviceUri, string userName, string password, string? domain = null);
		int? GetRequestTimeout();
    }
}
