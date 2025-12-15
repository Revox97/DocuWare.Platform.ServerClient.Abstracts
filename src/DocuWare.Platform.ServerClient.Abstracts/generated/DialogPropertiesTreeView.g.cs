using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogPropertiesTreeView(SDK.DialogPropertiesTreeView obj) : IDialogPropertiesTreeView
    {
        internal SDK.DialogPropertiesTreeView Obj { get; } = obj;

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string StoreDialogId
        {
            get => Obj.StoreDialogId;
            set => Obj.StoreDialogId = value;
        }

        public string Icon
        {
            get => Obj.Icon;
            set => Obj.Icon = value;
        }

        public string StoreDialogRelationLink => Obj.StoreDialogRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public IDialog GetDialogFromStoreDialogRelation() => new Dialog(Obj.GetDialogFromStoreDialogRelation());

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromStoreDialogRelationAsync()
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.GetDialogFromStoreDialogRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialog>> GetDialogFromStoreDialogRelationAsync(CancellationToken cancellationToken)
        {
            DocuWare.Platform.ServerClient.IDialog result = await Obj.GetDialogFromStoreDialogRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new IDialog(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<IDialog>(temp).ConfigureAwait(false);
        }
    }
}
