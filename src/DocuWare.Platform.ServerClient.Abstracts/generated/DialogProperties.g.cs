using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogProperties(DocuWare.Platform.ServerClient.DialogProperties obj) : IDialogProperties
    {
        internal DocuWare.Platform.ServerClient.DialogProperties Obj { get; } = obj;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
