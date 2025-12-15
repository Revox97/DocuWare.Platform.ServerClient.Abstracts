using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRestartWorkflowHistoryStep
    {
		List<IHistoryField> Fields { get; set; }
		string ErrorMessage { get; set; }
		string FullErrorMessage { get; set; }
    }
}
