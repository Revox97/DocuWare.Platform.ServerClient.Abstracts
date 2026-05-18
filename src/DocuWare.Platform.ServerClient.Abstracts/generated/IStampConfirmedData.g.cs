using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampConfirmedData : IConfirmedData
    {
		IAnnotationPoint Position { get; set; }
		int Section { get; set; }
		int Page { get; set; }
		int Layer { get; set; }
    }
}
