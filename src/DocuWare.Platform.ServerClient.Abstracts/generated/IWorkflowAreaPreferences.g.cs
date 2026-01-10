using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowAreaPreferences : IContentAreaPreferences
    {
		List<IWorkInstance> ControllerInstances { get; set; }
		string SelectedControllerInstanceGuid { get; set; }
		string SelectedInstanceGuid { get; set; }
    }
}
