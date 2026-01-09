using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistorySteps
    {
		List<IHistoryStep> HistoryStep { get; set; }
    }
}
