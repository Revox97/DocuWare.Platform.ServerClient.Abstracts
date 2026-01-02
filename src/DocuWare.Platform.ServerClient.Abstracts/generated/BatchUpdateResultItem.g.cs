using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateResultItem(SDK.BatchUpdateResultItem obj) : IBatchUpdateResultItem
    {
        internal SDK.BatchUpdateResultItem Obj { get; } = obj;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
