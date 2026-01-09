using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisions{3}
    {
		List<IDecision> Decision { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
