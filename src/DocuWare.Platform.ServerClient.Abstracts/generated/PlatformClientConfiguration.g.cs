using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PlatformClientConfiguration(DocuWare.Platform.ServerClient.PlatformClientConfiguration obj) : IPlatformClientConfiguration
    {
        internal DocuWare.Platform.ServerClient.PlatformClientConfiguration Obj { get; } = obj;

		public string GetHostId() => Obj.GetHostId();

		public void AddProductInfoHeaderValueOfExecutingApplication(HttpHeaderValueCollection<ProductInfoHeaderValue> userAgent) => Obj.AddProductInfoHeaderValueOfExecutingApplication(userAgent);

		public HttpMessageHandler CreateDefaultHttpMessageHandler() => Obj.CreateDefaultHttpMessageHandler();

		public HttpClientHandler CreateHandlerForNTLMAuthentication(ICredentials credentials) => Obj.CreateHandlerForNTLMAuthentication(credentials);

		public HttpClientHandler CreateHandlerForNTLMAuthentication(Uri serviceUri, string userName, string password, string domain) => Obj.CreateHandlerForNTLMAuthentication(serviceUri, userName, password, domain);

		public int? GetRequestTimeout() => Obj.GetRequestTimeout();
    }
}
