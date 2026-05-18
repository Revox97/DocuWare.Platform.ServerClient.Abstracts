using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICrossMarkEntry : IEntryBase
    {
		IStroke Stroke { get; set; }
		IAnnotationRectangle Location { get; set; }
    }
}
