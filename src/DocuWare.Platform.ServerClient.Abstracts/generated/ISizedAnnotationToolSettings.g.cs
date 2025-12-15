using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISizedAnnotationToolSettings
    {
		int LineSize { get; set; }
		DocuWare.Platform.ServerClient.AnnotationTools Type { get; set; }
		string Color { get; set; }
    }
}
