using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IThrottleDelegatingHandler
    {
		HttpMessageHandler InnerHandler { get; set; }
    }
}
