using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStartHistoryStep{3}
    {
		List<IConditionHistoryStep> Conditions { get; set; }
		string DocumentUserVersion { get; set; }
    }
}
