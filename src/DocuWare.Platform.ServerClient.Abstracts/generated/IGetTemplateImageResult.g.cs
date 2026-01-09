using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGetTemplateImageResult
    {
		string FileName { get; set; }
		string FileData { get; set; }
		int ImageDPI { get; set; }
    }
}
