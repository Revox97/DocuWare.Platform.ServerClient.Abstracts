using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionOperations
    {
		IBaseDecisionOperations BaseDecisionOperations { get; set; }
		IExtendedDecisionOperations ExtendedDecisionOperations { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
