using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISectionAnnotationsPlacement
    {
		IAnnotationsPlacement AnnotationsPlacement { get; set; }
		int SectionNumber { get; set; }
		int PageNumber { get; set; }
    }
}
