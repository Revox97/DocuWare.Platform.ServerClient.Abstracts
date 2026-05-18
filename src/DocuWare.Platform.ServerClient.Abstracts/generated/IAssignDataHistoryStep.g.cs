using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAssignDataHistoryStep
    {
		List<IHistoryField> Fields { get; set; }
		List<IFileCabinetHistoryField> FileCabinetFields { get; set; }
		List<IConditionHistoryStep> Conditions { get; set; }
    }
}
