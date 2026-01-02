using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITextAnnotationToolSettings
    {
		DocuWare.Platform.ServerClient.AnnotationTools Type { get; set; }
		string Color { get; set; }
    }
}
