using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAdhocRenderingFiles{3}
    {
		List<IAdhocRenderingFile> Item { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
