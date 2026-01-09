using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportConfigInput{3}
    {
		string FileName { get; set; }
		string FileData { get; set; }
		string OrganizationID { get; set; }
    }
}
