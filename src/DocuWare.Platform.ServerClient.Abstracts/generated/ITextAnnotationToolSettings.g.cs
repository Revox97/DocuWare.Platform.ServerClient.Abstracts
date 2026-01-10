using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextAnnotationToolSettings : IAnnotationToolSettings
    {
		IFontSettings FontSettings { get; set; }
    }
}
