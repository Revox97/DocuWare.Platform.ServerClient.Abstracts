using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAnnotationToolSettings
    {
		AnnotationTools Type { get; set; }
		string Color { get; set; }
    }
}
