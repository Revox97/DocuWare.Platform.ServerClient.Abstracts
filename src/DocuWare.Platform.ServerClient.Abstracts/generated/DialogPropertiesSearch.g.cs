using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DialogPropertiesSearch(DocuWare.Platform.ServerClient.DialogPropertiesSearch obj) : IDialogPropertiesSearch
    {
        internal DocuWare.Platform.ServerClient.DialogPropertiesSearch Obj { get; } = obj;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
