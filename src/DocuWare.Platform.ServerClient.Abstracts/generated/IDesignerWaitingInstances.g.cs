using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerWaitingInstances{3}
    {
		List<IDesignerWaitingInstance> DesignerWaitingInstance { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
