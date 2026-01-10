using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceConnectionTransportData
    {
		ProductInfoHeaderValue[] UserAgent { get; set; }
		HttpMessageHandler HttpClientHandler { get; set; }
		StringWithQualityHeaderValue[] AcceptLanguage { get; set; }
		CancellationToken CancellationToken { get; set; }
    }
}
