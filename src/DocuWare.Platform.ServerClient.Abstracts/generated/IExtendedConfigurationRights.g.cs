using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExtendedConfigurationRights
    {
		bool Forms { get; set; }
		bool IntelligentInsights { get; set; }
		bool EInvoicingConnector { get; set; }
		bool EInvoicingService { get; set; }
		bool ConfigureIDP { get; set; }
    }
}
