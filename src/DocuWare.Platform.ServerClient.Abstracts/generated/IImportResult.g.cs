using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportResult{3}
    {
		List<IImportResultEntry> Results { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
