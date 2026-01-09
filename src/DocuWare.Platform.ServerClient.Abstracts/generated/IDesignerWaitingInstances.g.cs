using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWaitingInstances
    {
		List<IDesignerWaitingInstance> DesignerWaitingInstance { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
