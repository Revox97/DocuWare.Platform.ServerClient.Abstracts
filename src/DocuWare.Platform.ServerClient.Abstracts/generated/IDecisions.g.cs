using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisions
    {
		List<IDecision> Decision { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
