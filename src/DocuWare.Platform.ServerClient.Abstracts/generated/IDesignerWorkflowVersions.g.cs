using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWorkflowVersions
    {
		List<IDesignerWorkflowVersion> DesignerWorkflowVersion { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
