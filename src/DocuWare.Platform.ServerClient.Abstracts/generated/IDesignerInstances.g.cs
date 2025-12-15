using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDesignerInstances
    {
		List<IDesignerInstance> DesignerInstance { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
