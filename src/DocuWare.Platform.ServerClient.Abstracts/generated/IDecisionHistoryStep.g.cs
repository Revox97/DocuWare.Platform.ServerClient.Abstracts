using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionHistoryStep
    {
		List<IHistoryField> InputFields { get; set; }
		List<IHistoryField> Assignments { get; set; }
		List<IFileCabinetHistoryField> FileCabinetAssignments { get; set; }
		List<IConditionHistoryStep> Conditions { get; set; }
		string DocumentUserVersion { get; set; }
		string UserName { get; set; }
		string DecisionName { get; set; }
		DateTime DecisionDate { get; set; }
		string Color { get; set; }
    }
}
