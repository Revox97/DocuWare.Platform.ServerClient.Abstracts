using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextAnnotationToolSettings
    {
		IFontSettings FontSettings { get; set; }
		DocuWare.Platform.ServerClient.AnnotationTools Type { get; set; }
		string Color { get; set; }
    }
}
