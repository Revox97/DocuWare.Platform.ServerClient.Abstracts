using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryStep
    {
		IHistoryStepInfo Info { get; set; }
		int StepNumber { get; set; }
		DateTime StepDate { get; set; }
		string ActivityName { get; set; }
		string ActivityType { get; set; }
		StepTypeEnum StepType { get; set; }
    }
}
