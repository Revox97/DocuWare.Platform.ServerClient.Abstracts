using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchUpdateResultItem
    {
		IDocument Document { get; set; }
		string ErrorMessage { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
