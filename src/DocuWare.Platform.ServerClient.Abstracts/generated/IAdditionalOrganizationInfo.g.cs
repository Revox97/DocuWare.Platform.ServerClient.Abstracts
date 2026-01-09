using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAdditionalOrganizationInfo{3}
    {
		List<string> CompanyNames { get; set; }
		List<string> AddressLines { get; set; }
		string Administrator { get; set; }
		string EMail { get; set; }
		string SystemNumber { get; set; }
		string RuntimeVersion { get; set; }
		string OrganizationType { get; set; }
    }
}
