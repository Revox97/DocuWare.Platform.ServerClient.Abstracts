using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAnnotationToolSettings
    {
		DocuWare.Platform.ServerClient.AnnotationTools Type { get; set; }
		string Color { get; set; }
    }
}
