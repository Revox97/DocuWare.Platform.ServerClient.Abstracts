using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IGeneralErrorDecisionHistoryStep
    {
		string UserName { get; set; }
		string DecisionName { get; set; }
    }
}
