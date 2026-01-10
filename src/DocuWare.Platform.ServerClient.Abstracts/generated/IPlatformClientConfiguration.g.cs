using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPlatformClientConfiguration
    {

		string GetHostId();
		void AddProductInfoHeaderValueOfExecutingApplication(HttpHeaderValueCollection<ProductInfoHeaderValue> userAgent);
		HttpMessageHandler CreateDefaultHttpMessageHandler();
		HttpClientHandler CreateHandlerForNTLMAuthentication(ICredentials credentials);
		HttpClientHandler CreateHandlerForNTLMAuthentication(Uri serviceUri, string userName, string password, string? domain = null);
		int? GetRequestTimeout();
    }
}
