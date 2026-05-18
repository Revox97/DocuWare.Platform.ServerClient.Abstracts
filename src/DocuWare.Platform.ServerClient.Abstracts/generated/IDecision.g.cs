using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecision
    {
		List<ITaskFormField> TaskFormField { get; set; }
		IDecisionOperations DecisionOperations { get; set; }
		Link[] Links { get; set; }
		int Id { get; set; }
		string Description { get; set; }
		string Label { get; set; }
		string Color { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
