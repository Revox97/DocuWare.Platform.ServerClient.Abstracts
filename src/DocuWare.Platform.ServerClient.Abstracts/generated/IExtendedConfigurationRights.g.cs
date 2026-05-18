using DocuWare.Platform.ServerClient;

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
