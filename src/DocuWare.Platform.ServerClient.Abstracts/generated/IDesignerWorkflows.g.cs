using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWorkflows
    {
		List<IDesignerWorkflow> Workflow { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
