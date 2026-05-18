using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
