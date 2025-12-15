using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogFields(SDK.DialogFields obj) : IDialogFields
    {
        internal SDK.DialogFields Obj { get; } = obj;

        public List<IDialogField> Field
        {
            get => Obj.Field.Select(x => new DialogField(x) as IDialogField).ToList();
            set => Obj.Field = value.Select(x => ((DialogField)x).Obj).ToList();
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
