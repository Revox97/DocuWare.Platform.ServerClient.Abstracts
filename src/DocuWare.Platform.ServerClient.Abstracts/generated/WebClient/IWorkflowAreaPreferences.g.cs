using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.WebClient
{
    public interface IWorkflowAreaPreferences : IContentAreaPreferences
    {
		List<IWorkInstance> ControllerInstances { get; set; }
		string SelectedControllerInstanceGuid { get; set; }
		string SelectedInstanceGuid { get; set; }
    }
}
