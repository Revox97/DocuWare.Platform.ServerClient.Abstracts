using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IEmailHistoryStep
    {
		List<string> Recipients { get; set; }
		List<string> Cc { get; set; }
		List<IConditionHistoryStep> Conditions { get; set; }
		string Subject { get; set; }
    }
}
