using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRectEntry : IEntryBase
    {
		IAnnotationRectangle Location { get; set; }
		bool Filled { get; set; }
		bool Ellipse { get; set; }
		string FillColor { get; set; }
    }
}
