using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IThrottleDelegatingHandler: DelegatingHandler
    {
		HttpMessageHandler InnerHandler { get; set; }
    }
}
