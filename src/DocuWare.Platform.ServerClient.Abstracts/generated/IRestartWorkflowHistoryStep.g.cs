using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRestartWorkflowHistoryStep{3}
    {
		List<IHistoryField> Fields { get; set; }
		string ErrorMessage { get; set; }
		string FullErrorMessage { get; set; }
    }
}
