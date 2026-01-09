using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskOperations
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
