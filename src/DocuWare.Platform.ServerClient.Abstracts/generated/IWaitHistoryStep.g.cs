using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWaitHistoryStep
    {
		List<IConditionHistoryStep> Conditions { get; set; }
		string Status { get; set; }
    }
}
