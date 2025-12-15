using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowDocumentHistory
    {
		List<IInstanceHistory> InstanceHistory { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
