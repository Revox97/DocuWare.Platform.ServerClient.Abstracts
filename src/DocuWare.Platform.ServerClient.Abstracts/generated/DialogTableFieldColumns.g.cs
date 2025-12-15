using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogTableFieldColumns(SDK.DialogTableFieldColumns obj) : IDialogTableFieldColumns
    {
        internal SDK.DialogTableFieldColumns Obj { get; } = obj;

        public List<IDialogFieldBase> DialogTableFieldColumn
        {
            get => Obj.DialogTableFieldColumn.Select(x => new DialogFieldBase(x) as IDialogFieldBase).ToList();
            set => Obj.DialogTableFieldColumn = value.Select(x => ((DialogFieldBase)x).Obj).ToList();
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
