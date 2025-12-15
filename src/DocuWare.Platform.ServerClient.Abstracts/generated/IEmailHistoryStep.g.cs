using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IEmailHistoryStep
    {
		List<string> Recipients { get; set; }
		List<string> Cc { get; set; }
		List<IConditionHistoryStep> Conditions { get; set; }
		string Subject { get; set; }
    }
}
