using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAdditionalOrganizationInfo
    {
		List<string> CompanyNames { get; set; }
		List<string> AddressLines { get; set; }
		string Administrator { get; set; }
		string EMail { get; set; }
		string SystemNumber { get; set; }
		string RuntimeVersion { get; set; }
		string OrganizationType { get; set; }
		bool IsAutoLogoutEnabled { get; set; }
		string AutoLogoutTimeout { get; set; }
    }
}
