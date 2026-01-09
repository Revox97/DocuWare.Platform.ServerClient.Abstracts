using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflows
    {
		List<IWorkflow> Workflow { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
