using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGetTemplateImageInput
    {
		string TemplateGUID { get; set; }
		string FileName { get; set; }
		int PageNumber { get; set; }
    }
}
