using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskOperations
    {
		IBaseTaskOperations BaseTaskOperations { get; set; }
		IExtendedControllerOperations ExtendedControllerOperations { get; set; }
		IExtendedUserOperations ExtendedUserOperations { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
