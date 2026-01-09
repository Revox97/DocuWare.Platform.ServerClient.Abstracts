using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionOperations
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
