using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExportTemplateInput{3}
    {
		string ConfigGUID { get; set; }
		string TemplateGUID { get; set; }
		string OrganizationID { get; set; }
    }
}
