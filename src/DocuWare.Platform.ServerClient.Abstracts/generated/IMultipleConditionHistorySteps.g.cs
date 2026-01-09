using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultipleConditionHistorySteps
    {
		List<IConditionHistoryStep> Conditions { get; set; }
    }
}
