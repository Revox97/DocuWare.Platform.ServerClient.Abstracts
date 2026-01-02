using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PlatformClientConfiguration(SDK.PlatformClientConfiguration obj) : IPlatformClientConfiguration
    {
        internal SDK.PlatformClientConfiguration Obj { get; } = obj;

        public ProductInfoHeaderValue DefaultProductInfoHeader
        {
            get => Obj.DefaultProductInfoHeader;
            set => Obj.DefaultProductInfoHeader = value;
        }

		public async string GetHostId() => Obj.GetHostId();

		public async void AddProductInfoHeaderValueOfExecutingApplication(HttpHeaderValueCollection<ProductInfoHeaderValue> userAgent) => Obj.AddProductInfoHeaderValueOfExecutingApplication(userAgent);

		public async HttpMessageHandler CreateDefaultHttpMessageHandler() => Obj.CreateDefaultHttpMessageHandler();

		public async HttpClientHandler CreateHandlerForNTLMAuthentication(ICredentials credentials) => Obj.CreateHandlerForNTLMAuthentication(credentials);

		public async HttpClientHandler CreateHandlerForNTLMAuthentication(Uri serviceUri, string userName, string password, string domain) => Obj.CreateHandlerForNTLMAuthentication(serviceUri, userName, password, domain);

		public async int? GetRequestTimeout() => Obj.GetRequestTimeout();
    }
}
