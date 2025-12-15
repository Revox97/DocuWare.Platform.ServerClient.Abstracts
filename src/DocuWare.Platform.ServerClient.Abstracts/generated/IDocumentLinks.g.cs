using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentLinks
    {
		List<IDocumentLink> Items { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
