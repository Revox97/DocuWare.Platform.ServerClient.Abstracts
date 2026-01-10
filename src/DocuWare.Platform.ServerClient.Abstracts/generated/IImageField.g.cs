using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImageField : IWebFormField
    {
		int OriginalImageWidth { get; set; }
		int OriginalImageSize { get; set; }
		AlignmentType Alignment { get; set; }
    }
}
