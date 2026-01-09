using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExportTemplateInput
    {
		string ConfigGUID { get; set; }
		string TemplateGUID { get; set; }
		string OrganizationID { get; set; }
    }
}
