using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogField : IDialogFieldBase
    {
		List<IDialogFieldBase> DialogTableFieldColumns { get; set; }
		bool UsedAsDocumentName { get; set; }
		bool IsHierarchy { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
