using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetField : IFileCabinetFieldBase
    {
		List<IFileCabinetFieldBase> TableFieldColumns { get; set; }
		bool UsedAsDocumentName { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
