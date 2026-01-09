using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGetTemplateImageResult{3}
    {
		string FileName { get; set; }
		string FileData { get; set; }
		int ImageDPI { get; set; }
    }
}
