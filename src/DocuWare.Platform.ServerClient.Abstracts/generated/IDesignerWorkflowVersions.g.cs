using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWorkflowVersions{3}
    {
		List<IDesignerWorkflowVersion> DesignerWorkflowVersion { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
