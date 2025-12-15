using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOrganizationCulture
    {
		string Language { get; set; }
		string DateAndNumberFormatCulture { get; set; }
    }
}
