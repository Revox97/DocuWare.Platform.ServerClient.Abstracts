using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOrganizationCulture{3}
    {
		string Language { get; set; }
		string DateAndNumberFormatCulture { get; set; }
    }
}
