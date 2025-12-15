using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestDecisionHistoryStep
    {
		List<IHistoryField> InputFields { get; set; }
		string DocumentUserVersion { get; set; }
		string UserName { get; set; }
		string DecisionName { get; set; }
		DateTime DecisionDate { get; set; }
		string Color { get; set; }
    }
}
