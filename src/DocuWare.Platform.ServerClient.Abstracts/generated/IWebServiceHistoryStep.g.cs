using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebServiceHistoryStep
    {
		List<IHistoryField> Parameters { get; set; }
		List<IHistoryField> Results { get; set; }
		List<IConditionHistoryStep> Conditions { get; set; }
		string Method { get; set; }
    }
}
