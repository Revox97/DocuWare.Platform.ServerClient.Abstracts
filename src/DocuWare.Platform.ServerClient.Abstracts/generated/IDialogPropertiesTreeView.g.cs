using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogPropertiesTreeView : IDialogProperties
    {
		Link[] Links { get; set; }
		string StoreDialogId { get; set; }
		string Icon { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDialog GetDialogFromStoreDialogRelation();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromStoreDialogRelationAsync();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromStoreDialogRelationAsync(CancellationToken cancellationToken);
    }
}
