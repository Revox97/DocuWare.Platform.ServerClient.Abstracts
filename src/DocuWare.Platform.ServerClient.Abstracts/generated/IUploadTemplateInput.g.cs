using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUploadTemplateInput{3}
    {
		string TemplateGUID { get; set; }
		string FileName { get; set; }
		string FileData { get; set; }
    }
}
