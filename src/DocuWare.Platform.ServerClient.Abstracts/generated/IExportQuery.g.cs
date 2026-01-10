using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExportQuery
    {
		IExportSettings Settings { get; set; }
		IDocumentsQuery Source { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
