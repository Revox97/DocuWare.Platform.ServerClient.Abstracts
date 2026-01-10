using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRectEntry : IEntryBase
    {
		IAnnotationRectangle Location { get; set; }
		bool Filled { get; set; }
		bool Ellipse { get; set; }
    }
}
