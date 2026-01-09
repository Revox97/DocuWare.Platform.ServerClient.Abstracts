using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskOperations{3}
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
