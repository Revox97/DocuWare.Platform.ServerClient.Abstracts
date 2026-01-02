using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogInfos(SDK.DialogInfos obj) : IDialogInfos
    {
        internal SDK.DialogInfos Obj { get; } = obj;

        public List<IDialogInfo> Dialog
        {
            get => Obj.Dialog.Select(x => new DialogInfo(x) as IDialogInfo).ToList();
            set => Obj.Dialog = value.Select(x => ((DialogInfo)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string SelfRelationLink => Obj.SelfRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);

        public DialogInfos GetDialogInfosFromSelfRelation() => new DialogInfos(Obj.GetDialogInfosFromSelfRelation());

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSelfRelationAsync()
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromSelfRelationAsync().ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }

        public async Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSelfRelationAsync(CancellationToken cancellationToken)
        {
            DeserializedHttpResponse<DocuWare.Platform.ServerClient.DialogInfos> result = await Obj.GetDialogInfosFromSelfRelationAsync(cancellationToken).ConfigureAwait(false);

            HttpResponseMessage temp = new()
            {
                Content = JsonContent.Create(new DialogInfos(result)),
                StatusCode = result.StatusCode
            };

            return await DeserializedHttpResponse.CreateAsync<DialogInfos>(temp).ConfigureAwait(false);
        }
    }
}
