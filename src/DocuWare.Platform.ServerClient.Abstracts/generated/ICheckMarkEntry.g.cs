using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICheckMarkEntry : IEntryBase
    {
		IStroke Stroke { get; set; }
		IAnnotationRectangle Location { get; set; }
    }
}
