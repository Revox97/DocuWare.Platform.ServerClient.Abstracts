using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRoles
    {
		List<IRole> Item { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
