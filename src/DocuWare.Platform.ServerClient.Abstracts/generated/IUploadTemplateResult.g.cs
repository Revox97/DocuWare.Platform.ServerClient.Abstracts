using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUploadTemplateResult{3}
    {
		string TemplateGUID { get; set; }
		int TotalNumberOfPages { get; set; }
    }
}
