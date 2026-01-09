using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWaitHistoryStep{3}
    {
		List<IConditionHistoryStep> Conditions { get; set; }
		string Status { get; set; }
    }
}
