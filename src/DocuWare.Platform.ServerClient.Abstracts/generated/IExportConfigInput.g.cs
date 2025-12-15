using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExportConfigInput
    {
		string ConfigGUID { get; set; }
		string OrganizationID { get; set; }
    }
}
