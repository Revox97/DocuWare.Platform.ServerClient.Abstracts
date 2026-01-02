using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IImportResult
    {
		List<IImportResultEntry> Results { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
