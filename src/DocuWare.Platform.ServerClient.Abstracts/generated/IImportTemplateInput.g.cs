using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportTemplateInput
    {
		string FileName { get; set; }
		string FileData { get; set; }
		string OrganizationID { get; set; }
    }
}
