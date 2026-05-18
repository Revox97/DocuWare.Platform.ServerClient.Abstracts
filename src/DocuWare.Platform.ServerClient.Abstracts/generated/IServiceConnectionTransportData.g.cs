using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceConnectionTransportData
    {
		ProductInfoHeaderValue[] UserAgent { get; set; }
		string ApplicationContext { get; set; }
		HttpMessageHandler HttpClientHandler { get; set; }
		IResiliencePolicyOptions ResiliencePolicyOptions { get; set; }
		StringWithQualityHeaderValue[] AcceptLanguage { get; set; }
		CancellationToken CancellationToken { get; set; }
    }
}
