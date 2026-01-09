using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStartHistoryStep
    {
		List<IConditionHistoryStep> Conditions { get; set; }
		string DocumentUserVersion { get; set; }
    }
}
