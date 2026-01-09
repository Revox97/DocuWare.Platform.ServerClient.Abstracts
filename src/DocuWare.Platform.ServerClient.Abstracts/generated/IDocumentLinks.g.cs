using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentLinks{3}
    {
		List<IDocumentLink> Items { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
