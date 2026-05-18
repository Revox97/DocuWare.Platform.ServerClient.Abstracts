using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IEventHistoryStep
    {
		List<IConditionHistoryStep> Conditions { get; set; }
		string FCName { get; set; }
		string DocId { get; set; }
		string Status { get; set; }
    }
}
