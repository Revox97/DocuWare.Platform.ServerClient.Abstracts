using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateResultItem(DocuWare.Platform.ServerClient.BatchUpdateResultItem obj) : IBatchUpdateResultItem
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateResultItem Obj { get; } = obj;

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
