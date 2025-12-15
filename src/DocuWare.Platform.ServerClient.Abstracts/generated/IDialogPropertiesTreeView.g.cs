using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogPropertiesTreeView
    {
		Link[] Links { get; set; }
		string StoreDialogId { get; set; }
		string Icon { get; set; }
		string StoreDialogRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IDialog GetDialogFromStoreDialogRelation();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromStoreDialogRelationAsync();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromStoreDialogRelationAsync(CancellationToken cancellationToken);
    }
}
